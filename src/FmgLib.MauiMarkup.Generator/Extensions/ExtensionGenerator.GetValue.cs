namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateExtensionMethod_GetValue(PropInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_GetValue_Sealed(info);
        else
            GenerateExtensionMethod_GetValue_Normal(info);
    }

    void GenerateExtensionMethod_GetValue_Sealed(PropInfo info)
    {
        builder.Append($@"
    public static {info.propertyTypeName} Get{info.methodName}Value<T>(this {info.MainSymbolName} self)
    {{
        return ({info.propertyTypeName})self.GetValue({info.BindablePropertyName});
    }}
    ");
    }

    void GenerateExtensionMethod_GetValue_Normal(PropInfo info)
    {
        builder.Append($@"
    public static {info.propertyTypeName} Get{info.methodName}Value<T>(this T self)
        where T : {info.MainSymbolName}
    {{
        return ({info.propertyTypeName})self.GetValue({info.BindablePropertyName});
    }}
    ");
    }
}