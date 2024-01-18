namespace FmgLib.MauiMarkup;

public static class LabelExtension
{
    public static T TextTransformFmg<T>(this T self, TextTransform textTransform) where T : Label
    {
        self.SetValue(Label.TextTransformProperty, textTransform);

        return self;
    }

    public static T TextTransformFmg<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure) where T : Label
    {
        PropertyContext<TextTransform> arg = new PropertyContext<TextTransform>(self, Label.TextTransformProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> TextTransformFmg<T>(this SettersContext<T> self, TextTransform textTransform) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.TextTransformProperty,
            Value = textTransform
        });

        return self;
    }

    public static SettersContext<T> TextTransformFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure) where T : Label
    {
        PropertySettersContext<TextTransform> arg = new PropertySettersContext<TextTransform>(self.XamlSetters, Label.TextTransformProperty);
        configure(arg).Build();

        return self;
    }

    public static T FormattedTextFmg<T>(this T self, FormattedString formattedText) where T : Label
    {
        self.SetValue(Label.FormattedTextProperty, formattedText);

        return self;
    }

    public static T FormattedTextFmg<T>(this T self, Func<PropertyContext<FormattedString>, IPropertyBuilder<FormattedString>> configure) where T : Label
    {
        PropertyContext<FormattedString> arg = new PropertyContext<FormattedString>(self, Label.FormattedTextProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> FormattedTextFmg<T>(this SettersContext<T> self, FormattedString formattedText) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.FormattedTextProperty,
            Value = formattedText
        });

        return self;
    }

    public static SettersContext<T> FormattedTextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FormattedString>, IPropertySettersBuilder<FormattedString>> configure) where T : Label
    {
        PropertySettersContext<FormattedString> arg = new PropertySettersContext<FormattedString>(self.XamlSetters, Label.FormattedTextProperty);
        configure(arg).Build();

        return self;
    }

    public static T HorizontalTextAlignmentFmg<T>(this T self, TextAlignment horizontalTextAlignment) where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, horizontalTextAlignment);

        return self;
    }

    public static T HorizontalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure) where T : Label
    {
        PropertyContext<TextAlignment> arg = new PropertyContext<TextAlignment>(self, Label.HorizontalTextAlignmentProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, TextAlignment horizontalTextAlignment) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.HorizontalTextAlignmentProperty,
            Value = horizontalTextAlignment
        });

        return self;
    }

    public static SettersContext<T> HorizontalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure) where T : Label
    {
        PropertySettersContext<TextAlignment> arg = new PropertySettersContext<TextAlignment>(self.XamlSetters, Label.HorizontalTextAlignmentProperty);
        configure(arg).Build();

        return self;
    }

    public static T LineBreakModeFmg<T>(this T self, LineBreakMode lineBreakMode) where T : Label
    {
        self.SetValue(Label.LineBreakModeProperty, lineBreakMode);

        return self;
    }

    public static T LineBreakModeFmg<T>(this T self, Func<PropertyContext<LineBreakMode>, IPropertyBuilder<LineBreakMode>> configure) where T : Label
    {
        PropertyContext<LineBreakMode> arg = new PropertyContext<LineBreakMode>(self, Label.LineBreakModeProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self, LineBreakMode lineBreakMode) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.LineBreakModeProperty,
            Value = lineBreakMode
        });

        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LineBreakMode>, IPropertySettersBuilder<LineBreakMode>> configure) where T : Label
    {
        PropertySettersContext<LineBreakMode> arg = new PropertySettersContext<LineBreakMode>(self.XamlSetters, Label.LineBreakModeProperty);
        configure(arg).Build();

        return self;
    }

    public static T TextFmg<T>(this T self, string text) where T : Label
    {
        self.SetValue(Label.TextProperty, text);

        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Label
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Label.TextProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.TextProperty,
            Value = text
        });

        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Label
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Label.TextProperty);
        configure(arg).Build();

        return self;
    }

    public static T TextColorFmg<T>(this T self, Color textColor) where T : Label
    {
        self.SetValue(Label.TextColorProperty, textColor);

        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Label
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Label.TextColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Color textColor) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.TextColorProperty,
            Value = textColor
        });

        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Label
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Label.TextColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Task<bool> AnimateTextColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : Label
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.TextColor;

        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.TextColor = actValue;
        }, element: self2, name: "AnimateTextColorTo", length: length, easing: easing);
    }

    public static T CharacterSpacingFmg<T>(this T self, double characterSpacing) where T : Label
    {
        self.SetValue(Label.CharacterSpacingProperty, characterSpacing);

        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Label
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Label.CharacterSpacingProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, double characterSpacing) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.CharacterSpacingProperty,
            Value = characterSpacing
        });

        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Label
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Label.CharacterSpacingProperty);
        configure(arg).Build();

        return self;
    }

    public static Task<bool> AnimateCharacterSpacingToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Label
    {
        T self2 = self;
        double fromValue = self2.CharacterSpacing;

        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.CharacterSpacing = actValue;
        }, element: self2, name: "AnimateCharacterSpacingTo", length: length, easing: easing);
    }

    public static T VerticalTextAlignmentFmg<T>(this T self, TextAlignment verticalTextAlignment) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, verticalTextAlignment);

        return self;
    }

    public static T VerticalTextAlignmentFmg<T>(this T self, Func<PropertyContext<TextAlignment>, IPropertyBuilder<TextAlignment>> configure) where T : Label
    {
        PropertyContext<TextAlignment> arg = new PropertyContext<TextAlignment>(self, Label.VerticalTextAlignmentProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, TextAlignment verticalTextAlignment) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.VerticalTextAlignmentProperty,
            Value = verticalTextAlignment
        });

        return self;
    }

    public static SettersContext<T> VerticalTextAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextAlignment>, IPropertySettersBuilder<TextAlignment>> configure) where T : Label
    {
        PropertySettersContext<TextAlignment> arg = new PropertySettersContext<TextAlignment>(self.XamlSetters, Label.VerticalTextAlignmentProperty);
        configure(arg).Build();

        return self;
    }

    public static T FontAttributesFmg<T>(this T self, FontAttributes fontAttributes) where T : Label
    {
        self.SetValue(Label.FontAttributesProperty, fontAttributes);

        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure) where T : Label
    {
        PropertyContext<FontAttributes> arg = new PropertyContext<FontAttributes>(self, Label.FontAttributesProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, FontAttributes fontAttributes) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.FontAttributesProperty,
            Value = fontAttributes
        });

        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure) where T : Label
    {
        PropertySettersContext<FontAttributes> arg = new PropertySettersContext<FontAttributes>(self.XamlSetters, Label.FontAttributesProperty);
        configure(arg).Build();

        return self;
    }

    public static T TextDecorationsFmg<T>(this T self, TextDecorations textDecorations) where T : Label
    {
        self.SetValue(Label.TextDecorationsProperty, textDecorations);

        return self;
    }

    public static T TextDecorationsFmg<T>(this T self, Func<PropertyContext<TextDecorations>, IPropertyBuilder<TextDecorations>> configure) where T : Label
    {
        PropertyContext<TextDecorations> arg = new PropertyContext<TextDecorations>(self, Label.TextDecorationsProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> TextDecorationsFmg<T>(this SettersContext<T> self, TextDecorations textDecorations) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.TextDecorationsProperty,
            Value = textDecorations
        });

        return self;
    }

    public static SettersContext<T> TextDecorationsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextDecorations>, IPropertySettersBuilder<TextDecorations>> configure) where T : Label
    {
        PropertySettersContext<TextDecorations> arg = new PropertySettersContext<TextDecorations>(self.XamlSetters, Label.TextDecorationsProperty);
        configure(arg).Build();

        return self;
    }

    public static T FontFamilyFmg<T>(this T self, string fontFamily) where T : Label
    {
        self.SetValue(Label.FontFamilyProperty, fontFamily);

        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Label
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Label.FontFamilyProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, string fontFamily) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.FontFamilyProperty,
            Value = fontFamily
        });

        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Label
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Label.FontFamilyProperty);
        configure(arg).Build();

        return self;
    }

    public static T FontSizeFmg<T>(this T self, double fontSize) where T : Label
    {
        self.SetValue(Label.FontSizeProperty, fontSize);

        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Label
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Label.FontSizeProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, double fontSize) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.FontSizeProperty,
            Value = fontSize
        });

        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Label
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Label.FontSizeProperty);
        configure(arg).Build();

        return self;
    }

    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Label
    {
        T self2 = self;
        double fromValue = self2.FontSize;

        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.FontSize = actValue;
        }, element: self2, name: "AnimateFontSizeTo", length: length, easing: easing);
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, bool fontAutoScalingEnabled) where T : Label
    {
        self.SetValue(Label.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);

        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Label
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Label.FontAutoScalingEnabledProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, bool fontAutoScalingEnabled) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.FontAutoScalingEnabledProperty,
            Value = fontAutoScalingEnabled
        });

        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Label
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Label.FontAutoScalingEnabledProperty);
        configure(arg).Build();

        return self;
    }

    public static T LineHeightFmg<T>(this T self, double lineHeight) where T : Label
    {
        self.SetValue(Label.LineHeightProperty, lineHeight);

        return self;
    }

    public static T LineHeightFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Label
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Label.LineHeightProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> LineHeightFmg<T>(this SettersContext<T> self, double lineHeight) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.LineHeightProperty,
            Value = lineHeight
        });

        return self;
    }

    public static SettersContext<T> LineHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Label
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Label.LineHeightProperty);
        configure(arg).Build();

        return self;
    }

    public static Task<bool> AnimateLineHeightToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Label
    {
        T self2 = self;
        double fromValue = self2.LineHeight;

        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.LineHeight = actValue;
        }, element: self2, name: "AnimateLineHeightTo", length: length, easing: easing);
    }

    public static T MaxLinesFmg<T>(this T self, int maxLines) where T : Label
    {
        self.SetValue(Label.MaxLinesProperty, maxLines);

        return self;
    }

    public static T MaxLinesFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : Label
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, Label.MaxLinesProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> MaxLinesFmg<T>(this SettersContext<T> self, int maxLines) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.MaxLinesProperty,
            Value = maxLines
        });

        return self;
    }

    public static SettersContext<T> MaxLinesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : Label
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, Label.MaxLinesProperty);
        configure(arg).Build();

        return self;
    }

    public static T PaddingFmg<T>(this T self, Thickness padding) where T : Label
    {
        self.SetValue(Label.PaddingProperty, padding);

        return self;
    }

    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : Label
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(self, Label.PaddingProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Thickness padding) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.PaddingProperty,
            Value = padding
        });

        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : Label
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(self.XamlSetters, Label.PaddingProperty);
        configure(arg).Build();

        return self;
    }

    public static T TextTypeFmg<T>(this T self, TextType textType) where T : Label
    {
        self.SetValue(Label.TextTypeProperty, textType);

        return self;
    }

    public static T TextTypeFmg<T>(this T self, Func<PropertyContext<TextType>, IPropertyBuilder<TextType>> configure) where T : Label
    {
        PropertyContext<TextType> arg = new PropertyContext<TextType>(self, Label.TextTypeProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> TextTypeFmg<T>(this SettersContext<T> self, TextType textType) where T : Label
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Label.TextTypeProperty,
            Value = textType
        });

        return self;
    }

    public static SettersContext<T> TextTypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextType>, IPropertySettersBuilder<TextType>> configure) where T : Label
    {
        PropertySettersContext<TextType> arg = new PropertySettersContext<TextType>(self.XamlSetters, Label.TextTypeProperty);
        configure(arg).Build();

        return self;
    }

    public static T TextCenterHorizontalFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);

        return self;
    }

    public static T TextCenterVerticalFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);

        return self;
    }

    public static T TextCenterFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Center);
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Center);

        return self;
    }

    public static T TextTopFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);

        return self;
    }

    public static T TextBottomFmg<T>(this T self) where T : Label, ITextAlignment
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.End);

        return self;
    }

    public static T TextTopStartFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);

        return self;
    }

    public static T TextBottomStartFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);

        return self;
    }

    public static T TextTopEndFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.Start);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);

        return self;
    }

    public static T TextBottomEndFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.VerticalTextAlignmentProperty, TextAlignment.End);
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);

        return self;
    }

    public static T TextStartFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.Start);

        return self;
    }

    public static T TextEndFmg<T>(this T self) where T : Label
    {
        self.SetValue(Label.HorizontalTextAlignmentProperty, TextAlignment.End);

        return self;
    }
}
