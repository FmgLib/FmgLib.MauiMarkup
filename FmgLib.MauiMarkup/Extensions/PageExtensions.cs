namespace FmgLib.MauiMarkup;
public static class PageExtensions
{
    public static T BackgroundImageSourceFmg<T>(this T item, ImageSource backgroundImageSource) where T : Page
    {
        item.SetValue(Page.BackgroundImageSourceProperty, backgroundImageSource);

        return item;
    }

    public static T BackgroundImageSourceFmg<T>(this T item, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : Page
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(item, Page.BackgroundImageSourceProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> BackgroundImageSourceFmg<T>(this SettersContext<T> item, ImageSource backgroundImageSource) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Page.BackgroundImageSourceProperty,
            Value = backgroundImageSource
        });

        return item;
    }

    public static SettersContext<T> BackgroundImageSourceFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : Page
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(item.XamlSetters, Page.BackgroundImageSourceProperty);
        configure(arg).Build();

        return item;
    }

    public static T IconImageSourceFmg<T>(this T item, ImageSource iconImageSource) where T : Page
    {
        item.SetValue(Page.IconImageSourceProperty, iconImageSource);

        return item;
    }

    public static T IconImageSourceFmg<T>(this T item, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure) where T : Page
    {
        PropertyContext<ImageSource> arg = new PropertyContext<ImageSource>(item, Page.IconImageSourceProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> IconImageSourceFmg<T>(this SettersContext<T> item, ImageSource iconImageSource) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Page.IconImageSourceProperty,
            Value = iconImageSource
        });

        return item;
    }

    public static SettersContext<T> IconImageSourceFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure) where T : Page
    {
        PropertySettersContext<ImageSource> arg = new PropertySettersContext<ImageSource>(item.XamlSetters, Page.IconImageSourceProperty);
        configure(arg).Build();

        return item;
    }

    public static T IsBusyFmg<T>(this T item, bool isBusy) where T : Page
    {
        item.SetValue(Page.IsBusyProperty, isBusy);

        return item;
    }

    public static T IsBusyFmg<T>(this T item, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Page
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(item, Page.IsBusyProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> IsBusyFmg<T>(this SettersContext<T> item, bool isBusy) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Page.IsBusyProperty,
            Value = isBusy
        });

        return item;
    }

    public static SettersContext<T> IsBusyFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Page
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(item.XamlSetters, Page.IsBusyProperty);
        configure(arg).Build();

        return item;
    }

    public static T PaddingFmg<T>(this T item, Thickness padding) where T : Page
    {
        item.SetValue(Page.PaddingProperty, padding);

        return item;
    }

    public static T PaddingFmg<T>(this T item, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : Page
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(item, Page.PaddingProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> item, Thickness padding) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Page.PaddingProperty,
            Value = padding
        });

        return item;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : Page
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(item.XamlSetters, Page.PaddingProperty);
        configure(arg).Build();

        return item;
    }

    public static T TitleFmg<T>(this T item, string title) where T : Page
    {
        item.SetValue(Page.TitleProperty, title);

        return item;
    }

    public static T TitleFmg<T>(this T item, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Page
    {
        PropertyContext<string> arg = new PropertyContext<string>(item, Page.TitleProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> item, string title) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Page.TitleProperty,
            Value = title
        });

        return item;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Page
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(item.XamlSetters, Page.TitleProperty);
        configure(arg).Build();

        return item;
    }

    public static T ToolbarItemsFmg<T>(this T item, IList<ToolbarItem> toolbarItems) where T : Page
    {
        foreach (ToolbarItem toolbarItem in toolbarItems)
        {
            item.ToolbarItems.Add(toolbarItem);
        }

        return item;
    }

    public static T ToolbarItemsFmg<T>(this T item, params ToolbarItem[] toolbarItems) where T : Page
    {
        foreach (ToolbarItem tbItem in toolbarItems)
        {
            item.ToolbarItems.Add(tbItem);
        }

        return item;
    }

    public static T MenuBarItemsFmg<T>(this T item, IList<MenuBarItem> menuBarItems) where T : Page
    {
        foreach (MenuBarItem menuBarItem in menuBarItems)
        {
            item.MenuBarItems.Add(menuBarItem);
        }

        return item;
    }

    public static T MenuBarItemsFmg<T>(this T item, params MenuBarItem[] menuBarItems) where T : Page
    {
        foreach (MenuBarItem mbItem in menuBarItems)
        {
            item.MenuBarItems.Add(mbItem);
        }

        return item;
    }

    public static T ContainerAreaFmg<T>(this T item, Rect containerArea) where T : Page
    {
        item.ContainerArea = containerArea;

        return item;
    }

    public static T IgnoresContainerAreaFmg<T>(this T item, bool ignoresContainerArea) where T : Page
    {
        item.IgnoresContainerArea = ignoresContainerArea;

        return item;
    }

    public static T InternalChildrenFmg<T>(this T item, IList<Element> internalChildren) where T : Page
    {
        foreach (Element internalChild in internalChildren)
        {
            item.InternalChildren.Add(internalChild);
        }

        return item;
    }

    public static T InternalChildrenFmg<T>(this T item, params Element[] internalChildren) where T : Page
    {
        foreach (Element child in internalChildren)
        {
            item.InternalChildren.Add(child);
        }

        return item;
    }

    public static T OnNavigatedToFmg<T>(this T item, EventHandler<NavigatedToEventArgs> handler) where T : Page
    {
        item.NavigatedTo += handler;

        return item;
    }

    public static T OnNavigatedToFmg<T>(this T item, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T item2 = item;
        item2.NavigatedTo += delegate
        {
            action2(item2);
        };

        return item2;
    }

    public static T OnNavigatingFromFmg<T>(this T item, EventHandler<NavigatingFromEventArgs> handler) where T : Page
    {
        item.NavigatingFrom += handler;

        return item;
    }

    public static T OnNavigatingFromFmg<T>(this T item, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T item2 = item;
        item2.NavigatingFrom += delegate
        {
            action2(item2);
        };

        return item2;
    }

    public static T OnNavigatedFromFmg<T>(this T item, EventHandler<NavigatedFromEventArgs> handler) where T : Page
    {
        item.NavigatedFrom += handler;

        return item;
    }

    public static T OnNavigatedFromFmg<T>(this T item, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T item2 = item;
        item2.NavigatedFrom += delegate
        {
            action2(item2);
        };

        return item2;
    }

    public static T OnLayoutChangedFmg<T>(this T item, EventHandler handler) where T : Page
    {
        item.LayoutChanged += handler;

        return item;
    }

    public static T OnLayoutChangedFmg<T>(this T item, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T item2 = item;
        item2.LayoutChanged += delegate
        {
            action2(item2);
        };

        return item2;
    }

    public static T OnAppearingFmg<T>(this T item, EventHandler handler) where T : Page
    {
        item.Appearing += handler;

        return item;
    }

    public static T OnAppearingFmg<T>(this T item, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T item2 = item;
        item2.Appearing += delegate
        {
            action2(item2);
        };

        return item2;
    }

    public static T OnDisappearingFmg<T>(this T item, EventHandler handler) where T : Page
    {
        item.Disappearing += handler;

        return item;
    }

    public static T OnDisappearingFmg<T>(this T item, Action<T> action) where T : Page
    {
        Action<T> action2 = action;
        T item2 = item;
        item2.Disappearing += delegate
        {
            action2(item2);
        };

        return item2;
    }

    public static T ShellPresentationModeFmg<T>(this T item, PresentationMode shellPresentationMode) where T : Page
    {
        item.SetValue(Shell.PresentationModeProperty, shellPresentationMode);

        return item;
    }

    public static T ShellPresentationModeFmg<T>(this T item, Func<PropertyContext<PresentationMode>, IPropertyBuilder<PresentationMode>> configure) where T : Page
    {
        PropertyContext<PresentationMode> arg = new PropertyContext<PresentationMode>(item, Shell.PresentationModeProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellPresentationModeFmg<T>(this SettersContext<T> item, PresentationMode shellPresentationMode) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.PresentationModeProperty,
            Value = shellPresentationMode
        });

        return item;
    }

    public static SettersContext<T> ShellPresentationModeFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<PresentationMode>, IPropertySettersBuilder<PresentationMode>> configure) where T : Page
    {
        PropertySettersContext<PresentationMode> arg = new PropertySettersContext<PresentationMode>(item.XamlSetters, Shell.PresentationModeProperty);
        configure(arg).Build();

        return item;
    }

    public static PresentationMode GetShellPresentationModeValueFmg<T>(this T item) where T : Page
    {
        return (PresentationMode)item.GetValue(Shell.PresentationModeProperty);
    }

    public static T ShellBackgroundColorFmg<T>(this T item, Color shellBackgroundColor) where T : Page
    {
        item.SetValue(Shell.BackgroundColorProperty, shellBackgroundColor);

        return item;
    }

    public static T ShellBackgroundColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.BackgroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellBackgroundColorFmg<T>(this SettersContext<T> item, Color shellBackgroundColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.BackgroundColorProperty,
            Value = shellBackgroundColor
        });

        return item;
    }

    public static SettersContext<T> ShellBackgroundColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.BackgroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellBackgroundColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.BackgroundColorProperty);
    }

    public static T ShellForegroundColorFmg<T>(this T item, Color shellForegroundColor) where T : Page
    {
        item.SetValue(Shell.ForegroundColorProperty, shellForegroundColor);

        return item;
    }

    public static T ShellForegroundColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.ForegroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellForegroundColorFmg<T>(this SettersContext<T> item, Color shellForegroundColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.ForegroundColorProperty,
            Value = shellForegroundColor
        });

        return item;
    }

    public static SettersContext<T> ShellForegroundColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.ForegroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellForegroundColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.ForegroundColorProperty);
    }

    public static T ShellTitleColorFmg<T>(this T item, Color shellTitleColor) where T : Page
    {
        item.SetValue(Shell.TitleColorProperty, shellTitleColor);

        return item;
    }

    public static T ShellTitleColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.TitleColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellTitleColorFmg<T>(this SettersContext<T> item, Color shellTitleColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.TitleColorProperty,
            Value = shellTitleColor
        });

        return item;
    }

    public static SettersContext<T> ShellTitleColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.TitleColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellTitleColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.TitleColorProperty);
    }

    public static T ShellDisabledColorFmg<T>(this T item, Color shellDisabledColor) where T : Page
    {
        item.SetValue(Shell.DisabledColorProperty, shellDisabledColor);

        return item;
    }

    public static T ShellDisabledColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.DisabledColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellDisabledColorFmg<T>(this SettersContext<T> item, Color shellDisabledColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.DisabledColorProperty,
            Value = shellDisabledColor
        });

        return item;
    }

    public static SettersContext<T> ShellDisabledColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.DisabledColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellDisabledColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.DisabledColorProperty);
    }

    public static T ShellUnselectedColorFmg<T>(this T item, Color shellUnselectedColor) where T : Page
    {
        item.SetValue(Shell.UnselectedColorProperty, shellUnselectedColor);

        return item;
    }

    public static T ShellUnselectedColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.UnselectedColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellUnselectedColorFmg<T>(this SettersContext<T> item, Color shellUnselectedColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.UnselectedColorProperty,
            Value = shellUnselectedColor
        });

        return item;
    }

    public static SettersContext<T> ShellUnselectedColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.UnselectedColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellUnselectedColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.UnselectedColorProperty);
    }

    public static T ShellNavBarHasShadowFmg<T>(this T item, bool shellNavBarHasShadow) where T : Page
    {
        item.SetValue(Shell.NavBarHasShadowProperty, shellNavBarHasShadow);

        return item;
    }

    public static T ShellNavBarHasShadowFmg<T>(this T item, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Page
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(item, Shell.NavBarHasShadowProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellNavBarHasShadowFmg<T>(this SettersContext<T> item, bool shellNavBarHasShadow) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.NavBarHasShadowProperty,
            Value = shellNavBarHasShadow
        });

        return item;
    }

    public static SettersContext<T> ShellNavBarHasShadowFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Page
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(item.XamlSetters, Shell.NavBarHasShadowProperty);
        configure(arg).Build();

        return item;
    }

    public static bool GetShellNavBarHasShadowValueFmg<T>(this T item) where T : Page
    {
        return (bool)item.GetValue(Shell.NavBarHasShadowProperty);
    }

    public static T ShellNavBarIsVisibleFmg<T>(this T item, bool shellNavBarIsVisible) where T : Page
    {
        item.SetValue(Shell.NavBarIsVisibleProperty, shellNavBarIsVisible);

        return item;
    }

    public static T ShellNavBarIsVisibleFmg<T>(this T item, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Page
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(item, Shell.NavBarIsVisibleProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellNavBarIsVisibleFmg<T>(this SettersContext<T> item, bool shellNavBarIsVisible) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.NavBarIsVisibleProperty,
            Value = shellNavBarIsVisible
        });

        return item;
    }

    public static SettersContext<T> ShellNavBarIsVisibleFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Page
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(item.XamlSetters, Shell.NavBarIsVisibleProperty);
        configure(arg).Build();

        return item;
    }

    public static bool GetShellNavBarIsVisibleValueFmg<T>(this T item) where T : Page
    {
        return (bool)item.GetValue(Shell.NavBarIsVisibleProperty);
    }

    public static T ShellTabBarBackgroundColorFmg<T>(this T item, Color shellTabBarBackgroundColor) where T : Page
    {
        item.SetValue(Shell.TabBarBackgroundColorProperty, shellTabBarBackgroundColor);

        return item;
    }

    public static T ShellTabBarBackgroundColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.TabBarBackgroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellTabBarBackgroundColorFmg<T>(this SettersContext<T> item, Color shellTabBarBackgroundColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarBackgroundColorProperty,
            Value = shellTabBarBackgroundColor
        });

        return item;
    }

    public static SettersContext<T> ShellTabBarBackgroundColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.TabBarBackgroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellTabBarBackgroundColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.TabBarBackgroundColorProperty);
    }

    public static T ShellTabBarForegroundColorFmg<T>(this T item, Color shellTabBarForegroundColor) where T : Page
    {
        item.SetValue(Shell.TabBarForegroundColorProperty, shellTabBarForegroundColor);

        return item;
    }

    public static T ShellTabBarForegroundColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.TabBarForegroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellTabBarForegroundColorFmg<T>(this SettersContext<T> item, Color shellTabBarForegroundColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarForegroundColorProperty,
            Value = shellTabBarForegroundColor
        });

        return item;
    }

    public static SettersContext<T> ShellTabBarForegroundColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.TabBarForegroundColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellTabBarForegroundColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.TabBarForegroundColorProperty);
    }

    public static T ShellTabBarTitleColorFmg<T>(this T item, Color shellTabBarTitleColor) where T : Page
    {
        item.SetValue(Shell.TabBarTitleColorProperty, shellTabBarTitleColor);

        return item;
    }

    public static T ShellTabBarTitleColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.TabBarTitleColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellTabBarTitleColorFmg<T>(this SettersContext<T> item, Color shellTabBarTitleColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarTitleColorProperty,
            Value = shellTabBarTitleColor
        });

        return item;
    }

    public static SettersContext<T> ShellTabBarTitleColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.TabBarTitleColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellTabBarTitleColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.TabBarTitleColorProperty);
    }

    public static T ShellTabBarDisabledColorFmg<T>(this T item, Color shellTabBarDisabledColor) where T : Page
    {
        item.SetValue(Shell.TabBarDisabledColorProperty, shellTabBarDisabledColor);

        return item;
    }

    public static T ShellTabBarDisabledColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.TabBarDisabledColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellTabBarDisabledColorFmg<T>(this SettersContext<T> item, Color shellTabBarDisabledColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarDisabledColorProperty,
            Value = shellTabBarDisabledColor
        });

        return item;
    }

    public static SettersContext<T> ShellTabBarDisabledColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.TabBarDisabledColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellTabBarDisabledColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.TabBarDisabledColorProperty);
    }

    public static T ShellTabBarUnselectedColorFmg<T>(this T item, Color shellTabBarUnselectedColor) where T : Page
    {
        item.SetValue(Shell.TabBarUnselectedColorProperty, shellTabBarUnselectedColor);

        return item;
    }

    public static T ShellTabBarUnselectedColorFmg<T>(this T item, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Page
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(item, Shell.TabBarUnselectedColorProperty);
        configure(arg).Build();

        return item;
    }

    public static SettersContext<T> ShellTabBarUnselectedColorFmg<T>(this SettersContext<T> item, Color shellTabBarUnselectedColor) where T : Page
    {
        item.XamlSetters.Add(new Setter
        {
            Property = Shell.TabBarUnselectedColorProperty,
            Value = shellTabBarUnselectedColor
        });

        return item;
    }

    public static SettersContext<T> ShellTabBarUnselectedColorFmg<T>(this SettersContext<T> item, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Page
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(item.XamlSetters, Shell.TabBarUnselectedColorProperty);
        configure(arg).Build();

        return item;
    }

    public static Color GetShellTabBarUnselectedColorValueFmg<T>(this T item) where T : Page
    {
        return (Color)item.GetValue(Shell.TabBarUnselectedColorProperty);
    }
}

