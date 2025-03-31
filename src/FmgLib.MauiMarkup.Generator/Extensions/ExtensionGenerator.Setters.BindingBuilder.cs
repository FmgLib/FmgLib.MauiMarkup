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
    public static SettersContext<{info.MainSymbolName}> {info.methodName}(this SettersContext<{info.MainSymbolName}> self, Func<PropertySettersContext<{info.MainSymbolName}, {info.propertyTypeName}>, IPropertySettersBuilder<{info.MainSymbolName}, {info.propertyTypeName}>> configure)
    {{
        var context = new PropertySettersContext<{info.MainSymbolName}, {info.propertyTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_SettersBuilder_Normal(PropInfo info)
    {
        builder.Append($@"
    public static SettersContext<T> {info.methodName}<T>(this SettersContext<T> self, Func<PropertySettersContext<T, {info.propertyTypeName}>, IPropertySettersBuilder<T, {info.propertyTypeName}>> configure)
        where T : {info.MainSymbolName}
    {{
        var context = new PropertySettersContext<T, {info.propertyTypeName}>(self.XamlSetters, {info.BindablePropertyName});
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
    public static SettersContext<{info.DeclaringTypeName}> {info.propertyName}(this SettersContext<{info.DeclaringTypeName}> self, Func<PropertySettersContext<{info.DeclaringTypeName}, {info.ReturnTypeName}>, IPropertySettersBuilder<{info.DeclaringTypeName}, {info.ReturnTypeName}>> configure)
    {{
        var context = new PropertySettersContext<{info.DeclaringTypeName}, {info.ReturnTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }

    void GenerateExtensionMethod_SettersBuilder_Normal(AttachedFieldInfo info)
    {
        builder.Append($@"
    public static SettersContext<T> {info.propertyName}<T>(this SettersContext<T> self, Func<PropertySettersContext<T, {info.ReturnTypeName}>, IPropertySettersBuilder<T, {info.ReturnTypeName}>> configure)
        where T : {info.DeclaringTypeName}
    {{
        var context = new PropertySettersContext<T, {info.ReturnTypeName}>(self.XamlSetters, {info.BindablePropertyName});
        configure(context).Build();
        return self;
    }}
    ");
    }
}