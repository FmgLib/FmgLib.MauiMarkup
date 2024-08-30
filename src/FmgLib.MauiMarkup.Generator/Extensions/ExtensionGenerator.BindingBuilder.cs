namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateExtensionMethod_BindablePropertyBuilder(PropInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_BindablePropertyBuilder_Sealed(info);
        else
            GenerateExtensionMethod_BindablePropertyBuilder_Normal(info);
    }

    void GenerateExtensionMethod_BindablePropertyBuilder_Sealed(PropInfo info)
    {
        builder.Append($@"
    public static {info.MainSymbolName} {info.propertyName}(this {info.MainSymbolName} self, Func<PropertyContext<{info.propertyTypeName}>, IPropertyBuilder<{info.propertyTypeName}>> configure)
    {{
        var context = new PropertyContext<{info.propertyTypeName}>(self, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_BindablePropertyBuilder_Normal(PropInfo info)
    {
        builder.Append($@"
    public static T {info.propertyName}<T>(this T self, Func<PropertyContext<{info.propertyTypeName}>, IPropertyBuilder<{info.propertyTypeName}>> configure)
        where T : {info.MainSymbolName}
    {{
        var context = new PropertyContext<{info.propertyTypeName}>(self, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }


    void GenerateExtensionMethod_BindablePropertyBuilder(AttachedFieldInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_BindablePropertyBuilder_Sealed(info);
        else
            GenerateExtensionMethod_BindablePropertyBuilder_Normal(info);
    }

    void GenerateExtensionMethod_BindablePropertyBuilder_Sealed(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static {info.DeclaringTypeName} {info.propertyName}(this {info.DeclaringTypeName} self, Func<PropertyContext<{info.ReturnTypeName}>, IPropertyBuilder<{info.ReturnTypeName}>> configure)
    {{
        var context = new PropertyContext<{info.propertyTypeName}>(self, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_BindablePropertyBuilder_Normal(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static T {info.propertyName}<T>(this T self, Func<PropertyContext<{info.ReturnTypeName}>, IPropertyBuilder<{info.ReturnTypeName}>> configure)
        where T : {info.DeclaringTypeName}
    {{
        var context = new PropertyContext<{info.ReturnTypeName}>(self, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }
}