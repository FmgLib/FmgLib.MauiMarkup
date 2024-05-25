namespace FmgLib.MauiMarkup;



public static partial class MultiPageOfPageExtension
{
    public static T ItemsSource<T>(this T self,
        Func<System.Collections.IEnumerable> configure)
        where T : MultiPage<Page>
    {
        var itemsSource = configure();
        self.SetValue(MultiPage<Page>.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSource<T>(this T self,
        System.Collections.IEnumerable itemsSource)
        where T : MultiPage<Page>
    {
        self.SetValue(MultiPage<Page>.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSource<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
        where T : MultiPage<Page>
    {
        var context = new PropertyContext<System.Collections.IEnumerable>(self, MultiPage<Page>.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self,
        System.Collections.IEnumerable itemsSource)
        where T : MultiPage<Page>
    {
        self.XamlSetters.Add(new Setter { Property = MultiPage<Page>.ItemsSourceProperty, Value = itemsSource });
        return self;
    }
    
    public static SettersContext<T> ItemsSource<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IEnumerable>, IPropertySettersBuilder<System.Collections.IEnumerable>> configure)
        where T : MultiPage<Page>
    {
        var context = new PropertySettersContext<System.Collections.IEnumerable>(self.XamlSetters, MultiPage<Page>.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self,
        Func<DataTemplate> configure)
        where T : MultiPage<Page>
    {
        var itemTemplate = configure();
        self.SetValue(MultiPage<Page>.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplate<T>(this T self,
        DataTemplate itemTemplate)
        where T : MultiPage<Page>
    {
        self.SetValue(MultiPage<Page>.ItemTemplateProperty, itemTemplate);
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : MultiPage<Page>
    {
        var context = new PropertyContext<DataTemplate>(self, MultiPage<Page>.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : MultiPage<Page>
    {
        self.XamlSetters.Add(new Setter { Property = MultiPage<Page>.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }
    
    public static SettersContext<T> ItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : MultiPage<Page>
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, MultiPage<Page>.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ItemTemplate<T>(this T self, Func<object> loadTemplate)
        where T : MultiPage<Page>
    {
        self.SetValue(MultiPage<Page>.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T SelectedItem<T>(this T self,
        Func<object> configure)
        where T : MultiPage<Page>
    {
        var selectedItem = configure();
        self.SetValue(MultiPage<Page>.SelectedItemProperty, selectedItem);
        return self;
    }
    
    public static T SelectedItem<T>(this T self,
        object selectedItem)
        where T : MultiPage<Page>
    {
        self.SetValue(MultiPage<Page>.SelectedItemProperty, selectedItem);
        return self;
    }
    
    public static T SelectedItem<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : MultiPage<Page>
    {
        var context = new PropertyContext<object>(self, MultiPage<Page>.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self,
        object selectedItem)
        where T : MultiPage<Page>
    {
        self.XamlSetters.Add(new Setter { Property = MultiPage<Page>.SelectedItemProperty, Value = selectedItem });
        return self;
    }
    
    public static SettersContext<T> SelectedItem<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : MultiPage<Page>
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, MultiPage<Page>.SelectedItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CurrentPage<T>(this T self,
        Func<Page> configure)
        where T : MultiPage<Page>
    {
        var currentPage = configure();
        self.CurrentPage = currentPage;
        return self;
    }
    
    public static T CurrentPage<T>(this T self,
        Page currentPage)
        where T : MultiPage<Page>
    {
        self.CurrentPage = currentPage;
        return self;
    }
    
    public static T Children<T>(this T self,
        IList<Page> children)
        where T : MultiPage<Page>
    {
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }

    public static T Children<T>(this T self,
        params Page[] children)
        where T : MultiPage<Page>
    {
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }

    public static T Children<T>(this T self,
        Func<Page[]> configure)
        where T : MultiPage<Page>
    {
        var children = configure();
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }
    
    public static T OnCurrentPageChanged<T>(this T self, EventHandler handler)
        where T : MultiPage<Page>
    {
        self.CurrentPageChanged += handler;
        return self;
    }
    
    public static T OnCurrentPageChanged<T>(this T self, Action<T> action)
        where T : MultiPage<Page>
    {
        self.CurrentPageChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPagesChanged<T>(this T self, System.Collections.Specialized.NotifyCollectionChangedEventHandler handler)
        where T : MultiPage<Page>
    {
        self.PagesChanged += handler;
        return self;
    }
    
    public static T OnPagesChanged<T>(this T self, Action<T> action)
        where T : MultiPage<Page>
    {
        self.PagesChanged += (o, arg) => action(self);
        return self;
    }
    
}
