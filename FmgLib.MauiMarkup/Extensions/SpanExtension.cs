namespace FmgLib.MauiMarkup;



public static partial class SpanExtension
{
    public static T Style<T>(this T self,
        Style style)
        where T : Span
    {
        self.SetValue(Span.StyleProperty, style);
        return self;
    }
    
    public static T Style<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure)
        where T : Span
    {
        var context = new PropertyContext<Style>(self, Span.StyleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Style<T>(this SettersContext<T> self,
        Style style)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.StyleProperty, Value = style });
        return self;
    }
    
    public static SettersContext<T> Style<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<Style>(self.XamlSetters, Span.StyleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BackgroundColor<T>(this T self,
        Color backgroundColor)
        where T : Span
    {
        self.SetValue(Span.BackgroundColorProperty, backgroundColor);
        return self;
    }
    
    public static T BackgroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Span
    {
        var context = new PropertyContext<Color>(self, Span.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BackgroundColor<T>(this SettersContext<T> self,
        Color backgroundColor)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.BackgroundColorProperty, Value = backgroundColor });
        return self;
    }
    
    public static SettersContext<T> BackgroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Span.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : Span
    {
        self.SetValue(Span.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Span
    {
        var context = new PropertyContext<Color>(self, Span.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Span.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : Span
    {
        self.SetValue(Span.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Span
    {
        var context = new PropertyContext<double>(self, Span.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Span.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextTransform<T>(this T self,
        TextTransform textTransform)
        where T : Span
    {
        self.SetValue(Span.TextTransformProperty, textTransform);
        return self;
    }
    
    public static T TextTransform<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure)
        where T : Span
    {
        var context = new PropertyContext<TextTransform>(self, Span.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
        TextTransform textTransform)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.TextTransformProperty, Value = textTransform });
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<TextTransform>(self.XamlSetters, Span.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : Span
    {
        self.SetValue(Span.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Span
    {
        var context = new PropertyContext<string>(self, Span.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Span.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : Span
    {
        self.SetValue(Span.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : Span
    {
        var context = new PropertyContext<FontAttributes>(self, Span.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, Span.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : Span
    {
        self.SetValue(Span.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Span
    {
        var context = new PropertyContext<string>(self, Span.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Span.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self,
        double fontSize)
        where T : Span
    {
        self.SetValue(Span.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Span
    {
        var context = new PropertyContext<double>(self, Span.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Span.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Span
    {
        self.SetValue(Span.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Span
    {
        var context = new PropertyContext<bool>(self, Span.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Span.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextDecorations<T>(this T self,
        TextDecorations textDecorations)
        where T : Span
    {
        self.SetValue(Span.TextDecorationsProperty, textDecorations);
        return self;
    }
    
    public static T TextDecorations<T>(this T self, Func<PropertyContext<TextDecorations>, IPropertyBuilder<TextDecorations>> configure)
        where T : Span
    {
        var context = new PropertyContext<TextDecorations>(self, Span.TextDecorationsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextDecorations<T>(this SettersContext<T> self,
        TextDecorations textDecorations)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.TextDecorationsProperty, Value = textDecorations });
        return self;
    }
    
    public static SettersContext<T> TextDecorations<T>(this SettersContext<T> self, Func<PropertySettersContext<TextDecorations>, IPropertySettersBuilder<TextDecorations>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<TextDecorations>(self.XamlSetters, Span.TextDecorationsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T LineHeight<T>(this T self,
        double lineHeight)
        where T : Span
    {
        self.SetValue(Span.LineHeightProperty, lineHeight);
        return self;
    }
    
    public static T LineHeight<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Span
    {
        var context = new PropertyContext<double>(self, Span.LineHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> LineHeight<T>(this SettersContext<T> self,
        double lineHeight)
        where T : Span
    {
        self.XamlSetters.Add(new Setter { Property = Span.LineHeightProperty, Value = lineHeight });
        return self;
    }
    
    public static SettersContext<T> LineHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Span
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Span.LineHeightProperty);
        configure(context).Build();
        return self;
    }
    
}
