namespace FmgLib.MauiMarkup;



public static partial class PolyQuadraticBezierSegmentExtension
{
    public static T PointsFmg<T>(this T self,
        IList<Point> points)
        where T : Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment
    {
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }

    public static T PointsFmg<T>(this T self,
        params Point[] points)
        where T : Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment
    {
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }
    
    public static T PointsFmg<T>(this T self, Func<PropertyContext<PointCollection>, IPropertyBuilder<PointCollection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment
    {
        var context = new PropertyContext<PointCollection>(self, Microsoft.Maui.Controls.Shapes.PolyQuadraticBezierSegment.PointsProperty);
        configure(context).Build();
        return self;
    }
    
}
