using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using FmgLib.MauiMarkup.Generator.Extensions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

#pragma warning disable RS2008, RS1032

namespace FmgLib.MauiMarkup;

/// <summary>
/// Generates fluent extension helpers for types marked with <c>MauiMarkup</c> or <c>MauiMarkupAttachedProp</c> attributes.
/// Uses the incremental generator pipeline for significantly improved performance in large solutions.
/// </summary>
[Generator(LanguageNames.CSharp)]
public sealed class SourceGenerator : IIncrementalGenerator
{
    private const string MauiMarkupAttributeName = "MauiMarkupAttribute";
    private const string MauiMarkupShortName = "MauiMarkup";
    private const string MauiMarkupAttachedPropAttributeName = "MauiMarkupAttachedPropAttribute";
    private const string MauiMarkupAttachedPropShortName = "MauiMarkupAttachedProp";
    private static readonly IEqualityComparer<INamedTypeSymbol> TypeSymbolComparer = SymbolEqualityComparer.Default;

    private static readonly DiagnosticDescriptor InvalidAttributeDescriptor = new(
        id: "FMMG001",
        title: "Invalid MauiMarkup attribute usage",
        messageFormat: "The attribute '{0}' has invalid arguments and has been ignored",
        category: "Usage",
        defaultSeverity: DiagnosticSeverity.Warning,
        isEnabledByDefault: true);

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterPostInitializationOutput(static output => AddAttributeDefinitions(output));

        var candidates = context.SyntaxProvider
            .CreateSyntaxProvider(
                static (node, _) => node is ClassDeclarationSyntax { AttributeLists.Count: > 0 },
                static (syntaxContext, cancellationToken) => GetCandidateType(syntaxContext, cancellationToken))
            .Where(static symbol => symbol is not null)
            .Select(static (symbol, _) => symbol!);

        var compilationAndTypes = context.CompilationProvider.Combine(candidates.Collect());

