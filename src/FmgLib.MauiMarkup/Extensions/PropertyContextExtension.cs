namespace FmgLib.MauiMarkup;

public static class PropertyContextExtension
{

    public static PropertyBindingBuilder<TSource, TProperty> Path<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, string path)
        => new PropertyBindingBuilder<TSource, TProperty>(self).Path(path);
    
    public static PropertyBindingBuilder<TSource, TProperty> Compiled<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<TSource, TProperty> getter)
        => new PropertyBindingBuilder<TSource, TProperty>(self).Compiled(getter);

    public static PropertyMultiBindingBuilder<TSource, TProperty> Bindings<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, params BindingBase[] bindings)
        => new PropertyMultiBindingBuilder<TSource, TProperty>(self).Bindings(bindings);

    public static PropertyIdiomBuilder<TSource, TProperty> OnPhone<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnPhone(value);

    public static PropertyIdiomBuilder<TSource, TProperty> OnPhone<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnPhone(configure);

    public static PropertyIdiomBuilder<TSource, TProperty> OnTablet<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnTablet(value);

    public static PropertyIdiomBuilder<TSource, TProperty> OnTablet<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnTablet(configure);

    public static PropertyIdiomBuilder<TSource, TProperty> OnDesktop<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnDesktop(value);

    public static PropertyIdiomBuilder<TSource, TProperty> OnDesktop<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnDesktop(configure);

    public static PropertyIdiomBuilder<TSource, TProperty> OnTV<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnTV(value);

    public static PropertyIdiomBuilder<TSource, TProperty> OnTV<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnTV(configure);

    public static PropertyIdiomBuilder<TSource, TProperty> OnWatch<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnWatch(value);

    public static PropertyIdiomBuilder<TSource, TProperty> OnWatch<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyIdiomBuilder<TSource, TProperty>(self).OnWatch(configure);

    public static PropertyPlatformBuilder<TSource, TProperty> OnMacCatalyst<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnMacCatalyst(value);

    public static PropertyPlatformBuilder<TSource, TProperty> OnMacCatalyst<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnMacCatalyst(configure);

    public static PropertyPlatformBuilder<TSource, TProperty> OniOS<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OniOS(value);

    public static PropertyPlatformBuilder<TSource, TProperty> OniOS<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OniOS(configure);

    public static PropertyPlatformBuilder<TSource, TProperty> OnAndroid<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnAndroid(value);

    public static PropertyPlatformBuilder<TSource, TProperty> OnAndroid<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnAndroid(configure);

    public static PropertyPlatformBuilder<TSource, TProperty> OnWinUI<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnWinUI(value);

    public static PropertyPlatformBuilder<TSource, TProperty> OnWinUI<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnWinUI(configure);

    public static PropertyPlatformBuilder<TSource, TProperty> OnTizen<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnTizen(value);

    public static PropertyPlatformBuilder<TSource, TProperty> OnTizen<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyPlatformBuilder<TSource, TProperty>(self).OnTizen(configure);

    public static PropertyThemeBuilder<TSource, TProperty> OnLight<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyThemeBuilder<TSource, TProperty>(self).OnLight(value);

    public static PropertyThemeBuilder<TSource, TProperty> OnLight<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyThemeBuilder<TSource, TProperty>(self).OnLight(configure);

    public static PropertyThemeBuilder<TSource, TProperty> OnDark<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, TProperty value)
        => new PropertyThemeBuilder<TSource, TProperty>(self).OnDark(value);

    public static PropertyThemeBuilder<TSource, TProperty> OnDark<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
        => new PropertyThemeBuilder<TSource, TProperty>(self).OnDark(configure);

    public static PropertyDynamicResourcesBuilder<TSource, TProperty> DynamicResource<TSource, TProperty>(this PropertyContext<TSource, TProperty> self, string key)
        => new PropertyDynamicResourcesBuilder<TSource, TProperty>(self).DynamicResource(key);
}
