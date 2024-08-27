namespace FmgLib.MauiMarkup;



public static partial class ItemsViewExtension
{
    public static T EmptyView<T>(this T self,
        Func<object> configure)
        where T : ItemsView
    {
        var emptyView = configure();
        self.SetValue(ItemsView.EmptyViewProperty, emptyView);
        return self;
    }

    public static T EmptyView<T>(this T self,
        object emptyView)
        where T : ItemsView
    {
        self.SetValue(ItemsView.EmptyViewProperty, emptyView);
        return self;
    }
    
    public static T EmptyView<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<object>(self, ItemsView.EmptyViewProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> EmptyView<T>(this SettersContext<T> self,
        object emptyView)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.EmptyViewProperty, Value = emptyView });
        return self;
    }
    
    public static SettersContext<T> EmptyView<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ItemsView.EmptyViewProperty);
        configure(context).Build();
        return self;
    }
    
    public static T EmptyViewTemplate<T>(this T self,
        Func<DataTemplate> configure)
        where T : ItemsView
    {
        var emptyViewTemplate = configure();
        self.SetValue(ItemsView.EmptyViewTemplateProperty, emptyViewTemplate);
        return self;
    }
    
    public static T EmptyViewTemplate<T>(this T self,
        DataTemplate emptyViewTemplate)
        where T : ItemsView
    {
        self.SetValue(ItemsView.EmptyViewTemplateProperty, emptyViewTemplate);
        return self;
    }
    
    public static T EmptyViewTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<DataTemplate>(self, ItemsView.EmptyViewTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> EmptyViewTemplate<T>(this SettersContext<T> self,
        DataTemplate emptyViewTemplate)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.EmptyViewTemplateProperty, Value = emptyViewTemplate });
        return self;
    }
    
    public static SettersContext<T> EmptyViewTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, ItemsView.EmptyViewTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T EmptyViewTemplate<T>(this T self, Func<object> loadTemplate)
        where T : ItemsView
    {
        self.SetValue(ItemsView.EmptyViewTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T ItemsSource<T>(this T self,
        Func<System.Collections.IEnumerable> configure)
        where T : ItemsView
    {
        var itemsSource = configure();
        self.SetValue(ItemsView.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSource<T>(this T self,
        System.Collections.IEnumerable itemsSource)
        where T : ItemsView
    {
        self.SetValue(ItemsView.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<System.Collections.IEnumerable>(self, ItemsView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self,
        System.Collections.IEnumerable itemsSource)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.ItemsSourceProperty, Value = itemsSource });
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IEnumerable>, IPropertySettersBuilder<System.Collections.IEnumerable>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<System.Collections.IEnumerable>(self.XamlSetters, ItemsView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RemainingItemsThresholdReachedCommand<T>(this T self,
        System.Windows.Input.ICommand remainingItemsThresholdReachedCommand)
        where T : ItemsView
    {
        self.SetValue(ItemsView.RemainingItemsThresholdReachedCommandProperty, remainingItemsThresholdReachedCommand);
        return self;
    }
    
    public static T RemainingItemsThresholdReachedCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, ItemsView.RemainingItemsThresholdReachedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RemainingItemsThresholdReachedCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand remainingItemsThresholdReachedCommand)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.RemainingItemsThresholdReachedCommandProperty, Value = remainingItemsThresholdReachedCommand });
        return self;
    }
    
    public static SettersContext<T> RemainingItemsThresholdReachedCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, ItemsView.RemainingItemsThresholdReachedCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RemainingItemsThresholdReachedCommandParameter<T>(this T self,
        object remainingItemsThresholdReachedCommandParameter)
        where T : ItemsView
    {
        self.SetValue(ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, remainingItemsThresholdReachedCommandParameter);
        return self;
    }
    
    public static T RemainingItemsThresholdReachedCommandParameter<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<object>(self, ItemsView.RemainingItemsThresholdReachedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RemainingItemsThresholdReachedCommandParameter<T>(this SettersContext<T> self,
        object remainingItemsThresholdReachedCommandParameter)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, Value = remainingItemsThresholdReachedCommandParameter });
        return self;
    }
    
    public static SettersContext<T> RemainingItemsThresholdReachedCommandParameter<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ItemsView.RemainingItemsThresholdReachedCommandParameterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HorizontalScrollBarVisibility<T>(this T self,
        ScrollBarVisibility horizontalScrollBarVisibility)
        where T : ItemsView
    {
        self.SetValue(ItemsView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
        return self;
    }
    
    public static T HorizontalScrollBarVisibility<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<ScrollBarVisibility>(self, ItemsView.HorizontalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalScrollBarVisibility<T>(this SettersContext<T> self,
        ScrollBarVisibility horizontalScrollBarVisibility)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.HorizontalScrollBarVisibilityProperty, Value = horizontalScrollBarVisibility });
        return self;
    }
    
    public static SettersContext<T> HorizontalScrollBarVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ItemsView.HorizontalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalScrollBarVisibility<T>(this T self,
        ScrollBarVisibility verticalScrollBarVisibility)
        where T : ItemsView
    {
        self.SetValue(ItemsView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
        return self;
    }
    
    public static T VerticalScrollBarVisibility<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<ScrollBarVisibility>(self, ItemsView.VerticalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalScrollBarVisibility<T>(this SettersContext<T> self,
        ScrollBarVisibility verticalScrollBarVisibility)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.VerticalScrollBarVisibilityProperty, Value = verticalScrollBarVisibility });
        return self;
    }
    
    public static SettersContext<T> VerticalScrollBarVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ItemsView.VerticalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RemainingItemsThreshold<T>(this T self,
        int remainingItemsThreshold)
        where T : ItemsView
    {
        self.SetValue(ItemsView.RemainingItemsThresholdProperty, remainingItemsThreshold);
        return self;
    }
    
    public static T RemainingItemsThreshold<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<int>(self, ItemsView.RemainingItemsThresholdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RemainingItemsThreshold<T>(this SettersContext<T> self,
        int remainingItemsThreshold)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.RemainingItemsThresholdProperty, Value = remainingItemsThreshold });
        return self;
    }
    
    public static SettersContext<T> RemainingItemsThreshold<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, ItemsView.RemainingItemsThresholdProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self,
        Func<DataTemplate> configure)
        where T : ItemsView
    {
        var itemTemplate = configure();
        self.SetValue(ItemsView.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplate<T>(this T self,
        DataTemplate itemTemplate)
        where T : ItemsView
    {
        self.SetValue(ItemsView.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<DataTemplate>(self, ItemsView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, ItemsView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<object> loadTemplate)
        where T : ItemsView
    {
        self.SetValue(ItemsView.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T ItemsUpdatingScrollMode<T>(this T self,
        ItemsUpdatingScrollMode itemsUpdatingScrollMode)
        where T : ItemsView
    {
        self.SetValue(ItemsView.ItemsUpdatingScrollModeProperty, itemsUpdatingScrollMode);
        return self;
    }
    
    public static T ItemsUpdatingScrollMode<T>(this T self, Func<PropertyContext<ItemsUpdatingScrollMode>, IPropertyBuilder<ItemsUpdatingScrollMode>> configure)
        where T : ItemsView
    {
        var context = new PropertyContext<ItemsUpdatingScrollMode>(self, ItemsView.ItemsUpdatingScrollModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsUpdatingScrollMode<T>(this SettersContext<T> self,
        ItemsUpdatingScrollMode itemsUpdatingScrollMode)
        where T : ItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView.ItemsUpdatingScrollModeProperty, Value = itemsUpdatingScrollMode });
        return self;
    }
    
    public static SettersContext<T> ItemsUpdatingScrollMode<T>(this SettersContext<T> self, Func<PropertySettersContext<ItemsUpdatingScrollMode>, IPropertySettersBuilder<ItemsUpdatingScrollMode>> configure)
        where T : ItemsView
    {
        var context = new PropertySettersContext<ItemsUpdatingScrollMode>(self.XamlSetters, ItemsView.ItemsUpdatingScrollModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnScrollToRequested<T>(this T self, EventHandler<ScrollToRequestEventArgs> handler)
        where T : ItemsView
    {
        self.ScrollToRequested += handler;
        return self;
    }
    
    public static T OnScrollToRequested<T>(this T self, Action<T> action)
        where T : ItemsView
    {
        self.ScrollToRequested += (o, arg) => action(self);
        return self;
    }
    
    public static T OnScrolled<T>(this T self, EventHandler<ItemsViewScrolledEventArgs> handler)
        where T : ItemsView
    {
        self.Scrolled += handler;
        return self;
    }
    
    public static T OnScrolled<T>(this T self, Action<T> action)
        where T : ItemsView
    {
        self.Scrolled += (o, arg) => action(self);
        return self;
    }
    
    public static T OnRemainingItemsThresholdReached<T>(this T self, EventHandler handler)
        where T : ItemsView
    {
        self.RemainingItemsThresholdReached += handler;
        return self;
    }
    
    public static T OnRemainingItemsThresholdReached<T>(this T self, Action<T> action)
        where T : ItemsView
    {
        self.RemainingItemsThresholdReached += (o, arg) => action(self);
        return self;
    }
    
}