using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class RequiredStringValidationBehaviorExtension
{
    public static T RequiredStringFmg<T>(this T self, string requiredString) where T : RequiredStringValidationBehavior
    {
        self.SetValue(RequiredStringValidationBehavior.RequiredStringProperty, requiredString);
        return self;
    }

    public static T RequiredStringFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : RequiredStringValidationBehavior
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, RequiredStringValidationBehavior.RequiredStringProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RequiredStringFmg<T>(this SettersContext<T> self, string requiredString) where T : RequiredStringValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RequiredStringValidationBehavior.RequiredStringProperty,
            Value = requiredString
        });
        return self;
    }

    public static SettersContext<T> RequiredStringFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : RequiredStringValidationBehavior
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, RequiredStringValidationBehavior.RequiredStringProperty);
        configure(arg).Build();
        return self;
    }

    public static T ExactMatchFmg<T>(this T self, bool exactMatch) where T : RequiredStringValidationBehavior
    {
        self.SetValue(RequiredStringValidationBehavior.ExactMatchProperty, exactMatch);
        return self;
    }

    public static T ExactMatchFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : RequiredStringValidationBehavior
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, RequiredStringValidationBehavior.ExactMatchProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ExactMatchFmg<T>(this SettersContext<T> self, bool exactMatch) where T : RequiredStringValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RequiredStringValidationBehavior.ExactMatchProperty,
            Value = exactMatch
        });
        return self;
    }

    public static SettersContext<T> ExactMatchFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : RequiredStringValidationBehavior
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, RequiredStringValidationBehavior.ExactMatchProperty);
        configure(arg).Build();
        return self;
    }
}
