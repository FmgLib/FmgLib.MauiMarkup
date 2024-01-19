namespace FmgLib.MauiMarkup;

public static partial class EllipseGeometryExtension
{
    public static T CenterFmg<T>(this T self,
        Point center)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty, center);
        return self;
    }
    
    public static T CenterFmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterFmg<T>(this SettersContext<T> self,
        Point center)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty, Value = center });
        return self;
    }
    
    public static SettersContext<T> CenterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.EllipseGeometry.CenterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RadiusXFmg<T>(this T self,
        double radiusX)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, radiusX);
        return self;
    }
    
    public static T RadiusXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RadiusXFmg<T>(this SettersContext<T> self,
        double radiusX)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty, Value = radiusX });
        return self;
    }
    
    public static SettersContext<T> RadiusXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RadiusYFmg<T>(this T self,
        double radiusY)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, radiusY);
        return self;
    }
    
    public static T RadiusYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RadiusYFmg<T>(this SettersContext<T> self,
        double radiusY)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty, Value = radiusY });
        return self;
    }
    
    public static SettersContext<T> RadiusYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.EllipseGeometry
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.EllipseGeometry.RadiusYProperty);
        configure(context).Build();
        return self;
    }
    
}