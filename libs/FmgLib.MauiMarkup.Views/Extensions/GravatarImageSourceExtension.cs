using CommunityToolkit.Maui.ImageSources;

namespace FmgLib.MauiMarkup.Views;

public static partial class GravatarImageSourceExtension
{
    public static T CacheValidityFmg<T>(this T self, TimeSpan timeSpan) where T : GravatarImageSource
    {
        self.SetValue(GravatarImageSource.CacheValidityProperty, timeSpan);
        return self;
    }

    public static T CacheValidityFmg<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure) where T : GravatarImageSource
    {
        PropertyContext<TimeSpan> arg = new PropertyContext<TimeSpan>(self, GravatarImageSource.CacheValidityProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CacheValidityFmg<T>(this SettersContext<T> self, TimeSpan timeSpan) where T : GravatarImageSource
    {
        self.XamlSetters.Add(new Setter
        {
            Property = GravatarImageSource.CacheValidityProperty,
            Value = timeSpan
        });
        return self;
    }

    public static SettersContext<T> CacheValidityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure) where T : GravatarImageSource
    {
        PropertySettersContext<TimeSpan> arg = new PropertySettersContext<TimeSpan>(self.XamlSetters, GravatarImageSource.CacheValidityProperty);
        configure(arg).Build();
        return self;
    }

    public static T CachingEnabledFmg<T>(this T self, bool cachingEnabled) where T : GravatarImageSource
    {
        self.SetValue(GravatarImageSource.CachingEnabledProperty, cachingEnabled);
        return self;
    }

    public static T CachingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : GravatarImageSource
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, GravatarImageSource.CachingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CachingEnabledFmg<T>(this SettersContext<T> self, bool cachingEnabled) where T : GravatarImageSource
    {
        self.XamlSetters.Add(new Setter
        {
            Property = GravatarImageSource.CachingEnabledProperty,
            Value = cachingEnabled
        });
        return self;
    }

    public static SettersContext<T> CachingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : GravatarImageSource
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, GravatarImageSource.CachingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static T EmailFmg<T>(this T self, string email) where T : GravatarImageSource
    {
        self.SetValue(GravatarImageSource.EmailProperty, email);
        return self;
    }

    public static T EmailFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : GravatarImageSource
    {
        var context = new PropertyContext<string>(self, GravatarImageSource.EmailProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> EmailFmg<T>(this SettersContext<T> self, string email)
        where T : GravatarImageSource
    {
        self.XamlSetters.Add(new Setter { Property = GravatarImageSource.EmailProperty, Value = email });
        return self;
    }

    public static SettersContext<T> EmailFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : GravatarImageSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, GravatarImageSource.EmailProperty);
        configure(context).Build();
        return self;
    }

    public static T ImageFmg<T>(this T self, DefaultImage image) where T : GravatarImageSource
    {
        self.SetValue(GravatarImageSource.ImageProperty, image);
        return self;
    }

    public static T ImageFmg<T>(this T self, Func<PropertyContext<DefaultImage>, IPropertyBuilder<DefaultImage>> configure) where T : GravatarImageSource
    {
        PropertyContext<DefaultImage> arg = new PropertyContext<DefaultImage>(self, GravatarImageSource.ImageProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ImageFmg<T>(this SettersContext<T> self, DefaultImage image) where T : GravatarImageSource
    {
        self.XamlSetters.Add(new Setter
        {
            Property = GravatarImageSource.ImageProperty,
            Value = image
        });
        return self;
    }

    public static SettersContext<T> ImageFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DefaultImage>, IPropertySettersBuilder<DefaultImage>> configure) where T : GravatarImageSource
    {
        PropertySettersContext<DefaultImage> arg = new PropertySettersContext<DefaultImage>(self.XamlSetters, GravatarImageSource.ImageProperty);
        configure(arg).Build();
        return self;
    }
}