        context.RegisterSourceOutput(compilationAndTypes, static (productionContext, source) =>
        {
            ExecuteGeneration(source.Left, source.Right, productionContext);
        });
    }

    private static INamedTypeSymbol? GetCandidateType(GeneratorSyntaxContext context, CancellationToken cancellationToken)
    {
        var classDeclaration = (ClassDeclarationSyntax)context.Node;
        if (!ContainsMauiMarkupAttribute(classDeclaration))
        {
            return null;
        }

        return context.SemanticModel.GetDeclaredSymbol(classDeclaration, cancellationToken) as INamedTypeSymbol;
    }

    private static bool ContainsMauiMarkupAttribute(ClassDeclarationSyntax classDeclaration)
    {
        foreach (var attributeList in classDeclaration.AttributeLists)
        {
            foreach (var attribute in attributeList.Attributes)
            {
                if (IsGeneratorAttribute(attribute.Name))
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static void ExecuteGeneration(Compilation compilation, ImmutableArray<INamedTypeSymbol> candidateTypes, SourceProductionContext context)
    {
        if (candidateTypes.IsDefaultOrEmpty)
        {
            return;
        }

        foreach (var generatorTypeSymbol in candidateTypes.Distinct(TypeSymbolComparer))
        {
            context.CancellationToken.ThrowIfCancellationRequested();

            GenerateForMauiMarkupAttributes(compilation, generatorTypeSymbol, context);
            GenerateForAttachedAttributes(compilation, generatorTypeSymbol, context);
        }
    }

    private static void GenerateForMauiMarkupAttributes(Compilation compilation, INamedTypeSymbol generatorTypeSymbol, SourceProductionContext context)
    {
        var suffixes = new Dictionary<string, int>(StringComparer.Ordinal);

        foreach (var attribute in generatorTypeSymbol.GetAttributes().Where(IsMauiMarkupAttribute))
        {
            foreach (var targetType in ExtractTypesFromAttribute(attribute).Distinct(TypeSymbolComparer))
            {
                context.CancellationToken.ThrowIfCancellationRequested();

                var (hintName, sourceText, generated) = new ExtensionGenerator(compilation, targetType, context.CancellationToken).Build();
                if (!generated)
                {
                    continue;
                }

                var uniqueName = AllocateHintName(suffixes, hintName);
                context.AddSource($"{uniqueName}.g.cs", sourceText);
            }
        }
    }

    private static void GenerateForAttachedAttributes(Compilation compilation, INamedTypeSymbol generatorTypeSymbol, SourceProductionContext context)
    {
        var suffixes = new Dictionary<string, int>(StringComparer.Ordinal);

        foreach (var attribute in generatorTypeSymbol.GetAttributes().Where(IsMauiMarkupAttachedPropAttribute))
        {
            if (!TryCreateAttachedModel(attribute, out var attachedModel))
            {
                var location = attribute.ApplicationSyntaxReference?.GetSyntax(context.CancellationToken)?.GetLocation();
                context.ReportDiagnostic(Diagnostic.Create(InvalidAttributeDescriptor, location, MauiMarkupAttachedPropAttributeName));
                continue;
            }

            var (hintName, sourceText, generated) = new ExtensionGenerator(compilation, attachedModel, context.CancellationToken).Build();
            if (!generated)
            {
                continue;
            }

            var uniqueName = AllocateHintName(suffixes, hintName);
            context.AddSource($"{uniqueName}.g.cs", sourceText);
        }
    }

    private static IEnumerable<INamedTypeSymbol> ExtractTypesFromAttribute(AttributeData attributeData)
    {
        if (attributeData.ConstructorArguments.Length == 0)
        {
            return Enumerable.Empty<INamedTypeSymbol>();
        }

        var typedArgument = attributeData.ConstructorArguments[0];
        if (typedArgument.Kind != TypedConstantKind.Array || typedArgument.Values.IsDefaultOrEmpty)
        {
            return Enumerable.Empty<INamedTypeSymbol>();
        }

        var symbols = new List<INamedTypeSymbol>(typedArgument.Values.Length);
        foreach (var typedConstant in typedArgument.Values)
        {
            if (typedConstant.Value is INamedTypeSymbol namedTypeSymbol)
            {
                symbols.Add(namedTypeSymbol);
            }
            else if (typedConstant.Value is ITypeSymbol typeSymbol && typeSymbol is INamedTypeSymbol namedType)
            {
                symbols.Add(namedType);
            }
        }

        return symbols;
    }

    private static bool TryCreateAttachedModel(AttributeData attributeData, out AttachedModel attachedModel)
    {
        attachedModel = default!;
        if (attributeData.ConstructorArguments.Length < 4)
        {
            return false;
        }

        var mainSymbol = attributeData.ConstructorArguments[0].Value as INamedTypeSymbol;
        var propertyName = attributeData.ConstructorArguments[1].Value?.ToString();
        var returnType = attributeData.ConstructorArguments[2].Value as INamedTypeSymbol;
        var declaringType = attributeData.ConstructorArguments[3].Value as INamedTypeSymbol;

        if (mainSymbol is null || string.IsNullOrWhiteSpace(propertyName) || returnType is null || declaringType is null)
        {
            return false;
        }

        attachedModel = new AttachedModel
        {
            MainSymbol = mainSymbol,
            ReturnTypeName = returnType.GetFullyQualifiedName(),
            DeclaringTypeName = declaringType.GetFullyQualifiedName(),
            PropertyName = propertyName!
        };

        return true;
    }

    private static bool IsMauiMarkupAttribute(AttributeData attributeData)
    {
        var name = attributeData.AttributeClass?.Name;
        return name is MauiMarkupAttributeName or MauiMarkupShortName;
    }

    private static bool IsMauiMarkupAttachedPropAttribute(AttributeData attributeData)
    {
        var name = attributeData.AttributeClass?.Name;
        return name is MauiMarkupAttachedPropAttributeName or MauiMarkupAttachedPropShortName;
    }

    private static bool IsGeneratorAttribute(NameSyntax nameSyntax)
    {
        var identifier = nameSyntax switch
        {
            IdentifierNameSyntax identifierName => identifierName.Identifier.ValueText,
            QualifiedNameSyntax qualifiedName => qualifiedName.Right.Identifier.ValueText,
            AliasQualifiedNameSyntax aliasName => aliasName.Name.Identifier.ValueText,
            _ => nameSyntax.ToString()
        };

        return identifier is MauiMarkupAttributeName or MauiMarkupShortName or MauiMarkupAttachedPropAttributeName or MauiMarkupAttachedPropShortName;
    }

    private static string AllocateHintName(IDictionary<string, int> suffixes, string baseName)
    {
        if (!suffixes.TryGetValue(baseName, out var index))
        {
            suffixes[baseName] = 0;
            return baseName;
        }

        index++;
        suffixes[baseName] = index;
        return $"{baseName}{index}";
    }

    private static void AddAttributeDefinitions(IncrementalGeneratorPostInitializationContext context)
    {
        context.AddSource("MauiMarkupAttribute.g.cs", @"//
// <auto-generated-fmglib-mauimarkup-generator />
//

using System;

namespace FmgLib.MauiMarkup;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
internal sealed class MauiMarkupAttribute : Attribute
{
    public MauiMarkupAttribute(params Type[] nativeControlTypes) { }
}

");

        context.AddSource("MauiMarkupAttachedPropAttribute.g.cs", @"//
// <auto-generated-fmglib-mauimarkup-generator />
//

using System;

namespace FmgLib.MauiMarkup;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
internal sealed class MauiMarkupAttachedPropAttribute : Attribute
{
    public MauiMarkupAttachedPropAttribute(Type controlType, string propertyName, Type returnType, Type declaringType) { }
}

");
    }
}
