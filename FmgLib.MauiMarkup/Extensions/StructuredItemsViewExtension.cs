namespace FmgLib.MauiMarkup;

public static class StructuredItemsViewExtension
{
    public static T HeaderFmg<T>(this T self, object header) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.HeaderProperty, header);
        return self;
    }

    public static T HeaderFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : StructuredItemsView
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, StructuredItemsView.HeaderProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HeaderFmg<T>(this SettersContext<T> self, object header) where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StructuredItemsView.HeaderProperty,
            Value = header
        });
        return self;
    }

    public static SettersContext<T> HeaderFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : StructuredItemsView
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, StructuredItemsView.HeaderProperty);
        configure(arg).Build();
        return self;
    }

    public static T HeaderTemplateFmg<T>(this T self, DataTemplate headerTemplate) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.HeaderTemplateProperty, headerTemplate);
        return self;
    }

    public static T HeaderTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure) where T : StructuredItemsView
    {
        PropertyContext<DataTemplate> arg = new PropertyContext<DataTemplate>(self, StructuredItemsView.HeaderTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HeaderTemplateFmg<T>(this SettersContext<T> self, DataTemplate headerTemplate) where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StructuredItemsView.HeaderTemplateProperty,
            Value = headerTemplate
        });
        return self;
    }

    public static SettersContext<T> HeaderTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure) where T : StructuredItemsView
    {
        PropertySettersContext<DataTemplate> arg = new PropertySettersContext<DataTemplate>(self.XamlSetters, StructuredItemsView.HeaderTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static T HeaderTemplateFmg<T>(this T self, Func<object> loadTemplate) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.HeaderTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }

    public static T FooterFmg<T>(this T self, object footer) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.FooterProperty, footer);
        return self;
    }

    public static T FooterFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : StructuredItemsView
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, StructuredItemsView.FooterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FooterFmg<T>(this SettersContext<T> self, object footer) where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StructuredItemsView.FooterProperty,
            Value = footer
        });
        return self;
    }

    public static SettersContext<T> FooterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : StructuredItemsView
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, StructuredItemsView.FooterProperty);
        configure(arg).Build();
        return self;
    }

    public static T FooterTemplateFmg<T>(this T self, DataTemplate footerTemplate) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.FooterTemplateProperty, footerTemplate);
        return self;
    }

    public static T FooterTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure) where T : StructuredItemsView
    {
        PropertyContext<DataTemplate> arg = new PropertyContext<DataTemplate>(self, StructuredItemsView.FooterTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FooterTemplateFmg<T>(this SettersContext<T> self, DataTemplate footerTemplate) where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StructuredItemsView.FooterTemplateProperty,
            Value = footerTemplate
        });
        return self;
    }

    public static SettersContext<T> FooterTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure) where T : StructuredItemsView
    {
        PropertySettersContext<DataTemplate> arg = new PropertySettersContext<DataTemplate>(self.XamlSetters, StructuredItemsView.FooterTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static T FooterTemplateFmg<T>(this T self, Func<object> loadTemplate) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.FooterTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }

    public static T ItemsLayoutFmg<T>(this T self, IItemsLayout itemsLayout) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.ItemsLayoutProperty, itemsLayout);
        return self;
    }

    public static T ItemsLayoutFmg<T>(this T self, Func<PropertyContext<IItemsLayout>, IPropertyBuilder<IItemsLayout>> configure) where T : StructuredItemsView
    {
        PropertyContext<IItemsLayout> arg = new PropertyContext<IItemsLayout>(self, StructuredItemsView.ItemsLayoutProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsLayoutFmg<T>(this SettersContext<T> self, IItemsLayout itemsLayout) where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StructuredItemsView.ItemsLayoutProperty,
            Value = itemsLayout
        });
        return self;
    }

    public static SettersContext<T> ItemsLayoutFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IItemsLayout>, IPropertySettersBuilder<IItemsLayout>> configure) where T : StructuredItemsView
    {
        PropertySettersContext<IItemsLayout> arg = new PropertySettersContext<IItemsLayout>(self.XamlSetters, StructuredItemsView.ItemsLayoutProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemSizingStrategyFmg<T>(this T self, ItemSizingStrategy itemSizingStrategy) where T : StructuredItemsView
    {
        self.SetValue(StructuredItemsView.ItemSizingStrategyProperty, itemSizingStrategy);
        return self;
    }

    public static T ItemSizingStrategyFmg<T>(this T self, Func<PropertyContext<ItemSizingStrategy>, IPropertyBuilder<ItemSizingStrategy>> configure) where T : StructuredItemsView
    {
        PropertyContext<ItemSizingStrategy> arg = new PropertyContext<ItemSizingStrategy>(self, StructuredItemsView.ItemSizingStrategyProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemSizingStrategyFmg<T>(this SettersContext<T> self, ItemSizingStrategy itemSizingStrategy) where T : StructuredItemsView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StructuredItemsView.ItemSizingStrategyProperty,
            Value = itemSizingStrategy
        });
        return self;
    }

    public static SettersContext<T> ItemSizingStrategyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ItemSizingStrategy>, IPropertySettersBuilder<ItemSizingStrategy>> configure) where T : StructuredItemsView
    {
        PropertySettersContext<ItemSizingStrategy> arg = new PropertySettersContext<ItemSizingStrategy>(self.XamlSetters, StructuredItemsView.ItemSizingStrategyProperty);
        configure(arg).Build();
        return self;
    }
}
