using CommunityToolkit.Maui.Behaviors;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class UserStoppedTypingBehaviorExtension
{
    public static T CommandFmg<T>(this T self, ICommand command) where T : UserStoppedTypingBehavior
    {
        self.SetValue(UserStoppedTypingBehavior.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : UserStoppedTypingBehavior
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, UserStoppedTypingBehavior.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : UserStoppedTypingBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = UserStoppedTypingBehavior.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : UserStoppedTypingBehavior
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, UserStoppedTypingBehavior.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, object value) where T : UserStoppedTypingBehavior
    {
        self.SetValue(UserStoppedTypingBehavior.CommandParameterProperty, value);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : UserStoppedTypingBehavior
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, UserStoppedTypingBehavior.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, object value) where T : UserStoppedTypingBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = UserStoppedTypingBehavior.CommandParameterProperty,
            Value = value
        });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : UserStoppedTypingBehavior
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, UserStoppedTypingBehavior.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T StoppedTypingTimeThresholdFmg<T>(this T self, int count) where T : UserStoppedTypingBehavior
    {
        self.SetValue(UserStoppedTypingBehavior.StoppedTypingTimeThresholdProperty, count);
        return self;
    }

    public static T StoppedTypingTimeThresholdFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : UserStoppedTypingBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, UserStoppedTypingBehavior.StoppedTypingTimeThresholdProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> StoppedTypingTimeThresholdFmg<T>(this SettersContext<T> self, int count) where T : UserStoppedTypingBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = UserStoppedTypingBehavior.StoppedTypingTimeThresholdProperty,
            Value = count
        });
        return self;
    }

    public static SettersContext<T> StoppedTypingTimeThresholdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : UserStoppedTypingBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, UserStoppedTypingBehavior.StoppedTypingTimeThresholdProperty);
        configure(arg).Build();
        return self;
    }

    public static T MinimumLengthThresholdFmg<T>(this T self, int minLength) where T : UserStoppedTypingBehavior
    {
        self.SetValue(UserStoppedTypingBehavior.MinimumLengthThresholdProperty, minLength);
        return self;
    }

    public static T MinimumLengthThresholdFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : UserStoppedTypingBehavior
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, UserStoppedTypingBehavior.MinimumLengthThresholdProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumLengthThresholdFmg<T>(this SettersContext<T> self, int minLength) where T : UserStoppedTypingBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = UserStoppedTypingBehavior.MinimumLengthThresholdProperty,
            Value = minLength
        });
        return self;
    }

    public static SettersContext<T> MinimumLengthThresholdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : UserStoppedTypingBehavior
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, UserStoppedTypingBehavior.MinimumLengthThresholdProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShouldDismissKeyboardAutomaticallyFmg<T>(this T self, bool shouldDismissKeyboardAutomatically) where T : UserStoppedTypingBehavior
    {
        self.SetValue(UserStoppedTypingBehavior.ShouldDismissKeyboardAutomaticallyProperty, shouldDismissKeyboardAutomatically);
        return self;
    }

    public static T ShouldDismissKeyboardAutomaticallyFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : UserStoppedTypingBehavior
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, UserStoppedTypingBehavior.ShouldDismissKeyboardAutomaticallyProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShouldDismissKeyboardAutomaticallyFmg<T>(this SettersContext<T> self, bool shouldDismissKeyboardAutomatically) where T : UserStoppedTypingBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = UserStoppedTypingBehavior.ShouldDismissKeyboardAutomaticallyProperty,
            Value = shouldDismissKeyboardAutomatically
        });
        return self;
    }

    public static SettersContext<T> ShouldDismissKeyboardAutomaticallyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : UserStoppedTypingBehavior
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, UserStoppedTypingBehavior.ShouldDismissKeyboardAutomaticallyProperty);
        configure(arg).Build();
        return self;
    }
}
