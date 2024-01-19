namespace FmgLib.MauiMarkup;



public static partial class ListViewExtension
{
    public static T Footer<T>(this T self,
        object footer)
        where T : ListView
    {
        self.SetValue(ListView.FooterProperty, footer);
        return self;
    }
    
    public static T Footer<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ListView
    {
        var context = new PropertyContext<object>(self, ListView.FooterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Footer<T>(this SettersContext<T> self,
        object footer)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.FooterProperty, Value = footer });
        return self;
    }
    
    public static SettersContext<T> Footer<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ListView.FooterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FooterTemplate<T>(this T self,
        DataTemplate footerTemplate)
        where T : ListView
    {
        self.SetValue(ListView.FooterTemplateProperty, footerTemplate);
        return self;
    }
    
    public static T FooterTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ListView
    {
        var context = new PropertyContext<DataTemplate>(self, ListView.FooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FooterTemplate<T>(this SettersContext<T> self,
        DataTemplate footerTemplate)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.FooterTemplateProperty, Value = footerTemplate });
        return self;
    }
    
    public static SettersContext<T> FooterTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, ListView.FooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FooterTemplate<T>(this T self, Func<object> loadTemplate)
        where T : ListView
    {
        self.SetValue(ListView.FooterTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T GroupDisplayBinding<T>(this T self,
        BindingBase groupDisplayBinding)
        where T : ListView
    {
        self.GroupDisplayBinding = groupDisplayBinding;
        return self;
    }
    
    public static T GroupHeaderTemplate<T>(this T self,
        DataTemplate groupHeaderTemplate)
        where T : ListView
    {
        self.SetValue(ListView.GroupHeaderTemplateProperty, groupHeaderTemplate);
        return self;
    }
    
    public static T GroupHeaderTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ListView
    {
        var context = new PropertyContext<DataTemplate>(self, ListView.GroupHeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> GroupHeaderTemplate<T>(this SettersContext<T> self,
        DataTemplate groupHeaderTemplate)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.GroupHeaderTemplateProperty, Value = groupHeaderTemplate });
        return self;
    }
    
    public static SettersContext<T> GroupHeaderTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, ListView.GroupHeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T GroupHeaderTemplate<T>(this T self, Func<object> loadTemplate)
        where T : ListView
    {
        self.SetValue(ListView.GroupHeaderTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T GroupShortNameBinding<T>(this T self,
        BindingBase groupShortNameBinding)
        where T : ListView
    {
        self.GroupShortNameBinding = groupShortNameBinding;
        return self;
    }
    
    public static T HasUnevenRows<T>(this T self,
        bool hasUnevenRows)
        where T : ListView
    {
        self.SetValue(ListView.HasUnevenRowsProperty, hasUnevenRows);
        return self;
    }
    
    public static T HasUnevenRows<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertyContext<bool>(self, ListView.HasUnevenRowsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HasUnevenRows<T>(this SettersContext<T> self,
        bool hasUnevenRows)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.HasUnevenRowsProperty, Value = hasUnevenRows });
        return self;
    }
    
    public static SettersContext<T> HasUnevenRows<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ListView.HasUnevenRowsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Header<T>(this T self,
        object header)
        where T : ListView
    {
        self.SetValue(ListView.HeaderProperty, header);
        return self;
    }
    
    public static T Header<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ListView
    {
        var context = new PropertyContext<object>(self, ListView.HeaderProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Header<T>(this SettersContext<T> self,
        object header)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.HeaderProperty, Value = header });
        return self;
    }
    
    public static SettersContext<T> Header<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ListView.HeaderProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HeaderTemplate<T>(this T self,
        DataTemplate headerTemplate)
        where T : ListView
    {
        self.SetValue(ListView.HeaderTemplateProperty, headerTemplate);
        return self;
    }
    
    public static T HeaderTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ListView
    {
        var context = new PropertyContext<DataTemplate>(self, ListView.HeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HeaderTemplate<T>(this SettersContext<T> self,
        DataTemplate headerTemplate)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.HeaderTemplateProperty, Value = headerTemplate });
        return self;
    }
    
    public static SettersContext<T> HeaderTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, ListView.HeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HeaderTemplate<T>(this T self, Func<object> loadTemplate)
        where T : ListView
    {
        self.SetValue(ListView.HeaderTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T IsGroupingEnabled<T>(this T self,
        bool isGroupingEnabled)
        where T : ListView
    {
        self.SetValue(ListView.IsGroupingEnabledProperty, isGroupingEnabled);
        return self;
    }
    
    public static T IsGroupingEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertyContext<bool>(self, ListView.IsGroupingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsGroupingEnabled<T>(this SettersContext<T> self,
        bool isGroupingEnabled)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.IsGroupingEnabledProperty, Value = isGroupingEnabled });
        return self;
    }
    
    public static SettersContext<T> IsGroupingEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ListView.IsGroupingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsPullToRefreshEnabled<T>(this T self,
        bool isPullToRefreshEnabled)
        where T : ListView
    {
        self.SetValue(ListView.IsPullToRefreshEnabledProperty, isPullToRefreshEnabled);
        return self;
    }
    
    public static T IsPullToRefreshEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertyContext<bool>(self, ListView.IsPullToRefreshEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsPullToRefreshEnabled<T>(this SettersContext<T> self,
        bool isPullToRefreshEnabled)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.IsPullToRefreshEnabledProperty, Value = isPullToRefreshEnabled });
        return self;
    }
    
    public static SettersContext<T> IsPullToRefreshEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ListView.IsPullToRefreshEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsRefreshing<T>(this T self,
        bool isRefreshing)
        where T : ListView
    {
        self.SetValue(ListView.IsRefreshingProperty, isRefreshing);
        return self;
    }
    
    public static T IsRefreshing<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertyContext<bool>(self, ListView.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsRefreshing<T>(this SettersContext<T> self,
        bool isRefreshing)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.IsRefreshingProperty, Value = isRefreshing });
        return self;
    }
    
    public static SettersContext<T> IsRefreshing<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ListView.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RefreshCommand<T>(this T self,
        System.Windows.Input.ICommand refreshCommand)
        where T : ListView
    {
        self.SetValue(ListView.RefreshCommandProperty, refreshCommand);
        return self;
    }
    
    public static T RefreshCommand<T>(this T self, Func<PropertyContext<System.Windows.Input.ICommand>, IPropertyBuilder<System.Windows.Input.ICommand>> configure)
        where T : ListView
    {
        var context = new PropertyContext<System.Windows.Input.ICommand>(self, ListView.RefreshCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RefreshCommand<T>(this SettersContext<T> self,
        System.Windows.Input.ICommand refreshCommand)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.RefreshCommandProperty, Value = refreshCommand });
        return self;
    }
    
    public static SettersContext<T> RefreshCommand<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Windows.Input.ICommand>, IPropertySettersBuilder<System.Windows.Input.ICommand>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<System.Windows.Input.ICommand>(self.XamlSetters, ListView.RefreshCommandProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RowHeight<T>(this T self,
        int rowHeight)
        where T : ListView
    {
        self.SetValue(ListView.RowHeightProperty, rowHeight);
        return self;
    }
    
    public static T RowHeight<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : ListView
    {
        var context = new PropertyContext<int>(self, ListView.RowHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RowHeight<T>(this SettersContext<T> self,
        int rowHeight)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.RowHeightProperty, Value = rowHeight });
        return self;
    }
    
    public static SettersContext<T> RowHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, ListView.RowHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectedItem<T>(this T self,
        object selectedItem)
        where T : ListView
    {
        self.SetValue(ListView.SelectedItemProperty, selectedItem);
        return self;
    }
    
    public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : ListView
    {
        var context = new PropertyContext<object>(self, ListView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self,
        object selectedItem)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.SelectedItemProperty, Value = selectedItem });
        return self;
    }
    
    public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, ListView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SelectionMode<T>(this T self,
        ListViewSelectionMode selectionMode)
        where T : ListView
    {
        self.SetValue(ListView.SelectionModeProperty, selectionMode);
        return self;
    }
    
    public static T SelectionMode<T>(this T self, Func<PropertyContext<ListViewSelectionMode>, IPropertyBuilder<ListViewSelectionMode>> configure)
        where T : ListView
    {
        var context = new PropertyContext<ListViewSelectionMode>(self, ListView.SelectionModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectionMode<T>(this SettersContext<T> self,
        ListViewSelectionMode selectionMode)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.SelectionModeProperty, Value = selectionMode });
        return self;
    }
    
    public static SettersContext<T> SelectionMode<T>(this SettersContext<T> self, Func<PropertySettersContext<ListViewSelectionMode>, IPropertySettersBuilder<ListViewSelectionMode>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<ListViewSelectionMode>(self.XamlSetters, ListView.SelectionModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SeparatorColor<T>(this T self,
        Color separatorColor)
        where T : ListView
    {
        self.SetValue(ListView.SeparatorColorProperty, separatorColor);
        return self;
    }
    
    public static T SeparatorColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ListView
    {
        var context = new PropertyContext<Color>(self, ListView.SeparatorColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SeparatorColor<T>(this SettersContext<T> self,
        Color separatorColor)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.SeparatorColorProperty, Value = separatorColor });
        return self;
    }
    
    public static SettersContext<T> SeparatorColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ListView.SeparatorColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateSeparatorColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : ListView
    {
        Color fromValue = self.SeparatorColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.SeparatorColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateSeparatorColorTo", transform, callback, length, easing);
    }
    
    public static T RefreshControlColor<T>(this T self,
        Color refreshControlColor)
        where T : ListView
    {
        self.SetValue(ListView.RefreshControlColorProperty, refreshControlColor);
        return self;
    }
    
    public static T RefreshControlColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ListView
    {
        var context = new PropertyContext<Color>(self, ListView.RefreshControlColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RefreshControlColor<T>(this SettersContext<T> self,
        Color refreshControlColor)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.RefreshControlColorProperty, Value = refreshControlColor });
        return self;
    }
    
    public static SettersContext<T> RefreshControlColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ListView.RefreshControlColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRefreshControlColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : ListView
    {
        Color fromValue = self.RefreshControlColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.RefreshControlColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateRefreshControlColorTo", transform, callback, length, easing);
    }
    
    public static T SeparatorVisibility<T>(this T self,
        SeparatorVisibility separatorVisibility)
        where T : ListView
    {
        self.SetValue(ListView.SeparatorVisibilityProperty, separatorVisibility);
        return self;
    }
    
    public static T SeparatorVisibility<T>(this T self, Func<PropertyContext<SeparatorVisibility>, IPropertyBuilder<SeparatorVisibility>> configure)
        where T : ListView
    {
        var context = new PropertyContext<SeparatorVisibility>(self, ListView.SeparatorVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SeparatorVisibility<T>(this SettersContext<T> self,
        SeparatorVisibility separatorVisibility)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.SeparatorVisibilityProperty, Value = separatorVisibility });
        return self;
    }
    
    public static SettersContext<T> SeparatorVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<SeparatorVisibility>, IPropertySettersBuilder<SeparatorVisibility>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<SeparatorVisibility>(self.XamlSetters, ListView.SeparatorVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HorizontalScrollBarVisibility<T>(this T self,
        ScrollBarVisibility horizontalScrollBarVisibility)
        where T : ListView
    {
        self.SetValue(ListView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
        return self;
    }
    
    public static T HorizontalScrollBarVisibility<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure)
        where T : ListView
    {
        var context = new PropertyContext<ScrollBarVisibility>(self, ListView.HorizontalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalScrollBarVisibility<T>(this SettersContext<T> self,
        ScrollBarVisibility horizontalScrollBarVisibility)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.HorizontalScrollBarVisibilityProperty, Value = horizontalScrollBarVisibility });
        return self;
    }
    
    public static SettersContext<T> HorizontalScrollBarVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ListView.HorizontalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalScrollBarVisibility<T>(this T self,
        ScrollBarVisibility verticalScrollBarVisibility)
        where T : ListView
    {
        self.SetValue(ListView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
        return self;
    }
    
    public static T VerticalScrollBarVisibility<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure)
        where T : ListView
    {
        var context = new PropertyContext<ScrollBarVisibility>(self, ListView.VerticalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalScrollBarVisibility<T>(this SettersContext<T> self,
        ScrollBarVisibility verticalScrollBarVisibility)
        where T : ListView
    {
        self.XamlSetters.Add(new Setter { Property = ListView.VerticalScrollBarVisibilityProperty, Value = verticalScrollBarVisibility });
        return self;
    }
    
    public static SettersContext<T> VerticalScrollBarVisibility<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure)
        where T : ListView
    {
        var context = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ListView.VerticalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RefreshAllowed<T>(this T self,
        bool refreshAllowed)
        where T : ListView
    {
        self.RefreshAllowed = refreshAllowed;
        return self;
    }
    
    public static T OnItemAppearing<T>(this T self, EventHandler<ItemVisibilityEventArgs> handler)
        where T : ListView
    {
        self.ItemAppearing += handler;
        return self;
    }
    
    public static T OnItemAppearing<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.ItemAppearing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnItemDisappearing<T>(this T self, EventHandler<ItemVisibilityEventArgs> handler)
        where T : ListView
    {
        self.ItemDisappearing += handler;
        return self;
    }
    
    public static T OnItemDisappearing<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.ItemDisappearing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnItemSelected<T>(this T self, EventHandler<SelectedItemChangedEventArgs> handler)
        where T : ListView
    {
        self.ItemSelected += handler;
        return self;
    }
    
    public static T OnItemSelected<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.ItemSelected += (o, arg) => action(self);
        return self;
    }
    
    public static T OnItemTapped<T>(this T self, EventHandler<ItemTappedEventArgs> handler)
        where T : ListView
    {
        self.ItemTapped += handler;
        return self;
    }
    
    public static T OnItemTapped<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.ItemTapped += (o, arg) => action(self);
        return self;
    }
    
    public static T OnScrolled<T>(this T self, EventHandler<ScrolledEventArgs> handler)
        where T : ListView
    {
        self.Scrolled += handler;
        return self;
    }
    
    public static T OnScrolled<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.Scrolled += (o, arg) => action(self);
        return self;
    }
    
    public static T OnRefreshing<T>(this T self, EventHandler handler)
        where T : ListView
    {
        self.Refreshing += handler;
        return self;
    }
    
    public static T OnRefreshing<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.Refreshing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnScrollToRequested<T>(this T self, EventHandler<ScrollToRequestedEventArgs> handler)
        where T : ListView
    {
        self.ScrollToRequested += handler;
        return self;
    }
    
    public static T OnScrollToRequested<T>(this T self, Action<T> action)
        where T : ListView
    {
        self.ScrollToRequested += (o, arg) => action(self);
        return self;
    }
    
}