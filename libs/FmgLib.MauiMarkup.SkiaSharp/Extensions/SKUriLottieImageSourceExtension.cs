using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKUriLottieImageSourceExtension
{
    public static T UriFmg<T>(this T self,
        Uri uri)
        where T : SKUriLottieImageSource
    {
        self.SetValue(SKUriLottieImageSource.UriProperty, uri);
        return self;
    }

    public static T UriFmg<T>(this T self, Func<PropertyContext<Uri>, IPropertyBuilder<Uri>> configure)
        where T : SKUriLottieImageSource
    {
        var context = new PropertyContext<Uri>(self, SKUriLottieImageSource.UriProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> UriFmg<T>(this SettersContext<T> self,
        Uri uri)
        where T : SKUriLottieImageSource
    {
        self.XamlSetters.Add(new Setter { Property = SKUriLottieImageSource.UriProperty, Value = uri });
        return self;
    }

    public static SettersContext<T> UriFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Uri>, IPropertySettersBuilder<Uri>> configure)
        where T : SKUriLottieImageSource
    {
        var context = new PropertySettersContext<Uri>(self.XamlSetters, SKUriLottieImageSource.UriProperty);
        configure(context).Build();
        return self;
    }
}
