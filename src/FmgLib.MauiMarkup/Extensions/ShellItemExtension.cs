namespace FmgLib.MauiMarkup;



public static partial class ShellItemExtension
{
    public static T CurrentItem<T>(this T self,
        ShellSection currentItem)
        where T : ShellItem
    {
        self.SetValue(ShellItem.CurrentItemProperty, currentItem);
        return self;
    }
    
    public static T CurrentItem<T>(this T self, Func<PropertyContext<ShellSection>, IPropertyBuilder<ShellSection>> configure)
        where T : ShellItem
    {
        var context = new PropertyContext<ShellSection>(self, ShellItem.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CurrentItem<T>(this SettersContext<T> self,
        ShellSection currentItem)
        where T : ShellItem
    {
        self.XamlSetters.Add(new Setter { Property = ShellItem.CurrentItemProperty, Value = currentItem });
        return self;
    }
    
    public static SettersContext<T> CurrentItem<T>(this SettersContext<T> self, Func<PropertySettersContext<ShellSection>, IPropertySettersBuilder<ShellSection>> configure)
        where T : ShellItem
    {
        var context = new PropertySettersContext<ShellSection>(self.XamlSetters, ShellItem.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Items<T>(this T self,
        IList<ShellSection> items)
        where T : ShellItem
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }

    public static T Items<T>(this T self,
        params ShellSection[] items)
        where T : ShellItem
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }

    public static T Items<T>(this T self,
        Func<ShellSection[]> configure)
        where T : ShellItem
    {
        var items = configure();
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }
    
    public static T Items<T>(this T self, Func<PropertyContext<IList<ShellSection>>, IPropertyBuilder<IList<ShellSection>>> configure)
        where T : ShellItem
    {
        var context = new PropertyContext<IList<ShellSection>>(self, ShellItem.ItemsProperty);
        configure(context).Build();
        return self;
    }
    
}