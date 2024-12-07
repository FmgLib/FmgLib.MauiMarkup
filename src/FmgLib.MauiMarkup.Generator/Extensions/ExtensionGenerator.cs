﻿using Microsoft.CodeAnalysis;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    readonly GeneratorExecutionContext context;
    readonly INamedTypeSymbol mainSymbol;
    readonly bool isBindableObject;
    readonly bool isVisualElement;
    bool isGeneratedExtension = false;
    readonly AttachedModel attachedModel = null;
    IPropertySymbol childProp;
    List<string> bindablePropertyNames;
    List<string> redefinedProperties;

    StringBuilder builder;

    public ExtensionGenerator(GeneratorExecutionContext context, INamedTypeSymbol symbol)
    {
        this.context = context;
        this.mainSymbol = symbol;
        this.isBindableObject = Helpers.IsBindableObject(mainSymbol);
        this.isVisualElement = Helpers.IsVisualElement(mainSymbol);
    }

    public ExtensionGenerator(GeneratorExecutionContext context, AttachedModel attachedModel)
    {
        this.context = context;
        this.mainSymbol = attachedModel.MainSymbol;
        this.isBindableObject = Helpers.IsBindableObject(mainSymbol);
        this.isVisualElement = Helpers.IsVisualElement(mainSymbol);
        this.attachedModel = attachedModel;
    }

    public (string, string, bool) Build()
    {
        builder = new StringBuilder();
        builder.AppendLine("//");
        builder.AppendLine("// <auto-generated-fmglib-mauimarkup-generator />");
        builder.AppendLine("//");
        builder.AppendLine();

        GenerateExtensionNameSpace();

        builder.AppendLine();

        return ($"{mainSymbol.ContainingNamespace.ToDisplayString()}.{Helpers.GetNormalizedFileName(mainSymbol)}{(attachedModel != null ? "Attached" : "")}", builder.ToString(), isGeneratedExtension);
    }

    void GenerateExtensionNameSpace()
    {
        var className = $"{Helpers.GetNormalizedClassName(mainSymbol)}{(attachedModel != null ? "Attached" : "")}Extension";

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
        var bindablePropertyType = context.Compilation.FindNamedType("Microsoft.Maui.Controls.BindableProperty");
        var editorBrowsableAttribute = context.Compilation.FindNamedType("System.ComponentModel.EditorBrowsableAttribute");

        var propertiesMap = mainSymbol
            .GetMembers()
            .Where(_ => (_.ContainingType is INamedTypeSymbol namedTypeSymbol) && namedTypeSymbol.GetFullyQualifiedName() == mainSymbol.GetFullyQualifiedName())
            .Where(_ => _.Kind == SymbolKind.Property &&
                _.DeclaredAccessibility == Accessibility.Public &&
                !_.GetAttributes().Any(_ => _.AttributeClass.EnsureNotNull().Name == "ObsoleteAttribute" || _.AttributeClass.EnsureNotNull().Name == "Obsolete"))
            .OrderBy(_ => _.Name)
            .Cast<IPropertySymbol>()
            .ToList();

        redefinedProperties = mainSymbol
            .GetMembers()
            .Where(_ => (_.ContainingType is INamedTypeSymbol namedTypeSymbol) && namedTypeSymbol.GetFullyQualifiedName() == mainSymbol.GetFullyQualifiedName())
            .Where(_ => _.Kind == SymbolKind.Property &&
                _.DeclaredAccessibility == Accessibility.Public &&
                !_.GetAttributes().Any(_ => _.AttributeClass.EnsureNotNull().Name == "ObsoleteAttribute" || _.AttributeClass.EnsureNotNull().Name == "Obsolete"))
            .OfType<IPropertySymbol>()
            .Where(property =>
            {
                var isDefinedInDerived = property.ContainingType.Equals(mainSymbol, SymbolEqualityComparer.Default);

                var baseType = property.ContainingType.BaseType;
                while (baseType != null)
                {
                    var baseProperty = baseType.GetMembers(property.Name)
                        .OfType<IPropertySymbol>()
                        .FirstOrDefault();

                    if (baseProperty != null)
                        return isDefinedInDerived && !property.IsOverride;

                    baseType = baseType.BaseType;
                }

                return false;
            })
            .Select(e => e.Name)
            .ToList();

        var fieldsMap = mainSymbol
            .GetMembers()
            .Where(_ => (_.ContainingType is INamedTypeSymbol namedTypeSymbol) && namedTypeSymbol.GetFullyQualifiedName() == mainSymbol.GetFullyQualifiedName())
            .Where(_ => _.Kind == SymbolKind.Field &&
                _.DeclaredAccessibility == Accessibility.Public &&
                !_.GetAttributes().Any(_ => _.AttributeClass.EnsureNotNull().Name == "ObsoleteAttribute" || _.AttributeClass.EnsureNotNull().Name == "Obsolete"))
            .Cast<IFieldSymbol>()
            .ToList();

        bindablePropertyNames = fieldsMap
            .Where(_ => _.Type.GetFullyQualifiedName().Equals("Microsoft.Maui.Controls.BindableProperty") &&
                _.IsStatic)
            .Select(_ => _.Name.Replace("PropertyKey", "").Replace("Property", ""))
            .ToList();

        var properties = propertiesMap
            .Where(_ => (!_.IsReadOnly && !(_.SetMethod == null || _.SetMethod?.DeclaredAccessibility == Accessibility.Protected || _.SetMethod?.DeclaredAccessibility == Accessibility.Private || _.SetMethod?.DeclaredAccessibility == Accessibility.Internal)) || bindablePropertyNames.Any(e => e.Equals(_.Name)))
            .ToList();

        var readOnlyListProperties = propertiesMap
            .Where(_ => _.IsReadOnly &&
                !bindablePropertyNames.Any(e => e.Equals(_.Name, StringComparison.InvariantCultureIgnoreCase)) &&
                (_.Type.Name.Contains(nameof(IList)) || _.Type.AllInterfaces.Any(e => e.Name.Contains(nameof(IList))) || _.Type.Name.Contains(nameof(ICollection)) || _.Type.AllInterfaces.Any(e => e.Name.Contains(nameof(ICollection)))) &&
                _.Type.AllInterfaces.Any(e => e.Name.Contains(nameof(IEnumerable))) &&
                !_.Type.Name.Equals(nameof(String), StringComparison.InvariantCultureIgnoreCase))
            .Where(_ => _.Type.Name.Contains(nameof(ICollection)) || _.Type.AllInterfaces.Any(e => e.Name.Contains(nameof(ICollection))) || !(_.Type.Name.Contains("IReadOnlyList") || _.Type.AllInterfaces.Any(e => e.Name.Contains("IReadOnlyList"))))
            .Where(_ => !(_.Type.Name.StartsWith("ReadOnlyObservableCollection") || _.Type.Name.StartsWith("ReadOnlyCollection") || _.Type.Name.StartsWith("ReadOnlyDictionary") || (_.Type.BaseType != null && (_.Type.BaseType.Name.StartsWith("ReadOnlyObservableCollection") || _.Type.BaseType.Name.StartsWith("ReadOnlyCollection") || _.Type.BaseType.Name.StartsWith("ReadOnlyDictionary")))))
            .ToList();


        var events = mainSymbol
           .GetMembers()
           .Where(_ => _.Kind == SymbolKind.Event)
           .Where(_ => _.DeclaredAccessibility == Accessibility.Public)
           .Cast<IEventSymbol>()
           .Where(_ => !_.Name.Contains('.'))
           .Where(_ => (_.ContainingType is INamedTypeSymbol namedTypeSymbol) && namedTypeSymbol.GetFullyQualifiedName() == mainSymbol.GetFullyQualifiedName())
           .Where(_ => !_.GetAttributes().Any(_ => _.AttributeClass.EnsureNotNull().Equals(editorBrowsableAttribute, SymbolEqualityComparer.Default)))
           .Where(_ => !_.GetAttributes().Any(_ => _.AttributeClass.EnsureNotNull().Name == "ObsoleteAttribute" || _.AttributeClass.EnsureNotNull().Name == "Obsolete"))
           .GroupBy(_ => _.Name, StringComparer.OrdinalIgnoreCase)
           .Select(_ => _.First())
           .OrderBy(_ => _.Name)
           .ToArray();

        if (attachedModel == null)
        {
            foreach (var prop in readOnlyListProperties)
                GenerateExtensionMethod(prop, true);

            foreach (var prop in properties)
                GenerateExtensionMethod(prop);

            foreach (var @event in events)
                GenerateEventMethod(@event);

            if (Helpers.IsBaseImplementationOfInterface(mainSymbol, "ITextAlignment"))
                GenerateExtensionMethods_ITextAlignment(mainSymbol);
        }
        else
        {
            GenerateAttachedExtensionMethod(attachedModel);
        }
    }

    IEnumerable<ISymbol> GetAllMembers(INamedTypeSymbol type)
    {
        foreach (var member in type.GetMembers())
        {
            yield return member;
        }

        if (type.BaseType != null)
        {
            foreach (var member in GetAllMembers(type.BaseType))
            {
                yield return member;
            }
        }
    }

    void GenerateExtension_ChildItem(IPropertySymbol propertySymbol)
    {
        var propertyName = propertySymbol.Name.Split(new[] { "." }, StringSplitOptions.None).Last();
        propertyName = propertyName.Equals("class", StringComparison.Ordinal) ? "@class" : propertyName;
        var info = new PropInfo
        {
            MainSymbolName = mainSymbol.ToDisplayString(),
            BindablePropertyName = $"{mainSymbol.ToDisplayString()}.{propertySymbol.Name}Property",
            PropertySymbol = propertySymbol,
            IsBindableProperty = bindablePropertyNames.Any(_ => _.Equals(propertySymbol.Name))
        };
        info.Build();

        if (propertySymbol.Type is INamedTypeSymbol namedType && namedType.TypeArguments.Length == 1)
        {
            var listItemType = namedType.TypeArguments[0]; // Listenin eleman türü

            GenerateExtensionMethod_ContentProp_List(info, listItemType.ToDisplayString(), info.propertyName + "_ContentProp");
        }
        else
        {
            GenerateExtensionMethod_ContentProp_Single(info);
        }
    }

    void GenerateExtensionMethod(IPropertySymbol propertySymbol, bool isOnlyList = false)
    {
        var propertyName = propertySymbol.Name.Split(new[] { "." }, StringSplitOptions.None).Last();
        propertyName = propertyName.Equals("class", StringComparison.Ordinal) ? "@class" : propertyName;
        var info = new PropInfo
        {
            MainSymbolName = mainSymbol.ToDisplayString(),
            BindablePropertyName = $"{mainSymbol.ToDisplayString()}.{propertySymbol.Name}Property",
            PropertySymbol = propertySymbol,
            IsBindableProperty = bindablePropertyNames.Any(_ => _.Equals(propertySymbol.Name))
        };
        info.Build(redefinedProperties);

        if (!Helpers.NotGenerateList.Contains(info.propertyName))
        {
            if (childProp != null)
                GenerateExtension_ChildItem(childProp);

            if (isOnlyList)
            {
                string typeName = "";
                if (propertySymbol.IsReadOnly && propertySymbol.Type is INamedTypeSymbol namedType && namedType.TypeArguments.Length == 1)
                    typeName = namedType.TypeArguments[0].ToDisplayString();

                else if (propertySymbol.IsReadOnly && propertySymbol.Type is INamedTypeSymbol namedListType &&
                            namedListType.AllInterfaces.Any(e => e.Name == nameof(IEnumerable)) &&
                            namedListType.BaseType.TypeArguments.Length == 1)
                    typeName = namedListType.BaseType.TypeArguments[0].ToDisplayString();

                if (!string.IsNullOrEmpty(typeName))
                    GenerateExtensionMethod_ContentProp_List(info, typeName);
            }
            else
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

            isGeneratedExtension = true;
        }
    }

    void GenerateAttachedExtensionMethod(AttachedModel parameter)
    {
        var info = new AttachedFieldInfo
        {
            MainSymbol = mainSymbol,
            BindablePropertyName = $"{mainSymbol.ToDisplayString()}.{parameter.PropertyName}",
            ReturnTypeName = parameter.ReturnTypeName,
            DeclaringTypeName = parameter.DeclaringTypeName,
            PropertyName = parameter.PropertyName
        };
        info.Build();

        if (!Helpers.NotGenerateList.Contains(info.propertyName))
        {
            GenerateExtensionMethod_Value(info);
            GenerateExtensionMethod_BindablePropertyBuilder(info);
            GenerateExtensionMethod_Setters(info);
            GenerateExtensionMethod_SettersBuilder(info);

            isGeneratedExtension = true;
        }
    }
}