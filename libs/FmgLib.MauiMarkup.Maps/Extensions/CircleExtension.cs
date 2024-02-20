using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace FmgLib.MauiMarkup.Maps;

public static partial class CircleExtension
{
    public static T FillColorFmg<T>(this T self, Color color) where T : Circle
    {
        self.SetValue(Circle.FillColorProperty, color);
        return self;
    }

    public static T FillColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Circle
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Circle.FillColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FillColorFmg<T>(this SettersContext<T> self, Color color) where T : Circle
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Circle.FillColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> FillColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Circle
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Circle.FillColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T CenterFmg<T>(this T self, Location location) where T : Circle
    {
        self.SetValue(Circle.CenterProperty, location);
        return self;
    }

    public static T CenterFmg<T>(this T self, Func<PropertyContext<Location>, IPropertyBuilder<Location>> configure) where T : Circle
    {
        PropertyContext<Location> arg = new PropertyContext<Location>(self, Circle.CenterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CenterFmg<T>(this SettersContext<T> self, Location location) where T : Circle
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Circle.CenterProperty,
            Value = location
        });
        return self;
    }

    public static SettersContext<T> CenterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Location>, IPropertySettersBuilder<Location>> configure) where T : Circle
    {
        PropertySettersContext<Location> arg = new PropertySettersContext<Location>(self.XamlSetters, Circle.CenterProperty);
        configure(arg).Build();
        return self;
    }

    public static T RadiusFmg<T>(this T self, Distance distance) where T : Circle
    {
        self.SetValue(Circle.RadiusProperty, distance);
        return self;
    }

    public static T RadiusFmg<T>(this T self, Func<PropertyContext<Distance>, IPropertyBuilder<Distance>> configure) where T : Circle
    {
        PropertyContext<Distance> arg = new PropertyContext<Distance>(self, Circle.RadiusProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RadiusFmg<T>(this SettersContext<T> self, Distance distance) where T : Circle
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Circle.RadiusProperty,
            Value = distance
        });
        return self;
    }

    public static SettersContext<T> RadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Distance>, IPropertySettersBuilder<Distance>> configure) where T : Circle
    {
        PropertySettersContext<Distance> arg = new PropertySettersContext<Distance>(self.XamlSetters, Circle.RadiusProperty);
        configure(arg).Build();
        return self;
    }
}
