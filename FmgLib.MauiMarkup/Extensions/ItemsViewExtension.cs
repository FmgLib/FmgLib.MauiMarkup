using System.Collections;
using System.Windows.Input;

namespace FmgLib.MauiMarkup;

public static class ItemsViewExtension
{
    public static T EmptyViewFmg<T>(this T self, object emptyView) where T : ItemsView
    {
        self.SetValue(ItemsView.EmptyViewProperty, emptyView);
        return self;
    }

    public static T EmptyViewFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : ItemsView
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, ItemsView.EmptyViewProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EmptyViewFmg<T>(this SettersContext<T> self, object emptyView) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.EmptyViewProperty,
            Value = emptyView
        });
        return self;
    }

    public static SettersContext<T> EmptyViewFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : ItemsView
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, ItemsView.EmptyViewProperty);
        configure(arg).Build();
        return self;
    }

    public static T EmptyViewTemplateFmg<T>(this T self, DataTemplate emptyViewTemplate) where T : ItemsView
    {
        self.SetValue(ItemsView.EmptyViewTemplateProperty, emptyViewTemplate);
        return self;
    }

    public static T EmptyViewTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure) where T : ItemsView
    {
        PropertyContext<DataTemplate> arg = new PropertyContext<DataTemplate>(self, ItemsView.EmptyViewTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EmptyViewTemplateFmg<T>(this SettersContext<T> self, DataTemplate emptyViewTemplate) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.EmptyViewTemplateProperty,
            Value = emptyViewTemplate
        });
        return self;
    }

    public static SettersContext<T> EmptyViewTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure) where T : ItemsView
    {
        PropertySettersContext<DataTemplate> arg = new PropertySettersContext<DataTemplate>(self.XamlSetters, ItemsView.EmptyViewTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static T EmptyViewTemplateFmg<T>(this T self, Func<object> loadTemplate) where T : ItemsView
    {
        self.SetValue(ItemsView.EmptyViewTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, IEnumerable itemsSource) where T : ItemsView
    {
        self.SetValue(ItemsView.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : ItemsView
    {
        PropertyContext<IEnumerable> arg = new PropertyContext<IEnumerable>(self, ItemsView.ItemsSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, IEnumerable itemsSource) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.ItemsSourceProperty,
            Value = itemsSource
        });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable>, IPropertySettersBuilder<IEnumerable>> configure) where T : ItemsView
    {
        PropertySettersContext<IEnumerable> arg = new PropertySettersContext<IEnumerable>(self.XamlSetters, ItemsView.ItemsSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static T RemainingItemsThresholdReachedCommandFmg<T>(this T self, ICommand remainingItemsThresholdReachedCommand) where T : ItemsView
    {
        self.SetValue(ItemsView.RemainingItemsThresholdReachedCommandProperty, remainingItemsThresholdReachedCommand);
        return self;
    }

    public static T RemainingItemsThresholdReachedCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : ItemsView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, ItemsView.RemainingItemsThresholdReachedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RemainingItemsThresholdReachedCommandFmg<T>(this SettersContext<T> self, ICommand remainingItemsThresholdReachedCommand) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.RemainingItemsThresholdReachedCommandProperty,
            Value = remainingItemsThresholdReachedCommand
        });
        return self;
    }

    public static SettersContext<T> RemainingItemsThresholdReachedCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : ItemsView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, ItemsView.RemainingItemsThresholdReachedCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T RemainingItemsThresholdReachedCommandParameterFmg<T>(this T self, object remainingItemsThresholdReachedCommandParameter) where T : ItemsView
    {
        self.SetValue(ItemsView.RemainingItemsThresholdReachedCommandParameterProperty, remainingItemsThresholdReachedCommandParameter);
        return self;
    }

    public static T RemainingItemsThresholdReachedCommandParameterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : ItemsView
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, ItemsView.RemainingItemsThresholdReachedCommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RemainingItemsThresholdReachedCommandParameterFmg<T>(this SettersContext<T> self, object remainingItemsThresholdReachedCommandParameter) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.RemainingItemsThresholdReachedCommandParameterProperty,
            Value = remainingItemsThresholdReachedCommandParameter
        });
        return self;
    }

    public static SettersContext<T> RemainingItemsThresholdReachedCommandParameterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : ItemsView
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, ItemsView.RemainingItemsThresholdReachedCommandParameterProperty);
        configure(arg).Build();
        return self;
    }

    public static T HorizontalScrollBarVisibilityFmg<T>(this T self, ScrollBarVisibility horizontalScrollBarVisibility) where T : ItemsView
    {
        self.SetValue(ItemsView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
        return self;
    }

    public static T HorizontalScrollBarVisibilityFmg<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure) where T : ItemsView
    {
        PropertyContext<ScrollBarVisibility> arg = new PropertyContext<ScrollBarVisibility>(self, ItemsView.HorizontalScrollBarVisibilityProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HorizontalScrollBarVisibilityFmg<T>(this SettersContext<T> self, ScrollBarVisibility horizontalScrollBarVisibility) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.HorizontalScrollBarVisibilityProperty,
            Value = horizontalScrollBarVisibility
        });
        return self;
    }

    public static SettersContext<T> HorizontalScrollBarVisibilityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure) where T : ItemsView
    {
        PropertySettersContext<ScrollBarVisibility> arg = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ItemsView.HorizontalScrollBarVisibilityProperty);
        configure(arg).Build();
        return self;
    }

    public static T VerticalScrollBarVisibilityFmg<T>(this T self, ScrollBarVisibility verticalScrollBarVisibility) where T : ItemsView
    {
        self.SetValue(ItemsView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
        return self;
    }

    public static T VerticalScrollBarVisibilityFmg<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure) where T : ItemsView
    {
        PropertyContext<ScrollBarVisibility> arg = new PropertyContext<ScrollBarVisibility>(self, ItemsView.VerticalScrollBarVisibilityProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> VerticalScrollBarVisibilityFmg<T>(this SettersContext<T> self, ScrollBarVisibility verticalScrollBarVisibility) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.VerticalScrollBarVisibilityProperty,
            Value = verticalScrollBarVisibility
        });
        return self;
    }

    public static SettersContext<T> VerticalScrollBarVisibilityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure) where T : ItemsView
    {
        PropertySettersContext<ScrollBarVisibility> arg = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ItemsView.VerticalScrollBarVisibilityProperty);
        configure(arg).Build();
        return self;
    }

    public static T RemainingItemsThresholdFmg<T>(this T self, int remainingItemsThreshold) where T : ItemsView
    {
        self.SetValue(ItemsView.RemainingItemsThresholdProperty, remainingItemsThreshold);
        return self;
    }

    public static T RemainingItemsThresholdFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : ItemsView
    {
        PropertyContext<int> arg = new PropertyContext<int>(self, ItemsView.RemainingItemsThresholdProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RemainingItemsThresholdFmg<T>(this SettersContext<T> self, int remainingItemsThreshold) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.RemainingItemsThresholdProperty,
            Value = remainingItemsThreshold
        });
        return self;
    }

    public static SettersContext<T> RemainingItemsThresholdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : ItemsView
    {
        PropertySettersContext<int> arg = new PropertySettersContext<int>(self.XamlSetters, ItemsView.RemainingItemsThresholdProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, DataTemplate itemTemplate) where T : ItemsView
    {
        self.SetValue(ItemsView.ItemTemplateProperty, itemTemplate);
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure) where T : ItemsView
    {
        PropertyContext<DataTemplate> arg = new PropertyContext<DataTemplate>(self, ItemsView.ItemTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, DataTemplate itemTemplate) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.ItemTemplateProperty,
            Value = itemTemplate
        });
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure) where T : ItemsView
    {
        PropertySettersContext<DataTemplate> arg = new PropertySettersContext<DataTemplate>(self.XamlSetters, ItemsView.ItemTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, Func<object> loadTemplate) where T : ItemsView
    {
        self.SetValue(ItemsView.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }

    public static T ItemsUpdatingScrollModeFmg<T>(this T self, ItemsUpdatingScrollMode itemsUpdatingScrollMode) where T : ItemsView
    {
        self.SetValue(ItemsView.ItemsUpdatingScrollModeProperty, itemsUpdatingScrollMode);
        return self;
    }

    public static T ItemsUpdatingScrollModeFmg<T>(this T self, Func<PropertyContext<ItemsUpdatingScrollMode>, IPropertyBuilder<ItemsUpdatingScrollMode>> configure) where T : ItemsView
    {
        PropertyContext<ItemsUpdatingScrollMode> arg = new PropertyContext<ItemsUpdatingScrollMode>(self, ItemsView.ItemsUpdatingScrollModeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsUpdatingScrollModeFmg<T>(this SettersContext<T> self, ItemsUpdatingScrollMode itemsUpdatingScrollMode) where T : ItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ItemsView.ItemsUpdatingScrollModeProperty,
            Value = itemsUpdatingScrollMode
        });
        return self;
    }

    public static SettersContext<T> ItemsUpdatingScrollModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ItemsUpdatingScrollMode>, IPropertySettersBuilder<ItemsUpdatingScrollMode>> configure) where T : ItemsView
    {
        PropertySettersContext<ItemsUpdatingScrollMode> arg = new PropertySettersContext<ItemsUpdatingScrollMode>(self.XamlSetters, ItemsView.ItemsUpdatingScrollModeProperty);
        configure(arg).Build();
        return self;
    }

    public static T OnScrollToRequestedFmg<T>(this T self, EventHandler<ScrollToRequestEventArgs> handler) where T : ItemsView
    {
        self.ScrollToRequested += handler;
        return self;
    }

    public static T OnScrollToRequestedFmg<T>(this T self, Action<T> action) where T : ItemsView
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.ScrollToRequested += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnScrolledFmg<T>(this T self, EventHandler<ItemsViewScrolledEventArgs> handler) where T : ItemsView
    {
        self.Scrolled += handler;
        return self;
    }

    public static T OnScrolledFmg<T>(this T self, Action<T> action) where T : ItemsView
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Scrolled += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnRemainingItemsThresholdReachedFmg<T>(this T self, EventHandler handler) where T : ItemsView
    {
        self.RemainingItemsThresholdReached += handler;
        return self;
    }

    public static T OnRemainingItemsThresholdReachedFmg<T>(this T self, Action<T> action) where T : ItemsView
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.RemainingItemsThresholdReached += delegate
        {
            action2(self2);
        };
        return self2;
    }
}
