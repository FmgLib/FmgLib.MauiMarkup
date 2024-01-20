namespace FmgLib.MauiMarkup;

public static partial class FontImageSourceExtension
{
    public static T ColorFmg<T>(this T self,
        Color color)
        where T : FontImageSource
    {
        self.SetValue(FontImageSource.ColorProperty, color);
        return self;
    }
    
    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : FontImageSource
    {
        var context = new PropertyContext<Color>(self, FontImageSource.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : FontImageSource
    {
        self.XamlSetters.Add(new Setter { Property = FontImageSource.ColorProperty, Value = color });
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : FontImageSource
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, FontImageSource.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : FontImageSource
    {
        self.SetValue(FontImageSource.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : FontImageSource
    {
        var context = new PropertyContext<string>(self, FontImageSource.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : FontImageSource
    {
        self.XamlSetters.Add(new Setter { Property = FontImageSource.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : FontImageSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, FontImageSource.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T GlyphFmg<T>(this T self,
        string glyph)
        where T : FontImageSource
    {
        self.SetValue(FontImageSource.GlyphProperty, glyph);
        return self;
    }
    
    public static T GlyphFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : FontImageSource
    {
        var context = new PropertyContext<string>(self, FontImageSource.GlyphProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> GlyphFmg<T>(this SettersContext<T> self,
        string glyph)
        where T : FontImageSource
    {
        self.XamlSetters.Add(new Setter { Property = FontImageSource.GlyphProperty, Value = glyph });
        return self;
    }
    
    public static SettersContext<T> GlyphFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : FontImageSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, FontImageSource.GlyphProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SizeFmg<T>(this T self,
        double size)
        where T : FontImageSource
    {
        self.SetValue(FontImageSource.SizeProperty, size);
        return self;
    }
    
    public static T SizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : FontImageSource
    {
        var context = new PropertyContext<double>(self, FontImageSource.SizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SizeFmg<T>(this SettersContext<T> self,
        double size)
        where T : FontImageSource
    {
        self.XamlSetters.Add(new Setter { Property = FontImageSource.SizeProperty, Value = size });
        return self;
    }
    
    public static SettersContext<T> SizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : FontImageSource
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, FontImageSource.SizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : FontImageSource
    {
        self.SetValue(FontImageSource.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : FontImageSource
    {
        var context = new PropertyContext<bool>(self, FontImageSource.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : FontImageSource
    {
        self.XamlSetters.Add(new Setter { Property = FontImageSource.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : FontImageSource
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, FontImageSource.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
}