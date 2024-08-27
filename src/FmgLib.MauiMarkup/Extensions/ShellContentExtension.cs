namespace FmgLib.MauiMarkup;

public static partial class ShellContentExtension
{
    public static T Content<T>(this T self,
        Func<object> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var content = configure();
        self.SetValue(Microsoft.Maui.Controls.ShellContent.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        object content)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.SetValue(Microsoft.Maui.Controls.ShellContent.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var context = new PropertyContext<object>(self, Microsoft.Maui.Controls.ShellContent.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        object content)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ShellContent.ContentProperty, Value = content });
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, Microsoft.Maui.Controls.ShellContent.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static T ContentTemplate<T>(this T self,
        Microsoft.Maui.Controls.DataTemplate contentTemplate)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.SetValue(Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty, contentTemplate);
        return self;
    }

    public static T ContentTemplate<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DataTemplate>, IPropertyBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ContentTemplate<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.DataTemplate contentTemplate)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty, Value = contentTemplate });
        return self;
    }

    public static SettersContext<T> ContentTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>, IPropertySettersBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>(self.XamlSetters, Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ContentTemplate<T>(this T self, System.Func<object> loadTemplate)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.SetValue(Microsoft.Maui.Controls.ShellContent.ContentTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }

    public static T MenuItems<T>(this T self,
        Func<MenuItem[]> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var menuItems = configure();
        foreach (var item in menuItems)
            self.MenuItems.Add(item);
        return self;
    }

    public static T MenuItems<T>(this T self,
        params MenuItem[] menuItems)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        foreach (var item in menuItems)
            self.MenuItems.Add(item);
        return self;
    }

    public static T MenuItems<T>(this T self,
        Microsoft.Maui.Controls.MenuItemCollection menuItems)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.SetValue(Microsoft.Maui.Controls.ShellContent.MenuItemsProperty, menuItems);
        return self;
    }

    public static T MenuItems<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.MenuItemCollection>, IPropertyBuilder<Microsoft.Maui.Controls.MenuItemCollection>> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.MenuItemCollection>(self, Microsoft.Maui.Controls.ShellContent.MenuItemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MenuItems<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.MenuItemCollection menuItems)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ShellContent.MenuItemsProperty, Value = menuItems });
        return self;
    }

    public static SettersContext<T> MenuItems<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.MenuItemCollection>, IPropertySettersBuilder<Microsoft.Maui.Controls.MenuItemCollection>> configure)
        where T : Microsoft.Maui.Controls.ShellContent
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.MenuItemCollection>(self.XamlSetters, Microsoft.Maui.Controls.ShellContent.MenuItemsProperty);
        configure(context).Build();
        return self;
    }

}
