using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKStreamLottieImageSourceExtension
{
    public static T StreamFmg<T>(this T self,
        Func<CancellationToken, Task<Stream?>> func)
        where T : SKStreamLottieImageSource
    {
        self.SetValue(SKStreamLottieImageSource.StreamProperty, func);
        return self;
    }

    public static T StreamFmg<T>(this T self, Func<PropertyContext<Func<CancellationToken, Task<Stream?>>>, IPropertyBuilder<Func<CancellationToken, Task<Stream?>>>> configure)
        where T : SKStreamLottieImageSource
    {
        var context = new PropertyContext<Func<CancellationToken, Task<Stream?>>>(self, SKStreamLottieImageSource.StreamProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StreamFmg<T>(this SettersContext<T> self,
        Func<CancellationToken, Task<Stream?>> func)
        where T : SKStreamLottieImageSource
    {
        self.XamlSetters.Add(new Setter { Property = SKStreamLottieImageSource.StreamProperty, Value = func });
        return self;
    }

    public static SettersContext<T> StreamFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Func<CancellationToken, Task<Stream?>>>, IPropertySettersBuilder<Func<CancellationToken, Task<Stream?>>>> configure)
        where T : SKStreamLottieImageSource
    {
        var context = new PropertySettersContext<Func<CancellationToken, Task<Stream?>>>(self.XamlSetters, SKStreamLottieImageSource.StreamProperty);
        configure(context).Build();
        return self;
    }
}
