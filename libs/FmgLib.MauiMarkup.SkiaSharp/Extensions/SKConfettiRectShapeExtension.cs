using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiRectShapeExtension
{
    public static T HeightRatioFmg<T>(this T self,
        double heightRatio)
        where T : SKConfettiRectShape
    {
        self.SetValue(SKConfettiRectShape.HeightRatioProperty, heightRatio);
        return self;
    }

    public static T HeightRatioFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiRectShape
    {
        var context = new PropertyContext<double>(self, SKConfettiRectShape.HeightRatioProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HeightRatioFmg<T>(this SettersContext<T> self,
        double heightRatio)
        where T : SKConfettiRectShape
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiRectShape.HeightRatioProperty, Value = heightRatio });
        return self;
    }

    public static SettersContext<T> HeightRatioFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiRectShape
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiRectShape.HeightRatioProperty);
        configure(context).Build();
        return self;
    }
}
