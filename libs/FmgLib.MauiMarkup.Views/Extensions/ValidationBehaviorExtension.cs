using CommunityToolkit.Maui.Behaviors;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class ValidationBehaviorExtension
{
    public static T IsNotValidFmg<T>(this T self, bool isNotValid) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.IsNotValidProperty, isNotValid);
        return self;
    }

    public static T IsNotValidFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : ValidationBehavior
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, ValidationBehavior.IsNotValidProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsNotValidFmg<T>(this SettersContext<T> self, bool isNotValid) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.IsNotValidProperty,
            Value = isNotValid
        });
        return self;
    }

    public static SettersContext<T> IsNotValidFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, ValidationBehavior.IsNotValidProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsValidFmg<T>(this T self, bool isValid) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.IsValidProperty, isValid);
        return self;
    }

    public static T IsValidFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : ValidationBehavior
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, ValidationBehavior.IsValidProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsValidFmg<T>(this SettersContext<T> self, bool isValid) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.IsValidProperty,
            Value = isValid
        });
        return self;
    }

    public static SettersContext<T> IsValidFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, ValidationBehavior.IsValidProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsRunningFmg<T>(this T self, bool isRunning) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.IsRunningProperty, isRunning);
        return self;
    }

    public static T IsRunningFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : ValidationBehavior
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, ValidationBehavior.IsRunningProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsRunningFmg<T>(this SettersContext<T> self, bool isRunning) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.IsRunningProperty,
            Value = isRunning
        });
        return self;
    }

    public static SettersContext<T> IsRunningFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, ValidationBehavior.IsRunningProperty);
        configure(arg).Build();
        return self;
    }

    public static T ValidStyleFmg<T>(this T self, Style style) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.ValidStyleProperty, style);
        return self;
    }

    public static T ValidStyleFmg<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure) where T : ValidationBehavior
    {
        PropertyContext<Style> arg = new PropertyContext<Style>(self, ValidationBehavior.ValidStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ValidStyleFmg<T>(this SettersContext<T> self, Style style) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.ValidStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<T> ValidStyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<Style> arg = new PropertySettersContext<Style>(self.XamlSetters, ValidationBehavior.ValidStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static T InvalidStyleFmg<T>(this T self, Style style) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.InvalidStyleProperty, style);
        return self;
    }

    public static T InvalidStyleFmg<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure) where T : ValidationBehavior
    {
        PropertyContext<Style> arg = new PropertyContext<Style>(self, ValidationBehavior.InvalidStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> InvalidStyleFmg<T>(this SettersContext<T> self, Style style) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.InvalidStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<T> InvalidStyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<Style> arg = new PropertySettersContext<Style>(self.XamlSetters, ValidationBehavior.InvalidStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static T FlagsFmg<T>(this T self, ValidationFlags flags) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.FlagsProperty, flags);
        return self;
    }

    public static T FlagsFmg<T>(this T self, Func<PropertyContext<ValidationFlags>, IPropertyBuilder<ValidationFlags>> configure) where T : ValidationBehavior
    {
        PropertyContext<ValidationFlags> arg = new PropertyContext<ValidationFlags>(self, ValidationBehavior.FlagsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FlagsFmg<T>(this SettersContext<T> self, ValidationFlags flags) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.FlagsProperty,
            Value = flags
        });
        return self;
    }

    public static SettersContext<T> FlagsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ValidationFlags>, IPropertySettersBuilder<ValidationFlags>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<ValidationFlags> arg = new PropertySettersContext<ValidationFlags>(self.XamlSetters, ValidationBehavior.FlagsProperty);
        configure(arg).Build();
        return self;
    }

    public static T ValueFmg<T>(this T self, object value) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.ValueProperty, value);
        return self;
    }

    public static T ValueFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : ValidationBehavior
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, ValidationBehavior.ValueProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self, object value) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.ValueProperty,
            Value = value
        });
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, ValidationBehavior.ValueProperty);
        configure(arg).Build();
        return self;
    }

    public static T ValuePropertyNameFmg<T>(this T self, string name) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.ValuePropertyNameProperty, name);
        return self;
    }

    public static T ValuePropertyNameFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : ValidationBehavior
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, ValidationBehavior.ValuePropertyNameProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ValuePropertyNameFmg<T>(this SettersContext<T> self, string name) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.ValuePropertyNameProperty,
            Value = name
        });
        return self;
    }

    public static SettersContext<T> ValuePropertyNameFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, ValidationBehavior.ValuePropertyNameProperty);
        configure(arg).Build();
        return self;
    }

    public static T ForceValidateCommandFmg<T>(this T self, ICommand command) where T : ValidationBehavior
    {
        self.SetValue(ValidationBehavior.ForceValidateCommandProperty, command);
        return self;
    }

    public static T ForceValidateCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ValidationBehavior
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ValidationBehavior.ForceValidateCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ForceValidateCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ValidationBehavior.ForceValidateCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> ForceValidateCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ValidationBehavior
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ValidationBehavior.ForceValidateCommandProperty);
        configure(arg).Build();
        return self;
    }
}
