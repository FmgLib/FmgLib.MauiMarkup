﻿namespace FmgLib.MauiMarkup;


public static partial class ButtonExtension
{
    public static T BorderColor<T>(this T self,
        Microsoft.Maui.Graphics.Color borderColor)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColor<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var borderColor = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Button.BorderColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color borderColor)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.BorderColorProperty, Value = borderColor });
        return self;
    }

    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Button.BorderColorProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateBorderColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Button
    {
        Microsoft.Maui.Graphics.Color fromValue = self.BorderColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.BorderColor = actValue; };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
    }

    public static T BorderWidth<T>(this T self,
        double borderWidth)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.BorderWidthProperty, borderWidth);
        return self;
    }

    public static T BorderWidth<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var borderWidth = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.BorderWidthProperty, borderWidth);
        return self;
    }

    public static T BorderWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Button.BorderWidthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BorderWidth<T>(this SettersContext<T> self,
        double borderWidth)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.BorderWidthProperty, Value = borderWidth });
        return self;
    }

    public static SettersContext<T> BorderWidth<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Button.BorderWidthProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Button
    {
        double fromValue = self.BorderWidth;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.BorderWidth = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
    }

    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacing<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var characterSpacing = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Button.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }

    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Button.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Button
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }

    public static T Command<T>(this T self,
        System.Windows.Input.ICommand command)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.CommandProperty, command);
        return self;
    }

    public static T Command<T>(this T self,
        Func<System.Windows.Input.ICommand> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var command = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.CommandProperty, command);
        return self;
    }

    public static T Command<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, Microsoft.Maui.Controls.Button.CommandProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Command<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand command)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.CommandProperty, Value = command });
        return self;
    }

    public static SettersContext<T> Command<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, Microsoft.Maui.Controls.Button.CommandProperty);
        configure(context).Build();
        return self;
    }

    public static T CommandParameter<T>(this T self,
        object commandParameter)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameter<T>(this T self,
        Func<object> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var commandParameter = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.Button.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self,
        object commandParameter)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.Button.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static T ContentLayout<T>(this T self,
        Microsoft.Maui.Controls.Button.ButtonContentLayout contentLayout)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.ContentLayoutProperty, contentLayout);
        return self;
    }

    public static T ContentLayout<T>(this T self,
        Func<Microsoft.Maui.Controls.Button.ButtonContentLayout> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var contentLayout = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.ContentLayoutProperty, contentLayout);
        return self;
    }

    public static T ContentLayout<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Button.ButtonContentLayout>, IPropertyBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Button.ButtonContentLayout>(self, Microsoft.Maui.Controls.Button.ContentLayoutProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ContentLayout<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Button.ButtonContentLayout contentLayout)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.ContentLayoutProperty, Value = contentLayout });
        return self;
    }

    public static SettersContext<T> ContentLayout<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Button.ButtonContentLayout>, IPropertySettersBuilder<Microsoft.Maui.Controls.Button.ButtonContentLayout>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Button.ButtonContentLayout>(self.XamlSetters, Microsoft.Maui.Controls.Button.ContentLayoutProperty);
        configure(context).Build();
        return self;
    }

    public static T CornerRadius<T>(this T self,
        int cornerRadius)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadius<T>(this T self,
        Func<int> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var cornerRadius = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadius<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<int>(self, Microsoft.Maui.Controls.Button.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self,
        int cornerRadius)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }

    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, Microsoft.Maui.Controls.Button.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAttributes<T>(this T self,
        Microsoft.Maui.Controls.FontAttributes fontAttributes)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributes<T>(this T self,
        Func<Microsoft.Maui.Controls.FontAttributes> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var fontAttributes = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.Button.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.FontAttributes fontAttributes)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.FontAttributesProperty, Value = fontAttributes });
        return self;
    }

    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>, IPropertySettersBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>(self.XamlSetters, Microsoft.Maui.Controls.Button.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabled<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var fontAutoScalingEnabled = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Button.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamily<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var fontFamily = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Button.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Button.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSize<T>(this T self,
        double fontSize)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSize<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var fontSize = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Button.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Button.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Button
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }

    public static T ImageSource<T>(this T self,
        Microsoft.Maui.Controls.ImageSource imageSource)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.ImageSourceProperty, imageSource);
        return self;
    }

    public static T ImageSource<T>(this T self,
        Func<Microsoft.Maui.Controls.ImageSource> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var imageSource = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.ImageSourceProperty, imageSource);
        return self;
    }

    public static T ImageSource<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.Button.ImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ImageSource<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource imageSource)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.ImageSourceProperty, Value = imageSource });
        return self;
    }

    public static SettersContext<T> ImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.Button.ImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T IsPressed<T>(this T self,
        bool isPressed)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.IsPressedProperty, isPressed);
        return self;
    }

    public static T IsPressed<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var isPressed = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.IsPressedProperty, isPressed);
        return self;
    }

    public static T IsPressed<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Button.IsPressedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsPressed<T>(this SettersContext<T> self,
        bool isPressed)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.IsPressedProperty, Value = isPressed });
        return self;
    }

    public static SettersContext<T> IsPressed<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Button.IsPressedProperty);
        configure(context).Build();
        return self;
    }

    public static T LineBreakMode<T>(this T self,
        Microsoft.Maui.LineBreakMode lineBreakMode)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.LineBreakModeProperty, lineBreakMode);
        return self;
    }

    public static T LineBreakMode<T>(this T self,
        Func<Microsoft.Maui.LineBreakMode> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var lineBreakMode = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.LineBreakModeProperty, lineBreakMode);
        return self;
    }

    public static T LineBreakMode<T>(this T self, Func<PropertyContext<Microsoft.Maui.LineBreakMode>, IPropertyBuilder<Microsoft.Maui.LineBreakMode>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.LineBreakMode>(self, Microsoft.Maui.Controls.Button.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> LineBreakMode<T>(this SettersContext<T> self,
        Microsoft.Maui.LineBreakMode lineBreakMode)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.LineBreakModeProperty, Value = lineBreakMode });
        return self;
    }

    public static SettersContext<T> LineBreakMode<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.LineBreakMode>, IPropertySettersBuilder<Microsoft.Maui.LineBreakMode>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.LineBreakMode>(self.XamlSetters, Microsoft.Maui.Controls.Button.LineBreakModeProperty);
        configure(context).Build();
        return self;
    }

    public static T Padding<T>(this T self, double horizontalSize, double verticalSize) where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.PaddingProperty, new Thickness(horizontalSize, verticalSize));
        return self;
    }

    public static T Padding<T>(this T self, double left, double top, double right, double bottom) where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self,
        Microsoft.Maui.Thickness padding)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.PaddingProperty, padding);
        return self;
    }

    public static T Padding<T>(this T self,
        Func<Microsoft.Maui.Thickness> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var padding = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.PaddingProperty, padding);
        return self;
    }

    public static T Padding<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Button.PaddingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self,
        Microsoft.Maui.Thickness padding)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.PaddingProperty, Value = padding });
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Button.PaddingProperty);
        configure(context).Build();
        return self;
    }

    public static T Text<T>(this T self,
        string text)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.TextProperty, text);
        return self;
    }

    public static T Text<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var text = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.TextProperty, text);
        return self;
    }

    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.Button.TextProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.TextProperty, Value = text });
        return self;
    }

    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.Button.TextProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColor<T>(this T self,
        Microsoft.Maui.Graphics.Color textColor)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.TextColorProperty, textColor);
        return self;
    }

    public static T TextColor<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var textColor = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.TextColorProperty, textColor);
        return self;
    }

    public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.Button.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color textColor)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.Button.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Button
    {
        Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }

    public static T TextTransform<T>(this T self,
        Microsoft.Maui.TextTransform textTransform)
        where T : Microsoft.Maui.Controls.Button
    {
        self.SetValue(Microsoft.Maui.Controls.Button.TextTransformProperty, textTransform);
        return self;
    }

    public static T TextTransform<T>(this T self,
        Func<Microsoft.Maui.TextTransform> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var textTransform = configure();
        self.SetValue(Microsoft.Maui.Controls.Button.TextTransformProperty, textTransform);
        return self;
    }

    public static T TextTransform<T>(this T self, Func<PropertyContext<Microsoft.Maui.TextTransform>, IPropertyBuilder<Microsoft.Maui.TextTransform>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertyContext<Microsoft.Maui.TextTransform>(self, Microsoft.Maui.Controls.Button.TextTransformProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
        Microsoft.Maui.TextTransform textTransform)
        where T : Microsoft.Maui.Controls.Button
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Button.TextTransformProperty, Value = textTransform });
        return self;
    }

    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.TextTransform>, IPropertySettersBuilder<Microsoft.Maui.TextTransform>> configure)
        where T : Microsoft.Maui.Controls.Button
    {
        var context = new PropertySettersContext<Microsoft.Maui.TextTransform>(self.XamlSetters, Microsoft.Maui.Controls.Button.TextTransformProperty);
        configure(context).Build();
        return self;
    }

    public static T OnClicked<T>(this T self, System.EventHandler handler)
        where T : Microsoft.Maui.Controls.Button
    {
        self.Clicked += handler;
        return self;
    }

    public static T OnClicked<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Button
    {
        self.Clicked += (o, arg) => action(self);
        return self;
    }

    public static T OnPressed<T>(this T self, System.EventHandler handler)
        where T : Microsoft.Maui.Controls.Button
    {
        self.Pressed += handler;
        return self;
    }

    public static T OnPressed<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Button
    {
        self.Pressed += (o, arg) => action(self);
        return self;
    }

    public static T OnReleased<T>(this T self, System.EventHandler handler)
        where T : Microsoft.Maui.Controls.Button
    {
        self.Released += handler;
        return self;
    }

    public static T OnReleased<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Button
    {
        self.Released += (o, arg) => action(self);
        return self;
    }

}
