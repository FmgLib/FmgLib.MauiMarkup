namespace FmgLib.MauiMarkup;

public static class PropertySettersContextExtension
{
    public static PropertySettersIdiomBuilder<T> OnPhoneFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersIdiomBuilder<T>(self).OnPhoneFmg(value);

    public static PropertySettersIdiomBuilder<T> OnPhoneFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersIdiomBuilder<T>(self).OnPhoneFmg(configure);

    public static PropertySettersIdiomBuilder<T> OnTabletFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersIdiomBuilder<T>(self).OnTabletFmg(value);

    public static PropertySettersIdiomBuilder<T> OnTabletFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersIdiomBuilder<T>(self).OnTabletFmg(configure);

    public static PropertySettersIdiomBuilder<T> OnDesktopFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersIdiomBuilder<T>(self).OnDesktopFmg(value);

    public static PropertySettersIdiomBuilder<T> OnDesktopFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersIdiomBuilder<T>(self).OnDesktopFmg(configure);

    public static PropertySettersIdiomBuilder<T> OnTVFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersIdiomBuilder<T>(self).OnTVFmg(value);

    public static PropertySettersIdiomBuilder<T> OnTVFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersIdiomBuilder<T>(self).OnTVFmg(configure);

    public static PropertySettersIdiomBuilder<T> OnWatchFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersIdiomBuilder<T>(self).OnWatchFmg(value);

    public static PropertySettersIdiomBuilder<T> OnWatchFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersIdiomBuilder<T>(self).OnWatchFmg(configure);

    public static PropertySettersPlatformBuilder<T> OnMacCatalystFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersPlatformBuilder<T>(self).OnMacCatalystFmg(value);

    public static PropertySettersPlatformBuilder<T> OnMacCatalystFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersPlatformBuilder<T>(self).OnMacCatalystFmg(configure);

    public static PropertySettersPlatformBuilder<T> OniOSFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersPlatformBuilder<T>(self).OniOSFmg(value);

    public static PropertySettersPlatformBuilder<T> OniOSFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersPlatformBuilder<T>(self).OniOSFmg(configure);

    public static PropertySettersPlatformBuilder<T> OnAndroidFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersPlatformBuilder<T>(self).OnAndroidFmg(value);

    public static PropertySettersPlatformBuilder<T> OnAndroidFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersPlatformBuilder<T>(self).OnAndroidFmg(configure);

    public static PropertySettersPlatformBuilder<T> OnWinUIFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersPlatformBuilder<T>(self).OnWinUIFmg(value);

    public static PropertySettersPlatformBuilder<T> OnWinUIFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersPlatformBuilder<T>(self).OnWinUIFmg(configure);

    public static PropertySettersPlatformBuilder<T> OnTizenFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersPlatformBuilder<T>(self).OnTizenFmg(value);

    public static PropertySettersPlatformBuilder<T> OnTizenFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersPlatformBuilder<T>(self).OnTizenFmg(configure);

    public static PropertySettersThemeBuilder<T> OnLightFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersThemeBuilder<T>(self).OnLightFmg(value);

    public static PropertySettersThemeBuilder<T> OnLightFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersThemeBuilder<T>(self).OnLightFmg(configure);

    public static PropertySettersThemeBuilder<T> OnDarkFmg<T>(this PropertySettersContext<T> self, T value)
        => new PropertySettersThemeBuilder<T>(self).OnDarkFmg(value);

    public static PropertySettersThemeBuilder<T> OnDarkFmg<T>(this PropertySettersContext<T> self, Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
        => new PropertySettersThemeBuilder<T>(self).OnDarkFmg(configure);
}
