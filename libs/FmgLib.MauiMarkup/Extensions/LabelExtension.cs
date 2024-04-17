namespace FmgLib.MauiMarkup;



public static partial class LabelExtension
{
    public static T TextTransform<T>(this T self,
        TextTransform textTransform)
        where T : Label
    {
        self.SetValue(Label.TextTransformProperty, textTransform);
        return self;
    }
    
    public static T TextTransform<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure)
        where T : Label
    {
        var context = new PropertyContext<TextTransform>(self, Label.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
        TextTransform textTransform)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.TextTransformProperty, Value = textTransform });
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<TextTransform>(self.XamlSetters, Label.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FormattedText<T>(this T self,
        FormattedString formattedText)
        where T : Label
    {
        self.SetValue(Label.FormattedTextProperty, formattedText);
        return self;
    }
    
    public static T FormattedText<T>(this T self, Func<PropertyContext<FormattedString>, IPropertyBuilder<FormattedString>> configure)
        where T : Label
    {
        var context = new PropertyContext<FormattedString>(self, Label.FormattedTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FormattedText<T>(this SettersContext<T> self,
        FormattedString formattedText)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.FormattedTextProperty, Value = formattedText });
        return self;
    }
    
    public static SettersContext<T> FormattedText<T>(this SettersContext<T> self, Func<PropertySettersContext<FormattedString>, IPropertySettersBuilder<FormattedString>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<FormattedString>(self.XamlSetters, Label.FormattedTextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HorizontalTextAlignment<T>(this T self,
        TextAlignment horizontalTextAlignment)
        where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, horizontalTextAlignment);
        return self;
    }
    
    public static T HorizontalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Label
    {
        var context = new PropertyContext<TextAlignment>(self, Label.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment horizontalTextAlignment)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.HorizontalTextAlignmentProperty, Value = horizontalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> HorizontalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Label.HorizontalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T LineBreakMode<T>(this T self,
        LineBreakMode lineBreakMode)
        where T : Label
    {
        self.SetValue(Label.LineBreakModeProperty, lineBreakMode);
        return self;
    }
    
    public static T LineBreakMode<T>(this T self, Func<PropertyContext<LineBreakMode>, IPropertyBuilder<LineBreakMode>> configure)
        where T : Label
    {
        var context = new PropertyContext<LineBreakMode>(self, Label.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> LineBreakMode<T>(this SettersContext<T> self,
        LineBreakMode lineBreakMode)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.LineBreakModeProperty, Value = lineBreakMode });
        return self;
    }
    
    public static SettersContext<T> LineBreakMode<T>(this SettersContext<T> self, Func<PropertySettersContext<LineBreakMode>, IPropertySettersBuilder<LineBreakMode>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<LineBreakMode>(self.XamlSetters, Label.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : Label
    {
        self.SetValue(Label.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Label
    {
        var context = new PropertyContext<string>(self, Label.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Label.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : Label
    {
        self.SetValue(Label.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Label
    {
        var context = new PropertyContext<Color>(self, Label.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Label.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Label
    {
        Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : Label
    {
        self.SetValue(Label.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Label
    {
        var context = new PropertyContext<double>(self, Label.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Label.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Label
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T VerticalTextAlignment<T>(this T self,
        TextAlignment verticalTextAlignment)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, verticalTextAlignment);
        return self;
    }
    
    public static T VerticalTextAlignment<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure)
        where T : Label
    {
        var context = new PropertyContext<TextAlignment>(self, Label.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self,
        TextAlignment verticalTextAlignment)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.VerticalTextAlignmentProperty, Value = verticalTextAlignment });
        return self;
    }
    
    public static SettersContext<T> VerticalTextAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<TextAlignment>(self.XamlSetters, Label.VerticalTextAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : Label
    {
        self.SetValue(Label.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : Label
    {
        var context = new PropertyContext<FontAttributes>(self, Label.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, Label.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextDecorations<T>(this T self,
        TextDecorations textDecorations)
        where T : Label
    {
        self.SetValue(Label.TextDecorationsProperty, textDecorations);
        return self;
    }
    
    public static T TextDecorations<T>(this T self, Func<PropertyContext<TextDecorations>, IPropertyBuilder<TextDecorations>> configure)
        where T : Label
    {
        var context = new PropertyContext<TextDecorations>(self, Label.TextDecorationsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextDecorations<T>(this SettersContext<T> self,
        TextDecorations textDecorations)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.TextDecorationsProperty, Value = textDecorations });
        return self;
    }
    
    public static SettersContext<T> TextDecorations<T>(this SettersContext<T> self, Func<PropertySettersContext<TextDecorations>, IPropertySettersBuilder<TextDecorations>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<TextDecorations>(self.XamlSetters, Label.TextDecorationsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : Label
    {
        self.SetValue(Label.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Label
    {
        var context = new PropertyContext<string>(self, Label.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Label.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self, double fontSize) where T : Label
    {
        self.SetValue(Label.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Label
    {
        var context = new PropertyContext<double>(self, Label.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Label.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Label
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Label
    {
        self.SetValue(Label.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Label
    {
        var context = new PropertyContext<bool>(self, Label.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Label.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T LineHeight<T>(this T self,
        double lineHeight)
        where T : Label
    {
        self.SetValue(Label.LineHeightProperty, lineHeight);
        return self;
    }
    
    public static T LineHeight<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Label
    {
        var context = new PropertyContext<double>(self, Label.LineHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> LineHeight<T>(this SettersContext<T> self,
        double lineHeight)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.LineHeightProperty, Value = lineHeight });
        return self;
    }
    
    public static SettersContext<T> LineHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Label.LineHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateLineHeightTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Label
    {
        double fromValue = self.LineHeight;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.LineHeight = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateLineHeightTo", transform, callback, length, easing);
    }
    
    public static T MaxLines<T>(this T self,
        int maxLines)
        where T : Label
    {
        self.SetValue(Label.MaxLinesProperty, maxLines);
        return self;
    }
    
    public static T MaxLines<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Label
    {
        var context = new PropertyContext<int>(self, Label.MaxLinesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaxLines<T>(this SettersContext<T> self,
        int maxLines)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.MaxLinesProperty, Value = maxLines });
        return self;
    }
    
    public static SettersContext<T> MaxLines<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Label.MaxLinesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Padding<T>(this T self,
        Thickness padding)
        where T : Label
    {
        self.SetValue(Label.PaddingProperty, padding);
        return self;
    }
    
    public static T Padding<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : Label
    {
        var context = new PropertyContext<Thickness>(self, Label.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Padding<T>(this SettersContext<T> self,
        Thickness padding)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.PaddingProperty, Value = padding });
        return self;
    }
    
    public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, Label.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextType<T>(this T self,
        TextType textType)
        where T : Label
    {
        self.SetValue(Label.TextTypeProperty, textType);
        return self;
    }
    
    public static T TextType<T>(this T self, Func<PropertyContext<TextType>, IPropertyBuilder<TextType>> configure)
        where T : Label
    {
        var context = new PropertyContext<TextType>(self, Label.TextTypeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextType<T>(this SettersContext<T> self,
        TextType textType)
        where T : Label
    {
        self.XamlSetters.Add(new Setter { Property = Label.TextTypeProperty, Value = textType });
        return self;
    }
    
    public static SettersContext<T> TextType<T>(this SettersContext<T> self, Func<PropertySettersContext<TextType>, IPropertySettersBuilder<TextType>> configure)
        where T : Label
    {
        var context = new PropertySettersContext<TextType>(self.XamlSetters, Label.TextTypeProperty);
        configure(context).Build();
        return self;
    }
    

    public static T TextCenterHorizontal<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenterVertical<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextCenter<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);
        return self;
    }

    public static T TextTop<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottom<T>(this T self)
        where T : Label, Microsoft.Maui.ITextAlignment
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextTopStart<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextBottomStart<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextTopEnd<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextBottomEnd<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    public static T TextStart<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);
        return self;
    }

    public static T TextEnd<T>(this T self)
        where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);
        return self;
    }

    
}