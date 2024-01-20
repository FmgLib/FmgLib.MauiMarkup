namespace FmgLib.MauiMarkup;



public static partial class ReorderableItemsViewExtension
{
    public static T CanMixGroupsFmg<T>(this T self,
        bool canMixGroups)
        where T : ReorderableItemsView
    {
        self.SetValue(ReorderableItemsView.CanMixGroupsProperty, canMixGroups);
        return self;
    }
    
    public static T CanMixGroupsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ReorderableItemsView
    {
        var context = new PropertyContext<bool>(self, ReorderableItemsView.CanMixGroupsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanMixGroupsFmg<T>(this SettersContext<T> self,
        bool canMixGroups)
        where T : ReorderableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ReorderableItemsView.CanMixGroupsProperty, Value = canMixGroups });
        return self;
    }
    
    public static SettersContext<T> CanMixGroupsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ReorderableItemsView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ReorderableItemsView.CanMixGroupsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CanReorderItemsFmg<T>(this T self,
        bool canReorderItems)
        where T : ReorderableItemsView
    {
        self.SetValue(ReorderableItemsView.CanReorderItemsProperty, canReorderItems);
        return self;
    }
    
    public static T CanReorderItemsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ReorderableItemsView
    {
        var context = new PropertyContext<bool>(self, ReorderableItemsView.CanReorderItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanReorderItemsFmg<T>(this SettersContext<T> self,
        bool canReorderItems)
        where T : ReorderableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = ReorderableItemsView.CanReorderItemsProperty, Value = canReorderItems });
        return self;
    }
    
    public static SettersContext<T> CanReorderItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ReorderableItemsView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ReorderableItemsView.CanReorderItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnReorderCompletedFmg<T>(this T self, EventHandler handler)
        where T : ReorderableItemsView
    {
        self.ReorderCompleted += handler;
        return self;
    }
    
    public static T OnReorderCompletedFmg<T>(this T self, Action<T> action)
        where T : ReorderableItemsView
    {
        self.ReorderCompleted += (o, arg) => action(self);
        return self;
    }
    
}
