namespace FmgLib.MauiMarkup;

public static class PropertyContextExtension
{
    public static PropertyBindingBuilder<T> PathFmg<T>(this PropertyContext<T> self, string path)
    {
        return new PropertyBindingBuilder<T>(self).Path(path);
    }

    public static PropertyIdiomBuilder<T> OnPhoneFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyIdiomBuilder<T>(self).OnPhone(value);
    }

    public static PropertyIdiomBuilder<T> OnPhoneFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyIdiomBuilder<T>(self).OnPhone(configure);
    }

    public static PropertyIdiomBuilder<T> OnTabletFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyIdiomBuilder<T>(self).OnTablet(value);
    }

    public static PropertyIdiomBuilder<T> OnTabletFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyIdiomBuilder<T>(self).OnTablet(configure);
    }

    public static PropertyIdiomBuilder<T> OnDesktopFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyIdiomBuilder<T>(self).OnDesktop(value);
    }

    public static PropertyIdiomBuilder<T> OnDesktopFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyIdiomBuilder<T>(self).OnDesktop(configure);
    }

    public static PropertyIdiomBuilder<T> OnTVFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyIdiomBuilder<T>(self).OnTV(value);
    }

    public static PropertyIdiomBuilder<T> OnTVFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyIdiomBuilder<T>(self).OnTV(configure);
    }

    public static PropertyIdiomBuilder<T> OnWatchFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyIdiomBuilder<T>(self).OnWatch(value);
    }

    public static PropertyIdiomBuilder<T> OnWatchFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyIdiomBuilder<T>(self).OnWatch(configure);
    }

    public static PropertyPlatformBuilder<T> OnMacCatalystFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyPlatformBuilder<T>(self).OnMacCatalyst(value);
    }

    public static PropertyPlatformBuilder<T> OnMacCatalystFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyPlatformBuilder<T>(self).OnMacCatalyst(configure);
    }

    public static PropertyPlatformBuilder<T> OniOSFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyPlatformBuilder<T>(self).OniOS(value);
    }

    public static PropertyPlatformBuilder<T> OniOSFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyPlatformBuilder<T>(self).OniOS(configure);
    }

    public static PropertyPlatformBuilder<T> OnAndroidFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyPlatformBuilder<T>(self).OnAndroid(value);
    }

    public static PropertyPlatformBuilder<T> OnAndroidFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyPlatformBuilder<T>(self).OnAndroid(configure);
    }

    public static PropertyPlatformBuilder<T> OnWinUIFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyPlatformBuilder<T>(self).OnWinUI(value);
    }

    public static PropertyPlatformBuilder<T> OnWinUIFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyPlatformBuilder<T>(self).OnWinUI(configure);
    }

    public static PropertyPlatformBuilder<T> OnTizenFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyPlatformBuilder<T>(self).OnTizen(value);
    }

    public static PropertyPlatformBuilder<T> OnTizenFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyPlatformBuilder<T>(self).OnTizen(configure);
    }

    public static PropertyThemeBuilder<T> OnLightFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyThemeBuilder<T>(self).OnLight(value);
    }

    public static PropertyThemeBuilder<T> OnLightFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyThemeBuilder<T>(self).OnLight(configure);
    }

    public static PropertyThemeBuilder<T> OnDarkFmg<T>(this PropertyContext<T> self, T value)
    {
        return new PropertyThemeBuilder<T>(self).OnDark(value);
    }

    public static PropertyThemeBuilder<T> OnDarkFmg<T>(this PropertyContext<T> self, Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        return new PropertyThemeBuilder<T>(self).OnDark(configure);
    }

    public static PropertyDynamicResourcesBuilder<T> DynamicResourceFmg<T>(this PropertyContext<T> self, string key)
    {
        return new PropertyDynamicResourcesBuilder<T>(self).DynamicResource(key);
    }
}
