namespace FmgLib.MauiMarkup;


public static partial class ActivityIndicatorExtension
{
    public static T ColorFmg<T>(this T self, Color color) where T : ActivityIndicator
    {
        self.SetValue(ActivityIndicator.ColorProperty, color);

        return self;
    }
    
    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : ActivityIndicator
    {
        var context = new PropertyContext<Color>(self, ActivityIndicator.ColorProperty);
        configure(context).Build();

        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Color color) where T : ActivityIndicator
    {
        self.XamlSetters.Add(new Setter { Property = ActivityIndicator.ColorProperty, Value = color });
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : ActivityIndicator
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ActivityIndicator.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null) where T : ActivityIndicator
    {
        Color fromValue = self.Color;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.Color = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateColorTo", transform, callback, length, easing);
    }
    
    public static T IsRunningFmg<T>(this T self,
        bool isRunning)
        where T : ActivityIndicator
    {
        self.SetValue(ActivityIndicator.IsRunningProperty, isRunning);
        return self;
    }
    
    public static T IsRunningFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : ActivityIndicator
    {
        var context = new PropertyContext<bool>(self, ActivityIndicator.IsRunningProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsRunningFmg<T>(this SettersContext<T> self,
        bool isRunning)
        where T : ActivityIndicator
    {
        self.XamlSetters.Add(new Setter { Property = ActivityIndicator.IsRunningProperty, Value = isRunning });
        return self;
    }
    
    public static SettersContext<T> IsRunningFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : ActivityIndicator
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, ActivityIndicator.IsRunningProperty);
        configure(context).Build();
        return self;
    }
    
}
