using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKAnimatedSurfaceViewExtension
{
    public static T IsAnimationEnabledFmg<T>(this T self,
        bool isAnimationEnabled)
        where T : SKAnimatedSurfaceView
    {
        self.SetValue(SKAnimatedSurfaceView.IsAnimationEnabledProperty, isAnimationEnabled);
        return self;
    }

    public static T IsAnimationEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKAnimatedSurfaceView
    {
        var context = new PropertyContext<bool>(self, SKAnimatedSurfaceView.IsAnimationEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsAnimationEnabledFmg<T>(this SettersContext<T> self,
        bool isAnimationEnabled)
        where T : SKAnimatedSurfaceView
    {
        self.XamlSetters.Add(new Setter { Property = SKAnimatedSurfaceView.IsAnimationEnabledProperty, Value = isAnimationEnabled });
        return self;
    }

    public static SettersContext<T> IsAnimationEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKAnimatedSurfaceView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKAnimatedSurfaceView.IsAnimationEnabledProperty);
        configure(context).Build();
        return self;
    }
}
