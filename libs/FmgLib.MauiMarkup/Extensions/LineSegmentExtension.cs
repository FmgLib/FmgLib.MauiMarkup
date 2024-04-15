namespace FmgLib.MauiMarkup;



public static partial class LineSegmentExtension
{
    public static T Point<T>(this T self,
        Point point)
        where T : Microsoft.Maui.Controls.Shapes.LineSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, point);
        return self;
    }
    
    public static T Point<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.LineSegment
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Point<T>(this SettersContext<T> self,
        Point point)
        where T : Microsoft.Maui.Controls.Shapes.LineSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty, Value = point });
        return self;
    }
    
    public static SettersContext<T> Point<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.LineSegment
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.LineSegment.PointProperty);
        configure(context).Build();
        return self;
    }
    
}