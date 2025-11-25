using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Extensions;

/// <summary>
/// Represents the attached property metadata supplied through <c>MauiMarkupAttachedProp</c>.
/// </summary>
public sealed class AttachedModel
{
    public INamedTypeSymbol MainSymbol { get; set; } = null!;
    public IFieldSymbol FieldSymbol { get; set; } = null!;
    public string PropertyName { get; set; } = null!;
    public string ReturnTypeName { get; set; } = null!;
    public string DeclaringTypeName { get; set; } = null!;
}
