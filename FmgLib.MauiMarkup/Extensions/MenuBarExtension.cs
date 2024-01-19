namespace FmgLib.MauiMarkup;



public static partial class MenuBarExtension
{
    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : MenuBar
    {
        self.SetValue(MenuBar.IsEnabledProperty, isEnabled);
        return self;
    }
    
    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : MenuBar
    {
        var context = new PropertyContext<bool>(self, MenuBar.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : MenuBar
    {
        self.XamlSetters.Add(new Setter { Property = MenuBar.IsEnabledProperty, Value = isEnabled });
        return self;
    }
    
    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : MenuBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, MenuBar.IsEnabledProperty);
        configure(context).Build();
        return self;
    }
    
}
