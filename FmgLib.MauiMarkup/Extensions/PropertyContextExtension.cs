namespace FmgLib.MauiMarkup;

public static class PropertyContextExtension
{

    public static PropertyBindingBuilder<T> PathFmg<T>(this PropertyContext<T> self, string path)
        => new PropertyBindingBuilder<T>(self).PathFmg(path);

    public static PropertyIdiomBuilder<T> OnPhoneFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyIdiomBuilder<T>(self).OnPhoneFmg(value);

    public static PropertyIdiomBuilder<T> OnPhoneFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyIdiomBuilder<T>(self).OnPhoneFmg(configure);

    public static PropertyIdiomBuilder<T> OnTabletFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyIdiomBuilder<T>(self).OnTabletFmg(value);

    public static PropertyIdiomBuilder<T> OnTabletFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyIdiomBuilder<T>(self).OnTabletFmg(configure);

    public static PropertyIdiomBuilder<T> OnDesktopFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyIdiomBuilder<T>(self).OnDesktopFmg(value);

    public static PropertyIdiomBuilder<T> OnDesktopFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyIdiomBuilder<T>(self).OnDesktopFmg(configure);

    public static PropertyIdiomBuilder<T> OnTVFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyIdiomBuilder<T>(self).OnTVFmg(value);

    public static PropertyIdiomBuilder<T> OnTVFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyIdiomBuilder<T>(self).OnTVFmg(configure);

    public static PropertyIdiomBuilder<T> OnWatchFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyIdiomBuilder<T>(self).OnWatchFmg(value);

    public static PropertyIdiomBuilder<T> OnWatchFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyIdiomBuilder<T>(self).OnWatchFmg(configure);

    public static PropertyPlatformBuilder<T> OnMacCatalystFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyPlatformBuilder<T>(self).OnMacCatalystFmg(value);

    public static PropertyPlatformBuilder<T> OnMacCatalystFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyPlatformBuilder<T>(self).OnMacCatalystFmg(configure);

    public static PropertyPlatformBuilder<T> OniOSFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyPlatformBuilder<T>(self).OniOSFmg(value);

    public static PropertyPlatformBuilder<T> OniOSFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyPlatformBuilder<T>(self).OniOSFmg(configure);

    public static PropertyPlatformBuilder<T> OnAndroidFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyPlatformBuilder<T>(self).OnAndroidFmg(value);

    public static PropertyPlatformBuilder<T> OnAndroidFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyPlatformBuilder<T>(self).OnAndroidFmg(configure);

    public static PropertyPlatformBuilder<T> OnWinUIFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyPlatformBuilder<T>(self).OnWinUIFmg(value);

    public static PropertyPlatformBuilder<T> OnWinUIFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyPlatformBuilder<T>(self).OnWinUIFmg(configure);

    public static PropertyPlatformBuilder<T> OnTizenFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyPlatformBuilder<T>(self).OnTizenFmg(value);

    public static PropertyPlatformBuilder<T> OnTizenFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyPlatformBuilder<T>(self).OnTizenFmg(configure);

    public static PropertyThemeBuilder<T> OnLightFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyThemeBuilder<T>(self).OnLightFmg(value);

    public static PropertyThemeBuilder<T> OnLightFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyThemeBuilder<T>(self).OnLightFmg(configure);

    public static PropertyThemeBuilder<T> OnDarkFmg<T>(this PropertyContext<T> self, T value)
        => new PropertyThemeBuilder<T>(self).OnDarkFmg(value);

    public static PropertyThemeBuilder<T> OnDarkFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
        => new PropertyThemeBuilder<T>(self).OnDarkFmg(configure);

    public static PropertyDynamicResourcesBuilder<T> DynamicResourceFmg<T>(this PropertyContext<T> self, string key)
        => new PropertyDynamicResourcesBuilder<T>(self).DynamicResourceFmg(key);
}
