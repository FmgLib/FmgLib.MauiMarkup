namespace FmgLib.MauiMarkup;

public static partial class FlyoutPageExtension
{
    public static T Detail<T>(this T self,
        Page detail)
        where T : FlyoutPage
    {
        self.Detail = detail;
        return self;
    }
    
    public static T IsGestureEnabled<T>(this T self,
        bool isGestureEnabled)
        where T : FlyoutPage
    {
        self.SetValue(FlyoutPage.IsGestureEnabledProperty, isGestureEnabled);
        return self;
    }
    
    public static T IsGestureEnabled<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertyContext<bool>(self, FlyoutPage.IsGestureEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsGestureEnabled<T>(this SettersContext<T> self,
        bool isGestureEnabled)
        where T : FlyoutPage
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutPage.IsGestureEnabledProperty, Value = isGestureEnabled });
        return self;
    }
    
    public static SettersContext<T> IsGestureEnabled<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, FlyoutPage.IsGestureEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsPresented<T>(this T self,
        bool isPresented)
        where T : FlyoutPage
    {
        self.SetValue(FlyoutPage.IsPresentedProperty, isPresented);
        return self;
    }
    
    public static T IsPresented<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertyContext<bool>(self, FlyoutPage.IsPresentedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsPresented<T>(this SettersContext<T> self,
        bool isPresented)
        where T : FlyoutPage
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutPage.IsPresentedProperty, Value = isPresented });
        return self;
    }
    
    public static SettersContext<T> IsPresented<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : FlyoutPage
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, FlyoutPage.IsPresentedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Flyout<T>(this T self,
        Page flyout)
        where T : FlyoutPage
    {
        self.Flyout = flyout;
        return self;
    }
    
    public static T FlyoutLayoutBehavior<T>(this T self,
        FlyoutLayoutBehavior flyoutLayoutBehavior)
        where T : FlyoutPage
    {
        self.SetValue(FlyoutPage.FlyoutLayoutBehaviorProperty, flyoutLayoutBehavior);
        return self;
    }
    
    public static T FlyoutLayoutBehavior<T>(this T self, Func<PropertyContext<FlyoutLayoutBehavior>, IPropertyBuilder<FlyoutLayoutBehavior>> configure)
        where T : FlyoutPage
    {
        var context = new PropertyContext<FlyoutLayoutBehavior>(self, FlyoutPage.FlyoutLayoutBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FlyoutLayoutBehavior<T>(this SettersContext<T> self,
        FlyoutLayoutBehavior flyoutLayoutBehavior)
        where T : FlyoutPage
    {
        self.XamlSetters.Add(new Setter { Property = FlyoutPage.FlyoutLayoutBehaviorProperty, Value = flyoutLayoutBehavior });
        return self;
    }
    
    public static SettersContext<T> FlyoutLayoutBehavior<T>(this SettersContext<T> self, Func<PropertySettersContext<FlyoutLayoutBehavior>, IPropertySettersBuilder<FlyoutLayoutBehavior>> configure)
        where T : FlyoutPage
    {
        var context = new PropertySettersContext<FlyoutLayoutBehavior>(self.XamlSetters, FlyoutPage.FlyoutLayoutBehaviorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnIsPresentedChanged<T>(this T self, EventHandler handler)
        where T : FlyoutPage
    {
        self.IsPresentedChanged += handler;
        return self;
    }
    
    public static T OnIsPresentedChanged<T>(this T self, Action<T> action)
        where T : FlyoutPage
    {
        self.IsPresentedChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnBackButtonPressed<T>(this T self, EventHandler<BackButtonPressedEventArgs> handler)
        where T : FlyoutPage
    {
        self.BackButtonPressed += handler;
        return self;
    }
    
    public static T OnBackButtonPressed<T>(this T self, Action<T> action)
        where T : FlyoutPage
    {
        self.BackButtonPressed += (o, arg) => action(self);
        return self;
    }
    
}