namespace FmgLib.MauiMarkup;

public static partial class FlyoutPageExtension
{
    public static T DetailFmg<T>(this T self,
        Page detail)
        where T : FlyoutPage
    {
        self.Detail = detail;
        return self;
    }
    
    public static T IsGestureEnabledFmg<T>(this T self,
        bool isGestureEnabled)
        where T : FlyoutPage
    {
        self.SetValue(FlyoutPage.IsGestureEnabledProperty, isGestureEnabled);
        return self;
    }
    
    public static T IsGestureEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertyContext<bool>(self, FlyoutPage.IsGestureEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsGestureEnabledFmg<T>(this SettersContext<T> self,
        bool isGestureEnabled)
        where T : FlyoutPage
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutPage.IsGestureEnabledProperty, Value = isGestureEnabled });
        return self;
    }
    
    public static SettersContext<T> IsGestureEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, FlyoutPage.IsGestureEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsPresentedFmg<T>(this T self,
        bool isPresented)
        where T : FlyoutPage
    {
        self.SetValue(FlyoutPage.IsPresentedProperty, isPresented);
        return self;
    }
    
    public static T IsPresentedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertyContext<bool>(self, FlyoutPage.IsPresentedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsPresentedFmg<T>(this SettersContext<T> self,
        bool isPresented)
        where T : FlyoutPage
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutPage.IsPresentedProperty, Value = isPresented });
        return self;
    }
    
    public static SettersContext<T> IsPresentedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, FlyoutPage.IsPresentedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FlyoutFmg<T>(this T self,
        Page flyout)
        where T : FlyoutPage
    {
        self.Flyout = flyout;
        return self;
    }
    
    public static T FlyoutLayoutBehaviorFmg<T>(this T self,
        FlyoutLayoutBehavior flyoutLayoutBehavior)
        where T : FlyoutPage
    {
        self.SetValue(FlyoutPage.FlyoutLayoutBehaviorProperty, flyoutLayoutBehavior);
        return self;
    }
    
    public static T FlyoutLayoutBehaviorFmg<T>(this T self, Func<PropertyContext<FlyoutLayoutBehavior>, IPropertyBuilder<FlyoutLayoutBehavior>> configure)
        where T : FlyoutPage
    {
        var context = new PropertyContext<FlyoutLayoutBehavior>(self, FlyoutPage.FlyoutLayoutBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutLayoutBehaviorFmg<T>(this SettersContext<T> self,
        FlyoutLayoutBehavior flyoutLayoutBehavior)
        where T : FlyoutPage
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutPage.FlyoutLayoutBehaviorProperty, Value = flyoutLayoutBehavior });
        return self;
    }
    
    public static SettersContext<T> FlyoutLayoutBehaviorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<FlyoutLayoutBehavior>, IPropertySettersBuilder<FlyoutLayoutBehavior>> configure)
        where T : FlyoutPage
    {
        var context = new PropertySettersContext<FlyoutLayoutBehavior>(self.XamlSetters, FlyoutPage.FlyoutLayoutBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnIsPresentedChangedFmg<T>(this T self, EventHandler handler)
        where T : FlyoutPage
    {
        self.IsPresentedChanged += handler;
        return self;
    }
    
    public static T OnIsPresentedChangedFmg<T>(this T self, Action<T> action)
        where T : FlyoutPage
    {
        self.IsPresentedChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnBackButtonPressedFmg<T>(this T self, EventHandler<BackButtonPressedEventArgs> handler)
        where T : FlyoutPage
    {
        self.BackButtonPressed += handler;
        return self;
    }
    
    public static T OnBackButtonPressedFmg<T>(this T self, Action<T> action)
        where T : FlyoutPage
    {
        self.BackButtonPressed += (o, arg) => action(self);
        return self;
    }
    
}