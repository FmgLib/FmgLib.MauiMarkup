namespace FmgLib.MauiMarkup;



public static partial class StructuredItemsViewExtension
{
    public static T Header<T>(this T self,
        Func<object> configure)
        where T : StructuredItemsView
    {
        var header = configure();
        self.SetValue(StructuredItemsView.HeaderProperty, header);
        return self;
    }

    public static T Header<T>(this T self,
        object header)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.HeaderProperty, header);
        return self;
    }
    
    public static T Header<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertyContext<object>(self, StructuredItemsView.HeaderProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Header<T>(this SettersContext<T> self,
        object header)
        where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter { Property = StructuredItemsView.HeaderProperty, Value = header });
        return self;
    }
    
    public static SettersContext<T> Header<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, StructuredItemsView.HeaderProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HeaderTemplate<T>(this T self,
        DataTemplate headerTemplate)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.HeaderTemplateProperty, headerTemplate);
        return self;
    }
    
    public static T HeaderTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertyContext<DataTemplate>(self, StructuredItemsView.HeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HeaderTemplate<T>(this SettersContext<T> self,
        DataTemplate headerTemplate)
        where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter { Property = StructuredItemsView.HeaderTemplateProperty, Value = headerTemplate });
        return self;
    }
    
    public static SettersContext<T> HeaderTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, StructuredItemsView.HeaderTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HeaderTemplate<T>(this T self, Func<object> loadTemplate)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.HeaderTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T Footer<T>(this T self,
        Func<object> configure)
        where T : StructuredItemsView
    {
        var footer = configure();
        self.SetValue(StructuredItemsView.FooterProperty, footer);
        return self;
    }
    
    public static T Footer<T>(this T self,
        object footer)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.FooterProperty, footer);
        return self;
    }
    
    public static T Footer<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertyContext<object>(self, StructuredItemsView.FooterProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Footer<T>(this SettersContext<T> self,
        object footer)
        where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter { Property = StructuredItemsView.FooterProperty, Value = footer });
        return self;
    }
    
    public static SettersContext<T> Footer<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, StructuredItemsView.FooterProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FooterTemplate<T>(this T self,
        DataTemplate footerTemplate)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.FooterTemplateProperty, footerTemplate);
        return self;
    }
    
    public static T FooterTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertyContext<DataTemplate>(self, StructuredItemsView.FooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FooterTemplate<T>(this SettersContext<T> self,
        DataTemplate footerTemplate)
        where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter { Property = StructuredItemsView.FooterTemplateProperty, Value = footerTemplate });
        return self;
    }
    
    public static SettersContext<T> FooterTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, StructuredItemsView.FooterTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FooterTemplate<T>(this T self, Func<object> loadTemplate)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.FooterTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T ItemsLayout<T>(this T self,
        IItemsLayout itemsLayout)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.ItemsLayoutProperty, itemsLayout);
        return self;
    }
    
    public static T ItemsLayout<T>(this T self, Func<PropertyContext<IItemsLayout>, IPropertyBuilder<IItemsLayout>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertyContext<IItemsLayout>(self, StructuredItemsView.ItemsLayoutProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsLayout<T>(this SettersContext<T> self,
        IItemsLayout itemsLayout)
        where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter { Property = StructuredItemsView.ItemsLayoutProperty, Value = itemsLayout });
        return self;
    }
    
    public static SettersContext<T> ItemsLayout<T>(this SettersContext<T> self, Func<PropertySettersContext<IItemsLayout>, IPropertySettersBuilder<IItemsLayout>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertySettersContext<IItemsLayout>(self.XamlSetters, StructuredItemsView.ItemsLayoutProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemSizingStrategy<T>(this T self,
        ItemSizingStrategy itemSizingStrategy)
        where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.ItemSizingStrategyProperty, itemSizingStrategy);
        return self;
    }
    
    public static T ItemSizingStrategy<T>(this T self, Func<PropertyContext<ItemSizingStrategy>, IPropertyBuilder<ItemSizingStrategy>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertyContext<ItemSizingStrategy>(self, StructuredItemsView.ItemSizingStrategyProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemSizingStrategy<T>(this SettersContext<T> self,
        ItemSizingStrategy itemSizingStrategy)
        where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter { Property = StructuredItemsView.ItemSizingStrategyProperty, Value = itemSizingStrategy });
        return self;
    }
    
    public static SettersContext<T> ItemSizingStrategy<T>(this SettersContext<T> self, Func<PropertySettersContext<ItemSizingStrategy>, IPropertySettersBuilder<ItemSizingStrategy>> configure)
        where T : StructuredItemsView
    {
        var context = new PropertySettersContext<ItemSizingStrategy>(self.XamlSetters, StructuredItemsView.ItemSizingStrategyProperty);
        configure(context).Build();
        return self;
    }
    
}
