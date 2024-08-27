using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FmgLib.MauiMarkup;

public static class Helpers
{
    public static List<string> NotGenerateList = new() { "this[]", "Handler", "LogicalChildren" };


    public static string ToCamelCase(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        return char.ToLowerInvariant(text[0]) + text.Substring(1);
    }

    public static INamedTypeSymbol? FindNamedType(this Compilation compilation, string typeMetadataName)
    {
        var typeToMauiMarkup = compilation.GetTypeByMetadataName(typeMetadataName);

        typeToMauiMarkup ??= compilation.References
            .Select(compilation.GetAssemblyOrModuleSymbol)
            .OfType<IAssemblySymbol>()
            .Select(assemblySymbol => assemblySymbol.GetTypeByMetadataName(typeMetadataName))
            .FirstOrDefault(_ => _ != null);

        return typeToMauiMarkup;
    }

    public static string GetFullyQualifiedName(this ISymbol typeSymbol)
    {
        return typeSymbol.ToString();
    }

    public static T EnsureNotNull<T>(this T? value)
    => value ?? throw new InvalidOperationException();

    public static void LoopDownToObject(INamedTypeSymbol symbol, Func<INamedTypeSymbol, bool> func)
    {
        var type = symbol;
        var endLoop = false;
        while (!endLoop && type != null && !type.Name.Equals("Object", StringComparison.Ordinal))
        {
            endLoop = func(type);
            type = type.BaseType;
        }
    }

    public static bool IsVisualElement(INamedTypeSymbol symbol)
    {
        var isNavigableElement = false;

        LoopDownToObject(symbol, type =>
        {
            if (type.ToDisplayString().Equals("Microsoft.Maui.Controls.VisualElement")) isNavigableElement = true;
            return isNavigableElement;
        });

        return isNavigableElement;
    }

    public static bool IsBaseImplementationOfInterface(INamedTypeSymbol symbol, string name)
    {
        var count = 0;
        LoopDownToObject(symbol, type =>
        {
            if (type.Interfaces.Any(e => e.Name.Equals(name))) count++;
            return false;
        });

        return count == 1;
    }

    public static string GetNormalizedFileName(INamedTypeSymbol type)
    {
        var tail = type.IsGenericType ? $".{type.TypeArguments.FirstOrDefault().Name}" : "";
        return $"{type.Name}{tail}";
    }

    public static string GetNormalizedClassName(INamedTypeSymbol type)
    {
        var tail = type.IsGenericType ? $"Of{type.TypeArguments.FirstOrDefault().Name}" : "";
        var prefix = type.ToDisplayString().Contains(".Shapes.") ? "Shapes" : "";
        prefix += type.ToDisplayString().Contains(".Compatibility.") ? "Compatibility" : "";
        return $"{prefix}{type.Name}{tail}";
    }

    public static bool IsBindableObject(INamedTypeSymbol symbol)
    {
        var isBindable = false;

        LoopDownToObject(symbol, type =>
        {
            if (type.ToDisplayString().Equals("Microsoft.Maui.Controls.BindableObject", StringComparison.Ordinal)) isBindable = true;
            return isBindable;
        });

        return isBindable;
    }

    public static string? GetFullyQualifiedName(this ClassDeclarationSyntax classDeclarationSyntax)
    {
        if (!TryGetNamespace(classDeclarationSyntax, out string? namespaceName))
        {
            return null; // or whatever you want to do in this scenario
        }

        //var namespaceName = namespaceDeclarationSyntax!.Name.ToString();
        return namespaceName + "." + classDeclarationSyntax.Identifier.ToString();
    }

    public static bool TryGetNamespace(SyntaxNode? syntaxNode, out string? result)
    {
        // set defaults
        result = null;

        if (syntaxNode == null)
        {
            return false;
        }

        try
        {
            syntaxNode = syntaxNode.Parent;

            if (syntaxNode == null)
            {
                return false;
            }

            if (syntaxNode is NamespaceDeclarationSyntax namespaceDeclarationSyntax)
            {
                result = namespaceDeclarationSyntax.Name.ToString();
                return true;
            }

            if (syntaxNode is FileScopedNamespaceDeclarationSyntax fileScopedNamespaceDeclarationSyntax)
            {
                result = fileScopedNamespaceDeclarationSyntax.Name.ToString();
                return true;
            }

            return TryGetNamespace(syntaxNode, out result);
        }
        catch
        {
            return false;
        }
    }

    public static string GetContentPropertyNameFor(INamedTypeSymbol symbol)
    {
        var attributeData = symbol.GetAttributes().FirstOrDefault(e => e.AttributeClass.Name.Equals("ContentPropertyAttribute"));
        return attributeData != null ? (string)attributeData.ConstructorArguments[0].Value : null;
    }
}
