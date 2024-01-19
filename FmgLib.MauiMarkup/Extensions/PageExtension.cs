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

    public static T ShellPresentationMode<T>(this T self,
        PresentationMode shellPresentationMode)
        where T : Page
    {
        self.SetValue(Shell.PresentationModeProperty, shellPresentationMode);
        return self;
    }
    
    public static T ShellPresentationMode<T>(this T self, Func<PropertyContext<PresentationMode>, IPropertyBuilder<PresentationMode>> configure)
        where T : Page
    {
        var context = new PropertyContext<PresentationMode>(self, Shell.PresentationModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellPresentationMode<T>(this SettersContext<T> self,
        PresentationMode shellPresentationMode)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.PresentationModeProperty, Value = shellPresentationMode });
        return self;
    }
    
    public static SettersContext<T> ShellPresentationMode<T>(this SettersContext<T> self, Func<PropertySettersContext<PresentationMode>, IPropertySettersBuilder<PresentationMode>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<PresentationMode>(self.XamlSetters, Shell.PresentationModeProperty);
        configure(context).Build();
        return self;
    }
    
    public static PresentationMode GetShellPresentationModeValue<T>(this T self)
        where T : Page
    {
        return (PresentationMode)self.GetValue(Shell.PresentationModeProperty);
    }
    
    public static T ShellBackgroundColor<T>(this T self,
        Color shellBackgroundColor)
        where T : Page
    {
        self.SetValue(Shell.BackgroundColorProperty, shellBackgroundColor);
        return self;
    }
    
    public static T ShellBackgroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellBackgroundColor<T>(this SettersContext<T> self,
        Color shellBackgroundColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.BackgroundColorProperty, Value = shellBackgroundColor });
        return self;
    }
    
    public static SettersContext<T> ShellBackgroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellBackgroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.BackgroundColorProperty);
    }
    
    public static T ShellForegroundColor<T>(this T self,
        Color shellForegroundColor)
        where T : Page
    {
        self.SetValue(Shell.ForegroundColorProperty, shellForegroundColor);
        return self;
    }
    
    public static T ShellForegroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.ForegroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellForegroundColor<T>(this SettersContext<T> self,
        Color shellForegroundColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.ForegroundColorProperty, Value = shellForegroundColor });
        return self;
    }
    
    public static SettersContext<T> ShellForegroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.ForegroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellForegroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.ForegroundColorProperty);
    }
    
    public static T ShellTitleColor<T>(this T self,
        Color shellTitleColor)
        where T : Page
    {
        self.SetValue(Shell.TitleColorProperty, shellTitleColor);
        return self;
    }
    
    public static T ShellTitleColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.TitleColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellTitleColor<T>(this SettersContext<T> self,
        Color shellTitleColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.TitleColorProperty, Value = shellTitleColor });
        return self;
    }
    
    public static SettersContext<T> ShellTitleColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.TitleColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellTitleColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TitleColorProperty);
    }
    
    public static T ShellDisabledColor<T>(this T self,
        Color shellDisabledColor)
        where T : Page
    {
        self.SetValue(Shell.DisabledColorProperty, shellDisabledColor);
        return self;
    }
    
    public static T ShellDisabledColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.DisabledColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellDisabledColor<T>(this SettersContext<T> self,
        Color shellDisabledColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.DisabledColorProperty, Value = shellDisabledColor });
        return self;
    }
    
    public static SettersContext<T> ShellDisabledColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.DisabledColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellDisabledColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.DisabledColorProperty);
    }
    
    public static T ShellUnselectedColor<T>(this T self,
        Color shellUnselectedColor)
        where T : Page
    {
        self.SetValue(Shell.UnselectedColorProperty, shellUnselectedColor);
        return self;
    }
    
    public static T ShellUnselectedColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.UnselectedColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellUnselectedColor<T>(this SettersContext<T> self,
        Color shellUnselectedColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.UnselectedColorProperty, Value = shellUnselectedColor });
        return self;
    }
    
    public static SettersContext<T> ShellUnselectedColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.UnselectedColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellUnselectedColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.UnselectedColorProperty);
    }
    
    public static T ShellNavBarHasShadow<T>(this T self,
        bool shellNavBarHasShadow)
        where T : Page
    {
        self.SetValue(Shell.NavBarHasShadowProperty, shellNavBarHasShadow);
        return self;
    }
    
    public static T ShellNavBarHasShadow<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertyContext<bool>(self, Shell.NavBarHasShadowProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellNavBarHasShadow<T>(this SettersContext<T> self,
        bool shellNavBarHasShadow)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.NavBarHasShadowProperty, Value = shellNavBarHasShadow });
        return self;
    }
    
    public static SettersContext<T> ShellNavBarHasShadow<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Shell.NavBarHasShadowProperty);
        configure(context).Build();
        return self;
    }
    
    public static bool GetShellNavBarHasShadowValue<T>(this T self)
        where T : Page
    {
        return (bool)self.GetValue(Shell.NavBarHasShadowProperty);
    }
    
    public static T ShellNavBarIsVisible<T>(this T self,
        bool shellNavBarIsVisible)
        where T : Page
    {
        self.SetValue(Shell.NavBarIsVisibleProperty, shellNavBarIsVisible);
        return self;
    }
    
    public static T ShellNavBarIsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertyContext<bool>(self, Shell.NavBarIsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellNavBarIsVisible<T>(this SettersContext<T> self,
        bool shellNavBarIsVisible)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.NavBarIsVisibleProperty, Value = shellNavBarIsVisible });
        return self;
    }
    
    public static SettersContext<T> ShellNavBarIsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Shell.NavBarIsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static bool GetShellNavBarIsVisibleValue<T>(this T self)
        where T : Page
    {
        return (bool)self.GetValue(Shell.NavBarIsVisibleProperty);
    }
    
    public static T ShellTabBarBackgroundColor<T>(this T self,
        Color shellTabBarBackgroundColor)
        where T : Page
    {
        self.SetValue(Shell.TabBarBackgroundColorProperty, shellTabBarBackgroundColor);
        return self;
    }
    
    public static T ShellTabBarBackgroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.TabBarBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellTabBarBackgroundColor<T>(this SettersContext<T> self,
        Color shellTabBarBackgroundColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.TabBarBackgroundColorProperty, Value = shellTabBarBackgroundColor });
        return self;
    }
    
    public static SettersContext<T> ShellTabBarBackgroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellTabBarBackgroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarBackgroundColorProperty);
    }
    
    public static T ShellTabBarForegroundColor<T>(this T self,
        Color shellTabBarForegroundColor)
        where T : Page
    {
        self.SetValue(Shell.TabBarForegroundColorProperty, shellTabBarForegroundColor);
        return self;
    }
    
    public static T ShellTabBarForegroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.TabBarForegroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellTabBarForegroundColor<T>(this SettersContext<T> self,
        Color shellTabBarForegroundColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.TabBarForegroundColorProperty, Value = shellTabBarForegroundColor });
        return self;
    }
    
    public static SettersContext<T> ShellTabBarForegroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarForegroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellTabBarForegroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarForegroundColorProperty);
    }
    
    public static T ShellTabBarTitleColor<T>(this T self,
        Color shellTabBarTitleColor)
        where T : Page
    {
        self.SetValue(Shell.TabBarTitleColorProperty, shellTabBarTitleColor);
        return self;
    }
    
    public static T ShellTabBarTitleColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.TabBarTitleColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellTabBarTitleColor<T>(this SettersContext<T> self,
        Color shellTabBarTitleColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.TabBarTitleColorProperty, Value = shellTabBarTitleColor });
        return self;
    }
    
    public static SettersContext<T> ShellTabBarTitleColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarTitleColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellTabBarTitleColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarTitleColorProperty);
    }
    
    public static T ShellTabBarDisabledColor<T>(this T self,
        Color shellTabBarDisabledColor)
        where T : Page
    {
        self.SetValue(Shell.TabBarDisabledColorProperty, shellTabBarDisabledColor);
        return self;
    }
    
    public static T ShellTabBarDisabledColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.TabBarDisabledColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellTabBarDisabledColor<T>(this SettersContext<T> self,
        Color shellTabBarDisabledColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.TabBarDisabledColorProperty, Value = shellTabBarDisabledColor });
        return self;
    }
    
    public static SettersContext<T> ShellTabBarDisabledColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarDisabledColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellTabBarDisabledColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarDisabledColorProperty);
    }
    
    public static T ShellTabBarUnselectedColor<T>(this T self,
        Color shellTabBarUnselectedColor)
        where T : Page
    {
        self.SetValue(Shell.TabBarUnselectedColorProperty, shellTabBarUnselectedColor);
        return self;
    }
    
    public static T ShellTabBarUnselectedColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertyContext<Color>(self, Shell.TabBarUnselectedColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ShellTabBarUnselectedColor<T>(this SettersContext<T> self,
        Color shellTabBarUnselectedColor)
        where T : Page
    {
        self.XamlSetters.Add(new Setter { Property = Shell.TabBarUnselectedColorProperty, Value = shellTabBarUnselectedColor });
        return self;
    }
    
    public static SettersContext<T> ShellTabBarUnselectedColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Page
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarUnselectedColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Color GetShellTabBarUnselectedColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarUnselectedColorProperty);
    }
    
}
