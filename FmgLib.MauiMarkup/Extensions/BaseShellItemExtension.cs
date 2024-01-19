namespace FmgLib.MauiMarkup;

public static partial class BaseShellItemExtension
{
    public static T FlyoutIcon<T>(this T self,
       ImageSource flyoutIcon)
       where T : BaseShellItem
    {
        self.SetValue(BaseShellItem.FlyoutIconProperty, flyoutIcon);
        return self;
    }

    public static T FlyoutIcon<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : BaseShellItem
    {
        var context = new PropertyContext<ImageSource>(self, BaseShellItem.FlyoutIconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FlyoutIcon<T>(this SettersContext<T> self,
        ImageSource flyoutIcon)
        where T : BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = BaseShellItem.FlyoutIconProperty, Value = flyoutIcon });
        return self;
    }

    public static SettersContext<T> FlyoutIcon<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : BaseShellItem
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, BaseShellItem.FlyoutIconProperty);
        configure(context).Build();
        return self;
    }

    public static T Icon<T>(this T self,
        ImageSource icon)
        where T : BaseShellItem
    {
        self.SetValue(BaseShellItem.IconProperty, icon);
        return self;
    }

    public static T Icon<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : BaseShellItem
    {
        var context = new PropertyContext<ImageSource>(self, BaseShellItem.IconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Icon<T>(this SettersContext<T> self,
        ImageSource icon)
        where T : BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = BaseShellItem.IconProperty, Value = icon });
        return self;
    }

    public static SettersContext<T> Icon<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : BaseShellItem
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, BaseShellItem.IconProperty);
        configure(context).Build();
        return self;
    }

    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : BaseShellItem
    {
        self.SetValue(BaseShellItem.IsEnabledProperty, isEnabled);
        return self;
    }

    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BaseShellItem
    {
        var context = new PropertyContext<bool>(self, BaseShellItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = BaseShellItem.IsEnabledProperty, Value = isEnabled });
        return self;
    }

    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BaseShellItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BaseShellItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T Route<T>(this T self,
        string route)
        where T : BaseShellItem
    {
        self.Route = route;
        return self;
    }

    public static T Title<T>(this T self,
        string title)
        where T : BaseShellItem
    {
        self.SetValue(BaseShellItem.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : BaseShellItem
    {
        var context = new PropertyContext<string>(self, BaseShellItem.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = BaseShellItem.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : BaseShellItem
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, BaseShellItem.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T IsVisible<T>(this T self,
        bool isVisible)
        where T : BaseShellItem
    {
        self.SetValue(BaseShellItem.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : BaseShellItem
    {
        var context = new PropertyContext<bool>(self, BaseShellItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self,
        bool isVisible)
        where T : BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = BaseShellItem.IsVisibleProperty, Value = isVisible });
        return self;
    }

    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : BaseShellItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, BaseShellItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static T FlyoutItemIsVisible<T>(this T self,
        bool flyoutItemIsVisible)
        where T : BaseShellItem
    {
        self.FlyoutItemIsVisible = flyoutItemIsVisible;
        return self;
    }

    public static T OnAppearing<T>(this T self, EventHandler handler)
        where T : BaseShellItem
    {
        self.Appearing += handler;
        return self;
    }

    public static T OnAppearing<T>(this T self, Action<T> action)
        where T : BaseShellItem
    {
        self.Appearing += (o, arg) => action(self);
        return self;
    }

    public static T OnDisappearing<T>(this T self, EventHandler handler)
        where T : BaseShellItem
    {
        self.Disappearing += handler;
        return self;
    }

    public static T OnDisappearing<T>(this T self, Action<T> action)
        where T : BaseShellItem
    {
        self.Disappearing += (o, arg) => action(self);
        return self;
    }

    public static T ShellItemTemplate<T>(this T self,
        DataTemplate shellItemTemplate)
        where T : BaseShellItem
    {
        self.SetValue(Shell.ItemTemplateProperty, shellItemTemplate);
        return self;
    }
    
    public static T ShellItemTemplate<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : BaseShellItem
    {
        var context = new PropertyContext<DataTemplate>(self, Shell.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellItemTemplate<T>(this SettersContext<T> self,
        DataTemplate shellItemTemplate)
        where T : BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Shell.ItemTemplateProperty, Value = shellItemTemplate });
        return self;
    }
    
    public static SettersContext<T> ShellItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : BaseShellItem
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, Shell.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T ShellItemTemplate<T>(this T self, Func<object> loadTemplate)
        where T : BaseShellItem
    {
        self.SetValue(Shell.ItemTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static DataTemplate GetShellItemTemplateValue<T>(this T self)
        where T : BaseShellItem
    {
        return (DataTemplate)self.GetValue(Shell.ItemTemplateProperty);
    }
    
}