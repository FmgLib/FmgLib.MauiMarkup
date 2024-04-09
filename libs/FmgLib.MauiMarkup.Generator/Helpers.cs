using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace FmgLib.MauiMarkup;

public static class Helpers
{
    static readonly string[] keywords = { "class", "switch", "event" };
    public static string[] NotGenerateList = { "this[]", "Handler", "LogicalChildren" };


    public static string ToCamelCase(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        return char.ToLowerInvariant(text[0]) + text.Substring(1);
    }

    public static string ToMethodNameWithoutProperty(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        return text.Replace("Property","");
    }

    public static string ToConvertTypeName(this string typeName)
    {
        return typeName switch
        {
            "SByte" => "sbyte",
            "Byte" => "byte",
            "Int16" => "short",
            "UInt16" => "ushort",
            "Int32" => "int",
            "UInt32" => "uint",
            "Int64" => "long",
            "UInt64" => "ulong",
            "Char" => "char",
            "Single" => "float",
            "Double" => "double",
            "Boolean" => "bool",
            "Decimal" => "decimal",
            "String" => "string",
            "Object" => "object",
            _ => typeName,
        };
    }

    public static string ToConvertFullTypeName(this string fullTypeName)
    {
        return fullTypeName switch
        {
            "System.SByte" => "sbyte",
            "System.Byte" => "byte",
            "System.Int16" => "short",
            "System.UInt16" => "ushort",
            "System.Int32" => "int",
            "System.UInt32" => "uint",
            "System.Int64" => "long",
            "System.UInt64" => "ulong",
            "System.Char" => "char",
            "System.Single" => "float",
            "System.Double" => "double",
            "System.Boolean" => "bool",
            "System.Decimal" => "decimal",
            "System.String" => "string",
            "System.Object" => "object",
            _ => fullTypeName.Replace('+', '.'),
        };
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

    public static void WaitForDebugger(CancellationToken cancellationToken)
    {
#if DEBUG
        while (!Debugger.IsAttached && !cancellationToken.IsCancellationRequested)
            Task.Delay(10).Wait(cancellationToken);
#endif
    }

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

    public static bool IsGenericIList(ISymbol symbol, out ITypeSymbol elementType)
    {
        elementType = null;
        var namedTypeSymbol = symbol as INamedTypeSymbol;
        if (namedTypeSymbol == null) return false;

        if (namedTypeSymbol.Name.Equals("IList", StringComparison.Ordinal) && namedTypeSymbol.IsGenericType)
        {
            elementType = namedTypeSymbol.TypeArguments.First();
            return true;
        }

        ITypeSymbol _elementType = null;
        foreach (var inter in namedTypeSymbol.AllInterfaces)
            if (inter.Name.Equals("IList", StringComparison.Ordinal) && inter.IsGenericType)
            {

                _elementType = inter.TypeArguments.First();
                break;
            }

        elementType = _elementType;
        return _elementType != null;
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

    public static bool IsSymbolDeprecated(ISymbol symbol)
    {
        foreach (var attribute in symbol.GetAttributes())
        {
            if (attribute.AttributeClass.Name == "ObsoleteAttribute" || attribute.AttributeClass.Name == "Obsolete")
                return true;
        }
        return false;
    }



    public static IPropertySymbol FindInBasePropertySymbolWithName(INamedTypeSymbol symbol, string propertyName)
    {
        IPropertySymbol propertySymbol = null;
        Helpers.LoopDownToObject(symbol.BaseType, type =>
        {
            propertySymbol = (IPropertySymbol)(type.GetMembers(propertyName).FirstOrDefault());
            return propertySymbol != null;
        });
        return propertySymbol;
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
}
