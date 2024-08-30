namespace FmgLib.MauiMarkup;

public static partial class PageExtension
{
    public static T NavigationPageHasNavigationBar<T>(this T self,
            bool hasNavigationBar)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.HasNavigationBarProperty, hasNavigationBar);
        return self;
    }

    public static T NavigationPageHasNavigationBar<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.NavigationPage.HasNavigationBarProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NavigationPageHasNavigationBar<T>(this SettersContext<T> self,
        bool hasNavigationBar)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.HasNavigationBarProperty, Value = hasNavigationBar });
        return self;
    }

    public static SettersContext<T> NavigationPageHasNavigationBar<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.HasNavigationBarProperty);
        configure(context).Build();
        return self;
    }

    public static T NavigationPageBackButtonTitle<T>(this T self,
            string backButtonTitle)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.BackButtonTitleProperty, backButtonTitle);
        return self;
    }

    public static T NavigationPageBackButtonTitle<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.NavigationPage.BackButtonTitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NavigationPageBackButtonTitle<T>(this SettersContext<T> self,
        string backButtonTitle)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.BackButtonTitleProperty, Value = backButtonTitle });
        return self;
    }

    public static SettersContext<T> NavigationPageBackButtonTitle<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.BackButtonTitleProperty);
        configure(context).Build();
        return self;
    }

    public static T NavigationPageHasBackButton<T>(this T self,
            bool navigationPageHasBackButton)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty, navigationPageHasBackButton);
        return self;
    }

    public static T NavigationPageHasBackButton<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var navigationPageHasBackButton = configure();
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty, navigationPageHasBackButton);
        return self;
    }

    public static T NavigationPageHasBackButton<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NavigationPageHasBackButton<T>(this SettersContext<T> self,
        bool navigationPageHasBackButton)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty, Value = navigationPageHasBackButton });
        return self;
    }

    public static SettersContext<T> NavigationPageHasBackButton<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty);
        configure(context).Build();
        return self;
    }

    public static T NavigationPageIconColor<T>(this T self,
            Microsoft.Maui.Graphics.Color navigationPageIconColor)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.IconColorProperty, navigationPageIconColor);
        return self;
    }

    public static T NavigationPageIconColor<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var navigationPageIconColor = configure();
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.IconColorProperty, navigationPageIconColor);
        return self;
    }

    public static T NavigationPageIconColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.NavigationPage.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NavigationPageIconColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color navigationPageIconColor)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.IconColorProperty, Value = navigationPageIconColor });
        return self;
    }

    public static SettersContext<T> NavigationPageIconColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static T NavigationPageTitleIconImageSource<T>(this T self,
            Microsoft.Maui.Controls.ImageSource navigationPageTitleIconImageSource)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty, navigationPageTitleIconImageSource);
        return self;
    }

    public static T NavigationPageTitleIconImageSource<T>(this T self,
        Func<Microsoft.Maui.Controls.ImageSource> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var navigationPageTitleIconImageSource = configure();
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty, navigationPageTitleIconImageSource);
        return self;
    }

    public static T NavigationPageTitleIconImageSource<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NavigationPageTitleIconImageSource<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource navigationPageTitleIconImageSource)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty, Value = navigationPageTitleIconImageSource });
        return self;
    }

    public static SettersContext<T> NavigationPageTitleIconImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T NavigationPageTitleView<T>(this T self,
            Microsoft.Maui.Controls.View navigationPageTitleView)
            where T : Microsoft.Maui.Controls.Page
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleViewProperty, navigationPageTitleView);
        return self;
    }

    public static T NavigationPageTitleView<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var navigationPageTitleView = configure();
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleViewProperty, navigationPageTitleView);
        return self;
    }

    public static T NavigationPageTitleView<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View>, IPropertyBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.NavigationPage.TitleViewProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NavigationPageTitleView<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View navigationPageTitleView)
        where T : Microsoft.Maui.Controls.Page
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.TitleViewProperty, Value = navigationPageTitleView });
        return self;
    }

    public static SettersContext<T> NavigationPageTitleView<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View>, IPropertySettersBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.Page
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.TitleViewProperty);
        configure(context).Build();
        return self;
    }
}
