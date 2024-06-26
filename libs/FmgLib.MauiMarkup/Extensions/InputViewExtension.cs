﻿namespace FmgLib.MauiMarkup;



public static partial class InputViewExtension
{
    public static T MaxLength<T>(this T self,
        int maxLength)
        where T : InputView
    {
        self.SetValue(InputView.MaxLengthProperty, maxLength);
        return self;
    }
    
    public static T MaxLength<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : InputView
    {
        var context = new PropertyContext<int>(self, InputView.MaxLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaxLength<T>(this SettersContext<T> self,
        int maxLength)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.MaxLengthProperty, Value = maxLength });
        return self;
    }
    
    public static SettersContext<T> MaxLength<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, InputView.MaxLengthProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : InputView
    {
        self.SetValue(InputView.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : InputView
    {
        var context = new PropertyContext<string>(self, InputView.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, InputView.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Keyboard<T>(this T self,
        Func<Microsoft.Maui.Keyboard> configure)
        where T : InputView
    {
        var keyboard = configure();
        self.SetValue(InputView.KeyboardProperty, keyboard);
        return self;
    }
    
    public static T Keyboard<T>(this T self,
        Microsoft.Maui.Keyboard keyboard)
        where T : InputView
    {
        self.SetValue(InputView.KeyboardProperty, keyboard);
        return self;
    }
    
    public static T Keyboard<T>(this T self, Func<PropertyContext<Microsoft.Maui.Keyboard>, IPropertyBuilder<Microsoft.Maui.Keyboard>> configure)
        where T : InputView
    {
        var context = new PropertyContext<Microsoft.Maui.Keyboard>(self, InputView.KeyboardProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Keyboard<T>(this SettersContext<T> self,
        Microsoft.Maui.Keyboard keyboard)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.KeyboardProperty, Value = keyboard });
        return self;
    }
    
    public static SettersContext<T> Keyboard<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Keyboard>, IPropertySettersBuilder<Microsoft.Maui.Keyboard>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<Microsoft.Maui.Keyboard>(self.XamlSetters, InputView.KeyboardProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsSpellCheckEnabled<T>(this T self,
        bool isSpellCheckEnabled)
        where T : InputView
    {
        self.SetValue(InputView.IsSpellCheckEnabledProperty, isSpellCheckEnabled);
        return self;
    }
    
    public static T IsSpellCheckEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : InputView
    {
        var context = new PropertyContext<bool>(self, InputView.IsSpellCheckEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsSpellCheckEnabled<T>(this SettersContext<T> self,
        bool isSpellCheckEnabled)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.IsSpellCheckEnabledProperty, Value = isSpellCheckEnabled });
        return self;
    }
    
    public static SettersContext<T> IsSpellCheckEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, InputView.IsSpellCheckEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsReadOnly<T>(this T self,
        bool isReadOnly)
        where T : InputView
    {
        self.SetValue(InputView.IsReadOnlyProperty, isReadOnly);
        return self;
    }
    
    public static T IsReadOnly<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : InputView
    {
        var context = new PropertyContext<bool>(self, InputView.IsReadOnlyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsReadOnly<T>(this SettersContext<T> self,
        bool isReadOnly)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.IsReadOnlyProperty, Value = isReadOnly });
        return self;
    }
    
    public static SettersContext<T> IsReadOnly<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, InputView.IsReadOnlyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Placeholder<T>(this T self,
        string placeholder)
        where T : InputView
    {
        self.SetValue(InputView.PlaceholderProperty, placeholder);
        return self;
    }
    
    public static T Placeholder<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : InputView
    {
        var context = new PropertyContext<string>(self, InputView.PlaceholderProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Placeholder<T>(this SettersContext<T> self,
        string placeholder)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.PlaceholderProperty, Value = placeholder });
        return self;
    }
    
    public static SettersContext<T> Placeholder<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, InputView.PlaceholderProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PlaceholderColor<T>(this T self,
        Color placeholderColor)
        where T : InputView
    {
        self.SetValue(InputView.PlaceholderColorProperty, placeholderColor);
        return self;
    }
    
    public static T PlaceholderColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : InputView
    {
        var context = new PropertyContext<Color>(self, InputView.PlaceholderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PlaceholderColor<T>(this SettersContext<T> self,
        Color placeholderColor)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.PlaceholderColorProperty, Value = placeholderColor });
        return self;
    }
    
    public static SettersContext<T> PlaceholderColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, InputView.PlaceholderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimatePlaceholderColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : InputView
    {
        Color fromValue = self.PlaceholderColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.PlaceholderColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimatePlaceholderColorTo", transform, callback, length, easing);
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : InputView
    {
        self.SetValue(InputView.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : InputView
    {
        var context = new PropertyContext<Color>(self, InputView.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, InputView.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : InputView
    {
        Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T CharacterSpacing<T>(this T self,
        double characterSpacing)
        where T : InputView
    {
        self.SetValue(InputView.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : InputView
    {
        var context = new PropertyContext<double>(self, InputView.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, InputView.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : InputView
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T TextTransform<T>(this T self,
        TextTransform textTransform)
        where T : InputView
    {
        self.SetValue(InputView.TextTransformProperty, textTransform);
        return self;
    }
    
    public static T TextTransform<T>(this T self, Func<PropertyContext<TextTransform>, IPropertyBuilder<TextTransform>> configure)
        where T : InputView
    {
        var context = new PropertyContext<TextTransform>(self, InputView.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self,
        TextTransform textTransform)
        where T : InputView
    {
        self.XamlSetters.Add(new Setter { Property = InputView.TextTransformProperty, Value = textTransform });
        return self;
    }
    
    public static SettersContext<T> TextTransform<T>(this SettersContext<T> self, Func<PropertySettersContext<TextTransform>, IPropertySettersBuilder<TextTransform>> configure)
        where T : InputView
    {
        var context = new PropertySettersContext<TextTransform>(self.XamlSetters, InputView.TextTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnTextChanged<T>(this T self, EventHandler<TextChangedEventArgs> handler)
        where T : InputView
    {
        self.TextChanged += handler;
        return self;
    }
    
    public static T OnTextChanged<T>(this T self, Action<T> action)
        where T : InputView
    {
        self.TextChanged += (o, arg) => action(self);
        return self;
    }
    
}