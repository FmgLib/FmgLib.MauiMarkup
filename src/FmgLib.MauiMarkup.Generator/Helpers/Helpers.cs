using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FmgLib.MauiMarkup;

/// <summary>
/// Shared helper utilities used by the source generator.
/// </summary>
public static class Helpers
{
    public static readonly HashSet<string> NotGenerateList = new(StringComparer.Ordinal) { "this[]", "Handler", "LogicalChildren" };

    public static string ToCamelCase(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        return char.ToLowerInvariant(text[0]) + text[1..];
    }

    public static INamedTypeSymbol? FindNamedType(this Compilation compilation, string typeMetadataName)
    {
        var typeToMauiMarkup = compilation.GetTypeByMetadataName(typeMetadataName);

        typeToMauiMarkup ??= compilation.References
            .Select(compilation.GetAssemblyOrModuleSymbol)
            .OfType<IAssemblySymbol>()
            .Select(assemblySymbol => assemblySymbol.GetTypeByMetadataName(typeMetadataName))
            .FirstOrDefault(static symbol => symbol is not null);

        return typeToMauiMarkup;
    }

    public static string GetFullyQualifiedName(this ISymbol typeSymbol)
    {
        return typeSymbol.ToString();
    }

    public static T EnsureNotNull<T>(this T? value)
        => value ?? throw new InvalidOperationException();

    public static bool IsVisualElement(INamedTypeSymbol symbol)
    {
        return IsDerivedFrom(symbol, "Microsoft.Maui.Controls.VisualElement");
    }

    public static bool IsBindableObject(INamedTypeSymbol symbol)
    {
        return IsDerivedFrom(symbol, "Microsoft.Maui.Controls.BindableObject");
    }

    public static void LoopDownToObject(INamedTypeSymbol symbol, Func<INamedTypeSymbol, bool> func)
    {
        for (var type = symbol; type != null && type.SpecialType != SpecialType.System_Object; type = type.BaseType)
        {
            if (func(type))
            {
                break;
            }
        }
    }

    public static bool IsBaseImplementationOfInterface(INamedTypeSymbol symbol, string name)
    {
        var count = 0;
        for (var type = symbol; type != null && type.SpecialType != SpecialType.System_Object; type = type.BaseType)
        {
            if (type.Interfaces.Any(interfaceSymbol => interfaceSymbol.Name.Equals(name, StringComparison.Ordinal)))
            {
                count++;
            }
        }

        return count == 1;
    }

    public static string GetNormalizedFileName(INamedTypeSymbol type)
    {
        var tail = type.IsGenericType ? $".{type.TypeArguments.FirstOrDefault()?.Name}" : string.Empty;
        return $"{type.Name}{tail}";
    }

    public static string GetNormalizedClassName(INamedTypeSymbol type)
    {
        var tail = type.IsGenericType ? $"Of{type.TypeArguments.FirstOrDefault()?.Name}" : string.Empty;
        var fullName = type.ToDisplayString();
        var prefix = fullName.IndexOf(".Shapes.", StringComparison.Ordinal) >= 0 ? "Shapes" : string.Empty;
        prefix += fullName.IndexOf(".Compatibility.", StringComparison.Ordinal) >= 0 ? "Compatibility" : string.Empty;
        return $"{prefix}{type.Name}{tail}";
    }

    public static string? GetFullyQualifiedName(this ClassDeclarationSyntax classDeclarationSyntax)
    {
        if (!TryGetNamespace(classDeclarationSyntax, out string? namespaceName))
        {
            return null;
        }

        return namespaceName + "." + classDeclarationSyntax.Identifier;
    }

    public static bool TryGetNamespace(SyntaxNode? syntaxNode, out string? result)
    {
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

    static bool IsDerivedFrom(INamedTypeSymbol symbol, string fullyQualifiedMetadataName)
    {
        for (var type = symbol; type != null && type.SpecialType != SpecialType.System_Object; type = type.BaseType)
        {
            if (type.GetFullyQualifiedName().Equals(fullyQualifiedMetadataName, StringComparison.Ordinal))
            {
                return true;
            }
        }

        return false;
    }
}
