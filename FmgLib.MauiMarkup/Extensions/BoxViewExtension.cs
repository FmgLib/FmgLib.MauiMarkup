namespace FmgLib.MauiMarkup;

public static partial class BoxViewExtension
{
    public static T ColorFmg<T>(this T self,
        Color color)
        where T : BoxView
    {
        self.SetValue(BoxView.ColorProperty, color);
        return self;
    }
    
    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : BoxView
    {
        var context = new PropertyContext<Color>(self, BoxView.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : BoxView
    {
        self.XamlSetters.Add(new Setter { Property = BoxView.ColorProperty, Value = color });
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : BoxView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, BoxView.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : BoxView
    {
        Color fromValue = self.Color;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.Color = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateColorTo", transform, callback, length, easing);
    }
    
    public static T CornerRadiusFmg<T>(this T self,
        CornerRadius cornerRadius)
        where T : BoxView
    {
        self.SetValue(BoxView.CornerRadiusProperty, cornerRadius);
        return self;
    }
    
    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<CornerRadius>, IPropertyBuilder<CornerRadius>> configure)
        where T : BoxView
    {
        var context = new PropertyContext<CornerRadius>(self, BoxView.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self,
        CornerRadius cornerRadius)
        where T : BoxView
    {
        self.XamlSetters.Add(new Setter { Property = BoxView.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }
    
    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<CornerRadius>, IPropertySettersBuilder<CornerRadius>> configure)
        where T : BoxView
    {
        var context = new PropertySettersContext<CornerRadius>(self.XamlSetters, BoxView.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
}