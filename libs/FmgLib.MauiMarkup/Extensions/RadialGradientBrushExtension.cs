namespace FmgLib.MauiMarkup;



public static partial class RadialGradientBrushExtension
{
    public static T Center<T>(this T self,
        Point center)
        where T : RadialGradientBrush
    {
        self.SetValue(RadialGradientBrush.CenterProperty, center);
        return self;
    }
    
    public static T Center<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : RadialGradientBrush
    {
        var context = new PropertyContext<Point>(self, RadialGradientBrush.CenterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Center<T>(this SettersContext<T> self,
        Point center)
        where T : RadialGradientBrush
    {
        self.XamlSetters.Add(new Setter { Property = RadialGradientBrush.CenterProperty, Value = center });
        return self;
    }
    
    public static SettersContext<T> Center<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : RadialGradientBrush
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, RadialGradientBrush.CenterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Radius<T>(this T self,
        double radius)
        where T : RadialGradientBrush
    {
        self.SetValue(RadialGradientBrush.RadiusProperty, radius);
        return self;
    }
    
    public static T Radius<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : RadialGradientBrush
    {
        var context = new PropertyContext<double>(self, RadialGradientBrush.RadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Radius<T>(this SettersContext<T> self,
        double radius)
        where T : RadialGradientBrush
    {
        self.XamlSetters.Add(new Setter { Property = RadialGradientBrush.RadiusProperty, Value = radius });
        return self;
    }
    
    public static SettersContext<T> Radius<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : RadialGradientBrush
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, RadialGradientBrush.RadiusProperty);
        configure(context).Build();
        return self;
    }
    
}
