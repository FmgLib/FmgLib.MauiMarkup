using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKFileLottieImageSourceExtension
{
    public static T FileFmg<T>(this T self,
        string file)
        where T : SKFileLottieImageSource
    {
        self.SetValue(SKFileLottieImageSource.FileProperty, file);
        return self;
    }

    public static T FileFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SKFileLottieImageSource
    {
        var context = new PropertyContext<string>(self, SKFileLottieImageSource.FileProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FileFmg<T>(this SettersContext<T> self,
        string file)
        where T : SKFileLottieImageSource
    {
        self.XamlSetters.Add(new Setter { Property = SKFileLottieImageSource.FileProperty, Value = file });
        return self;
    }

    public static SettersContext<T> FileFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SKFileLottieImageSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SKFileLottieImageSource.FileProperty);
        configure(context).Build();
        return self;
    }
}
