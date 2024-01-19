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
