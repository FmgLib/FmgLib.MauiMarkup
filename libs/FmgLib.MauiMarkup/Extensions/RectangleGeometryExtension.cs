﻿namespace FmgLib.MauiMarkup;



public static partial class RectangleGeometryExtension
{
    public static T RectFmg<T>(this T self,
        Rect rect)
        where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty, rect);
        return self;
    }
    
    public static T RectFmg<T>(this T self, Func<PropertyContext<Rect>, IPropertyBuilder<Rect>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
    {
        var context = new PropertyContext<Rect>(self, Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RectFmg<T>(this SettersContext<T> self,
        Rect rect)
        where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty, Value = rect });
        return self;
    }
    
    public static SettersContext<T> RectFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Rect>, IPropertySettersBuilder<Rect>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RectangleGeometry
    {
        var context = new PropertySettersContext<Rect>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RectangleGeometry.RectProperty);
        configure(context).Build();
        return self;
    }
    
}