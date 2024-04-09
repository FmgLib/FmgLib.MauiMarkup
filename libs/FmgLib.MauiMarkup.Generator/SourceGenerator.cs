using FmgLib.MauiMarkup.Generator.Extensions;
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

            var mauiMarkupAttribute = generatorTypeSymbol.GetAttributes()
                .First(_ => _.AttributeClass.EnsureNotNull().Name == "MauiMarkupAttribute" || _.AttributeClass.EnsureNotNull().Name == "MauiMarkup");

            if (mauiMarkupAttribute.ConstructorArguments.Length == 0)
            {
                throw new InvalidOperationException("Invalid MauiMarkupAttribute arguments");
            }

            var typeMetadataName = ((ISymbol)mauiMarkupAttribute.ConstructorArguments[0].Value.EnsureNotNull()).GetFullyQualifiedName();
            var typeToMauiMarkup = context.Compilation.FindNamedType(typeMetadataName).EnsureNotNull();

            var result = new ExtensionGenerator(context, typeToMauiMarkup).Build();

            context.AddSource(result.Item1, result.Item2);
        }
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        context.RegisterForPostInitialization((i) => i.AddSource("MauiMarkupAttribute.g.cs", @"using System;

namespace FmgLib.MauiMarkup
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class MauiMarkupAttribute : Attribute
    {
        public MauiMarkupAttribute(Type nativeControlType) 
        {
            NativeControlType = nativeControlType;
        }

        public Type NativeControlType { get; }
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