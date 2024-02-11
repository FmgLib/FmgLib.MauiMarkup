namespace FmgLib.MauiMarkup;



public static partial class LinearGradientBrushExtension
{
    public static T StartPointFmg<T>(this T self,
        Point startPoint)
        where T : LinearGradientBrush
    {
        self.SetValue(LinearGradientBrush.StartPointProperty, startPoint);
        return self;
    }
    
    public static T StartPointFmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : LinearGradientBrush
    {
        var context = new PropertyContext<Point>(self, LinearGradientBrush.StartPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StartPointFmg<T>(this SettersContext<T> self,
        Point startPoint)
        where T : LinearGradientBrush
    {
        self.XamlSetters.Add(new Setter { Property = LinearGradientBrush.StartPointProperty, Value = startPoint });
        return self;
    }
    
    public static SettersContext<T> StartPointFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : LinearGradientBrush
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, LinearGradientBrush.StartPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static T EndPointFmg<T>(this T self,
        Point endPoint)
        where T : LinearGradientBrush
    {
        self.SetValue(LinearGradientBrush.EndPointProperty, endPoint);
        return self;
    }
    
    public static T EndPointFmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : LinearGradientBrush
    {
        var context = new PropertyContext<Point>(self, LinearGradientBrush.EndPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> EndPointFmg<T>(this SettersContext<T> self,
        Point endPoint)
        where T : LinearGradientBrush
    {
        self.XamlSetters.Add(new Setter { Property = LinearGradientBrush.EndPointProperty, Value = endPoint });
        return self;
    }
    
    public static SettersContext<T> EndPointFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : LinearGradientBrush
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, LinearGradientBrush.EndPointProperty);
        configure(context).Build();
        return self;
    }
    
}
