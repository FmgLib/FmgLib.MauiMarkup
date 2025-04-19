namespace FmgLib.MauiMarkup;



public static partial class TimePickerExtension
{
    public static T Format<T>(this T self,
        string format)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FormatProperty, format);
        return self;
    }
    
    public static T Format<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<string>(self, TimePicker.FormatProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Format<T>(this SettersContext<T> self,
        string format)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.FormatProperty, Value = format });
        return self;
    }
    
    public static SettersContext<T> Format<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TimePicker.FormatProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : TimePicker
    {
        self.SetValue(TimePicker.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<Color>(self, TimePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TimePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : TimePicker
    {
        Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : TimePicker
    {
        self.SetValue(TimePicker.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<double>(self, TimePicker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, TimePicker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : TimePicker
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T Time<T>(this T self,
        TimeSpan time)
        where T : TimePicker
    {
        self.SetValue(TimePicker.TimeProperty, time);
        return self;
    }
    
    public static T Time<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<TimeSpan>(self, TimePicker.TimeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Time<T>(this SettersContext<T> self,
        TimeSpan time)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.TimeProperty, Value = time });
        return self;
    }
    
    public static SettersContext<T> Time<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, TimePicker.TimeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<FontAttributes>(self, TimePicker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, TimePicker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<string>(self, TimePicker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TimePicker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self,
        double fontSize)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<double>(self, TimePicker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, TimePicker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : TimePicker
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<bool>(self, TimePicker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TimePicker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
}
