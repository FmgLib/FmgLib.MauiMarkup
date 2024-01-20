namespace FmgLib.MauiMarkup;



public static partial class ScrollViewExtension
{
    public static T LayoutAreaOverrideFmg<T>(this T self,
        Rect layoutAreaOverride)
        where T : ScrollView
    {
        self.LayoutAreaOverride = layoutAreaOverride;
        return self;
    }
    
    public static T ContentFmg<T>(this T self,
        View content)
        where T : ScrollView
    {
        self.Content = content;
        return self;
    }
    
    public static T OrientationFmg<T>(this T self,
        ScrollOrientation orientation)
        where T : ScrollView
    {
        self.SetValue(ScrollView.OrientationProperty, orientation);
        return self;
    }
    
    public static T OrientationFmg<T>(this T self, Func<PropertyContext<ScrollOrientation>, IPropertyBuilder<ScrollOrientation>> configure)
        where T : ScrollView
    {
        var context = new PropertyContext<ScrollOrientation>(self, ScrollView.OrientationProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OrientationFmg<T>(this SettersContext<T> self,
        ScrollOrientation orientation)
        where T : ScrollView
    {
        self.XamlSetters.Add(new Setter { Property = ScrollView.OrientationProperty, Value = orientation });
        return self;
    }
    
    public static SettersContext<T> OrientationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollOrientation>, IPropertySettersBuilder<ScrollOrientation>> configure)
        where T : ScrollView
    {
        var context = new PropertySettersContext<ScrollOrientation>(self.XamlSetters, ScrollView.OrientationProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HorizontalScrollBarVisibilityFmg<T>(this T self,
        ScrollBarVisibility horizontalScrollBarVisibility)
        where T : ScrollView
    {
        self.SetValue(ScrollView.HorizontalScrollBarVisibilityProperty, horizontalScrollBarVisibility);
        return self;
    }
    
    public static T HorizontalScrollBarVisibilityFmg<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure)
        where T : ScrollView
    {
        var context = new PropertyContext<ScrollBarVisibility>(self, ScrollView.HorizontalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalScrollBarVisibilityFmg<T>(this SettersContext<T> self,
        ScrollBarVisibility horizontalScrollBarVisibility)
        where T : ScrollView
    {
        self.XamlSetters.Add(new Setter { Property = ScrollView.HorizontalScrollBarVisibilityProperty, Value = horizontalScrollBarVisibility });
        return self;
    }
    
    public static SettersContext<T> HorizontalScrollBarVisibilityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure)
        where T : ScrollView
    {
        var context = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ScrollView.HorizontalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalScrollBarVisibilityFmg<T>(this T self,
        ScrollBarVisibility verticalScrollBarVisibility)
        where T : ScrollView
    {
        self.SetValue(ScrollView.VerticalScrollBarVisibilityProperty, verticalScrollBarVisibility);
        return self;
    }
    
    public static T VerticalScrollBarVisibilityFmg<T>(this T self, Func<PropertyContext<ScrollBarVisibility>, IPropertyBuilder<ScrollBarVisibility>> configure)
        where T : ScrollView
    {
        var context = new PropertyContext<ScrollBarVisibility>(self, ScrollView.VerticalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalScrollBarVisibilityFmg<T>(this SettersContext<T> self,
        ScrollBarVisibility verticalScrollBarVisibility)
        where T : ScrollView
    {
        self.XamlSetters.Add(new Setter { Property = ScrollView.VerticalScrollBarVisibilityProperty, Value = verticalScrollBarVisibility });
        return self;
    }
    
    public static SettersContext<T> VerticalScrollBarVisibilityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ScrollBarVisibility>, IPropertySettersBuilder<ScrollBarVisibility>> configure)
        where T : ScrollView
    {
        var context = new PropertySettersContext<ScrollBarVisibility>(self.XamlSetters, ScrollView.VerticalScrollBarVisibilityProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnScrollToRequestedFmg<T>(this T self, EventHandler<ScrollToRequestedEventArgs> handler)
        where T : ScrollView
    {
        self.ScrollToRequested += handler;
        return self;
    }
    
    public static T OnScrollToRequestedFmg<T>(this T self, Action<T> action)
        where T : ScrollView
    {
        self.ScrollToRequested += (o, arg) => action(self);
        return self;
    }
    
    public static T OnScrolledFmg<T>(this T self, EventHandler<ScrolledEventArgs> handler)
        where T : ScrollView
    {
        self.Scrolled += handler;
        return self;
    }
    
    public static T OnScrolledFmg<T>(this T self, Action<T> action)
        where T : ScrollView
    {
        self.Scrolled += (o, arg) => action(self);
        return self;
    }
    
}
