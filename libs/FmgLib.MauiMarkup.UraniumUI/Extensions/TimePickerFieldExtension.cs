using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TimePickerFieldExtension
{
    public static T TimeFmg<T>(this T self,
        TimeSpan time)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.TimeProperty, time);
        return self;
    }

    public static T TimeFmg<T>(this T self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<TimeSpan>(self, TimePickerField.TimeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TimeFmg<T>(this SettersContext<T> self,
        TimeSpan time)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.TimeProperty, Value = time });
        return self;
    }

    public static SettersContext<T> TimeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, TimePickerField.TimeProperty);
        configure(context).Build();
        return self;
    }

    public static T FormatFmg<T>(this T self, string format) where T : TimePickerField
    {
        self.SetValue(TimePickerField.FormatProperty, format);
        return self;
    }

    public static T FormatFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : TimePickerField
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, TimePickerField.FormatProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self, string format) where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TimePickerField.FormatProperty,
            Value = format
        });
        return self;
    }

    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : TimePickerField
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, TimePickerField.FormatProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<Color>(self, TimePickerField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TimePickerField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<double>(self, TimePickerField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, TimePickerField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<FontAttributes>(self, TimePickerField.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.FontAttributesProperty, Value = fontAttributes });
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, TimePickerField.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<string>(self, TimePickerField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TimePickerField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<double>(self, TimePickerField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, TimePickerField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self,
       bool fontAutoScalingEnabled)
       where T : TimePickerField
    {
        self.SetValue(TimePickerField.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<bool>(self, TimePickerField.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TimePickerField.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T AllowClearFmg<T>(this T self,
        bool allowClear)
        where T : TimePickerField
    {
        self.SetValue(TimePickerField.AllowClearProperty, allowClear);
        return self;
    }

    public static T AllowClearFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TimePickerField
    {
        var context = new PropertyContext<bool>(self, TimePickerField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self,
        bool allowClear)
        where T : TimePickerField
    {
        self.XamlSetters.Add(new Setter { Property = TimePickerField.AllowClearProperty, Value = allowClear });
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TimePickerField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TimePickerField.AllowClearProperty);
        configure(context).Build();
        return self;
    }
}
