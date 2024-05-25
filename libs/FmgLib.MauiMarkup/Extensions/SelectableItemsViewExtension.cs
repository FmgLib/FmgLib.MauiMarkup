namespace FmgLib.MauiMarkup;



public static partial class SelectableItemsViewExtension
{
    public static T SelectedItem<T>(this T self,
        object selectedItem)
        where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectedItemProperty, selectedItem);
        return self;
    }
    
    public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertyContext<object>(self, SelectableItemsView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self,
        object selectedItem)
        where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = SelectableItemsView.SelectedItemProperty, Value = selectedItem });
        return self;
    }
    
    public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SelectableItemsView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectedItems<T>(this T self,
        IList<object> selectedItems)
        where T : SelectableItemsView
    {
        foreach (var item in selectedItems)
            self.SelectedItems.Add(item);
        return self;
    }

    public static T SelectedItems<T>(this T self,
        params object[] selectedItems)
        where T : SelectableItemsView
    {
        foreach (var item in selectedItems)
            self.SelectedItems.Add(item);
        return self;
    }

    public static T SelectedItems<T>(this T self,
        Func<object[]> configure)
        where T : SelectableItemsView
    {
        var selectedItems = configure();
        foreach (var item in selectedItems)
            self.SelectedItems.Add(item);
        return self;
    }
    
    public static T SelectedItems<T>(this T self, Func<PropertyContext<IList<object>>, IPropertyBuilder<IList<object>>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertyContext<IList<object>>(self, SelectableItemsView.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionChangedCommand<T>(this T self,
        System.Windows.Input.ICommand selectionChangedCommand)
        where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectionChangedCommandProperty, selectionChangedCommand);
        return self;
    }
    
    public static T SelectionChangedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, SelectableItemsView.SelectionChangedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionChangedCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand selectionChangedCommand)
        where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = SelectableItemsView.SelectionChangedCommandProperty, Value = selectionChangedCommand });
        return self;
    }
    
    public static SettersContext<T> SelectionChangedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, SelectableItemsView.SelectionChangedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionChangedCommandParameter<T>(this T self,
        object selectionChangedCommandParameter)
        where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectionChangedCommandParameterProperty, selectionChangedCommandParameter);
        return self;
    }
    
    public static T SelectionChangedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertyContext<object>(self, SelectableItemsView.SelectionChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionChangedCommandParameter<T>(this SettersContext<T> self,
        object selectionChangedCommandParameter)
        where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = SelectableItemsView.SelectionChangedCommandParameterProperty, Value = selectionChangedCommandParameter });
        return self;
    }
    
    public static SettersContext<T> SelectionChangedCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, SelectableItemsView.SelectionChangedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionMode<T>(this T self,
        SelectionMode selectionMode)
        where T : SelectableItemsView
    {
        self.SetValue(SelectableItemsView.SelectionModeProperty, selectionMode);
        return self;
    }
    
    public static T SelectionMode<T>(this T self, Func<PropertyContext<SelectionMode>, IPropertyBuilder<SelectionMode>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertyContext<SelectionMode>(self, SelectableItemsView.SelectionModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionMode<T>(this SettersContext<T> self,
        SelectionMode selectionMode)
        where T : SelectableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = SelectableItemsView.SelectionModeProperty, Value = selectionMode });
        return self;
    }
    
    public static SettersContext<T> SelectionMode<T>(this SettersContext<T> self, Func<PropertySettersContext<SelectionMode>, IPropertySettersBuilder<SelectionMode>> configure)
        where T : SelectableItemsView
    {
        var context = new PropertySettersContext<SelectionMode>(self.XamlSetters, SelectableItemsView.SelectionModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnSelectionChanged<T>(this T self, EventHandler<SelectionChangedEventArgs> handler)
        where T : SelectableItemsView
    {
        self.SelectionChanged += handler;
        return self;
    }
    
    public static T OnSelectionChanged<T>(this T self, Action<T> action)
        where T : SelectableItemsView
    {
        self.SelectionChanged += (o, arg) => action(self);
        return self;
    }
    
}
