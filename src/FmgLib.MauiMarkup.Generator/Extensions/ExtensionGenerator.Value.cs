namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateExtensionMethod_Value(PropInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_Value_Sealed(info);
        else
            GenerateExtensionMethod_Value_Normal(info);
    }

    void GenerateExtensionMethod_Value_Sealed(PropInfo info)
    {
        builder.Append($@"
    public static {info.MainSymbolName} {info.methodName}(this {info.MainSymbolName} self,
        {info.propertyTypeName} {info.camelCaseName})
    {{
        {info.valueAssignmentString}
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_Value_Normal(PropInfo info)
    {
        builder.Append($@"
    public static T {info.methodName}<T>(this T self,
        {info.propertyTypeName} {info.camelCaseName})
        where T : {info.MainSymbolName}
    {{
        {info.valueAssignmentString}
        return self;
    }}
    ");
    }


    void GenerateExtensionMethod_Value(AttachedFieldInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_Value_Sealed(info);
        else
            GenerateExtensionMethod_Value_Normal(info);
    }

    void GenerateExtensionMethod_Value_Sealed(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static {info.DeclaringTypeName} {info.propertyName}(this {info.DeclaringTypeName} self,
        {info.ReturnTypeName} {info.camelCaseName})
    {{
        {info.valueAssignmentString}
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_Value_Normal(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static T {info.propertyName}<T>(this T self,
        {info.ReturnTypeName} {info.camelCaseName})
        where T : {info.DeclaringTypeName}
    {{
        {info.valueAssignmentString}
        return self;
    }}
    ");
    }
}