namespace FmgLib.MauiMarkup;

public static partial class BaseShellItemExtension
{
    public static T FlyoutIcon<T>(this T self,
        Microsoft.Maui.Controls.ImageSource flyoutIcon)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, flyoutIcon);
        return self;
    }

    public static T FlyoutIcon<T>(this T self,
        Func<Microsoft.Maui.Controls.ImageSource> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var flyoutIcon = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, flyoutIcon);
        return self;
    }

    public static T FlyoutIcon<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FlyoutIcon<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource flyoutIcon)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty, Value = flyoutIcon });
        return self;
    }

    public static SettersContext<T> FlyoutIcon<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.FlyoutIconProperty);
        configure(context).Build();
        return self;
    }

    public static T Icon<T>(this T self,
        Microsoft.Maui.Controls.ImageSource icon)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IconProperty, icon);
        return self;
    }

    public static T Icon<T>(this T self,
        Func<Microsoft.Maui.Controls.ImageSource> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var icon = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IconProperty, icon);
        return self;
    }

    public static T Icon<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.BaseShellItem.IconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Icon<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource icon)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.IconProperty, Value = icon });
        return self;
    }

    public static SettersContext<T> Icon<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.IconProperty);
        configure(context).Build();
        return self;
    }

    public static T IsChecked<T>(this T self,
        bool isChecked)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty, isChecked);
        return self;
    }

    public static T IsChecked<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var isChecked = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty, isChecked);
        return self;
    }

    public static T IsChecked<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsChecked<T>(this SettersContext<T> self,
        bool isChecked)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty, Value = isChecked });
        return self;
    }

    public static SettersContext<T> IsChecked<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static T IsEnabled<T>(this T self,
        bool isEnabled)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, isEnabled);
        return self;
    }

    public static T IsEnabled<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var isEnabled = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, isEnabled);
        return self;
    }

    public static T IsEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self,
        bool isEnabled)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty, Value = isEnabled });
        return self;
    }

    public static SettersContext<T> IsEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.IsEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T IsVisible<T>(this T self,
        bool isVisible)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisible<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var isVisible = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self,
        bool isVisible)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty, Value = isVisible });
        return self;
    }

    public static SettersContext<T> IsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static T Title<T>(this T self,
        string title)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var title = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.BaseShellItem.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T Window<T>(this T self,
        Microsoft.Maui.Controls.Window window)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.WindowProperty, window);
        return self;
    }

    public static T Window<T>(this T self,
        Func<Microsoft.Maui.Controls.Window> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var window = configure();
        self.SetValue(Microsoft.Maui.Controls.BaseShellItem.WindowProperty, window);
        return self;
    }

    public static T Window<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Window>, IPropertyBuilder<Microsoft.Maui.Controls.Window>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Window>(self, Microsoft.Maui.Controls.BaseShellItem.WindowProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Window<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Window window)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BaseShellItem.WindowProperty, Value = window });
        return self;
    }

    public static SettersContext<T> Window<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Window>, IPropertySettersBuilder<Microsoft.Maui.Controls.Window>> configure)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Window>(self.XamlSetters, Microsoft.Maui.Controls.BaseShellItem.WindowProperty);
        configure(context).Build();
        return self;
    }

    public static T OnAppearing<T>(this T self, System.EventHandler handler)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.Appearing += handler;
        return self;
    }

    public static T OnAppearing<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.Appearing += (o, arg) => action(self);
        return self;
    }

    public static T OnDisappearing<T>(this T self, System.EventHandler handler)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.Disappearing += handler;
        return self;
    }

    public static T OnDisappearing<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.BaseShellItem
    {
        self.Disappearing += (o, arg) => action(self);
        return self;
    }

}