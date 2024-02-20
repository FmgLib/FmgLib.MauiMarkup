using Microsoft.Maui.Controls.Maps;

namespace FmgLib.MauiMarkup.Maps;

public static partial class MapElementExtension
{
    public static T StrokeColorFmg<T>(this T self, Color color) where T : MapElement
    {
        self.SetValue(MapElement.StrokeColorProperty, color);
        return self;
    }

    public static T StrokeColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : MapElement
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, MapElement.StrokeColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> StrokeColorFmg<T>(this SettersContext<T> self, Color color) where T : MapElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MapElement.StrokeColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> StrokeColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : MapElement
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, MapElement.StrokeColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T StrokeWidthFmg<T>(this T self, float width) where T : MapElement
    {
        self.SetValue(MapElement.StrokeWidthProperty, width);
        return self;
    }

    public static T StrokeWidthFmg<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure) where T : MapElement
    {
        PropertyContext<float> arg = new PropertyContext<float>(self, MapElement.StrokeWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> StrokeWidthFmg<T>(this SettersContext<T> self, float width) where T : MapElement
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MapElement.StrokeWidthProperty,
            Value = width
        });
        return self;
    }

    public static SettersContext<T> StrokeWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure) where T : MapElement
    {
        PropertySettersContext<float> arg = new PropertySettersContext<float>(self.XamlSetters, MapElement.StrokeWidthProperty);
        configure(arg).Build();
        return self;
    }
}
