using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiOvalShapeExtension
{
    public static T HeightRatioFmg<T>(this T self,
        double heightRatio)
        where T : SKConfettiOvalShape
    {
        self.SetValue(SKConfettiOvalShape.HeightRatioProperty, heightRatio);
        return self;
    }

    public static T HeightRatioFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiOvalShape
    {
        var context = new PropertyContext<double>(self, SKConfettiOvalShape.HeightRatioProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HeightRatioFmg<T>(this SettersContext<T> self,
        double heightRatio)
        where T : SKConfettiOvalShape
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiOvalShape.HeightRatioProperty, Value = heightRatio });
        return self;
    }

    public static SettersContext<T> HeightRatioFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiOvalShape
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiOvalShape.HeightRatioProperty);
        configure(context).Build();
        return self;
    }
}
