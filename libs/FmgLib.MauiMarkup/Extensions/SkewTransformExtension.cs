namespace FmgLib.MauiMarkup;



public static partial class SkewTransformExtension
{
    public static T AngleXFmg<T>(this T self,
        double angleX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty, angleX);
        return self;
    }
    
    public static T AngleXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AngleXFmg<T>(this SettersContext<T> self,
        double angleX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty, Value = angleX });
        return self;
    }
    
    public static SettersContext<T> AngleXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T AngleYFmg<T>(this T self,
        double angleY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty, angleY);
        return self;
    }
    
    public static T AngleYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AngleYFmg<T>(this SettersContext<T> self,
        double angleY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty, Value = angleY });
        return self;
    }
    
    public static SettersContext<T> AngleYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.AngleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterXFmg<T>(this T self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty, centerX);
        return self;
    }
    
    public static T CenterXFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterXFmg<T>(this SettersContext<T> self,
        double centerX)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty, Value = centerX });
        return self;
    }
    
    public static SettersContext<T> CenterXFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CenterYFmg<T>(this T self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty, centerY);
        return self;
    }
    
    public static T CenterYFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CenterYFmg<T>(this SettersContext<T> self,
        double centerY)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty, Value = centerY });
        return self;
    }
    
    public static SettersContext<T> CenterYFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.SkewTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.SkewTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
}
