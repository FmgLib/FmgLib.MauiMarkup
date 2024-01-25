using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.Views;

public static partial class ExpanderExtension
{
    public static T HeaderFmg<T>(this T self, IView view) where T : Expander
    {
        self.SetValue(Expander.HeaderProperty, view);
        return self;
    }

    public static T HeaderFmg<T>(this T self, Func<PropertyContext<IView>, IPropertyBuilder<IView>> configure) where T : Expander
    {
        PropertyContext<IView> arg = new PropertyContext<IView>(self, Expander.HeaderProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HeaderFmg<T>(this SettersContext<T> self, IView view) where T : Expander
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Expander.HeaderProperty,
            Value = view
        });
        return self;
    }

    public static SettersContext<T> HeaderFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IView>, IPropertySettersBuilder<IView>> configure) where T : Expander
    {
        PropertySettersContext<IView> arg = new PropertySettersContext<IView>(self.XamlSetters, Expander.HeaderProperty);
        configure(arg).Build();
        return self;
    }

    public static T ContentFmg<T>(this T self, IView view) where T : Expander
    {
        self.SetValue(Expander.ContentProperty, view);
        return self;
    }

    public static T ContentFmg<T>(this T self, Func<PropertyContext<IView>, IPropertyBuilder<IView>> configure) where T : Expander
    {
        PropertyContext<IView> arg = new PropertyContext<IView>(self, Expander.ContentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, IView view) where T : Expander
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Expander.ContentProperty,
            Value = view
        });
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IView>, IPropertySettersBuilder<IView>> configure) where T : Expander
    {
        PropertySettersContext<IView> arg = new PropertySettersContext<IView>(self.XamlSetters, Expander.ContentProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsExpandedFmg<T>(this T self, bool isExpanded) where T : Expander
    {
        self.SetValue(Expander.IsExpandedProperty, isExpanded);
        return self;
    }

    public static T IsExpandedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Expander
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Expander.IsExpandedProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsExpandedFmg<T>(this SettersContext<T> self, bool isExpanded) where T : Expander
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Expander.IsExpandedProperty,
            Value = isExpanded
        });
        return self;
    }

    public static SettersContext<T> IsExpandedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Expander
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Expander.IsExpandedProperty);
        configure(arg).Build();
        return self;
    }

    public static T DirectionFmg<T>(this T self, ExpandDirection expandDirection) where T : Expander
    {
        self.SetValue(Expander.DirectionProperty, expandDirection);
        return self;
    }

    public static T DirectionFmg<T>(this T self, Func<PropertyContext<ExpandDirection>, IPropertyBuilder<ExpandDirection>> configure) where T : Expander
    {
        PropertyContext<ExpandDirection> arg = new PropertyContext<ExpandDirection>(self, Expander.DirectionProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DirectionFmg<T>(this SettersContext<T> self, ExpandDirection expandDirection) where T : Expander
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Expander.DirectionProperty,
            Value = expandDirection
        });
        return self;
    }

    public static SettersContext<T> DirectionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ExpandDirection>, IPropertySettersBuilder<ExpandDirection>> configure) where T : Expander
    {
        PropertySettersContext<ExpandDirection> arg = new PropertySettersContext<ExpandDirection>(self.XamlSetters, Expander.DirectionProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, object commandParameter) where T : Expander
    {
        self.SetValue(Expander.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : Expander
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, Expander.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, object commandParameter) where T : Expander
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Expander.CommandParameterProperty,
            Value = commandParameter
        });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : Expander
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, Expander.CommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandFmg<T>(this T self, ICommand command) where T : Expander
    {
        self.SetValue(Expander.CommandProperty, command);
        return self;
    }

    public static T CommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : Expander
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, Expander.CommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, ICommand command) where T : Expander
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Expander.CommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> CommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : Expander
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, Expander.CommandProperty);
        configure(arg).Build();
        return self;
    }
}
