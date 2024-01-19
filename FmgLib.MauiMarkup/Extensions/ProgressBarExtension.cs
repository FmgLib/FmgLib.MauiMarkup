namespace FmgLib.MauiMarkup;



public static partial class ProgressBarExtension
{
    public static T ProgressColor<T>(this T self,
        Color progressColor)
        where T : ProgressBar
    {
        self.SetValue(ProgressBar.ProgressColorProperty, progressColor);
        return self;
    }
    
    public static T ProgressColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ProgressBar
    {
        var context = new PropertyContext<Color>(self, ProgressBar.ProgressColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ProgressColor<T>(this SettersContext<T> self,
        Color progressColor)
        where T : ProgressBar
    {
        self.XamlSetters.Add(new Setter { Property = ProgressBar.ProgressColorProperty, Value = progressColor });
        return self;
    }
    
    public static SettersContext<T> ProgressColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ProgressBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ProgressBar.ProgressColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateProgressColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : ProgressBar
    {
        Color fromValue = self.ProgressColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.ProgressColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateProgressColorTo", transform, callback, length, easing);
    }
    
    public static T Progress<T>(this T self,
        double progress)
        where T : ProgressBar
    {
        self.SetValue(ProgressBar.ProgressProperty, progress);
        return self;
    }
    
    public static T Progress<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : ProgressBar
    {
        var context = new PropertyContext<double>(self, ProgressBar.ProgressProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Progress<T>(this SettersContext<T> self,
        double progress)
        where T : ProgressBar
    {
        self.XamlSetters.Add(new Setter { Property = ProgressBar.ProgressProperty, Value = progress });
        return self;
    }
    
    public static SettersContext<T> Progress<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : ProgressBar
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, ProgressBar.ProgressProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateProgressTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : ProgressBar
    {
        double fromValue = self.Progress;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Progress = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateProgressTo", transform, callback, length, easing);
    }
    
}
