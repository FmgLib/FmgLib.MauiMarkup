namespace FmgLib.MauiMarkup;


public static partial class CompositeTransformExtension
{
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform CenterXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double centerX)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterXProperty, centerX);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform CenterXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> CenterXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double centerX)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterXProperty, Value = centerX });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> CenterXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform CenterYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double centerY)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterYProperty, centerY);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform CenterYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> CenterYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double centerY)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterYProperty, Value = centerY });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> CenterYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.CenterYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform ScaleXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double scaleX)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleXProperty, scaleX);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform ScaleXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> ScaleXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double scaleX)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleXProperty, Value = scaleX });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> ScaleXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform ScaleYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double scaleY)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleYProperty, scaleY);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform ScaleYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> ScaleYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double scaleY)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleYProperty, Value = scaleY });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> ScaleYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.ScaleYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform SkewXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double skewX)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewXProperty, skewX);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform SkewXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> SkewXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double skewX)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewXProperty, Value = skewX });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> SkewXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform SkewYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double skewY)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewYProperty, skewY);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform SkewYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> SkewYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double skewY)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewYProperty, Value = skewY });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> SkewYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.SkewYProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform RotationFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double rotation)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.RotationProperty, rotation);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform RotationFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.RotationProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> RotationFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double rotation)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.RotationProperty, Value = rotation });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> RotationFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.RotationProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform TranslateXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double translateX)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateXProperty, translateX);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform TranslateXFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateXProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> TranslateXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double translateX)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateXProperty, Value = translateX });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> TranslateXFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateXProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform TranslateYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self,
        double translateY)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateYProperty, translateY);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.CompositeTransform TranslateYFmg(this Microsoft.Maui.Controls.Shapes.CompositeTransform self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateYProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> TranslateYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self,
        double translateY)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateYProperty, Value = translateY });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> TranslateYFmg(this SettersContext<Microsoft.Maui.Controls.Shapes.CompositeTransform> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.CompositeTransform.TranslateYProperty);
        configure(context).Build();
        return self;
    }
    
}