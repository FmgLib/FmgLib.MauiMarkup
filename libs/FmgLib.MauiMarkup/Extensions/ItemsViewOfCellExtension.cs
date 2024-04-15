namespace FmgLib.MauiMarkup;



public static partial class ItemsViewOfCellExtension
{
    public static T ItemsSource<T>(this T self,
        System.Collections.IEnumerable itemsSource)
        where T : ItemsView<Cell>
    {
        self.SetValue(ItemsView<Cell>.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
        where T : ItemsView<Cell>
    {
        var context = new PropertyContext<System.Collections.IEnumerable>(self, ItemsView<Cell>.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self,
        System.Collections.IEnumerable itemsSource)
        where T : ItemsView<Cell>
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView<Cell>.ItemsSourceProperty, Value = itemsSource });
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IEnumerable>, IPropertySettersBuilder<System.Collections.IEnumerable>> configure)
        where T : ItemsView<Cell>
    {
        var context = new PropertySettersContext<System.Collections.IEnumerable>(self.XamlSetters, ItemsView<Cell>.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self,
        DataTemplate itemTemplate)
        where T : ItemsView<Cell>
    {
        self.SetValue(ItemsView<Cell>.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : ItemsView<Cell>
    {
        var context = new PropertyContext<DataTemplate>(self, ItemsView<Cell>.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : ItemsView<Cell>
    {
        self.XamlSetters.Add(new Setter { Property = ItemsView<Cell>.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : ItemsView<Cell>
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, ItemsView<Cell>.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<object> loadTemplate)
        where T : ItemsView<Cell>
    {
        self.SetValue(ItemsView<Cell>.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
}
