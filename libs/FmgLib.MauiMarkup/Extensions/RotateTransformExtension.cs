﻿namespace FmgLib.MauiMarkup;



public static partial class RotateTransformExtension
{
    public static T Angle<T>(this T self,
        double angle)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty, angle);
        return self;
    }
    
    public static T Angle<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Angle<T>(this SettersContext<T> self,
        double angle)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty, Value = angle });
        return self;
    }
    
    public static SettersContext<T> Angle<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RotateTransform.AngleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterX<T>(this T self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty, centerX);
        return self;
    }
    
    public static T CenterX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterX<T>(this SettersContext<T> self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty, Value = centerX });
        return self;
    }
    
    public static SettersContext<T> CenterX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RotateTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterY<T>(this T self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty, centerY);
        return self;
    }
    
    public static T CenterY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterY<T>(this SettersContext<T> self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty, Value = centerY });
        return self;
    }
    
    public static SettersContext<T> CenterY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.RotateTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RotateTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
}
