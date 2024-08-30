namespace FmgLib.MauiMarkup;

public static partial class PageExtension
{
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

    public static T ShellBackButtonBehavior<T>(this T self,
            Microsoft.Maui.Controls.BackButtonBehavior shellBackButtonBehavior)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.BackButtonBehaviorProperty, shellBackButtonBehavior);
        return self;
    }

    public static T ShellBackButtonBehavior<T>(this T self,
        Func<Microsoft.Maui.Controls.BackButtonBehavior> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellBackButtonBehavior = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.BackButtonBehaviorProperty, shellBackButtonBehavior);
        return self;
    }

    public static T ShellBackButtonBehavior<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.BackButtonBehavior>, IPropertyBuilder<Microsoft.Maui.Controls.BackButtonBehavior>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.BackButtonBehavior>(self, Microsoft.Maui.Controls.Shell.BackButtonBehaviorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellBackButtonBehavior<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.BackButtonBehavior shellBackButtonBehavior)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.BackButtonBehaviorProperty, Value = shellBackButtonBehavior });
        return self;
    }

    public static SettersContext<T> ShellBackButtonBehavior<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.BackButtonBehavior>, IPropertySettersBuilder<Microsoft.Maui.Controls.BackButtonBehavior>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.BackButtonBehavior>(self.XamlSetters, Microsoft.Maui.Controls.Shell.BackButtonBehaviorProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellFlyoutBackdrop<T>(this T self,
            Microsoft.Maui.Controls.Brush shellFlyoutBackdrop)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty, shellFlyoutBackdrop);
        return self;
    }

    public static T ShellFlyoutBackdrop<T>(this T self,
        Func<Microsoft.Maui.Controls.Brush> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellFlyoutBackdrop = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty, shellFlyoutBackdrop);
        return self;
    }

    public static T ShellFlyoutBackdrop<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Brush>, IPropertyBuilder<Microsoft.Maui.Controls.Brush>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Brush>(self, Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellFlyoutBackdrop<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Brush shellFlyoutBackdrop)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty, Value = shellFlyoutBackdrop });
        return self;
    }

    public static SettersContext<T> ShellFlyoutBackdrop<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Brush>, IPropertySettersBuilder<Microsoft.Maui.Controls.Brush>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Brush>(self.XamlSetters, Microsoft.Maui.Controls.Shell.FlyoutBackdropProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellTitleView<T>(this T self,
            Microsoft.Maui.Controls.View shellTitleView)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, shellTitleView);
        return self;
    }

    public static T ShellTitleView<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellTitleView = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.TitleViewProperty, shellTitleView);
        return self;
    }

    public static T ShellTitleView<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View>, IPropertyBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.Shell.TitleViewProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellTitleView<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View shellTitleView)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.TitleViewProperty, Value = shellTitleView });
        return self;
    }

    public static SettersContext<T> ShellTitleView<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View>, IPropertySettersBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View>(self.XamlSetters, Microsoft.Maui.Controls.Shell.TitleViewProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellFlyoutBehavior<T>(this T self,
            Microsoft.Maui.FlyoutBehavior shellFlyoutBehavior)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty, shellFlyoutBehavior);
        return self;
    }

    public static T ShellFlyoutBehavior<T>(this T self,
        Func<Microsoft.Maui.FlyoutBehavior> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellFlyoutBehavior = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty, shellFlyoutBehavior);
        return self;
    }

    public static T ShellFlyoutBehavior<T>(this T self, Func<PropertyContext<Microsoft.Maui.FlyoutBehavior>, IPropertyBuilder<Microsoft.Maui.FlyoutBehavior>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.FlyoutBehavior>(self, Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellFlyoutBehavior<T>(this SettersContext<T> self,
        Microsoft.Maui.FlyoutBehavior shellFlyoutBehavior)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty, Value = shellFlyoutBehavior });
        return self;
    }

    public static SettersContext<T> ShellFlyoutBehavior<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.FlyoutBehavior>, IPropertySettersBuilder<Microsoft.Maui.FlyoutBehavior>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.FlyoutBehavior>(self.XamlSetters, Microsoft.Maui.Controls.Shell.FlyoutBehaviorProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellFlyoutHeight<T>(this T self,
            double shellFlyoutHeight)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutHeightProperty, shellFlyoutHeight);
        return self;
    }

    public static T ShellFlyoutHeight<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellFlyoutHeight = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutHeightProperty, shellFlyoutHeight);
        return self;
    }

    public static T ShellFlyoutHeight<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shell.FlyoutHeightProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellFlyoutHeight<T>(this SettersContext<T> self,
        double shellFlyoutHeight)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.FlyoutHeightProperty, Value = shellFlyoutHeight });
        return self;
    }

    public static SettersContext<T> ShellFlyoutHeight<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shell.FlyoutHeightProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellFlyoutItemIsVisible<T>(this T self,
            bool shellFlyoutItemIsVisible)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutItemIsVisibleProperty, shellFlyoutItemIsVisible);
        return self;
    }

    public static T ShellFlyoutItemIsVisible<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellFlyoutItemIsVisible = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutItemIsVisibleProperty, shellFlyoutItemIsVisible);
        return self;
    }

    public static T ShellFlyoutItemIsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Shell.FlyoutItemIsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellFlyoutItemIsVisible<T>(this SettersContext<T> self,
        bool shellFlyoutItemIsVisible)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.FlyoutItemIsVisibleProperty, Value = shellFlyoutItemIsVisible });
        return self;
    }

    public static SettersContext<T> ShellFlyoutItemIsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Shell.FlyoutItemIsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellFlyoutWidth<T>(this T self,
            double shellFlyoutWidth)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutWidthProperty, shellFlyoutWidth);
        return self;
    }

    public static T ShellFlyoutWidth<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellFlyoutWidth = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.FlyoutWidthProperty, shellFlyoutWidth);
        return self;
    }

    public static T ShellFlyoutWidth<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shell.FlyoutWidthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellFlyoutWidth<T>(this SettersContext<T> self,
        double shellFlyoutWidth)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.FlyoutWidthProperty, Value = shellFlyoutWidth });
        return self;
    }

    public static SettersContext<T> ShellFlyoutWidth<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shell.FlyoutWidthProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellItemTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate shellItemTemplate)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.ItemTemplateProperty, shellItemTemplate);
        return self;
    }

    public static T ShellItemTemplate<T>(this T self,
        Func<Microsoft.Maui.Controls.DataTemplate> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellItemTemplate = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.ItemTemplateProperty, shellItemTemplate);
        return self;
    }

    public static T ShellItemTemplate<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DataTemplate>, IPropertyBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.Shell.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellItemTemplate<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.DataTemplate shellItemTemplate)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.ItemTemplateProperty, Value = shellItemTemplate });
        return self;
    }

    public static SettersContext<T> ShellItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>, IPropertySettersBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>(self.XamlSetters, Microsoft.Maui.Controls.Shell.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellMenuItemTemplate<T>(this T self,
            Microsoft.Maui.Controls.DataTemplate shellMenuItemTemplate)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.MenuItemTemplateProperty, shellMenuItemTemplate);
        return self;
    }

    public static T ShellMenuItemTemplate<T>(this T self,
        Func<Microsoft.Maui.Controls.DataTemplate> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellMenuItemTemplate = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.MenuItemTemplateProperty, shellMenuItemTemplate);
        return self;
    }

    public static T ShellMenuItemTemplate<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DataTemplate>, IPropertyBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.DataTemplate>(self, Microsoft.Maui.Controls.Shell.MenuItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellMenuItemTemplate<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.DataTemplate shellMenuItemTemplate)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.MenuItemTemplateProperty, Value = shellMenuItemTemplate });
        return self;
    }

    public static SettersContext<T> ShellMenuItemTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>, IPropertySettersBuilder<Microsoft.Maui.Controls.DataTemplate>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.DataTemplate>(self.XamlSetters, Microsoft.Maui.Controls.Shell.MenuItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellSearchHandler<T>(this T self,
            Microsoft.Maui.Controls.SearchHandler shellSearchHandler)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.SearchHandlerProperty, shellSearchHandler);
        return self;
    }

    public static T ShellSearchHandler<T>(this T self,
        Func<Microsoft.Maui.Controls.SearchHandler> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellSearchHandler = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.SearchHandlerProperty, shellSearchHandler);
        return self;
    }

    public static T ShellSearchHandler<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.SearchHandler>, IPropertyBuilder<Microsoft.Maui.Controls.SearchHandler>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.SearchHandler>(self, Microsoft.Maui.Controls.Shell.SearchHandlerProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellSearchHandler<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.SearchHandler shellSearchHandler)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.SearchHandlerProperty, Value = shellSearchHandler });
        return self;
    }

    public static SettersContext<T> ShellSearchHandler<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.SearchHandler>, IPropertySettersBuilder<Microsoft.Maui.Controls.SearchHandler>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.SearchHandler>(self.XamlSetters, Microsoft.Maui.Controls.Shell.SearchHandlerProperty);
        configure(context).Build();
        return self;
    }

    public static T ShellTabBarIsVisible<T>(this T self,
            bool shellTabBarIsVisible)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.Shell.TabBarIsVisibleProperty, shellTabBarIsVisible);
        return self;
    }

    public static T ShellTabBarIsVisible<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var shellTabBarIsVisible = configure();
        self.SetValue(Microsoft.Maui.Controls.Shell.TabBarIsVisibleProperty, shellTabBarIsVisible);
        return self;
    }

    public static T ShellTabBarIsVisible<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Shell.TabBarIsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShellTabBarIsVisible<T>(this SettersContext<T> self,
        bool shellTabBarIsVisible)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shell.TabBarIsVisibleProperty, Value = shellTabBarIsVisible });
        return self;
    }

    public static SettersContext<T> ShellTabBarIsVisible<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Shell.TabBarIsVisibleProperty);
        configure(context).Build();
        return self;
    }

    #region Get Methods

    public static Color GetShellTabBarUnselectedColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarUnselectedColorProperty);
    }

    public static Color GetShellTabBarDisabledColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarDisabledColorProperty);
    }

    public static Color GetShellTabBarTitleColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarTitleColorProperty);
    }

    public static Color GetShellTabBarForegroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarForegroundColorProperty);
    }

    public static Color GetShellTabBarBackgroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TabBarBackgroundColorProperty);
    }

    public static bool GetShellNavBarIsVisibleValue<T>(this T self)
        where T : Page
    {
        return (bool)self.GetValue(Shell.NavBarIsVisibleProperty);
    }

    public static bool GetShellNavBarHasShadowValue<T>(this T self)
        where T : Page
    {
        return (bool)self.GetValue(Shell.NavBarHasShadowProperty);
    }

    public static Color GetShellUnselectedColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.UnselectedColorProperty);
    }

    public static Color GetShellDisabledColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.DisabledColorProperty);
    }

    public static Color GetShellTitleColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.TitleColorProperty);
    }

    public static Color GetShellForegroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.ForegroundColorProperty);
    }

    public static Color GetShellBackgroundColorValue<T>(this T self)
        where T : Page
    {
        return (Color)self.GetValue(Shell.BackgroundColorProperty);
    }

    public static PresentationMode GetShellPresentationModeValue<T>(this T self)
        where T : Page
    {
        return (PresentationMode)self.GetValue(Shell.PresentationModeProperty);
    }

    #endregion
}
