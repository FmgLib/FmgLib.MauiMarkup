﻿namespace FmgLib.MauiMarkup;



public static partial class TimePickerExtension
{
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacing<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var characterSpacing = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.SetValue(Microsoft.Maui.Controls.TimePicker.CharacterSpacingProperty, actValue); };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T FontAttributes<T>(this T self,
        Microsoft.Maui.Controls.FontAttributes fontAttributes)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributes<T>(this T self,
        Func<Microsoft.Maui.Controls.FontAttributes> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var fontAttributes = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributes<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.FontAttributes>, IPropertyBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.FontAttributes>(self, Microsoft.Maui.Controls.TimePicker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.FontAttributes fontAttributes)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributes<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>, IPropertySettersBuilder<Microsoft.Maui.Controls.FontAttributes>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.FontAttributes>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabled<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var fontAutoScalingEnabled = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamily<T>(this T self,
        string fontFamily)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamily<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var fontFamily = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamily<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.TimePicker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self,
        string fontFamily)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamily<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSize<T>(this T self,
        double fontSize)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSize<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var fontSize = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSize<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.TimePicker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self,
        double fontSize)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSize<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.SetValue(Microsoft.Maui.Controls.TimePicker.FontSizeProperty, actValue); };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T Format<T>(this T self,
        string format)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FormatProperty, format);
        return self;
    }

    public static T Format<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var format = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.FormatProperty, format);
        return self;
    }
    
    public static T Format<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.TimePicker.FormatProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Format<T>(this SettersContext<T> self,
        string format)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.FormatProperty, Value = format });
        return self;
    }
    
    public static SettersContext<T> Format<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.FormatProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Microsoft.Maui.Graphics.Color textColor)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.TextColorProperty, textColor);
        return self;
    }

    public static T TextColor<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var textColor = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.TimePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color textColor)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        Microsoft.Maui.Graphics.Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.SetValue(Microsoft.Maui.Controls.TimePicker.TextColorProperty, actValue); };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T Time<T>(this T self,
        System.TimeSpan time)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.SetValue(Microsoft.Maui.Controls.TimePicker.TimeProperty, time);
        return self;
    }

    public static T Time<T>(this T self,
        Func<System.TimeSpan> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var time = configure();
        self.SetValue(Microsoft.Maui.Controls.TimePicker.TimeProperty, time);
        return self;
    }
    
    public static T Time<T>(this T self, Func<PropertyContext<System.TimeSpan>, IPropertyBuilder<System.TimeSpan>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertyContext<System.TimeSpan>(self, Microsoft.Maui.Controls.TimePicker.TimeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Time<T>(this SettersContext<T> self,
        System.TimeSpan time)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.TimePicker.TimeProperty, Value = time });
        return self;
    }
    
    public static SettersContext<T> Time<T>(this SettersContext<T> self, Func<PropertySettersContext<System.TimeSpan>, IPropertySettersBuilder<System.TimeSpan>> configure)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        var context = new PropertySettersContext<System.TimeSpan>(self.XamlSetters, Microsoft.Maui.Controls.TimePicker.TimeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnTimeSelected<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.TimeChangedEventArgs> handler)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.TimeSelected += handler;
        return self;
    }
    
    public static T OnTimeSelected<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.TimePicker
    {
        self.TimeSelected += (o, arg) => action(self);
        return self;
    }
        
}
