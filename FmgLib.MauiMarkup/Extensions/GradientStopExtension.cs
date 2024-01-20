namespace FmgLib.MauiMarkup;

public static partial class GradientStopExtension
{
    public static T ColorFmg<T>(this T self,
        Color color)
        where T : GradientStop
    {
        self.SetValue(GradientStop.ColorProperty, color);
        return self;
    }
    
    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : GradientStop
    {
        var context = new PropertyContext<Color>(self, GradientStop.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : GradientStop
    {
        self.XamlSetters.Add(new Setter { Property = GradientStop.ColorProperty, Value = color });
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : GradientStop
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, GradientStop.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OffsetFmg<T>(this T self,
        float offset)
        where T : GradientStop
    {
        self.SetValue(GradientStop.OffsetProperty, offset);
        return self;
    }
    
    public static T OffsetFmg<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure)
        where T : GradientStop
    {
        var context = new PropertyContext<float>(self, GradientStop.OffsetProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OffsetFmg<T>(this SettersContext<T> self,
        float offset)
        where T : GradientStop
    {
        self.XamlSetters.Add(new Setter { Property = GradientStop.OffsetProperty, Value = offset });
        return self;
    }
    
    public static SettersContext<T> OffsetFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure)
        where T : GradientStop
    {
        var context = new PropertySettersContext<float>(self.XamlSetters, GradientStop.OffsetProperty);
        configure(context).Build();
        return self;
    }
    
}