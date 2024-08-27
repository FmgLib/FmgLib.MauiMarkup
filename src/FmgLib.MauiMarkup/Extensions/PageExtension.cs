namespace FmgLib.MauiMarkup;



public static partial class PageExtension
{
    public static T BackgroundImageSource<T>(this T self,
        ImageSource backgroundImageSource)
        where T : Page
    {
        self.SetValue(Page.BackgroundImageSourceProperty, backgroundImageSource);
        return self;
    }

    public static T BackgroundImageSource<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : Page
    {
        var context = new PropertyContext<ImageSource>(self, Page.BackgroundImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BackgroundImageSource<T>(this SettersContext<T> self,
        ImageSource backgroundImageSource)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Page.BackgroundImageSourceProperty, Value = backgroundImageSource });
        return self;
    }

    public static SettersContext<T> BackgroundImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, Page.BackgroundImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T IconImageSource<T>(this T self,
        ImageSource iconImageSource)
        where T : Page
    {
        self.SetValue(Page.IconImageSourceProperty, iconImageSource);
        return self;
    }

    public static T IconImageSource<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : Page
    {
        var context = new PropertyContext<ImageSource>(self, Page.IconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconImageSource<T>(this SettersContext<T> self,
        ImageSource iconImageSource)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Page.IconImageSourceProperty, Value = iconImageSource });
        return self;
    }

    public static SettersContext<T> IconImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, Page.IconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T IsBusy<T>(this T self,
        bool isBusy)
        where T : Page
    {
        self.SetValue(Page.IsBusyProperty, isBusy);
        return self;
    }

    public static T IsBusy<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertyContext<bool>(self, Page.IsBusyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsBusy<T>(this SettersContext<T> self,
        bool isBusy)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Page.IsBusyProperty, Value = isBusy });
        return self;
    }

    public static SettersContext<T> IsBusy<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Page.IsBusyProperty);
        configure(context).Build();
        return self;
    }

    public static T Padding<T>(this T self, double horizontalSize, double verticalSize) where T : Page
    {
        self.SetValue(Page.PaddingProperty, new Thickness(horizontalSize, verticalSize));
        return self;
    }

    public static T Padding<T>(this T self, double left, double top, double right, double bottom) where T : Page
    {
        self.SetValue(Page.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : Page
    {
        self.SetValue(Page.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self,
        Thickness padding)
        where T : Page
    {
        self.SetValue(Page.PaddingProperty, padding);
        return self;
    }

    public static T Padding<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : Page
    {
        var context = new PropertyContext<Thickness>(self, Page.PaddingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self,
        Thickness padding)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Page.PaddingProperty, Value = padding });
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, Page.PaddingProperty);
        configure(context).Build();
        return self;
    }

    public static T Title<T>(this T self,
        string title)
        where T : Page
    {
        self.SetValue(Page.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Page
    {
        var context = new PropertyContext<string>(self, Page.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Page.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Page.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T ToolbarItems<T>(this T self,
        IList<ToolbarItem> toolbarItems)
        where T : Page
    {
        foreach (var item in toolbarItems)
            self.ToolbarItems.Add(item);
        return self;
    }

    public static T ToolbarItems<T>(this T self,
        params ToolbarItem[] toolbarItems)
        where T : Page
    {
        foreach (var item in toolbarItems)
            self.ToolbarItems.Add(item);
        return self;
    }

    public static T ToolbarItems<T>(this T self,
        Func<ToolbarItem[]> configure)
        where T : Page
    {
        var toolbarItems = configure();
        foreach (var item in toolbarItems)
            self.ToolbarItems.Add(item);
        return self;
    }

    public static T MenuBarItems<T>(this T self,
        IList<MenuBarItem> menuBarItems)
        where T : Page
    {
        foreach (var item in menuBarItems)
            self.MenuBarItems.Add(item);
        return self;
    }

    public static T MenuBarItems<T>(this T self,
        params MenuBarItem[] menuBarItems)
        where T : Page
    {
        foreach (var item in menuBarItems)
            self.MenuBarItems.Add(item);
        return self;
    }

    public static T MenuBarItems<T>(this T self,
        Func<MenuBarItem[]> configure)
        where T : Page
    {
        var menuBarItems = configure();
        foreach (var item in menuBarItems)
            self.MenuBarItems.Add(item);
        return self;
    }

    public static T ContainerArea<T>(this T self,
        Rect containerArea)
        where T : Page
    {
        self.ContainerArea = containerArea;
        return self;
    }

    public static T IgnoresContainerArea<T>(this T self,
        bool ignoresContainerArea)
        where T : Page
    {
        self.IgnoresContainerArea = ignoresContainerArea;
        return self;
    }

    public static T InternalChildren<T>(this T self,
        IList<Element> internalChildren)
        where T : Page
    {
        foreach (var item in internalChildren)
            self.InternalChildren.Add(item);
        return self;
    }

    public static T InternalChildren<T>(this T self,
        params Element[] internalChildren)
        where T : Page
    {
        foreach (var item in internalChildren)
            self.InternalChildren.Add(item);
        return self;
    }

    public static T InternalChildren<T>(this T self,
        Func<Element[]> configure)
        where T : Page
    {
        var internalChildren = configure();
        foreach (var item in internalChildren)
            self.InternalChildren.Add(item);
        return self;
    }

    public static T OnNavigatedTo<T>(this T self, EventHandler<NavigatedToEventArgs> handler)
        where T : Page
    {
        self.NavigatedTo += handler;
        return self;
    }

    public static T OnNavigatedTo<T>(this T self, Action<T> action)
        where T : Page
    {
        self.NavigatedTo += (o, arg) => action(self);
        return self;
    }

    public static T OnNavigatingFrom<T>(this T self, EventHandler<NavigatingFromEventArgs> handler)
        where T : Page
    {
        self.NavigatingFrom += handler;
        return self;
    }

    public static T OnNavigatingFrom<T>(this T self, Action<T> action)
        where T : Page
    {
        self.NavigatingFrom += (o, arg) => action(self);
        return self;
    }

    public static T OnNavigatedFrom<T>(this T self, EventHandler<NavigatedFromEventArgs> handler)
        where T : Page
    {
        self.NavigatedFrom += handler;
        return self;
    }

    public static T OnNavigatedFrom<T>(this T self, Action<T> action)
        where T : Page
    {
        self.NavigatedFrom += (o, arg) => action(self);
        return self;
    }

    public static T OnLayoutChanged<T>(this T self, EventHandler handler)
        where T : Page
    {
        self.LayoutChanged += handler;
        return self;
    }

    public static T OnLayoutChanged<T>(this T self, Action<T> action)
        where T : Page
    {
        self.LayoutChanged += (o, arg) => action(self);
        return self;
    }

    public static T OnAppearing<T>(this T self, EventHandler handler)
        where T : Page
    {
        self.Appearing += handler;
        return self;
    }

    public static T OnAppearing<T>(this T self, Action<T> action)
        where T : Page
    {
        self.Appearing += (o, arg) => action(self);
        return self;
    }

    public static T OnDisappearing<T>(this T self, EventHandler handler)
        where T : Page
    {
        self.Disappearing += handler;
        return self;
    }

    public static T OnDisappearing<T>(this T self, Action<T> action)
        where T : Page
    {
        self.Disappearing += (o, arg) => action(self);
        return self;
    }
}
