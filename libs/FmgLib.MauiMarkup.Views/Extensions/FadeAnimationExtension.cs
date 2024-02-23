using CommunityToolkit.Maui.Animations;

namespace FmgLib.MauiMarkup.Views;

public static partial class FadeAnimationExtension
{
    public static T OpacityFmg<T>(this T self, double opacity) where T : FadeAnimation
    {
        self.SetValue(FadeAnimation.OpacityProperty, opacity);
        return self;
    }

    public static T OpacityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : FadeAnimation
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, FadeAnimation.OpacityProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> OpacityFmg<T>(this SettersContext<T> self, double opacity) where T : FadeAnimation
    {
        self.XamlSetters.Add(new Setter
        {
            Property = FadeAnimation.OpacityProperty,
            Value = opacity
        });
        return self;
    }

    public static SettersContext<T> OpacityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : FadeAnimation
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, FadeAnimation.OpacityProperty);
        configure(arg).Build();
        return self;
    }
}
