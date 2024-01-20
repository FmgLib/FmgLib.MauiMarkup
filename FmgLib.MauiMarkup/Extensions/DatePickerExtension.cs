namespace FmgLib.MauiMarkup;

public static partial class DatePickerExtension
{
    public static T DateFmg<T>(this T self,
        DateTime date)
        where T : DatePicker
    {
        self.SetValue(DatePicker.DateProperty, date);
        return self;
    }
    
    public static T DateFmg<T>(this T self, Func<PropertyContext<DateTime>, IPropertyBuilder<DateTime>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<DateTime>(self, DatePicker.DateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DateFmg<T>(this SettersContext<T> self,
        DateTime date)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.DateProperty, Value = date });
        return self;
    }
    
    public static SettersContext<T> DateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DateTime>, IPropertySettersBuilder<DateTime>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<DateTime>(self.XamlSetters, DatePicker.DateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FormatFmg<T>(this T self,
        string format)
        where T : DatePicker
    {
        self.SetValue(DatePicker.FormatProperty, format);
        return self;
    }
    
    public static T FormatFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<string>(self, DatePicker.FormatProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self,
        string format)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.FormatProperty, Value = format });
        return self;
    }
    
    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DatePicker.FormatProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MaximumDateFmg<T>(this T self,
        DateTime maximumDate)
        where T : DatePicker
    {
        self.SetValue(DatePicker.MaximumDateProperty, maximumDate);
        return self;
    }
    
    public static T MaximumDateFmg<T>(this T self, Func<PropertyContext<DateTime>, IPropertyBuilder<DateTime>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<DateTime>(self, DatePicker.MaximumDateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumDateFmg<T>(this SettersContext<T> self,
        DateTime maximumDate)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.MaximumDateProperty, Value = maximumDate });
        return self;
    }
    
    public static SettersContext<T> MaximumDateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DateTime>, IPropertySettersBuilder<DateTime>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<DateTime>(self.XamlSetters, DatePicker.MaximumDateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MinimumDateFmg<T>(this T self,
        DateTime minimumDate)
        where T : DatePicker
    {
        self.SetValue(DatePicker.MinimumDateProperty, minimumDate);
        return self;
    }
    
    public static T MinimumDateFmg<T>(this T self, Func<PropertyContext<DateTime>, IPropertyBuilder<DateTime>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<DateTime>(self, DatePicker.MinimumDateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MinimumDateFmg<T>(this SettersContext<T> self,
        DateTime minimumDate)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.MinimumDateProperty, Value = minimumDate });
        return self;
    }
    
    public static SettersContext<T> MinimumDateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DateTime>, IPropertySettersBuilder<DateTime>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<DateTime>(self.XamlSetters, DatePicker.MinimumDateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : DatePicker
    {
        self.SetValue(DatePicker.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<Color>(self, DatePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, DatePicker.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateTextColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : DatePicker
    {
        Color fromValue = self.TextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.TextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateTextColorTo", transform, callback, length, easing);
    }
    
    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : DatePicker
    {
        self.SetValue(DatePicker.CharacterSpacingProperty, characterSpacing);
        return self;
    }
    
    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<double>(self, DatePicker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }
    
    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DatePicker.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateCharacterSpacingToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : DatePicker
    {
        double fromValue = self.CharacterSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.CharacterSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateCharacterSpacingTo", transform, callback, length, easing);
    }
    
    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : DatePicker
    {
        self.SetValue(DatePicker.FontAttributesProperty, fontAttributes);
        return self;
    }
    
    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<FontAttributes>(self, DatePicker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.FontAttributesProperty, Value = fontAttributes });
        return self;
    }
    
    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, DatePicker.FontAttributesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : DatePicker
    {
        self.SetValue(DatePicker.FontFamilyProperty, fontFamily);
        return self;
    }
    
    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<string>(self, DatePicker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.FontFamilyProperty, Value = fontFamily });
        return self;
    }
    
    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DatePicker.FontFamilyProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : DatePicker
    {
        self.SetValue(DatePicker.FontSizeProperty, fontSize);
        return self;
    }
    
    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<double>(self, DatePicker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.FontSizeProperty, Value = fontSize });
        return self;
    }
    
    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DatePicker.FontSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateFontSizeToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : DatePicker
    {
        double fromValue = self.FontSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.FontSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateFontSizeTo", transform, callback, length, easing);
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self,
        bool fontAutoScalingEnabled)
        where T : DatePicker
    {
        self.SetValue(DatePicker.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }
    
    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DatePicker
    {
        var context = new PropertyContext<bool>(self, DatePicker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : DatePicker
    {
        self.XamlSetters.Add(new Setter { Property = DatePicker.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }
    
    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DatePicker
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DatePicker.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnDateSelectedFmg<T>(this T self, EventHandler<DateChangedEventArgs> handler)
        where T : DatePicker
    {
        self.DateSelected += handler;
        return self;
    }
    
    public static T OnDateSelectedFmg<T>(this T self, Action<T> action)
        where T : DatePicker
    {
        self.DateSelected += (o, arg) => action(self);
        return self;
    }
    
}