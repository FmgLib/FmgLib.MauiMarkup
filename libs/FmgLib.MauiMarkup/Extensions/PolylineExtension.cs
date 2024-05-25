namespace FmgLib.MauiMarkup;



public static partial class PolylineExtension
{
    public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self,
        IList<Point> points)
    {
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self,
        params Point[] points)
    {
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self,
        Func<Point[]> configure)
    {
        var points = configure();
        foreach (var item in points)
            self.Points.Add(item);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Polyline Points(this Microsoft.Maui.Controls.Shapes.Polyline self, Func<PropertyContext<PointCollection>, IPropertyBuilder<PointCollection>> configure)
    {
        var context = new PropertyContext<PointCollection>(self, Microsoft.Maui.Controls.Shapes.Polyline.PointsProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Polyline FillRule(this Microsoft.Maui.Controls.Shapes.Polyline self,
        Microsoft.Maui.Controls.Shapes.FillRule fillRule)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty, fillRule);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Polyline FillRule(this Microsoft.Maui.Controls.Shapes.Polyline self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>(self, Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Polyline> FillRule(this SettersContext<Microsoft.Maui.Controls.Shapes.Polyline> self,
        Microsoft.Maui.Controls.Shapes.FillRule fillRule)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty, Value = fillRule });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Polyline> FillRule(this SettersContext<Microsoft.Maui.Controls.Shapes.Polyline> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.FillRule>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Polyline.FillRuleProperty);
        configure(context).Build();
        return self;
    }
    
}
