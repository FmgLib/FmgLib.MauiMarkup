﻿namespace FmgLib.MauiMarkup;



public static partial class SkewTransformExtension
{
    public static T AngleX<T>(this T self,
        double angleX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty, angleX);
        return self;
    }
    
    public static T AngleX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AngleX<T>(this SettersContext<T> self,
        double angleX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty, Value = angleX });
        return self;
    }
    
    public static SettersContext<T> AngleX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T AngleY<T>(this T self,
        double angleY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty, angleY);
        return self;
    }
    
    public static T AngleY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AngleY<T>(this SettersContext<T> self,
        double angleY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty, Value = angleY });
        return self;
    }
    
    public static SettersContext<T> AngleY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterX<T>(this T self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty, centerX);
        return self;
    }
    
    public static T CenterX<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterX<T>(this SettersContext<T> self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty, Value = centerX });
        return self;
    }
    
    public static SettersContext<T> CenterX<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterY<T>(this T self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty, centerY);
        return self;
    }
    
    public static T CenterY<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterY<T>(this SettersContext<T> self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty, Value = centerY });
        return self;
    }
    
    public static SettersContext<T> CenterY<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
}
