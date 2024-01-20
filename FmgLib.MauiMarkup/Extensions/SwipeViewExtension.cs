using ISwipeItem = Microsoft.Maui.Controls.ISwipeItem;

namespace FmgLib.MauiMarkup;



public static partial class SwipeViewExtension
{
    public static T ThresholdFmg<T>(this T self,
        double threshold)
        where T : SwipeView
    {
        self.SetValue(SwipeView.ThresholdProperty, threshold);
        return self;
    }
    
    public static T ThresholdFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SwipeView
    {
        var context = new PropertyContext<double>(self, SwipeView.ThresholdProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ThresholdFmg<T>(this SettersContext<T> self,
        double threshold)
        where T : SwipeView
    {
        self.XamlSetters.Add(new Setter { Property = SwipeView.ThresholdProperty, Value = threshold });
        return self;
    }
    
    public static SettersContext<T> ThresholdFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SwipeView
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SwipeView.ThresholdProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateThresholdToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : SwipeView
    {
        double fromValue = self.Threshold;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Threshold = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateThresholdTo", transform, callback, length, easing);
    }
    
    public static T LeftItemsFmg<T>(this T self,
        IList<ISwipeItem> leftItems)
        where T : SwipeView
    {
        foreach (var item in leftItems)
            self.LeftItems.Add(item);
        return self;
    }

    public static T LeftItemsFmg<T>(this T self,
        params ISwipeItem[] leftItems)
        where T : SwipeView
    {
        foreach (var item in leftItems)
            self.LeftItems.Add(item);
        return self;
    }
    
    public static T LeftItemsFmg<T>(this T self, Func<PropertyContext<SwipeItems>, IPropertyBuilder<SwipeItems>> configure)
        where T : SwipeView
    {
        var context = new PropertyContext<SwipeItems>(self, SwipeView.LeftItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RightItemsFmg<T>(this T self,
        IList<ISwipeItem> rightItems)
        where T : SwipeView
    {
        foreach (var item in rightItems)
            self.RightItems.Add(item);
        return self;
    }

    public static T RightItemsFmg<T>(this T self,
        params ISwipeItem[] rightItems)
        where T : SwipeView
    {
        foreach (var item in rightItems)
            self.RightItems.Add(item);
        return self;
    }
    
    public static T RightItemsFmg<T>(this T self, Func<PropertyContext<SwipeItems>, IPropertyBuilder<SwipeItems>> configure)
        where T : SwipeView
    {
        var context = new PropertyContext<SwipeItems>(self, SwipeView.RightItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TopItemsFmg<T>(this T self,
        IList<ISwipeItem> topItems)
        where T : SwipeView
    {
        foreach (var item in topItems)
            self.TopItems.Add(item);
        return self;
    }

    public static T TopItemsFmg<T>(this T self,
        params ISwipeItem[] topItems)
        where T : SwipeView
    {
        foreach (var item in topItems)
            self.TopItems.Add(item);
        return self;
    }
    
    public static T TopItemsFmg<T>(this T self, Func<PropertyContext<SwipeItems>, IPropertyBuilder<SwipeItems>> configure)
        where T : SwipeView
    {
        var context = new PropertyContext<SwipeItems>(self, SwipeView.TopItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BottomItemsFmg<T>(this T self,
        IList<ISwipeItem> bottomItems)
        where T : SwipeView
    {
        foreach (var item in bottomItems)
            self.BottomItems.Add(item);
        return self;
    }

    public static T BottomItemsFmg<T>(this T self,
        params ISwipeItem[] bottomItems)
        where T : SwipeView
    {
        foreach (var item in bottomItems)
            self.BottomItems.Add(item);
        return self;
    }
    
    public static T BottomItemsFmg<T>(this T self, Func<PropertyContext<SwipeItems>, IPropertyBuilder<SwipeItems>> configure)
        where T : SwipeView
    {
        var context = new PropertyContext<SwipeItems>(self, SwipeView.BottomItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnSwipeStartedFmg<T>(this T self, EventHandler<SwipeStartedEventArgs> handler)
        where T : SwipeView
    {
        self.SwipeStarted += handler;
        return self;
    }
    
    public static T OnSwipeStartedFmg<T>(this T self, Action<T> action)
        where T : SwipeView
    {
        self.SwipeStarted += (o, arg) => action(self);
        return self;
    }
    
    public static T OnSwipeChangingFmg<T>(this T self, EventHandler<SwipeChangingEventArgs> handler)
        where T : SwipeView
    {
        self.SwipeChanging += handler;
        return self;
    }
    
    public static T OnSwipeChangingFmg<T>(this T self, Action<T> action)
        where T : SwipeView
    {
        self.SwipeChanging += (o, arg) => action(self);
        return self;
    }
    
    public static T OnSwipeEndedFmg<T>(this T self, EventHandler<SwipeEndedEventArgs> handler)
        where T : SwipeView
    {
        self.SwipeEnded += handler;
        return self;
    }
    
    public static T OnSwipeEndedFmg<T>(this T self, Action<T> action)
        where T : SwipeView
    {
        self.SwipeEnded += (o, arg) => action(self);
        return self;
    }
    
    public static T OnOpenRequestedFmg<T>(this T self, EventHandler<OpenRequestedEventArgs> handler)
        where T : SwipeView
    {
        self.OpenRequested += handler;
        return self;
    }
    
    public static T OnOpenRequestedFmg<T>(this T self, Action<T> action)
        where T : SwipeView
    {
        self.OpenRequested += (o, arg) => action(self);
        return self;
    }
    
    public static T OnCloseRequestedFmg<T>(this T self, EventHandler<CloseRequestedEventArgs> handler)
        where T : SwipeView
    {
        self.CloseRequested += handler;
        return self;
    }
    
    public static T OnCloseRequestedFmg<T>(this T self, Action<T> action)
        where T : SwipeView
    {
        self.CloseRequested += (o, arg) => action(self);
        return self;
    }
    
}
