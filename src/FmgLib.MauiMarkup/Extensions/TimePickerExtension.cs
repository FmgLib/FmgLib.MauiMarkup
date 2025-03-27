namespace FmgLib.MauiMarkup;



public static partial class TimePickerExtension
{
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : TimePicker
    {
        self.SetValue(TimePicker.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacing<T>(this T self,
        Func<double> configure)
        where T : TimePicker
    {
        var characterSpacing = configure();
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
        var callback = (double actValue) => { self.SetValue(TimePicker.CharacterSpacingProperty, actValue); };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T FontAttributes<T>(this T self,
        FontAttributes fontAttributes)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributes<T>(this T self,
        Func<FontAttributes> configure)
        where T : TimePicker
    {
        var fontAttributes = configure();
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
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabled<T>(this T self,
        Func<bool> configure)
        where T : TimePicker
    {
        var fontAutoScalingEnabled = configure();
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
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamily<T>(this T self,
        Func<string> configure)
        where T : TimePicker
    {
        var fontFamily = configure();
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

    public static T FontSize<T>(this T self,
        Func<double> configure)
        where T : TimePicker
    {
        var fontSize = configure();
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
        var callback = (double actValue) => { self.SetValue(TimePicker.FontSizeProperty, actValue); };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T Format<T>(this T self,
        string format)
        where T : TimePicker
    {
        self.SetValue(TimePicker.FormatProperty, format);
        return self;
    }

    public static T Format<T>(this T self,
        Func<string> configure)
        where T : TimePicker
    {
        var format = configure();
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
        Microsoft.Maui.Graphics.Color textColor)
        where T : TimePicker
    {
        self.SetValue(TimePicker.TextColorProperty, textColor);
        return self;
    }

    public static T TextColor<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : TimePicker
    {
        var textColor = configure();
        self.SetValue(TimePicker.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, TimePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color textColor)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, TimePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : TimePicker
    {
        Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SetValue(TimePicker.TextColorProperty, actValue); };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T Time<T>(this T self,
        System.TimeSpan time)
        where T : TimePicker
    {
        self.SetValue(TimePicker.TimeProperty, time);
        return self;
    }

    public static T Time<T>(this T self,
        Func<System.TimeSpan> configure)
        where T : TimePicker
    {
        var time = configure();
        self.SetValue(TimePicker.TimeProperty, time);
        return self;
    }
    
    public static T Time<T>(this T self, Func<PropertyContext<System.TimeSpan>, IPropertyBuilder<System.TimeSpan>> configure)
        where T : TimePicker
    {
        var context = new PropertyContext<System.TimeSpan>(self, TimePicker.TimeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Time<T>(this SettersContext<T> self,
        System.TimeSpan time)
        where T : TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = TimePicker.TimeProperty, Value = time });
        return self;
    }
    
    public static SettersContext<T> Time<T>(this SettersContext<T> self, Func<PropertySettersContext<System.TimeSpan>, IPropertySettersBuilder<System.TimeSpan>> configure)
        where T : TimePicker
    {
        var context = new PropertySettersContext<System.TimeSpan>(self.XamlSetters, TimePicker.TimeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnTimeSelected<T>(this T self, System.EventHandler<TimeChangedEventArgs> handler)
        where T : TimePicker
    {
        self.TimeSelected += handler;
        return self;
    }
    
    public static T OnTimeSelected<T>(this T self, System.Action<T> action)
        where T : TimePicker
    {
        self.TimeSelected += (o, arg) => action(self);
        return self;
    }
        
}
