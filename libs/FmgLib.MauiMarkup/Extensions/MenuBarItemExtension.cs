namespace FmgLib.MauiMarkup;



public static partial class MenuBarItemExtension
{
    public static T Priority<T>(this T self,
        int priority)
        where T : MenuBarItem
    {
        self.Priority = priority;
        return self;
    }
    
    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : MenuBarItem
    {
        self.SetValue(MenuBarItem.IsEnabledProperty, isEnabled);
        return self;
    }
    
    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MenuBarItem
    {
        var context = new PropertyContext<bool>(self, MenuBarItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : MenuBarItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuBarItem.IsEnabledProperty, Value = isEnabled });
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MenuBarItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MenuBarItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Text<T>(this T self,
        string text)
        where T : MenuBarItem
    {
        self.SetValue(MenuBarItem.TextProperty, text);
        return self;
    }
    
    public static T Text<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : MenuBarItem
    {
        var context = new PropertyContext<string>(self, MenuBarItem.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self,
        string text)
        where T : MenuBarItem
    {
        self.XamlSetters.Add(new Setter { Property = MenuBarItem.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> Text<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : MenuBarItem
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, MenuBarItem.TextProperty);
        configure(context).Build();
        return self;
    }
    
}
