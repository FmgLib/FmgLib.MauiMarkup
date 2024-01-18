namespace FmgLib.MauiMarkup;
public static class PageExtensions
{
    public static T BackgroundImageSourceFmg<T>(this T self, ImageSource backgroundImageSource) where T : Page
    {
        self.SetValue(Page.BackgroundImageSourceProperty, backgroundImageSource);

        return self;
    }

    public static T BackgroundImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : Page
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(self, Page.BackgroundImageSourceProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> BackgroundImageSourceFmg<T>(this SettersContext<T> self, ImageSource backgroundImageSource) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Page.BackgroundImageSourceProperty,
            Value = backgroundImageSource
        });

        return self;
    }

    public static SettersContext<T> BackgroundImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : Page
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(self.XamlSetters, Page.BackgroundImageSourceProperty);
        configure(arg).Build();

        return self;
    }

    public static T IconImageSourceFmg<T>(this T self, ImageSource iconImageSource) where T : Page
    {
        self.SetValue(Page.IconImageSourceProperty, iconImageSource);

        return self;
    }

    public static T IconImageSourceFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : Page
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(self, Page.IconImageSourceProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> IconImageSourceFmg<T>(this SettersContext<T> self, ImageSource iconImageSource) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Page.IconImageSourceProperty,
            Value = iconImageSource
        });

        return self;
    }

    public static SettersContext<T> IconImageSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : Page
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(self.XamlSetters, Page.IconImageSourceProperty);
        configure(arg).Build();

        return self;
    }

    public static T IsBusyFmg<T>(this T self, bool isBusy) where T : Page
    {
        self.SetValue(Page.IsBusyProperty, isBusy);

        return self;
    }

    public static T IsBusyFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Page
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Page.IsBusyProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> IsBusyFmg<T>(this SettersContext<T> self, bool isBusy) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Page.IsBusyProperty,
            Value = isBusy
        });

        return self;
    }

    public static SettersContext<T> IsBusyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Page
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Page.IsBusyProperty);
        configure(arg).Build();

        return self;
    }

    public static T PaddingFmg<T>(this T self, Thickness padding) where T : Page
    {
        self.SetValue(Page.PaddingProperty, padding);

        return self;
    }

    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : Page
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(self, Page.PaddingProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Thickness padding) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Page.PaddingProperty,
            Value = padding
        });

        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : Page
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(self.XamlSetters, Page.PaddingProperty);
        configure(arg).Build();

        return self;
    }

    public static T TitleFmg<T>(this T self, string title) where T : Page
    {
        self.SetValue(Page.TitleProperty, title);

        return self;
    }

    public static T TitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Page
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Page.TitleProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, string title) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Page.TitleProperty,
            Value = title
        });

        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Page
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Page.TitleProperty);
        configure(arg).Build();

        return self;
    }

    public static T ToolbarItemsFmg<T>(this T self, IList<ToolbarItem> toolbaritems) where T : Page
    {
        foreach (ToolbarItem item in toolbaritems)
        {
            self.ToolbarItems.Add(item);
        }

        return self;
    }

    public static T ToolbarItemsFmg<T>(this T self, params ToolbarItem[] toolbaritems) where T : Page
    {
        foreach (ToolbarItem item in toolbaritems)
        {
            self.ToolbarItems.Add(item);
        }

        return self;
    }

    public static T MenuBarItemsFmg<T>(this T self, IList<MenuBarItem> menuBaritems) where T : Page
    {
        foreach (MenuBarItem item in menuBaritems)
        {
            self.MenuBarItems.Add(item);
        }

        return self;
    }

    public static T MenuBarItemsFmg<T>(this T self, params MenuBarItem[] menuBaritems) where T : Page
    {
        foreach (MenuBarItem item in menuBaritems)
        {
            self.MenuBarItems.Add(item);
        }

        return self;
    }

    public static T ContainerAreaFmg<T>(this T self, Rect containerArea) where T : Page
    {
        self.ContainerArea = containerArea;

        return self;
    }

    public static T IgnoresContainerAreaFmg<T>(this T self, bool ignoresContainerArea) where T : Page
    {
        self.IgnoresContainerArea = ignoresContainerArea;

        return self;
    }

    public static T InternalChildrenFmg<T>(this T self, IList<Element> internalChildren) where T : Page
    {
        foreach (Element internalChild in internalChildren)
        {
            self.InternalChildren.Add(internalChild);
        }

        return self;
    }

    public static T InternalChildrenFmg<T>(this T self, params Element[] internalChildren) where T : Page
    {
        foreach (Element child in internalChildren)
        {
            self.InternalChildren.Add(child);
        }

        return self;
    }

    public static T OnNavigatedToFmg<T>(this T self, EventHandler<NavigatedToEventArgs> handler) where T : Page
    {
        self.NavigatedTo += handler;

        return self;
    }

    public static T OnNavigatedToFmg<T>(this T self, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.NavigatedTo += delegate
        {
            action2(self2);
        };

        return self2;
    }

    public static T OnNavigatingFromFmg<T>(this T self, EventHandler<NavigatingFromEventArgs> handler) where T : Page
    {
        self.NavigatingFrom += handler;

        return self;
    }

    public static T OnNavigatingFromFmg<T>(this T self, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.NavigatingFrom += delegate
        {
            action2(self2);
        };

        return self2;
    }

    public static T OnNavigatedFromFmg<T>(this T self, EventHandler<NavigatedFromEventArgs> handler) where T : Page
    {
        self.NavigatedFrom += handler;

        return self;
    }

    public static T OnNavigatedFromFmg<T>(this T self, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.NavigatedFrom += delegate
        {
            action2(self2);
        };

        return self2;
    }

    public static T OnLayoutChangedFmg<T>(this T self, EventHandler handler) where T : Page
    {
        self.LayoutChanged += handler;

        return self;
    }

    public static T OnLayoutChangedFmg<T>(this T self, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.LayoutChanged += delegate
        {
            action2(self2);
        };

        return self2;
    }

    public static T OnAppearingFmg<T>(this T self, EventHandler handler) where T : Page
    {
        self.Appearing += handler;

        return self;
    }

    public static T OnAppearingFmg<T>(this T self, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Appearing += delegate
        {
            action2(self2);
        };

        return self2;
    }

    public static T OnDisappearingFmg<T>(this T self, EventHandler handler) where T : Page
    {
        self.Disappearing += handler;

        return self;
    }

    public static T OnDisappearingFmg<T>(this T self, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.Disappearing += delegate
        {
            action2(self2);
        };

        return self2;
    }

    public static T ShellPresentationModeFmg<T>(this T self, PresentationMode shellPresentationMode) where T : Page
    {
        self.SetValue(Shell.PresentationModeProperty, shellPresentationMode);

        return self;
    }

    public static T ShellPresentationModeFmg<T>(this T self, Func<PropertyContext<PresentationMode>, IPropertyBuilder<PresentationMode>> configure) where T : Page
    {
        PropertyContext<PresentationMode> arg = new PropertyContext<PresentationMode>(self, Shell.PresentationModeProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellPresentationModeFmg<T>(this SettersContext<T> self, PresentationMode shellPresentationMode) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.PresentationModeProperty,
            Value = shellPresentationMode
        });

        return self;
    }

    public static SettersContext<T> ShellPresentationModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<PresentationMode>, IPropertySettersBuilder<PresentationMode>> configure) where T : Page
    {
        PropertySettersContext<PresentationMode> arg = new PropertySettersContext<PresentationMode>(self.XamlSetters, Shell.PresentationModeProperty);
        configure(arg).Build();

        return self;
    }

    public static PresentationMode GetShellPresentationModeValueFmg<T>(this T self) where T : Page
    {
        return (PresentationMode)self.GetValue(Shell.PresentationModeProperty);
    }

    public static T ShellBackgroundColorFmg<T>(this T self, Color shellBackgroundColor) where T : Page
    {
        self.SetValue(Shell.BackgroundColorProperty, shellBackgroundColor);

        return self;
    }

    public static T ShellBackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.BackgroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellBackgroundColorFmg<T>(this SettersContext<T> self, Color shellBackgroundColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.BackgroundColorProperty,
            Value = shellBackgroundColor
        });

        return self;
    }

    public static SettersContext<T> ShellBackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.BackgroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellBackgroundColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.BackgroundColorProperty);
    }

    public static T ShellForegroundColorFmg<T>(this T self, Color shellForegroundColor) where T : Page
    {
        self.SetValue(Shell.ForegroundColorProperty, shellForegroundColor);

        return self;
    }

    public static T ShellForegroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.ForegroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellForegroundColorFmg<T>(this SettersContext<T> self, Color shellForegroundColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.ForegroundColorProperty,
            Value = shellForegroundColor
        });

        return self;
    }

    public static SettersContext<T> ShellForegroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.ForegroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellForegroundColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.ForegroundColorProperty);
    }

    public static T ShellTitleColorFmg<T>(this T self, Color shellTitleColor) where T : Page
    {
        self.SetValue(Shell.TitleColorProperty, shellTitleColor);

        return self;
    }

    public static T ShellTitleColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.TitleColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellTitleColorFmg<T>(this SettersContext<T> self, Color shellTitleColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.TitleColorProperty,
            Value = shellTitleColor
        });

        return self;
    }

    public static SettersContext<T> ShellTitleColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.TitleColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellTitleColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.TitleColorProperty);
    }

    public static T ShellDisabledColorFmg<T>(this T self, Color shellDisabledColor) where T : Page
    {
        self.SetValue(Shell.DisabledColorProperty, shellDisabledColor);

        return self;
    }

    public static T ShellDisabledColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.DisabledColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellDisabledColorFmg<T>(this SettersContext<T> self, Color shellDisabledColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.DisabledColorProperty,
            Value = shellDisabledColor
        });

        return self;
    }

    public static SettersContext<T> ShellDisabledColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.DisabledColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellDisabledColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.DisabledColorProperty);
    }

    public static T ShellUnselectedColorFmg<T>(this T self, Color shellUnselectedColor) where T : Page
    {
        self.SetValue(Shell.UnselectedColorProperty, shellUnselectedColor);

        return self;
    }

    public static T ShellUnselectedColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.UnselectedColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellUnselectedColorFmg<T>(this SettersContext<T> self, Color shellUnselectedColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.UnselectedColorProperty,
            Value = shellUnselectedColor
        });

        return self;
    }

    public static SettersContext<T> ShellUnselectedColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.UnselectedColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellUnselectedColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.UnselectedColorProperty);
    }

    public static T ShellNavBarHasShadowFmg<T>(this T self, bool shellNavBarHasShadow) where T : Page
    {
        self.SetValue(Shell.NavBarHasShadowProperty, shellNavBarHasShadow);

        return self;
    }

    public static T ShellNavBarHasShadowFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Page
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Shell.NavBarHasShadowProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellNavBarHasShadowFmg<T>(this SettersContext<T> self, bool shellNavBarHasShadow) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.NavBarHasShadowProperty,
            Value = shellNavBarHasShadow
        });

        return self;
    }

    public static SettersContext<T> ShellNavBarHasShadowFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Page
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Shell.NavBarHasShadowProperty);
        configure(arg).Build();

        return self;
    }

    public static bool GetShellNavBarHasShadowValueFmg<T>(this T self) where T : Page
    {
        return (bool)self.GetValue(Shell.NavBarHasShadowProperty);
    }

    public static T ShellNavBarIsVisibleFmg<T>(this T self, bool shellNavBarIsVisible) where T : Page
    {
        self.SetValue(Shell.NavBarIsVisibleProperty, shellNavBarIsVisible);

        return self;
    }

    public static T ShellNavBarIsVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Page
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Shell.NavBarIsVisibleProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellNavBarIsVisibleFmg<T>(this SettersContext<T> self, bool shellNavBarIsVisible) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.NavBarIsVisibleProperty,
            Value = shellNavBarIsVisible
        });

        return self;
    }

    public static SettersContext<T> ShellNavBarIsVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Page
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Shell.NavBarIsVisibleProperty);
        configure(arg).Build();

        return self;
    }

    public static bool GetShellNavBarIsVisibleValueFmg<T>(this T self) where T : Page
    {
        return (bool)self.GetValue(Shell.NavBarIsVisibleProperty);
    }

    public static T ShellTabBarBackgroundColorFmg<T>(this T self, Color shellTabBarBackgroundColor) where T : Page
    {
        self.SetValue(Shell.TabBarBackgroundColorProperty, shellTabBarBackgroundColor);

        return self;
    }

    public static T ShellTabBarBackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.TabBarBackgroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellTabBarBackgroundColorFmg<T>(this SettersContext<T> self, Color shellTabBarBackgroundColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarBackgroundColorProperty,
            Value = shellTabBarBackgroundColor
        });

        return self;
    }

    public static SettersContext<T> ShellTabBarBackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarBackgroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellTabBarBackgroundColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarBackgroundColorProperty);
    }

    public static T ShellTabBarForegroundColorFmg<T>(this T self, Color shellTabBarForegroundColor) where T : Page
    {
        self.SetValue(Shell.TabBarForegroundColorProperty, shellTabBarForegroundColor);

        return self;
    }

    public static T ShellTabBarForegroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.TabBarForegroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellTabBarForegroundColorFmg<T>(this SettersContext<T> self, Color shellTabBarForegroundColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarForegroundColorProperty,
            Value = shellTabBarForegroundColor
        });

        return self;
    }

    public static SettersContext<T> ShellTabBarForegroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarForegroundColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellTabBarForegroundColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarForegroundColorProperty);
    }

    public static T ShellTabBarTitleColorFmg<T>(this T self, Color shellTabBarTitleColor) where T : Page
    {
        self.SetValue(Shell.TabBarTitleColorProperty, shellTabBarTitleColor);

        return self;
    }

    public static T ShellTabBarTitleColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.TabBarTitleColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellTabBarTitleColorFmg<T>(this SettersContext<T> self, Color shellTabBarTitleColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarTitleColorProperty,
            Value = shellTabBarTitleColor
        });

        return self;
    }

    public static SettersContext<T> ShellTabBarTitleColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarTitleColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellTabBarTitleColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarTitleColorProperty);
    }

    public static T ShellTabBarDisabledColorFmg<T>(this T self, Color shellTabBarDisabledColor) where T : Page
    {
        self.SetValue(Shell.TabBarDisabledColorProperty, shellTabBarDisabledColor);

        return self;
    }

    public static T ShellTabBarDisabledColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.TabBarDisabledColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellTabBarDisabledColorFmg<T>(this SettersContext<T> self, Color shellTabBarDisabledColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarDisabledColorProperty,
            Value = shellTabBarDisabledColor
        });

        return self;
    }

    public static SettersContext<T> ShellTabBarDisabledColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarDisabledColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellTabBarDisabledColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarDisabledColorProperty);
    }

    public static T ShellTabBarUnselectedColorFmg<T>(this T self, Color shellTabBarUnselectedColor) where T : Page
    {
        self.SetValue(Shell.TabBarUnselectedColorProperty, shellTabBarUnselectedColor);

        return self;
    }

    public static T ShellTabBarUnselectedColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Shell.TabBarUnselectedColorProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> ShellTabBarUnselectedColorFmg<T>(this SettersContext<T> self, Color shellTabBarUnselectedColor) where T : Page
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarUnselectedColorProperty,
            Value = shellTabBarUnselectedColor
        });

        return self;
    }

    public static SettersContext<T> ShellTabBarUnselectedColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Shell.TabBarUnselectedColorProperty);
        configure(arg).Build();

        return self;
    }

    public static Color GetShellTabBarUnselectedColorValueFmg<T>(this T self) where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarUnselectedColorProperty);
    }
}

