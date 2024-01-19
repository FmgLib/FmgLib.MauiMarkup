namespace FmgLib.MauiMarkup;



public static partial class RadioButtonExtension
{
    public static T Content<T>(this T self,
        object content)
        where T : RadioButton
    {
        self.SetValue(RadioButton.ContentProperty, content);
        return self;
    }
    
    public static T Content<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<object>(self, RadioButton.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        object content)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.ContentProperty, Value = content });
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RadioButton.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Value<T>(this T self,
        object value)
        where T : RadioButton
    {
        self.SetValue(RadioButton.ValueProperty, value);
        return self;
    }
    
    public static T Value<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<object>(self, RadioButton.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Value<T>(this SettersContext<T> self,
        object value)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.ValueProperty, Value = value });
        return self;
    }
    
    public static SettersContext<T> Value<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RadioButton.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsChecked<T>(this T self,
        bool isChecked)
        where T : RadioButton
    {
        self.SetValue(RadioButton.IsCheckedProperty, isChecked);
        return self;
    }
    
    public static T IsChecked<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<bool>(self, RadioButton.IsCheckedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsChecked<T>(this SettersContext<T> self,
        bool isChecked)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.IsCheckedProperty, Value = isChecked });
        return self;
    }
    
    public static SettersContext<T> IsChecked<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RadioButton.IsCheckedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T GroupName<T>(this T self,
        string groupName)
        where T : RadioButton
    {
        self.SetValue(RadioButton.GroupNameProperty, groupName);
        return self;
    }
    
    public static T GroupName<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<string>(self, RadioButton.GroupNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> GroupName<T>(this SettersContext<T> self,
        string groupName)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.GroupNameProperty, Value = groupName });
        return self;
    }
    
    public static SettersContext<T> GroupName<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, RadioButton.GroupNameProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : RadioButton
    {
        self.SetValue(RadioButton.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<Color>(self, RadioButton.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RadioButton.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : RadioButton
    {
        Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : RadioButton
    {
        self.SetValue(RadioButton.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<double>(self, RadioButton.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, RadioButton.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : RadioButton
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T TextTransform<T>(this T self,
        TextTransform textTransform)
        where T : RadioButton
    {
        self.SetValue(RadioButton.TextTransformProperty, textTransform);
        return self;
    }
    
    public static T TextTransform<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<TextTransform>(self, RadioButton.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
        TextTransform textTransform)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.TextTransformProperty, Value = textTransform });
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<TextTransform>(self.XamlSetters, RadioButton.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : RadioButton
    {
        self.SetValue(RadioButton.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<FontAttributes>(self, RadioButton.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, RadioButton.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : RadioButton
    {
        self.SetValue(RadioButton.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<string>(self, RadioButton.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, RadioButton.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self,
        double fontSize)
        where T : RadioButton
    {
        self.SetValue(RadioButton.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<double>(self, RadioButton.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, RadioButton.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : RadioButton
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : RadioButton
    {
        self.SetValue(RadioButton.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<bool>(self, RadioButton.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, RadioButton.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BorderWidth<T>(this T self,
        double borderWidth)
        where T : RadioButton
    {
        self.SetValue(RadioButton.BorderWidthProperty, borderWidth);
        return self;
    }
    
    public static T BorderWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<double>(self, RadioButton.BorderWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BorderWidth<T>(this SettersContext<T> self,
        double borderWidth)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.BorderWidthProperty, Value = borderWidth });
        return self;
    }
    
    public static SettersContext<T> BorderWidth<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, RadioButton.BorderWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBorderWidthTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : RadioButton
    {
        double fromValue = self.BorderWidth;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.BorderWidth = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateBorderWidthTo", transform, callback, length, easing);
    }
    
    public static T BorderColor<T>(this T self,
        Color borderColor)
        where T : RadioButton
    {
        self.SetValue(RadioButton.BorderColorProperty, borderColor);
        return self;
    }
    
    public static T BorderColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<Color>(self, RadioButton.BorderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self,
        Color borderColor)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.BorderColorProperty, Value = borderColor });
        return self;
    }
    
    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, RadioButton.BorderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBorderColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : RadioButton
    {
        Color fromValue = self.BorderColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BorderColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
    }
    
    public static T CornerRadius<T>(this T self,
        int cornerRadius)
        where T : RadioButton
    {
        self.SetValue(RadioButton.CornerRadiusProperty, cornerRadius);
        return self;
    }
    
    public static T CornerRadius<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : RadioButton
    {
        var context = new PropertyContext<int>(self, RadioButton.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self,
        int cornerRadius)
        where T : RadioButton
    {
        self.XamlSetters.Add(new Setter { Property = RadioButton.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }
    
    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : RadioButton
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, RadioButton.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnCheckedChanged<T>(this T self, EventHandler<CheckedChangedEventArgs> handler)
        where T : RadioButton
    {
        self.CheckedChanged += handler;
        return self;
    }
    
    public static T OnCheckedChanged<T>(this T self, Action<T> action)
        where T : RadioButton
    {
        self.CheckedChanged += (o, arg) => action(self);
        return self;
    }
    
}
