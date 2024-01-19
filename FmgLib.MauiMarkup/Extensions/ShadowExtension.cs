namespace FmgLib.MauiMarkup;



public static partial class ShadowExtension
{
    public static T RadiusFmg<T>(this T self,
        float radius)
        where T : Shadow
    {
        self.SetValue(Shadow.RadiusProperty, radius);
        return self;
    }
    
    public static T RadiusFmg<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure)
        where T : Shadow
    {
        var context = new PropertyContext<float>(self, Shadow.RadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RadiusFmg<T>(this SettersContext<T> self,
        float radius)
        where T : Shadow
    {
        self.XamlSetters.Add(new Setter { Property = Shadow.RadiusProperty, Value = radius });
        return self;
    }
    
    public static SettersContext<T> RadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure)
        where T : Shadow
    {
        var context = new PropertySettersContext<float>(self.XamlSetters, Shadow.RadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OpacityFmg<T>(this T self,
        float opacity)
        where T : Shadow
    {
        self.SetValue(Shadow.OpacityProperty, opacity);
        return self;
    }
    
    public static T OpacityFmg<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure)
        where T : Shadow
    {
        var context = new PropertyContext<float>(self, Shadow.OpacityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OpacityFmg<T>(this SettersContext<T> self,
        float opacity)
        where T : Shadow
    {
        self.XamlSetters.Add(new Setter { Property = Shadow.OpacityProperty, Value = opacity });
        return self;
    }
    
    public static SettersContext<T> OpacityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure)
        where T : Shadow
    {
        var context = new PropertySettersContext<float>(self.XamlSetters, Shadow.OpacityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BrushFmg<T>(this T self,
        Brush brush)
        where T : Shadow
    {
        self.SetValue(Shadow.BrushProperty, brush);
        return self;
    }
    
    public static T BrushFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : Shadow
    {
        var context = new PropertyContext<Brush>(self, Shadow.BrushProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BrushFmg<T>(this SettersContext<T> self,
        Brush brush)
        where T : Shadow
    {
        self.XamlSetters.Add(new Setter { Property = Shadow.BrushProperty, Value = brush });
        return self;
    }
    
    public static SettersContext<T> BrushFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : Shadow
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, Shadow.BrushProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OffsetFmg<T>(this T self,
        Point offset)
        where T : Shadow
    {
        self.SetValue(Shadow.OffsetProperty, offset);
        return self;
    }
    
    public static T OffsetFmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : Shadow
    {
        var context = new PropertyContext<Point>(self, Shadow.OffsetProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OffsetFmg<T>(this SettersContext<T> self,
        Point offset)
        where T : Shadow
    {
        self.XamlSetters.Add(new Setter { Property = Shadow.OffsetProperty, Value = offset });
        return self;
    }
    
    public static SettersContext<T> OffsetFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : Shadow
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Shadow.OffsetProperty);
        configure(context).Build();
        return self;
    }
    
}
