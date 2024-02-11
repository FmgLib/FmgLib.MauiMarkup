using CommunityToolkit.Maui.Behaviors;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class MaxLengthReachedBehaviorExtension
{
    public static T CommandFmg<T>(this T self, ICommand command) where T : MaxLengthReachedBehavior
    {
        self.SetValue(MaxLengthReachedBehavior.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : MaxLengthReachedBehavior
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, MaxLengthReachedBehavior.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : MaxLengthReachedBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MaxLengthReachedBehavior.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : MaxLengthReachedBehavior
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, MaxLengthReachedBehavior.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShouldDismissKeyboardAutomaticallyFmg<T>(this T self, bool shouldDismissKeyboardAutomatically) where T : MaxLengthReachedBehavior
    {
        self.SetValue(MaxLengthReachedBehavior.ShouldDismissKeyboardAutomaticallyProperty, shouldDismissKeyboardAutomatically);
        return self;
    }

    public static T ShouldDismissKeyboardAutomaticallyFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : MaxLengthReachedBehavior
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, MaxLengthReachedBehavior.ShouldDismissKeyboardAutomaticallyProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShouldDismissKeyboardAutomaticallyFmg<T>(this SettersContext<T> self, bool shouldDismissKeyboardAutomatically) where T : MaxLengthReachedBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MaxLengthReachedBehavior.ShouldDismissKeyboardAutomaticallyProperty,
            Value = shouldDismissKeyboardAutomatically
        });
        return self;
    }

    public static SettersContext<T> ShouldDismissKeyboardAutomaticallyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : MaxLengthReachedBehavior
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, MaxLengthReachedBehavior.ShouldDismissKeyboardAutomaticallyProperty);
        configure(arg).Build();
        return self;
    }
}
