using System.Collections;
using System.Windows.Input;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class RadioButtonGroupViewExtension
{
    public static T SelectedItemFmg<T>(this T self,
       IList selectedItems)
       where T : RadioButtonGroupView
    {
        self.SetValue(RadioButtonGroupView.SelectedItemProperty, selectedItems);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : RadioButtonGroupView
    {
        var context = new PropertyContext<IList>(self, RadioButtonGroupView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self,
        IList selectedItems)
        where T : RadioButtonGroupView
    {
        self.XamlSetters.Add(new Setter { Property = RadioButtonGroupView.SelectedItemProperty, Value = selectedItems });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : RadioButtonGroupView
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, RadioButtonGroupView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedIndexFmg<T>(this T self,
        int selectedIndex)
        where T : RadioButtonGroupView
    {
        self.SetValue(RadioButtonGroupView.SelectedIndexProperty, selectedIndex);
        return self;
    }

    public static T SelectedIndexFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : RadioButtonGroupView
    {
        var context = new PropertyContext<int>(self, RadioButtonGroupView.SelectedIndexProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedIndexFmg<T>(this SettersContext<T> self,
        int selectedIndex)
        where T : RadioButtonGroupView
    {
        self.XamlSetters.Add(new Setter { Property = RadioButtonGroupView.SelectedIndexProperty, Value = selectedIndex });
        return self;
    }

    public static SettersContext<T> SelectedIndexFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : RadioButtonGroupView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, RadioButtonGroupView.SelectedIndexProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemChangedCommandFmg<T>(this T self, ICommand command) where T : RadioButtonGroupView
    {
        self.SetValue(RadioButtonGroupView.SelectedItemChangedCommandProperty, command);
        return self;
    }

    public static T SelectedItemChangedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : RadioButtonGroupView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, RadioButtonGroupView.SelectedItemChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemChangedCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : RadioButtonGroupView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = RadioButtonGroupView.SelectedItemChangedCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> SelectedItemChangedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : RadioButtonGroupView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, RadioButtonGroupView.SelectedItemChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T CommandParameterFmg<T>(this T self,
        object commandParameter)
        where T : RadioButtonGroupView
    {
        self.SetValue(RadioButtonGroupView.CommandParameterProperty, commandParameter);
        return self;
    }

    public static T CommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : RadioButtonGroupView
    {
        var context = new PropertyContext<object>(self, RadioButtonGroupView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self,
        object commandParameter)
        where T : RadioButtonGroupView
    {
        self.XamlSetters.Add(new Setter { Property = RadioButtonGroupView.CommandParameterProperty, Value = commandParameter });
        return self;
    }

    public static SettersContext<T> CommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : RadioButtonGroupView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, RadioButtonGroupView.CommandParameterProperty);
        configure(context).Build();
        return self;
    }
}
