namespace FmgLib.MauiMarkup;

public static class ShellGroupItemExtension
{
    public static T FlyoutDisplayOptions<T>(this T self, FlyoutDisplayOptions flyoutDisplayOptions) where T : ShellGroupItem
    {
        self.SetValue(ShellGroupItem.FlyoutDisplayOptionsProperty, flyoutDisplayOptions);
        return self;
    }

    public static T FlyoutDisplayOptions<T>(this T self, Func<PropertyContext<FlyoutDisplayOptions>, IPropertyBuilder<FlyoutDisplayOptions>> configure) where T : ShellGroupItem
    {
        PropertyContext<FlyoutDisplayOptions> arg = new PropertyContext<FlyoutDisplayOptions>(self, ShellGroupItem.FlyoutDisplayOptionsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FlyoutDisplayOptions<T>(this SettersContext<T> self, FlyoutDisplayOptions flyoutDisplayOptions) where T : ShellGroupItem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ShellGroupItem.FlyoutDisplayOptionsProperty,
            Value = flyoutDisplayOptions
        });
        return self;
    }

    public static SettersContext<T> FlyoutDisplayOptions<T>(this SettersContext<T> self, Func<PropertySettersContext<FlyoutDisplayOptions>, IPropertySettersBuilder<FlyoutDisplayOptions>> configure) where T : ShellGroupItem
    {
        PropertySettersContext<FlyoutDisplayOptions> arg = new PropertySettersContext<FlyoutDisplayOptions>(self.XamlSetters, ShellGroupItem.FlyoutDisplayOptionsProperty);
        configure(arg).Build();
        return self;
    }
}
