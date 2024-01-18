using System.Windows.Input;

namespace FmgLib.MauiMarkup;

public static class SelectableItemsViewExtension
{
    public static T SelectedItemFmg<T>(this T self, object selectedItem) where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectedItemProperty, selectedItem);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : SelectableItemsView
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, SelectableItemsView.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, object selectedItem) where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SelectableItemsView.SelectedItemProperty,
            Value = selectedItem
        });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : SelectableItemsView
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, SelectableItemsView.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self, IList<object> selectedItems) where T : SelectableItemsView
    {
        foreach (object selectedItem in selectedItems)
        {
            self.SelectedItems.Add(selectedItem);
        }

        return self;
    }

    public static T SelectedItemsFmg<T>(this T self, params object[] selectedItems) where T : SelectableItemsView
    {
        foreach (object item in selectedItems)
        {
            self.SelectedItems.Add(item);
        }

        return self;
    }

    public static T SelectedItemsFmg<T>(this T self, Func<PropertyContext<IList<object>>, IPropertyBuilder<IList<object>>> configure) where T : SelectableItemsView
    {
        PropertyContext<IList<object>> arg = new PropertyContext<IList<object>>(self, SelectableItemsView.SelectedItemsProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectionChangedCommandFmg<T>(this T self, ICommand selectionChangedCommand) where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectionChangedCommandProperty, selectionChangedCommand);
        return self;
    }

    public static T SelectionChangedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : SelectableItemsView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, SelectableItemsView.SelectionChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectionChangedCommandFmg<T>(this SettersContext<T> self, ICommand selectionChangedCommand) where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SelectableItemsView.SelectionChangedCommandProperty,
            Value = selectionChangedCommand
        });
        return self;
    }

    public static SettersContext<T> SelectionChangedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : SelectableItemsView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, SelectableItemsView.SelectionChangedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectionChangedCommandParameterFmg<T>(this T self, object selectionChangedCommandParameter) where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectionChangedCommandParameterProperty, selectionChangedCommandParameter);
        return self;
    }

    public static T SelectionChangedCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : SelectableItemsView
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, SelectableItemsView.SelectionChangedCommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectionChangedCommandParameterFmg<T>(this SettersContext<T> self, object selectionChangedCommandParameter) where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SelectableItemsView.SelectionChangedCommandParameterProperty,
            Value = selectionChangedCommandParameter
        });
        return self;
    }

    public static SettersContext<T> SelectionChangedCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : SelectableItemsView
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, SelectableItemsView.SelectionChangedCommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectionModeFmg<T>(this T self, SelectionMode selectionMode) where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectionModeProperty, selectionMode);
        return self;
    }

    public static T SelectionModeFmg<T>(this T self, Func<PropertyContext<SelectionMode>, IPropertyBuilder<SelectionMode>> configure) where T : SelectableItemsView
    {
        PropertyContext<SelectionMode> arg = new PropertyContext<SelectionMode>(self, SelectableItemsView.SelectionModeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectionModeFmg<T>(this SettersContext<T> self, SelectionMode selectionMode) where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SelectableItemsView.SelectionModeProperty,
            Value = selectionMode
        });
        return self;
    }

    public static SettersContext<T> SelectionModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SelectionMode>, IPropertySettersBuilder<SelectionMode>> configure) where T : SelectableItemsView
    {
        PropertySettersContext<SelectionMode> arg = new PropertySettersContext<SelectionMode>(self.XamlSetters, SelectableItemsView.SelectionModeProperty);
        configure(arg).Build();
        return self;
    }

    public static T OnSelectionChangedFmg<T>(this T self, EventHandler<SelectionChangedEventArgs> handler) where T : SelectableItemsView
    {
        self.SelectionChanged += handler;
        return self;
    }

    public static T OnSelectionChangedFmg<T>(this T self, Action<T> action) where T : SelectableItemsView
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.SelectionChanged += delegate
        {
            action2(self2);
        };
        return self2;
    }
}
