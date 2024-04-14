namespace FmgLib.MauiMarkup;



public static partial class SwipeItemsExtension
{
    public static T Mode<T>(this T self,
        SwipeMode mode)
        where T : SwipeItems
    {
        self.SetValue(SwipeItems.ModeProperty, mode);
        return self;
    }
    
    public static T Mode<T>(this T self, Func<PropertyContext<SwipeMode>, IPropertyBuilder<SwipeMode>> configure)
        where T : SwipeItems
    {
        var context = new PropertyContext<SwipeMode>(self, SwipeItems.ModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Mode<T>(this SettersContext<T> self,
        SwipeMode mode)
        where T : SwipeItems
    {
        self.XamlSetters.Add(new Setter { Property = SwipeItems.ModeProperty, Value = mode });
        return self;
    }
    
    public static SettersContext<T> Mode<T>(this SettersContext<T> self, Func<PropertySettersContext<SwipeMode>, IPropertySettersBuilder<SwipeMode>> configure)
        where T : SwipeItems
    {
        var context = new PropertySettersContext<SwipeMode>(self.XamlSetters, SwipeItems.ModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SwipeBehaviorOnInvoked<T>(this T self,
        SwipeBehaviorOnInvoked swipeBehaviorOnInvoked)
        where T : SwipeItems
    {
        self.SetValue(SwipeItems.SwipeBehaviorOnInvokedProperty, swipeBehaviorOnInvoked);
        return self;
    }
    
    public static T SwipeBehaviorOnInvoked<T>(this T self, Func<PropertyContext<SwipeBehaviorOnInvoked>, IPropertyBuilder<SwipeBehaviorOnInvoked>> configure)
        where T : SwipeItems
    {
        var context = new PropertyContext<SwipeBehaviorOnInvoked>(self, SwipeItems.SwipeBehaviorOnInvokedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SwipeBehaviorOnInvoked<T>(this SettersContext<T> self,
        SwipeBehaviorOnInvoked swipeBehaviorOnInvoked)
        where T : SwipeItems
    {
        self.XamlSetters.Add(new Setter { Property = SwipeItems.SwipeBehaviorOnInvokedProperty, Value = swipeBehaviorOnInvoked });
        return self;
    }
    
    public static SettersContext<T> SwipeBehaviorOnInvoked<T>(this SettersContext<T> self, Func<PropertySettersContext<SwipeBehaviorOnInvoked>, IPropertySettersBuilder<SwipeBehaviorOnInvoked>> configure)
        where T : SwipeItems
    {
        var context = new PropertySettersContext<SwipeBehaviorOnInvoked>(self.XamlSetters, SwipeItems.SwipeBehaviorOnInvokedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnCollectionChanged<T>(this T self, System.Collections.Specialized.NotifyCollectionChangedEventHandler handler)
        where T : SwipeItems
    {
        self.CollectionChanged += handler;
        return self;
    }
    
    public static T OnCollectionChanged<T>(this T self, Action<T> action)
        where T : SwipeItems
    {
        self.CollectionChanged += (o, arg) => action(self);
        return self;
    }
    
}
