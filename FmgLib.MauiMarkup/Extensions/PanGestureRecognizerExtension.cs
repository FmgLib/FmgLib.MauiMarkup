namespace FmgLib.MauiMarkup;



public static partial class PanGestureRecognizerExtension
{
    public static T TouchPointsFmg<T>(this T self,
        int touchPoints)
        where T : PanGestureRecognizer
    {
        self.SetValue(PanGestureRecognizer.TouchPointsProperty, touchPoints);
        return self;
    }
    
    public static T TouchPointsFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : PanGestureRecognizer
    {
        var context = new PropertyContext<int>(self, PanGestureRecognizer.TouchPointsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TouchPointsFmg<T>(this SettersContext<T> self,
        int touchPoints)
        where T : PanGestureRecognizer
    {
        self.XamlSetters.Add(new Setter { Property = PanGestureRecognizer.TouchPointsProperty, Value = touchPoints });
        return self;
    }
    
    public static SettersContext<T> TouchPointsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : PanGestureRecognizer
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, PanGestureRecognizer.TouchPointsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnPanUpdatedFmg<T>(this T self, EventHandler<PanUpdatedEventArgs> handler)
        where T : PanGestureRecognizer
    {
        self.PanUpdated += handler;
        return self;
    }
    
    public static T OnPanUpdatedFmg<T>(this T self, Action<T> action)
        where T : PanGestureRecognizer
    {
        self.PanUpdated += (o, arg) => action(self);
        return self;
    }
    
}
