using Microsoft.Maui.Controls.Maps;

namespace FmgLib.MauiMarkup.Maps;

public static partial class PolygonExtension
{
    public static T FillColorFmg<T>(this T self, Color color) where T : Polygon
    {
        self.SetValue(Polygon.FillColorProperty, color);
        return self;
    }

    public static T FillColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Polygon
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Polygon.FillColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FillColorFmg<T>(this SettersContext<T> self, Color color) where T : Polygon
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Polygon.FillColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> FillColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Polygon
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Polygon.FillColorProperty);
        configure(arg).Build();
        return self;
    }
}
