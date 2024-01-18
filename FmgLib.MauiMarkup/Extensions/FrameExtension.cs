namespace FmgLib.MauiMarkup;

public static class FrameExtension
{
    public static T HasShadowFmg<T>(this T self, bool hasShadow) where T : Frame
    {
        self.SetValue(Frame.HasShadowProperty, hasShadow);
        return self;
    }

    public static T HasShadowFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Frame
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Frame.HasShadowProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HasShadowFmg<T>(this SettersContext<T> self, bool hasShadow) where T : Frame
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Frame.HasShadowProperty,
            Value = hasShadow
        });
        return self;
    }

    public static SettersContext<T> HasShadowFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Frame
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Frame.HasShadowProperty);
        configure(arg).Build();
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Color borderColor) where T : Frame
    {
        self.SetValue(Frame.BorderColorProperty, borderColor);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : Frame
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, Frame.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Color borderColor) where T : Frame
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Frame.BorderColorProperty,
            Value = borderColor
        });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : Frame
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, Frame.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateBorderColorToFmg<T>(this T self, Color value, uint length = 250u, Easing? easing = null) where T : Frame
    {
        Color value2 = value;
        T self2 = self;
        Color fromValue = self2.BorderColor;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.ColorTransform(fromValue, value2, t), callback: delegate (Color actValue)
        {
            self2.BorderColor = actValue;
        }, element: self2, name: "AnimateBorderColorTo", length: length, easing: easing);
    }

    public static T CornerRadiusFmg<T>(this T self, float cornerRadius) where T : Frame
    {
        self.SetValue(Frame.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadiusFmg<T>(this T self, Func<PropertyContext<float>, IPropertyBuilder<float>> configure) where T : Frame
    {
        PropertyContext<float> arg = new PropertyContext<float>(self, Frame.CornerRadiusProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, float cornerRadius) where T : Frame
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Frame.CornerRadiusProperty,
            Value = cornerRadius
        });
        return self;
    }

    public static SettersContext<T> CornerRadiusFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<float>, IPropertySettersBuilder<float>> configure) where T : Frame
    {
        PropertySettersContext<float> arg = new PropertySettersContext<float>(self.XamlSetters, Frame.CornerRadiusProperty);
        configure(arg).Build();
        return self;
    }
}
