namespace FmgLib.MauiMarkup;



public static partial class ShellSectionExtension
{
    public static T CurrentItem<T>(this T self,
        ShellContent currentItem)
        where T : ShellSection
    {
        self.SetValue(ShellSection.CurrentItemProperty, currentItem);
        return self;
    }
    
    public static T CurrentItem<T>(this T self, Func<PropertyContext<ShellContent>, IPropertyBuilder<ShellContent>> configure)
        where T : ShellSection
    {
        var context = new PropertyContext<ShellContent>(self, ShellSection.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CurrentItem<T>(this SettersContext<T> self,
        ShellContent currentItem)
        where T : ShellSection
    {
        self.XamlSetters.Add(new Setter { Property = ShellSection.CurrentItemProperty, Value = currentItem });
        return self;
    }
    
    public static SettersContext<T> CurrentItem<T>(this SettersContext<T> self, Func<PropertySettersContext<ShellContent>, IPropertySettersBuilder<ShellContent>> configure)
        where T : ShellSection
    {
        var context = new PropertySettersContext<ShellContent>(self.XamlSetters, ShellSection.CurrentItemProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Items<T>(this T self,
        IList<ShellContent> items)
        where T : ShellSection
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }

    public static T Items<T>(this T self,
        params ShellContent[] items)
        where T : ShellSection
    {
        foreach (var item in items)
            self.Items.Add(item);
        return self;
    }
    
    public static T Items<T>(this T self, Func<PropertyContext<IList<ShellContent>>, IPropertyBuilder<IList<ShellContent>>> configure)
        where T : ShellSection
    {
        var context = new PropertyContext<IList<ShellContent>>(self, ShellSection.ItemsProperty);
        configure(context).Build();
        return self;
    }
    
}
