namespace FmgLib.MauiMarkup;



public static partial class TabbedPageExtension
{
    public static T BarBackgroundColorFmg<T>(this T self,
        Color barBackgroundColor)
        where T : TabbedPage
    {
        self.SetValue(TabbedPage.BarBackgroundColorProperty, barBackgroundColor);
        return self;
    }
    
    public static T BarBackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertyContext<Color>(self, TabbedPage.BarBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BarBackgroundColorFmg<T>(this SettersContext<T> self,
        Color barBackgroundColor)
        where T : TabbedPage
    {
        self.XamlSetters.Add(new Setter { Property = TabbedPage.BarBackgroundColorProperty, Value = barBackgroundColor });
        return self;
    }
    
    public static SettersContext<T> BarBackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabbedPage.BarBackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBarBackgroundColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : TabbedPage
    {
        Color fromValue = self.BarBackgroundColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BarBackgroundColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBarBackgroundColorTo", transform, callback, length, easing);
    }
    
    public static T BarBackgroundFmg<T>(this T self,
        Brush barBackground)
        where T : TabbedPage
    {
        self.SetValue(TabbedPage.BarBackgroundProperty, barBackground);
        return self;
    }
    
    public static T BarBackgroundFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : TabbedPage
    {
        var context = new PropertyContext<Brush>(self, TabbedPage.BarBackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BarBackgroundFmg<T>(this SettersContext<T> self,
        Brush barBackground)
        where T : TabbedPage
    {
        self.XamlSetters.Add(new Setter { Property = TabbedPage.BarBackgroundProperty, Value = barBackground });
        return self;
    }
    
    public static SettersContext<T> BarBackgroundFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : TabbedPage
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, TabbedPage.BarBackgroundProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BarTextColorFmg<T>(this T self,
        Color barTextColor)
        where T : TabbedPage
    {
        self.SetValue(TabbedPage.BarTextColorProperty, barTextColor);
        return self;
    }
    
    public static T BarTextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertyContext<Color>(self, TabbedPage.BarTextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BarTextColorFmg<T>(this SettersContext<T> self,
        Color barTextColor)
        where T : TabbedPage
    {
        self.XamlSetters.Add(new Setter { Property = TabbedPage.BarTextColorProperty, Value = barTextColor });
        return self;
    }
    
    public static SettersContext<T> BarTextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabbedPage.BarTextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBarTextColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : TabbedPage
    {
        Color fromValue = self.BarTextColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BarTextColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBarTextColorTo", transform, callback, length, easing);
    }
    
    public static T UnselectedTabColorFmg<T>(this T self,
        Color unselectedTabColor)
        where T : TabbedPage
    {
        self.SetValue(TabbedPage.UnselectedTabColorProperty, unselectedTabColor);
        return self;
    }
    
    public static T UnselectedTabColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertyContext<Color>(self, TabbedPage.UnselectedTabColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> UnselectedTabColorFmg<T>(this SettersContext<T> self,
        Color unselectedTabColor)
        where T : TabbedPage
    {
        self.XamlSetters.Add(new Setter { Property = TabbedPage.UnselectedTabColorProperty, Value = unselectedTabColor });
        return self;
    }
    
    public static SettersContext<T> UnselectedTabColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabbedPage.UnselectedTabColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateUnselectedTabColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : TabbedPage
    {
        Color fromValue = self.UnselectedTabColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.UnselectedTabColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateUnselectedTabColorTo", transform, callback, length, easing);
    }
    
    public static T SelectedTabColorFmg<T>(this T self,
        Color selectedTabColor)
        where T : TabbedPage
    {
        self.SetValue(TabbedPage.SelectedTabColorProperty, selectedTabColor);
        return self;
    }
    
    public static T SelectedTabColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertyContext<Color>(self, TabbedPage.SelectedTabColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedTabColorFmg<T>(this SettersContext<T> self,
        Color selectedTabColor)
        where T : TabbedPage
    {
        self.XamlSetters.Add(new Setter { Property = TabbedPage.SelectedTabColorProperty, Value = selectedTabColor });
        return self;
    }
    
    public static SettersContext<T> SelectedTabColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabbedPage
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabbedPage.SelectedTabColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateSelectedTabColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : TabbedPage
    {
        Color fromValue = self.SelectedTabColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.SelectedTabColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateSelectedTabColorTo", transform, callback, length, easing);
    }
    
}
