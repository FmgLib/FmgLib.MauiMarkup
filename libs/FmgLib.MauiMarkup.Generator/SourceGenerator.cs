﻿using FmgLib.MauiMarkup.Generator.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FmgLib.MauiMarkup;

[Generator]
public class SourceGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        foreach (var classToMarkup in ((MauiMarkupSyntaxReceiver)context.SyntaxReceiver.EnsureNotNull()).ClassesToMarkup)
        {
            //BuildExtensions(context, classToMarkup);
            INamedTypeSymbol generatorTypeSymbol = context.Compilation.GetTypeByMetadataName(classToMarkup).EnsureNotNull();

            var mauiMarkupAttributes = generatorTypeSymbol
                .GetAttributes()
                .Where(_ => _.AttributeClass.EnsureNotNull().Name == "MauiMarkupAttribute" || _.AttributeClass.EnsureNotNull().Name == "MauiMarkup")
                .ToList();

            foreach (var mauiMarkupAttribute in mauiMarkupAttributes)
            {
                if (mauiMarkupAttribute.ConstructorArguments.Length == 0)
                {
                    throw new InvalidOperationException("Invalid MauiMarkupAttribute arguments");
                }
                foreach (var item in mauiMarkupAttribute.ConstructorArguments)
                {
                    var typeMetadataName = ((ISymbol)item.Value.EnsureNotNull()).GetFullyQualifiedName();
                    var typeToMauiMarkup = context.Compilation.GetTypeByMetadataName(typeMetadataName).EnsureNotNull();

                    var result = new ExtensionGenerator(context, typeToMauiMarkup).Build();

                    if (result.Item3)
                        context.AddSource(result.Item1, result.Item2);
                }
            }
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForPostInitialization((i) => i.AddSource("MauiMarkupAttribute.g.cs", @"//
// <auto-generated-fmglib-mauimarkup-generator />
//

using System;

namespace FmgLib.MauiMarkup
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class MauiMarkupAttribute : Attribute
    {
        public MauiMarkupAttribute(Type nativeControlType) { }

        public MauiMarkupAttribute(Type nativeControlType1, Type nativeControlType2) { }

        public MauiMarkupAttribute(Type nativeControlType1, Type nativeControlType2, Type nativeControlType3) { }

        public MauiMarkupAttribute(Type nativeControlType1, Type nativeControlType2, Type nativeControlType3, Type nativeControlType4) { }

        public MauiMarkupAttribute(Type nativeControlType1, Type nativeControlType2, Type nativeControlType3, Type nativeControlType4, Type nativeControlType5) { }
    }
}
"));

        context.RegisterForSyntaxNotifications(() => new MauiMarkupSyntaxReceiver());
    }
}


class MauiMarkupSyntaxReceiver : ISyntaxReceiver
{
    public List<string> ClassesToMarkup { get; } = new();

    public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
    {
        if (syntaxNode is ClassDeclarationSyntax cds)
        {
            var mauiMarkupAttribute = cds.AttributeLists
                .Where(_ => _.Attributes.Any(attr => attr.Name is IdentifierNameSyntax nameSyntax && (nameSyntax.Identifier.Text == "MauiMarkup" ||
                    nameSyntax.Identifier.Text == "MauiMarkupAttribute")))
                .Select(_ => _.Attributes.First())
                .FirstOrDefault();

            if (mauiMarkupAttribute != null)
            {
                ClassesToMarkup.Add(cds.GetFullyQualifiedName().EnsureNotNull());
            }
        }
    }
}