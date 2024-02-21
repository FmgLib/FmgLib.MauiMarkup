using CommunityToolkit.Maui.Behaviors;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class EventToCommandBehaviorExtension
{
    public static T EventNameFmg<T>(this T self, string name) where T : EventToCommandBehavior
    {
        self.SetValue(EventToCommandBehavior.EventNameProperty, name);
        return self;
    }

    public static T EventNameFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : EventToCommandBehavior
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, EventToCommandBehavior.EventNameProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EventNameFmg<T>(this SettersContext<T> self, string name) where T : EventToCommandBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = EventToCommandBehavior.EventNameProperty,
            Value = name
        });
        return self;
    }

    public static SettersContext<T> EventNameFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : EventToCommandBehavior
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, EventToCommandBehavior.EventNameProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandFmg<T>(this T self, ICommand command) where T : EventToCommandBehavior
    {
        self.SetValue(EventToCommandBehavior.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : EventToCommandBehavior
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, EventToCommandBehavior.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : EventToCommandBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = EventToCommandBehavior.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : EventToCommandBehavior
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, EventToCommandBehavior.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, object value) where T : EventToCommandBehavior
    {
        self.SetValue(EventToCommandBehavior.CommandParameterProperty, value);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : EventToCommandBehavior
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, EventToCommandBehavior.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, object value) where T : EventToCommandBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = EventToCommandBehavior.CommandParameterProperty,
            Value = value
        });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : EventToCommandBehavior
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, EventToCommandBehavior.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T EventArgsConverterFmg<T>(this T self, IValueConverter converter) where T : EventToCommandBehavior
    {
        self.SetValue(EventToCommandBehavior.EventArgsConverterProperty, converter);
        return self;
    }

    public static T EventArgsConverterFmg<T>(this T self, Func<PropertyContext<IValueConverter>, IPropertyBuilder<IValueConverter>> configure) where T : EventToCommandBehavior
    {
        PropertyContext<IValueConverter> arg = new PropertyContext<IValueConverter>(self, EventToCommandBehavior.EventArgsConverterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EventArgsConverterFmg<T>(this SettersContext<T> self, IValueConverter converter) where T : EventToCommandBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = EventToCommandBehavior.EventArgsConverterProperty,
            Value = converter
        });
        return self;
    }

    public static SettersContext<T> EventArgsConverterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IValueConverter>, IPropertySettersBuilder<IValueConverter>> configure) where T : EventToCommandBehavior
    {
        PropertySettersContext<IValueConverter> arg = new PropertySettersContext<IValueConverter>(self.XamlSetters, EventToCommandBehavior.EventArgsConverterProperty);
        configure(arg).Build();
        return self;
    }
}
