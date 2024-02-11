using System.Windows.Input;
using UraniumUI.Views;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class StatefulContentViewExtension
{
    public static T PressedCommandFmg<T>(this T self, ICommand command) where T : StatefulContentView
    {
        self.SetValue(StatefulContentView.PressedCommandProperty, command);
        return self;
    }

    public static T PressedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, StatefulContentView.PressedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PressedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : StatefulContentView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatefulContentView.PressedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> PressedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, StatefulContentView.PressedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T HoverCommandFmg<T>(this T self, ICommand command) where T : StatefulContentView
    {
        self.SetValue(StatefulContentView.HoverCommandProperty, command);
        return self;
    }

    public static T HoverCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, StatefulContentView.HoverCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HoverCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : StatefulContentView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatefulContentView.HoverCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> HoverCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, StatefulContentView.HoverCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T HoverExitCommandFmg<T>(this T self, ICommand command) where T : StatefulContentView
    {
        self.SetValue(StatefulContentView.HoverExitCommandProperty, command);
        return self;
    }

    public static T HoverExitCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, StatefulContentView.HoverExitCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HoverExitCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : StatefulContentView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatefulContentView.HoverExitCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> HoverExitCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, StatefulContentView.HoverExitCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T LongPressCommandFmg<T>(this T self, ICommand command) where T : StatefulContentView
    {
        self.SetValue(StatefulContentView.LongPressCommandProperty, command);
        return self;
    }

    public static T LongPressCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, StatefulContentView.LongPressCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LongPressCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : StatefulContentView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatefulContentView.LongPressCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> LongPressCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, StatefulContentView.LongPressCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T TappedCommandFmg<T>(this T self, ICommand command) where T : StatefulContentView
    {
        self.SetValue(StatefulContentView.TappedCommandProperty, command);
        return self;
    }

    public static T TappedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, StatefulContentView.TappedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TappedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : StatefulContentView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatefulContentView.TappedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> TappedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : StatefulContentView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, StatefulContentView.TappedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : StatefulContentView
    {
        self.SetValue(StatefulContentView.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : StatefulContentView
    {
        var context = new PropertyContext<object>(self, StatefulContentView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : StatefulContentView
    {
        self.XamlSetters.Add(new Setter { Property = StatefulContentView.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : StatefulContentView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, StatefulContentView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
}
