﻿namespace FmgLib.MauiMarkup;



public static partial class RoundRectangleGeometryExtension
{
    public static T RectFmg<T>(this T self,
        Rect rect)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty, rect);
        return self;
    }
    
    public static T RectFmg<T>(this T self, Func<PropertyContext<Rect>, IPropertyBuilder<Rect>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        var context = new PropertyContext<Rect>(self, Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RectFmg<T>(this SettersContext<T> self,
        Rect rect)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty, Value = rect });
        return self;
    }
    
    public static SettersContext<T> RectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Rect>, IPropertySettersBuilder<Rect>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        var context = new PropertySettersContext<Rect>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty);
        configure(context).Build();
        return self;
    }

    public static T RectFmg<T>(this T self, double x, double y, double width, double height)
            where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.RectProperty, new Rect(x, y, width, height));
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self,
        CornerRadius cornerRadius)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, cornerRadius);
        return self;
    }
    
    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<CornerRadius>, IPropertyBuilder<CornerRadius>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        var context = new PropertyContext<CornerRadius>(self, Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self,
        CornerRadius cornerRadius)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }
    
    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<CornerRadius>, IPropertySettersBuilder<CornerRadius>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry
    {
        var context = new PropertySettersContext<CornerRadius>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RoundRectangleGeometry.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
}
