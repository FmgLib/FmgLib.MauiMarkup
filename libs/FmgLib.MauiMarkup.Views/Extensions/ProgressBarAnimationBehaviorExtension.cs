using CommunityToolkit.Maui.Animations;
using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class ProgressBarAnimationBehaviorExtension
{
    public static T ProgressFmg<T>(this T self, double progress) where T : ProgressBarAnimationBehavior
    {
        self.SetValue(ProgressBarAnimationBehavior.ProgressProperty, progress);
        return self;
    }

    public static T ProgressFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : ProgressBarAnimationBehavior
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, ProgressBarAnimationBehavior.ProgressProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ProgressFmg<T>(this SettersContext<T> self, double progress) where T : ProgressBarAnimationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ProgressBarAnimationBehavior.ProgressProperty,
            Value = progress
        });
        return self;
    }

    public static SettersContext<T> ProgressFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : ProgressBarAnimationBehavior
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, ProgressBarAnimationBehavior.ProgressProperty);
        configure(arg).Build();
        return self;
    }

    public static T LengthFmg<T>(this T self, uint length) where T : ProgressBarAnimationBehavior
    {
        self.SetValue(ProgressBarAnimationBehavior.LengthProperty, length);
        return self;
    }

    public static T LengthFmg<T>(this T self, Func<PropertyContext<uint>, IPropertyBuilder<uint>> configure) where T : ProgressBarAnimationBehavior
    {
        PropertyContext<uint> arg = new PropertyContext<uint>(self, ProgressBarAnimationBehavior.LengthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LengthFmg<T>(this SettersContext<T> self, uint length) where T : ProgressBarAnimationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ProgressBarAnimationBehavior.LengthProperty,
            Value = length
        });
        return self;
    }

    public static SettersContext<T> LengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<uint>, IPropertySettersBuilder<uint>> configure) where T : ProgressBarAnimationBehavior
    {
        PropertySettersContext<uint> arg = new PropertySettersContext<uint>(self.XamlSetters, ProgressBarAnimationBehavior.LengthProperty);
        configure(arg).Build();
        return self;
    }

    public static T EasingFmg<T>(this T self, Easing easing) where T : ProgressBarAnimationBehavior
    {
        self.SetValue(ProgressBarAnimationBehavior.EasingProperty, easing);
        return self;
    }

    public static T EasingFmg<T>(this T self, Func<PropertyContext<Easing>, IPropertyBuilder<Easing>> configure) where T : ProgressBarAnimationBehavior
    {
        PropertyContext<Easing> arg = new PropertyContext<Easing>(self, ProgressBarAnimationBehavior.EasingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EasingFmg<T>(this SettersContext<T> self, Easing easing) where T : ProgressBarAnimationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ProgressBarAnimationBehavior.EasingProperty,
            Value = easing
        });
        return self;
    }

    public static SettersContext<T> EasingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Easing>, IPropertySettersBuilder<Easing>> configure) where T : ProgressBarAnimationBehavior
    {
        PropertySettersContext<Easing> arg = new PropertySettersContext<Easing>(self.XamlSetters, ProgressBarAnimationBehavior.EasingProperty);
        configure(arg).Build();
        return self;
    }
}
