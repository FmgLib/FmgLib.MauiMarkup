using CommunityToolkit.Maui.Behaviors;
using System.Text.RegularExpressions;

namespace FmgLib.MauiMarkup.Views;

public static partial class TextValidationBehaviorExtension
{
    public static T MinimumLengthFmg<T>(this T self, int minLength) where T : TextValidationBehavior
    {
        self.SetValue(TextValidationBehavior.MinimumLengthProperty, minLength);
        return self;
    }

    public static T MinimumLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : TextValidationBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, TextValidationBehavior.MinimumLengthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumLengthFmg<T>(this SettersContext<T> self, int minLength) where T : TextValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextValidationBehavior.MinimumLengthProperty,
            Value = minLength
        });
        return self;
    }

    public static SettersContext<T> MinimumLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : TextValidationBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, TextValidationBehavior.MinimumLengthProperty);
        configure(arg).Build();
        return self;
    }

    public static T MaximumLengthFmg<T>(this T self, int maxLength) where T : TextValidationBehavior
    {
        self.SetValue(TextValidationBehavior.MaximumLengthProperty, maxLength);
        return self;
    }

    public static T MaximumLengthFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : TextValidationBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, TextValidationBehavior.MaximumLengthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumLengthFmg<T>(this SettersContext<T> self, int maxLength) where T : TextValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextValidationBehavior.MaximumLengthProperty,
            Value = maxLength
        });
        return self;
    }

    public static SettersContext<T> MaximumLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : TextValidationBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, TextValidationBehavior.MaximumLengthProperty);
        configure(arg).Build();
        return self;
    }

    public static T DecorationFlagsFmg<T>(this T self, TextDecorationFlags flags) where T : TextValidationBehavior
    {
        self.SetValue(TextValidationBehavior.DecorationFlagsProperty, flags);
        return self;
    }

    public static T DecorationFlagsFmg<T>(this T self, Func<PropertyContext<TextDecorationFlags>, IPropertyBuilder<TextDecorationFlags>> configure) where T : TextValidationBehavior
    {
        PropertyContext<TextDecorationFlags> arg = new PropertyContext<TextDecorationFlags>(self, TextValidationBehavior.DecorationFlagsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DecorationFlagsFmg<T>(this SettersContext<T> self, TextDecorationFlags flags) where T : TextValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextValidationBehavior.DecorationFlagsProperty,
            Value = flags
        });
        return self;
    }

    public static SettersContext<T> DecorationFlagsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TextDecorationFlags>, IPropertySettersBuilder<TextDecorationFlags>> configure) where T : TextValidationBehavior
    {
        PropertySettersContext<TextDecorationFlags> arg = new PropertySettersContext<TextDecorationFlags>(self.XamlSetters, TextValidationBehavior.DecorationFlagsProperty);
        configure(arg).Build();
        return self;
    }

    public static T RegexPatternFmg<T>(this T self, string regexPattern) where T : TextValidationBehavior
    {
        self.SetValue(TextValidationBehavior.RegexPatternProperty, regexPattern);
        return self;
    }

    public static T RegexPatternFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : TextValidationBehavior
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, TextValidationBehavior.RegexPatternProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RegexPatternFmg<T>(this SettersContext<T> self, string regexPattern) where T : TextValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextValidationBehavior.RegexPatternProperty,
            Value = regexPattern
        });
        return self;
    }

    public static SettersContext<T> RegexPatternFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : TextValidationBehavior
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, TextValidationBehavior.RegexPatternProperty);
        configure(arg).Build();
        return self;
    }

    public static T RegexOptionsFmg<T>(this T self, RegexOptions regexOptions) where T : TextValidationBehavior
    {
        self.SetValue(TextValidationBehavior.RegexOptionsProperty, regexOptions);
        return self;
    }

    public static T RegexOptionsFmg<T>(this T self, Func<PropertyContext<RegexOptions>, IPropertyBuilder<RegexOptions>> configure) where T : TextValidationBehavior
    {
        PropertyContext<RegexOptions> arg = new PropertyContext<RegexOptions>(self, TextValidationBehavior.RegexOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RegexOptionsFmg<T>(this SettersContext<T> self, RegexOptions regexOptions) where T : TextValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TextValidationBehavior.RegexOptionsProperty,
            Value = regexOptions
        });
        return self;
    }

    public static SettersContext<T> RegexOptionsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<RegexOptions>, IPropertySettersBuilder<RegexOptions>> configure) where T : TextValidationBehavior
    {
        PropertySettersContext<RegexOptions> arg = new PropertySettersContext<RegexOptions>(self.XamlSetters, TextValidationBehavior.RegexOptionsProperty);
        configure(arg).Build();
        return self;
    }
}
