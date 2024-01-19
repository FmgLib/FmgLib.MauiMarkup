namespace FmgLib.MauiMarkup;



public static partial class LineGeometryExtension
{
    public static T StartPoint<T>(this T self,
        Point startPoint)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.LineGeometry.StartPointProperty, startPoint);
        return self;
    }
    
    public static T StartPoint<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.LineGeometry.StartPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StartPoint<T>(this SettersContext<T> self,
        Point startPoint)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.LineGeometry.StartPointProperty, Value = startPoint });
        return self;
    }
    
    public static SettersContext<T> StartPoint<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.LineGeometry.StartPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static T EndPoint<T>(this T self,
        Point endPoint)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.LineGeometry.EndPointProperty, endPoint);
        return self;
    }
    
    public static T EndPoint<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.LineGeometry.EndPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> EndPoint<T>(this SettersContext<T> self,
        Point endPoint)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.LineGeometry.EndPointProperty, Value = endPoint });
        return self;
    }
    
    public static SettersContext<T> EndPoint<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.LineGeometry
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.LineGeometry.EndPointProperty);
        configure(context).Build();
        return self;
    }
    
}
