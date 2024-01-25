using System.Windows.Input;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class ButtonViewExtension
{
    public static T PressedCommandFmg<T>(this T self, ICommand command) where T : ButtonView
    {
        self.SetValue(ButtonView.PressedCommandProperty, command);
        return self;
    }

    public static T PressedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ButtonView.PressedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PressedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ButtonView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ButtonView.PressedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> PressedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ButtonView.PressedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T HoverCommandFmg<T>(this T self, ICommand command) where T : ButtonView
    {
        self.SetValue(ButtonView.HoverCommandProperty, command);
        return self;
    }

    public static T HoverCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ButtonView.HoverCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HoverCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ButtonView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ButtonView.HoverCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> HoverCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ButtonView.HoverCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T HoverExitCommandFmg<T>(this T self, ICommand command) where T : ButtonView
    {
        self.SetValue(ButtonView.HoverExitCommandProperty, command);
        return self;
    }

    public static T HoverExitCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ButtonView.HoverExitCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HoverExitCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ButtonView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ButtonView.HoverExitCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> HoverExitCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ButtonView.HoverExitCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T LongPressCommandFmg<T>(this T self, ICommand command) where T : ButtonView
    {
        self.SetValue(ButtonView.LongPressCommandProperty, command);
        return self;
    }

    public static T LongPressCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ButtonView.LongPressCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LongPressCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ButtonView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ButtonView.LongPressCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> LongPressCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ButtonView.LongPressCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T TappedCommandFmg<T>(this T self, ICommand command) where T : ButtonView
    {
        self.SetValue(ButtonView.TappedCommandProperty, command);
        return self;
    }

    public static T TappedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ButtonView.TappedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TappedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : ButtonView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ButtonView.TappedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> TappedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ButtonView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ButtonView.TappedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : ButtonView
    {
        self.SetValue(ButtonView.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ButtonView
    {
        var context = new PropertyContext<object>(self, ButtonView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : ButtonView
    {
        self.XamlSetters.Add(new Setter { Property = ButtonView.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ButtonView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ButtonView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
}
