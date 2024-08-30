namespace FmgLib.MauiMarkup.Generator.Extensions;

public partial class ExtensionGenerator
{
    void GenerateExtensionMethod_SettersBuilder(PropInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_SettersBuilder_Sealed(info);
        else
            GenerateExtensionMethod_SettersBuilder_Normal(info);
    }

    void GenerateExtensionMethod_SettersBuilder_Sealed(PropInfo info)
    {
        builder.Append($@"
    public static SettersContext<{info.MainSymbolName}> {info.propertyName}(this SettersContext<{info.MainSymbolName}> self, Func<PropertySettersContext<{info.propertyTypeName}>, IPropertySettersBuilder<{info.propertyTypeName}>> configure)
    {{
        var context = new PropertySettersContext<{info.propertyTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_SettersBuilder_Normal(PropInfo info)
    {
        builder.Append($@"
    public static SettersContext<T> {info.propertyName}<T>(this SettersContext<T> self, Func<PropertySettersContext<{info.propertyTypeName}>, IPropertySettersBuilder<{info.propertyTypeName}>> configure)
        where T : {info.MainSymbolName}
    {{
        var context = new PropertySettersContext<{info.propertyTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }


    void GenerateExtensionMethod_SettersBuilder(AttachedFieldInfo info)
    {
        if (mainSymbol.IsSealed)
            GenerateExtensionMethod_SettersBuilder_Sealed(info);
        else
            GenerateExtensionMethod_SettersBuilder_Normal(info);
    }

    void GenerateExtensionMethod_SettersBuilder_Sealed(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static SettersContext<{info.DeclaringTypeName}> {info.propertyName}(this SettersContext<{info.DeclaringTypeName}> self, Func<PropertySettersContext<{info.ReturnTypeName}>, IPropertySettersBuilder<{info.ReturnTypeName}>> configure)
    {{
        var context = new PropertySettersContext<{info.ReturnTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_SettersBuilder_Normal(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static SettersContext<T> {info.propertyName}<T>(this SettersContext<T> self, Func<PropertySettersContext<{info.ReturnTypeName}>, IPropertySettersBuilder<{info.ReturnTypeName}>> configure)
        where T : {info.DeclaringTypeName}
    {{
        var context = new PropertySettersContext<{info.ReturnTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }
}