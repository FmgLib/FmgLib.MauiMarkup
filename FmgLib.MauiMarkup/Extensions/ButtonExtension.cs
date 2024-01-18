using System.Windows.Input;

namespace FmgLib.MauiMarkup;

public static class ButtonExtension
{
    public static T PaddingFmg<T>(this T self, Thickness padding) where T : Button
    {
        self.SetValue(Button.PaddingProperty, padding);
        return self;
    }

    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : Button
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(self, Button.PaddingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Thickness padding) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.PaddingProperty,
            Value = padding
        });
        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : Button
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(self.XamlSetters, Button.PaddingProperty);
        configure(arg).Build();
        return self;
    }

    public static T LineBreakModeFmg<T>(this T self, LineBreakMode lineBreakMode) where T : Button
    {
        self.SetValue(Button.LineBreakModeProperty, lineBreakMode);
        return self;
    }

    public static T LineBreakModeFmg<T>(this T self, Func<PropertyContext<LineBreakMode>, IPropertyBuilder<LineBreakMode>> configure) where T : Button
    {
        PropertyContext<LineBreakMode> arg = new PropertyContext<LineBreakMode>(self, Button.LineBreakModeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self, LineBreakMode lineBreakMode) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.LineBreakModeProperty,
            Value = lineBreakMode
        });
        return self;
    }

    public static SettersContext<T> LineBreakModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LineBreakMode>, IPropertySettersBuilder<LineBreakMode>> configure) where T : Button
    {
        PropertySettersContext<LineBreakMode> arg = new PropertySettersContext<LineBreakMode>(self.XamlSetters, Button.LineBreakModeProperty);
        configure(arg).Build();
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Color borderColor) where T : Button
    {
        self.SetValue(Button.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Button
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Button.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Color borderColor) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.BorderColorProperty,
            Value = borderColor
        });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Button
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Button.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateBorderColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : Button
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.BorderColor;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.BorderColor = actValue;
        }, element: self2, name: "AnimateBorderColorTo", length: length, easing: easing);
    }

    public static T CornerRadiusFmg<T>(this T self, int cornerRadius) where T : Button
    {
        self.SetValue(Button.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : Button
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, Button.CornerRadiusProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, int cornerRadius) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.CornerRadiusProperty,
            Value = cornerRadius
        });
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : Button
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, Button.CornerRadiusProperty);
        configure(arg).Build();
        return self;
    }

    public static T BorderWidthFmg<T>(this T self, double borderWidth) where T : Button
    {
        self.SetValue(Button.BorderWidthProperty, borderWidth);
        return self;
    }

    public static T BorderWidthFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Button
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Button.BorderWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderWidthFmg<T>(this SettersContext<T> self, double borderWidth) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.BorderWidthProperty,
            Value = borderWidth
        });
        return self;
    }

    public static SettersContext<T> BorderWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Button
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Button.BorderWidthProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateBorderWidthToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Button
    {
        T self2 = self;
        double fromValue = self2.BorderWidth;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.BorderWidth = actValue;
        }, element: self2, name: "AnimateBorderWidthTo", length: length, easing: easing);
    }

    public static T ContentLayoutFmg<T>(this T self, Button.ButtonContentLayout contentLayout) where T : Button
    {
        self.SetValue(Button.ContentLayoutProperty, contentLayout);
        return self;
    }

    public static T ContentLayoutFmg<T>(this T self, Func<PropertyContext<Button.ButtonContentLayout>, IPropertyBuilder<Button.ButtonContentLayout>> configure) where T : Button
    {
        PropertyContext<Button.ButtonContentLayout> arg = new PropertyContext<Button.ButtonContentLayout>(self, Button.ContentLayoutProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ContentLayoutFmg<T>(this SettersContext<T> self, Button.ButtonContentLayout contentLayout) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.ContentLayoutProperty,
            Value = contentLayout
        });
        return self;
    }

    public static SettersContext<T> ContentLayoutFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Button.ButtonContentLayout>, IPropertySettersBuilder<Button.ButtonContentLayout>> configure) where T : Button
    {
        PropertySettersContext<Button.ButtonContentLayout> arg = new PropertySettersContext<Button.ButtonContentLayout>(self.XamlSetters, Button.ContentLayoutProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandFmg<T>(this T self, ICommand command) where T : Button
    {
        self.SetValue(Button.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : Button
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, Button.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : Button
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, Button.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, object commandParameter) where T : Button
    {
        self.SetValue(Button.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : Button
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, Button.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, object commandParameter) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.CommandParameterProperty,
            Value = commandParameter
        });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : Button
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, Button.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T ImageSourceFmg<T>(this T self, ImageSource imageSource) where T : Button
    {
        self.SetValue(Button.ImageSourceProperty, imageSource);
        return self;
    }

    public static T ImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : Button
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(self, Button.ImageSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ImageSourceFmg<T>(this SettersContext<T> self, ImageSource imageSource) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.ImageSourceProperty,
            Value = imageSource
        });
        return self;
    }

    public static SettersContext<T> ImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : Button
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(self.XamlSetters, Button.ImageSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextFmg<T>(this T self, string text) where T : Button
    {
        self.SetValue(Button.TextProperty, text);
        return self;
    }

    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Button
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Button.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, string text) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.TextProperty,
            Value = text
        });
        return self;
    }

    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Button
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Button.TextProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self, Color textColor) where T : Button
    {
        self.SetValue(Button.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Button
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Button.TextColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Color textColor) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.TextColorProperty,
            Value = textColor
        });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Button
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Button.TextColorProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateTextColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : Button
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.TextColor;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.TextColor = actValue;
        }, element: self2, name: "AnimateTextColorTo", length: length, easing: easing);
    }

    public static T CharacterSpacingFmg<T>(this T self, double characterSpacing) where T : Button
    {
        self.SetValue(Button.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Button
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Button.CharacterSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, double characterSpacing) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.CharacterSpacingProperty,
            Value = characterSpacing
        });
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Button
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Button.CharacterSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateCharacterSpacingToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Button
    {
        T self2 = self;
        double fromValue = self2.CharacterSpacing;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.CharacterSpacing = actValue;
        }, element: self2, name: "AnimateCharacterSpacingTo", length: length, easing: easing);
    }

    public static T FontAttributesFmg<T>(this T self, FontAttributes fontAttributes) where T : Button
    {
        self.SetValue(Button.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure) where T : Button
    {
        PropertyContext<FontAttributes> arg = new PropertyContext<FontAttributes>(self, Button.FontAttributesProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, FontAttributes fontAttributes) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.FontAttributesProperty,
            Value = fontAttributes
        });
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure) where T : Button
    {
        PropertySettersContext<FontAttributes> arg = new PropertySettersContext<FontAttributes>(self.XamlSetters, Button.FontAttributesProperty);
        configure(arg).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, string fontFamily) where T : Button
    {
        self.SetValue(Button.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Button
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Button.FontFamilyProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, string fontFamily) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.FontFamilyProperty,
            Value = fontFamily
        });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Button
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Button.FontFamilyProperty);
        configure(arg).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self, double fontSize) where T : Button
    {
        self.SetValue(Button.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Button
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Button.FontSizeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, double fontSize) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.FontSizeProperty,
            Value = fontSize
        });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Button
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Button.FontSizeProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Button
    {
        T self2 = self;
        double fromValue = self2.FontSize;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.FontSize = actValue;
        }, element: self2, name: "AnimateFontSizeTo", length: length, easing: easing);
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, bool fontAutoScalingEnabled) where T : Button
    {
        self.SetValue(Button.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Button
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Button.FontAutoScalingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, bool fontAutoScalingEnabled) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.FontAutoScalingEnabledProperty,
            Value = fontAutoScalingEnabled
        });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Button
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Button.FontAutoScalingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextTransformFmg<T>(this T self, TextTransform textTransform) where T : Button
    {
        self.SetValue(Button.TextTransformProperty, textTransform);
        return self;
    }

    public static T TextTransformFmg<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure) where T : Button
    {
        PropertyContext<TextTransform> arg = new PropertyContext<TextTransform>(self, Button.TextTransformProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TextTransformFmg<T>(this SettersContext<T> self, TextTransform textTransform) where T : Button
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Button.TextTransformProperty,
            Value = textTransform
        });
        return self;
    }

    public static SettersContext<T> TextTransformFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure) where T : Button
    {
        PropertySettersContext<TextTransform> arg = new PropertySettersContext<TextTransform>(self.XamlSetters, Button.TextTransformProperty);
        configure(arg).Build();
        return self;
    }

    public static T OnClickedFmg<T>(this T self, EventHandler handler) where T : Button
    {
        self.Clicked += handler;
        return self;
    }

    public static T OnClickedFmg<T>(this T self, Action<T> action) where T : Button
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Clicked += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnPressedFmg<T>(this T self, EventHandler handler) where T : Button
    {
        self.Pressed += handler;
        return self;
    }

    public static T OnPressedFmg<T>(this T self, Action<T> action) where T : Button
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Pressed += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnReleasedFmg<T>(this T self, EventHandler handler) where T : Button
    {
        self.Released += handler;
        return self;
    }

    public static T OnReleasedFmg<T>(this T self, Action<T> action) where T : Button
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Released += delegate
        {
            action2(self2);
        };
        return self2;
    }
}
