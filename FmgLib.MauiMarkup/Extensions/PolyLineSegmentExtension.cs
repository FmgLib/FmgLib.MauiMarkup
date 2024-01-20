namespace FmgLib.MauiMarkup;



public static partial class PolyLineSegmentExtension
{
    public static T PointsFmg<T>(this T self,
        IList<Point> points)
        where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
    {
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }

    public static T PointsFmg<T>(this T self,
        params Point[] points)
        where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
    {
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }
    
    public static T PointsFmg<T>(this T self, Func<PropertyContext<PointCollection>, IPropertyBuilder<PointCollection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.PolyLineSegment
    {
        var context = new PropertyContext<PointCollection>(self, Microsoft.Maui.Controls.Shapes.PolyLineSegment.PointsProperty);
        configure(context).Build();
        return self;
    }
    
}
