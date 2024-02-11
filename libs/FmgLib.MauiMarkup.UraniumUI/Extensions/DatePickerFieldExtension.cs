using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class DatePickerFieldExtension
{
    public static T DateFmg<T>(this T self,
        DateTime date)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.DateProperty, date);
        return self;
    }

    public static T DateFmg<T>(this T self, Func<PropertyContext<DateTime>, IPropertyBuilder<DateTime>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<DateTime>(self, DatePickerField.DateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DateFmg<T>(this SettersContext<T> self,
        DateTime date)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.DateProperty, Value = date });
        return self;
    }

    public static SettersContext<T> DateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DateTime>, IPropertySettersBuilder<DateTime>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<DateTime>(self.XamlSetters, DatePickerField.DateProperty);
        configure(context).Build();
        return self;
    }

    public static T MaximumDateFmg<T>(this T self,
        DateTime date)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.MaximumDateProperty, date);
        return self;
    }

    public static T MaximumDateFmg<T>(this T self, Func<PropertyContext<DateTime>, IPropertyBuilder<DateTime>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<DateTime>(self, DatePickerField.MaximumDateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaximumDateFmg<T>(this SettersContext<T> self,
        DateTime date)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.MaximumDateProperty, Value = date });
        return self;
    }

    public static SettersContext<T> MaximumDateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DateTime>, IPropertySettersBuilder<DateTime>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<DateTime>(self.XamlSetters, DatePickerField.MaximumDateProperty);
        configure(context).Build();
        return self;
    }

    public static T MinimumDateFmg<T>(this T self,
        DateTime date)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.MinimumDateProperty, date);
        return self;
    }

    public static T MinimumDateFmg<T>(this T self, Func<PropertyContext<DateTime>, IPropertyBuilder<DateTime>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<DateTime>(self, DatePickerField.MinimumDateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MinimumDateFmg<T>(this SettersContext<T> self,
        DateTime date)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.MinimumDateProperty, Value = date });
        return self;
    }

    public static SettersContext<T> MinimumDateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DateTime>, IPropertySettersBuilder<DateTime>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<DateTime>(self.XamlSetters, DatePickerField.MinimumDateProperty);
        configure(context).Build();
        return self;
    }

    public static T FormatFmg<T>(this T self, string format) where T : DatePickerField
    {
        self.SetValue(DatePickerField.FormatProperty, format);
        return self;
    }

    public static T FormatFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : DatePickerField
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, DatePickerField.FormatProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self, string format) where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DatePickerField.FormatProperty,
            Value = format
        });
        return self;
    }

    public static SettersContext<T> FormatFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : DatePickerField
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, DatePickerField.FormatProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<Color>(self, DatePickerField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, DatePickerField.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self,
        double characterSpacing)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.CharacterSpacingProperty, characterSpacing);
        return self;
    }

    public static T CharacterSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<double>(self, DatePickerField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self,
        double characterSpacing)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.CharacterSpacingProperty, Value = characterSpacing });
        return self;
    }

    public static SettersContext<T> CharacterSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DatePickerField.CharacterSpacingProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAttributesFmg<T>(this T self,
        FontAttributes fontAttributes)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.FontAttributesProperty, fontAttributes);
        return self;
    }

    public static T FontAttributesFmg<T>(this T self, Func<PropertyContext<FontAttributes>, IPropertyBuilder<FontAttributes>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<FontAttributes>(self, DatePickerField.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self,
        FontAttributes fontAttributes)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.FontAttributesProperty, Value = fontAttributes });
        return self;
    }

    public static SettersContext<T> FontAttributesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FontAttributes>, IPropertySettersBuilder<FontAttributes>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<FontAttributes>(self.XamlSetters, DatePickerField.FontAttributesProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<string>(self, DatePickerField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DatePickerField.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<double>(self, DatePickerField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DatePickerField.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self,
       bool fontAutoScalingEnabled)
       where T : DatePickerField
    {
        self.SetValue(DatePickerField.FontAutoScalingEnabledProperty, fontAutoScalingEnabled);
        return self;
    }

    public static T FontAutoScalingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<bool>(self, DatePickerField.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self,
        bool fontAutoScalingEnabled)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.FontAutoScalingEnabledProperty, Value = fontAutoScalingEnabled });
        return self;
    }

    public static SettersContext<T> FontAutoScalingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DatePickerField.FontAutoScalingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T AllowClearFmg<T>(this T self,
        bool allowClear)
        where T : DatePickerField
    {
        self.SetValue(DatePickerField.AllowClearProperty, allowClear);
        return self;
    }

    public static T AllowClearFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DatePickerField
    {
        var context = new PropertyContext<bool>(self, DatePickerField.AllowClearProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self,
        bool allowClear)
        where T : DatePickerField
    {
        self.XamlSetters.Add(new Setter { Property = DatePickerField.AllowClearProperty, Value = allowClear });
        return self;
    }

    public static SettersContext<T> AllowClearFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DatePickerField
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DatePickerField.AllowClearProperty);
        configure(context).Build();
        return self;
    }
}
