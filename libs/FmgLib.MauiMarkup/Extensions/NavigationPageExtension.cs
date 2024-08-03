namespace FmgLib.MauiMarkup;



public static partial class NavigationPageExtension
{
    public static T BarBackgroundColor<T>(this T self,
        Color barBackgroundColor)
        where T : NavigationPage
    {
        self.SetValue(NavigationPage.BarBackgroundColorProperty, barBackgroundColor);
        return self;
    }
    
    public static T BarBackgroundColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : NavigationPage
    {
        var context = new PropertyContext<Color>(self, NavigationPage.BarBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BarBackgroundColor<T>(this SettersContext<T> self,
        Color barBackgroundColor)
        where T : NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = barBackgroundColor });
        return self;
    }
    
    public static SettersContext<T> BarBackgroundColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : NavigationPage
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, NavigationPage.BarBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBarBackgroundColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : NavigationPage
    {
        Color fromValue = self.BarBackgroundColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BarBackgroundColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBarBackgroundColorTo", transform, callback, length, easing);
    }
    
    public static T BarBackground<T>(this T self,
        Brush barBackground)
        where T : NavigationPage
    {
        self.SetValue(NavigationPage.BarBackgroundProperty, barBackground);
        return self;
    }
    
    public static T BarBackground<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : NavigationPage
    {
        var context = new PropertyContext<Brush>(self, NavigationPage.BarBackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BarBackground<T>(this SettersContext<T> self,
        Brush barBackground)
        where T : NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = NavigationPage.BarBackgroundProperty, Value = barBackground });
        return self;
    }
    
    public static SettersContext<T> BarBackground<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : NavigationPage
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, NavigationPage.BarBackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BarTextColor<T>(this T self,
        Color barTextColor)
        where T : NavigationPage
    {
        self.SetValue(NavigationPage.BarTextColorProperty, barTextColor);
        return self;
    }
    
    public static T BarTextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : NavigationPage
    {
        var context = new PropertyContext<Color>(self, NavigationPage.BarTextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BarTextColor<T>(this SettersContext<T> self,
        Color barTextColor)
        where T : NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = NavigationPage.BarTextColorProperty, Value = barTextColor });
        return self;
    }
    
    public static SettersContext<T> BarTextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : NavigationPage
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, NavigationPage.BarTextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBarTextColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : NavigationPage
    {
        Color fromValue = self.BarTextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BarTextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBarTextColorTo", transform, callback, length, easing);
    }

    public static T HasBackButton<T>(this T self,
            bool hasBackButton)
            where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty, hasBackButton);
        return self;
    }

    public static T HasBackButton<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HasBackButton<T>(this SettersContext<T> self,
        bool hasBackButton)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty, Value = hasBackButton });
        return self;
    }

    public static SettersContext<T> HasBackButton<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.HasBackButtonProperty);
        configure(context).Build();
        return self;
    }

    public static T TitleIconImageSource<T>(this T self,
            Microsoft.Maui.Controls.ImageSource titleIconImageSource)
            where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty, titleIconImageSource);
        return self;
    }

    public static T TitleIconImageSource<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleIconImageSource<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource titleIconImageSource)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty, Value = titleIconImageSource });
        return self;
    }

    public static SettersContext<T> TitleIconImageSource<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.TitleIconImageSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T IconColor<T>(this T self,
            Microsoft.Maui.Graphics.Color iconColor)
            where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.IconColorProperty, iconColor);
        return self;
    }

    public static T IconColor<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.NavigationPage.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconColor<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color iconColor)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.IconColorProperty, Value = iconColor });
        return self;
    }

    public static SettersContext<T> IconColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TitleView<T>(this T self,
            Microsoft.Maui.Controls.View titleView)
            where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.SetValue(Microsoft.Maui.Controls.NavigationPage.TitleViewProperty, titleView);
        return self;
    }

    public static T TitleView<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View>, IPropertyBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.NavigationPage.TitleViewProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleView<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View titleView)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.NavigationPage.TitleViewProperty, Value = titleView });
        return self;
    }

    public static SettersContext<T> TitleView<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View>, IPropertySettersBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.NavigationPage
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View>(self.XamlSetters, Microsoft.Maui.Controls.NavigationPage.TitleViewProperty);
        configure(context).Build();
        return self;
    }

    public static T OnPopped<T>(this T self, EventHandler<NavigationEventArgs> handler)
        where T : NavigationPage
    {
        self.Popped += handler;
        return self;
    }
    
    public static T OnPopped<T>(this T self, Action<T> action)
        where T : NavigationPage
    {
        self.Popped += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPoppedToRoot<T>(this T self, EventHandler<NavigationEventArgs> handler)
        where T : NavigationPage
    {
        self.PoppedToRoot += handler;
        return self;
    }
    
    public static T OnPoppedToRoot<T>(this T self, Action<T> action)
        where T : NavigationPage
    {
        self.PoppedToRoot += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPushed<T>(this T self, EventHandler<NavigationEventArgs> handler)
        where T : NavigationPage
    {
        self.Pushed += handler;
        return self;
    }
    
    public static T OnPushed<T>(this T self, Action<T> action)
        where T : NavigationPage
    {
        self.Pushed += (o, arg) => action(self);
        return self;
    }
    
}
