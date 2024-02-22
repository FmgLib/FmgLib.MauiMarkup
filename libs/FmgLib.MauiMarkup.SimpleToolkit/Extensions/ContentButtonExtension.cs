using SimpleToolkit.Core;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.SimpleToolkit;

public static partial class ContentButtonExtension
{
    public static T CommandParameterFmg<T>(this T self, object commandParameter) where T : ContentButton
    {
        self.SetValue(ContentButton.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : ContentButton
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, ContentButton.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, object commandParameter) where T : ContentButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ContentButton.CommandParameterProperty,
            Value = commandParameter
        });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : ContentButton
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, ContentButton.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandFmg<T>(this T self, ICommand command) where T : ContentButton
    {
        self.SetValue(ContentButton.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ContentButton
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ContentButton.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ContentButton
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ContentButton.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ContentButton
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ContentButton.CommandProperty);
        configure(arg).Build();
        return self;
    }
}
