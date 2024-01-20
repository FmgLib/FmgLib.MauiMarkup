namespace FmgLib.MauiMarkup;



public static partial class SwipeItemExtension
{
    public static T BackgroundColorFmg<T>(this T self,
        Color backgroundColor)
        where T : SwipeItem
    {
        self.SetValue(SwipeItem.BackgroundColorProperty, backgroundColor);
        return self;
    }
    
    public static T BackgroundColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SwipeItem
    {
        var context = new PropertyContext<Color>(self, SwipeItem.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BackgroundColorFmg<T>(this SettersContext<T> self,
        Color backgroundColor)
        where T : SwipeItem
    {
        self.XamlSetters.Add(new Setter { Property = SwipeItem.BackgroundColorProperty, Value = backgroundColor });
        return self;
    }
    
    public static SettersContext<T> BackgroundColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SwipeItem
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SwipeItem.BackgroundColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsVisibleFmg<T>(this T self,
        bool isVisible)
        where T : SwipeItem
    {
        self.SetValue(SwipeItem.IsVisibleProperty, isVisible);
        return self;
    }
    
    public static T IsVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SwipeItem
    {
        var context = new PropertyContext<bool>(self, SwipeItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self,
        bool isVisible)
        where T : SwipeItem
    {
        self.XamlSetters.Add(new Setter { Property = SwipeItem.IsVisibleProperty, Value = isVisible });
        return self;
    }
    
    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SwipeItem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SwipeItem.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnInvokedFmg<T>(this T self, EventHandler<EventArgs> handler)
        where T : SwipeItem
    {
        self.Invoked += handler;
        return self;
    }
    
    public static T OnInvokedFmg<T>(this T self, Action<T> action)
        where T : SwipeItem
    {
        self.Invoked += (o, arg) => action(self);
        return self;
    }
    
}
