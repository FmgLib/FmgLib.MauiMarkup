namespace FmgLib.MauiMarkup;

public static partial class GroupableItemsViewExtension
{
    public static T IsGrouped<T>(this T self,
        bool isGrouped)
        where T : GroupableItemsView
    {
        self.SetValue(GroupableItemsView.IsGroupedProperty, isGrouped);
        return self;
    }
    
    public static T IsGrouped<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : GroupableItemsView
    {
        var context = new PropertyContext<bool>(self, GroupableItemsView.IsGroupedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsGrouped<T>(this SettersContext<T> self,
        bool isGrouped)
        where T : GroupableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = GroupableItemsView.IsGroupedProperty, Value = isGrouped });
        return self;
    }
    
    public static SettersContext<T> IsGrouped<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : GroupableItemsView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, GroupableItemsView.IsGroupedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T GroupHeaderTemplate<T>(this T self,
        DataTemplate groupHeaderTemplate)
        where T : GroupableItemsView
    {
        self.SetValue(GroupableItemsView.GroupHeaderTemplateProperty, groupHeaderTemplate);
        return self;
    }
    
    public static T GroupHeaderTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : GroupableItemsView
    {
        var context = new PropertyContext<DataTemplate>(self, GroupableItemsView.GroupHeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> GroupHeaderTemplate<T>(this SettersContext<T> self,
        DataTemplate groupHeaderTemplate)
        where T : GroupableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = GroupableItemsView.GroupHeaderTemplateProperty, Value = groupHeaderTemplate });
        return self;
    }
    
    public static SettersContext<T> GroupHeaderTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : GroupableItemsView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, GroupableItemsView.GroupHeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T GroupHeaderTemplate<T>(this T self, Func<object> loadTemplate)
        where T : GroupableItemsView
    {
        self.SetValue(GroupableItemsView.GroupHeaderTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T GroupFooterTemplate<T>(this T self,
        DataTemplate groupFooterTemplate)
        where T : GroupableItemsView
    {
        self.SetValue(GroupableItemsView.GroupFooterTemplateProperty, groupFooterTemplate);
        return self;
    }
    
    public static T GroupFooterTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : GroupableItemsView
    {
        var context = new PropertyContext<DataTemplate>(self, GroupableItemsView.GroupFooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> GroupFooterTemplate<T>(this SettersContext<T> self,
        DataTemplate groupFooterTemplate)
        where T : GroupableItemsView
    {
        self.XamlSetters.Add(new Setter { Property = GroupableItemsView.GroupFooterTemplateProperty, Value = groupFooterTemplate });
        return self;
    }
    
    public static SettersContext<T> GroupFooterTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : GroupableItemsView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, GroupableItemsView.GroupFooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T GroupFooterTemplate<T>(this T self, Func<object> loadTemplate)
        where T : GroupableItemsView
    {
        self.SetValue(GroupableItemsView.GroupFooterTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
}