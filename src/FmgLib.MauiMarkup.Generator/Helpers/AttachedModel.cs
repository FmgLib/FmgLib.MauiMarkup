using Microsoft.CodeAnalysis;

namespace FmgLib.MauiMarkup.Generator.Extensions;

public class AttachedModel
{
    public INamedTypeSymbol MainSymbol { get; set; }
    public IFieldSymbol FieldSymbol { get; set; }
    public string PropertyName { get; set; }
    public string ReturnTypeName { get; set; }
    public string DeclaringTypeName { get; set; }
}
