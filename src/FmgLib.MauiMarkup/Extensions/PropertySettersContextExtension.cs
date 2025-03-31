namespace FmgLib.MauiMarkup;

public static class PropertySettersContextExtension
{
    public static PropertySettersBindingBuilder<TSource, TProperty> Path<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, string path)
        => new PropertySettersBindingBuilder<TSource, TProperty>(self).Path(path);
    
    public static PropertySettersBindingBuilder<TSource, TProperty> Compiled<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<TSource, TProperty> getter)
        => new PropertySettersBindingBuilder<TSource, TProperty>(self).Compiled(getter);

    public static PropertySettersMultiBindingBuilder<TSource, TProperty> Bindings<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, params BindingBase[] bindings)
        => new PropertySettersMultiBindingBuilder<TSource, TProperty>(self).Bindings(bindings);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnPhone<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnPhone(value);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnPhone<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnPhone(configure);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnTablet<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnTablet(value);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnTablet<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnTablet(configure);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnDesktop<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnDesktop(value);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnDesktop<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnDesktop(configure);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnTV<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnTV(value);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnTV<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnTV(configure);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnWatch<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnWatch(value);

    public static PropertySettersIdiomBuilder<TSource, TProperty> OnWatch<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersIdiomBuilder<TSource, TProperty>(self).OnWatch(configure);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnMacCatalyst<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnMacCatalyst(value);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnMacCatalyst<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnMacCatalyst(configure);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OniOS<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OniOS(value);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OniOS<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OniOS(configure);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnAndroid<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnAndroid(value);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnAndroid<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnAndroid(configure);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnWinUI<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnWinUI(value);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnWinUI<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnWinUI(configure);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnTizen<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnTizen(value);

    public static PropertySettersPlatformBuilder<TSource, TProperty> OnTizen<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersPlatformBuilder<TSource, TProperty>(self).OnTizen(configure);

    public static PropertySettersThemeBuilder<TSource, TProperty> OnLight<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersThemeBuilder<TSource, TProperty>(self).OnLight(value);

    public static PropertySettersThemeBuilder<TSource, TProperty> OnLight<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersThemeBuilder<TSource, TProperty>(self).OnLight(configure);

    public static PropertySettersThemeBuilder<TSource, TProperty> OnDark<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, TProperty value)
        => new PropertySettersThemeBuilder<TSource, TProperty>(self).OnDark(value);

    public static PropertySettersThemeBuilder<TSource, TProperty> OnDark<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
        => new PropertySettersThemeBuilder<TSource, TProperty>(self).OnDark(configure);

    public static PropertySettersDynamicResourcesBuilder<TSource, TProperty> DynamicResource<TSource, TProperty>(this PropertySettersContext<TSource, TProperty> self, string key)
        => new PropertySettersDynamicResourcesBuilder<TSource, TProperty>(self).DynamicResource(key);
}
