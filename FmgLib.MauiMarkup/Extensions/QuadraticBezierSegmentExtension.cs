namespace FmgLib.MauiMarkup;



public static partial class QuadraticBezierSegmentExtension
{
    public static T Point1Fmg<T>(this T self,
        Point point1)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property, point1);
        return self;
    }
    
    public static T Point1Fmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Point1Fmg<T>(this SettersContext<T> self,
        Point point1)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property, Value = point1 });
        return self;
    }
    
    public static SettersContext<T> Point1Fmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point1Property);
        configure(context).Build();
        return self;
    }
    
    public static T Point2Fmg<T>(this T self,
        Point point2)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property, point2);
        return self;
    }
    
    public static T Point2Fmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Point2Fmg<T>(this SettersContext<T> self,
        Point point2)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property, Value = point2 });
        return self;
    }
    
    public static SettersContext<T> Point2Fmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.QuadraticBezierSegment.Point2Property);
        configure(context).Build();
        return self;
    }
    
}
