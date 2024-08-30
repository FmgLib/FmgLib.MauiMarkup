namespace FmgLib.MauiMarkup;

public static partial class FrameExtension
{
    public static T HasShadow<T>(this T self,
        bool hasShadow)
        where T : Frame
    {
        self.SetValue(Frame.HasShadowProperty, hasShadow);
        return self;
    }
    
    public static T HasShadow<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Frame
    {
        var context = new PropertyContext<bool>(self, Frame.HasShadowProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HasShadow<T>(this SettersContext<T> self,
        bool hasShadow)
        where T : Frame
    {
        self.XamlSetters.Add(new Setter { Property = Frame.HasShadowProperty, Value = hasShadow });
        return self;
    }
    
    public static SettersContext<T> HasShadow<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Frame
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Frame.HasShadowProperty);
        configure(context).Build();
        return self;
    }
    
    public static T BorderColor<T>(this T self,
        Color borderColor)
        where T : Frame
    {
        self.SetValue(Frame.BorderColorProperty, borderColor);
        return self;
    }
    
    public static T BorderColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Frame
    {
        var context = new PropertyContext<Color>(self, Frame.BorderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self,
        Color borderColor)
        where T : Frame
    {
        self.XamlSetters.Add(new Setter { Property = Frame.BorderColorProperty, Value = borderColor });
        return self;
    }
    
    public static SettersContext<T> BorderColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Frame
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Frame.BorderColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateBorderColorTo<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Frame
    {
        Color fromValue = self.BorderColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.BorderColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateBorderColorTo", transform, callback, length, easing);
    }
    
    public static T CornerRadius<T>(this T self,
        float cornerRadius)
        where T : Frame
    {
        self.SetValue(Frame.CornerRadiusProperty, cornerRadius);
        return self;
    }
    
    public static T CornerRadius<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure)
        where T : Frame
    {
        var context = new PropertyContext<float>(self, Frame.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self,
        float cornerRadius)
        where T : Frame
    {
        self.XamlSetters.Add(new Setter { Property = Frame.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }
    
    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure)
        where T : Frame
    {
        var context = new PropertySettersContext<float>(self.XamlSetters, Frame.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
}