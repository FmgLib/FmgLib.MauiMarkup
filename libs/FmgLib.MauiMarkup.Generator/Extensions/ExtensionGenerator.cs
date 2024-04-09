﻿//
// MIT License
// Copyright Pawel Krzywdzinski
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Extensions
{
    public partial class ExtensionGenerator
    {
        readonly GeneratorExecutionContext context;
        readonly INamedTypeSymbol mainSymbol;
        readonly bool isBindableObject;
        readonly bool isVisualElement;

        StringBuilder builder;

        public ExtensionGenerator(GeneratorExecutionContext context, INamedTypeSymbol symbol)
        {
            this.context = context;
            this.mainSymbol = symbol;
            this.isBindableObject = Helpers.IsBindableObject(mainSymbol);
            this.isVisualElement = Helpers.IsVisualElement(mainSymbol);
        }

        public (string,string) Build()
        {
            builder = new StringBuilder();
            builder.AppendLine("//");
            builder.AppendLine("// <auto-generated-fmglib-mauimarkup-Generator />");
            builder.AppendLine("//");
            builder.AppendLine();

            GenerateExtensionNameSpace();

            builder.AppendLine();

            return ($"{mainSymbol.ContainingNamespace.ToDisplayString()}.{Helpers.GetNormalizedFileName(mainSymbol)}.g.cs", builder.ToString());
        }

        void GenerateExtensionNameSpace()
        {
            var className = $"{Helpers.GetNormalizedClassName(mainSymbol)}Extension";

            builder.Append($@"
namespace FmgLib.MauiMarkup;

public static partial class {className}
{{");
            
    GenerateClassExtensionBody();

    builder.AppendLine($@"
}}
");
        }

        void GenerateClassExtensionBody()
        {
            var bindablePropertyNames = new List<string>();
            var bindableProperties = mainSymbol
                    .GetMembers()
                    .Where(e => e.IsStatic && e.Name.EndsWith("Property") && e.DeclaredAccessibility == Accessibility.Public).ToList();

            bindablePropertyNames.Clear();
            foreach (var prop in bindableProperties)
            {
                var name = prop.Name.Substring(0, prop.Name.Length - "Property".Length);
                bindablePropertyNames.Add(name);
            }

            var properties = mainSymbol
                .GetMembers()
                .Where(e => e.Kind == SymbolKind.Property && e.DeclaredAccessibility == Accessibility.Public && !e.IsStatic && !Helpers.IsSymbolDeprecated(e));

            var events = mainSymbol
                .GetMembers()
                .Where(e => e.Kind == SymbolKind.Event && e.DeclaredAccessibility == Accessibility.Public && !e.IsStatic && !Helpers.IsSymbolDeprecated(e));

            foreach (var prop in properties)
                GenerateExtensionMethod(prop as IPropertySymbol, bindablePropertyNames);

            foreach (var @event in events)
                GenerateEventMethod(@event);

            if (Helpers.IsBaseImplementationOfInterface(mainSymbol, "ITextAlignment"))
                GenerateExtensionMethods_ITextAlignment(mainSymbol);

            GenerateBindablePropertyExtensionsFromInterface();
        }

        bool ExistInBaseClasses(string propertyName, bool getterAndSetter)
        {
            var existInBaseClasses = false;
            Helpers.LoopDownToObject(mainSymbol.BaseType, type =>
            {
                existInBaseClasses = (type
                            .GetMembers()
                            .FirstOrDefault(e =>
                                e.Kind == SymbolKind.Property &&
                                e.DeclaredAccessibility == Accessibility.Public &&
                                (((IPropertySymbol)e).SetMethod != null || !getterAndSetter) &&
                                e.Name.Equals(propertyName, StringComparison.Ordinal)) != null);

                return existInBaseClasses;
            });
            return existInBaseClasses;
        }

        void GenerateBindablePropertyExtensionsFromInterface()
        {
            // generate using bindable interface
            var interfaces = mainSymbol
                .Interfaces.ToList();
                
            foreach (var inter in interfaces)
            {
                var properties = inter
                    .GetMembers()
                    .Where(e => e.Kind == SymbolKind.Property && !Helpers.IsSymbolDeprecated(e));

                foreach (var prop in properties)
                {
                    var propertySymbol = (IPropertySymbol)prop;
                    var fullPropertyName = $"{mainSymbol.ToDisplayString()}.{prop.Name}";
                    GenerateExtensionMethodForBindableFromInterface(propertySymbol);
                }
            }
        }

        void GenerateExtensionMethodForBindableFromInterface(IPropertySymbol propertySymbol, string bindablePropertyName = null)
        {
            var info = new PropertyInfo
            {
                MainSymbol = mainSymbol,
                BindablePropertyName = bindablePropertyName,
                PropertySymbol = propertySymbol,
                IsBindableProperty = true,
                IsBindableObject = true
            };
            info.Build();

            if (!Helpers.NotGenerateList.Contains(info.propertyName))
            {
                GenerateExtensionMethod_Value(info);
                GenerateExtensionMethod_BindablePropertyBuilder(info);
                GenerateExtensionMethod_Setters(info);
                GenerateExtensionMethod_SettersBuilder(info);

                if (info.propertyTypeName.Contains("DataTemplate"))
                    GenerateExtensionMethod_DataTemplate(info);

                //if (attachedInterfacesAttribute != null)
                //    GenerateExtensionMethod_GetValue(info);
            }
        }

        void GenerateExtensionMethod(IPropertySymbol property, List<string> bindablePropertyNames)
        {
            var info = new PropertyInfo
            {
                MainSymbol = mainSymbol,
                PropertySymbol = property,
                BindableProperties = bindablePropertyNames,
                IsBindableObject = isBindableObject
            };
            info.Build();

            var propertyType = info.PropertySymbol.Type as INamedTypeSymbol;
            var isGenericIList = Helpers.IsGenericIList(propertyType, out var elementType);

            if (!Helpers.NotGenerateList.Contains(info.propertyName))
            {
                if (!isGenericIList &&
                    info.PropertySymbol.SetMethod != null &&
                    info.PropertySymbol.SetMethod.DeclaredAccessibility == Accessibility.Public &&
                    !ExistInBaseClasses(info.propertyName, getterAndSetter: true))
                {
                    GenerateExtensionMethod_Value(info);

                    if (info.IsBindableProperty)
                    {
                        GenerateExtensionMethod_BindablePropertyBuilder(info);
                        GenerateExtensionMethod_Setters(info);
                        GenerateExtensionMethod_SettersBuilder(info);
                    }

                    if (info.propertyTypeName.Equals("Microsoft.Maui.Controls.DataTemplate"))
                        GenerateExtensionMethod_DataTemplate(info);

                    if (isVisualElement)
                    {
                        if (info.propertyTypeName.Equals("double"))
                            GenerateExtensionMethod_AnimateTo(info, "DoubleTransform");

                        if (info.propertyTypeName.Equals("Microsoft.Maui.Graphics.Color"))
                            GenerateExtensionMethod_AnimateTo(info, "ColorTransform");
                    }
                }
                else if (isGenericIList &&
                    info.PropertySymbol.GetMethod != null &&
                    info.PropertySymbol.GetMethod.DeclaredAccessibility == Accessibility.Public &&
                    !ExistInBaseClasses(info.propertyName, getterAndSetter: false))
                {
                    GenerateExtensionMethod_List(info, elementType.ToDisplayString());
                    if (info.IsBindableProperty)
                        GenerateExtensionMethod_BindablePropertyBuilder(info);
                }
            }
        }
    }
}
