namespace FmgLib.MauiMarkup;


public static partial class ArcSegmentExtension
{
    public static T Point<T>(this T self,
        Point point)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, point);
        return self;
    }
    
    public static T Point<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Point<T>(this SettersContext<T> self,
        Point point)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, Value = point });
        return self;
    }
    
    public static SettersContext<T> Point<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Size<T>(this T self,
        Size size)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, size);
        return self;
    }
    
    public static T Size<T>(this T self, Func<PropertyContext<Size>, IPropertyBuilder<Size>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<Size>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Size<T>(this SettersContext<T> self,
        Size size)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, Value = size });
        return self;
    }
    
    public static SettersContext<T> Size<T>(this SettersContext<T> self, Func<PropertySettersContext<Size>, IPropertySettersBuilder<Size>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<Size>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RotationAngle<T>(this T self,
        double rotationAngle)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, rotationAngle);
        return self;
    }
    
    public static T RotationAngle<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RotationAngle<T>(this SettersContext<T> self,
        double rotationAngle)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, Value = rotationAngle });
        return self;
    }
    
    public static SettersContext<T> RotationAngle<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SweepDirection<T>(this T self,
        SweepDirection sweepDirection)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, sweepDirection);
        return self;
    }
    
    public static T SweepDirection<T>(this T self, Func<PropertyContext<SweepDirection>, IPropertyBuilder<SweepDirection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<SweepDirection>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SweepDirection<T>(this SettersContext<T> self,
        SweepDirection sweepDirection)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, Value = sweepDirection });
        return self;
    }
    
    public static SettersContext<T> SweepDirection<T>(this SettersContext<T> self, Func<PropertySettersContext<SweepDirection>, IPropertySettersBuilder<SweepDirection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<SweepDirection>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsLargeArc<T>(this T self,
        bool isLargeArc)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, isLargeArc);
        return self;
    }
    
    public static T IsLargeArc<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsLargeArc<T>(this SettersContext<T> self,
        bool isLargeArc)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, Value = isLargeArc });
        return self;
    }
    
    public static SettersContext<T> IsLargeArc<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty);
        configure(context).Build();
        return self;
    }
    
}