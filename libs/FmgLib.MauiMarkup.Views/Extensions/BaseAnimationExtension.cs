using CommunityToolkit.Maui.Animations;

namespace FmgLib.MauiMarkup.Views;

public static partial class BaseAnimationExtension
{
    public static T LengthFmg<T>(this T self, uint length) where T : BaseAnimation
    {
        self.SetValue(BaseAnimation.LengthProperty, length);
        return self;
    }

    public static T LengthFmg<T>(this T self, Func<PropertyContext<uint>, IPropertyBuilder<uint>> configure) where T : BaseAnimation
    {
        PropertyContext<uint> arg = new PropertyContext<uint>(self, BaseAnimation.LengthProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LengthFmg<T>(this SettersContext<T> self, uint length) where T : BaseAnimation
    {
        self.XamlSetters.Add(new Setter
        {
            Property = BaseAnimation.LengthProperty,
            Value = length
        });
        return self;
    }

    public static SettersContext<T> LengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<uint>, IPropertySettersBuilder<uint>> configure) where T : BaseAnimation
    {
        PropertySettersContext<uint> arg = new PropertySettersContext<uint>(self.XamlSetters, BaseAnimation.LengthProperty);
        configure(arg).Build();
        return self;
    }

    public static T EasingFmg<T>(this T self, Easing easing) where T : BaseAnimation
    {
        self.SetValue(BaseAnimation.EasingProperty, easing);
        return self;
    }

    public static T EasingFmg<T>(this T self, Func<PropertyContext<Easing>, IPropertyBuilder<Easing>> configure) where T : BaseAnimation
    {
        PropertyContext<Easing> arg = new PropertyContext<Easing>(self, BaseAnimation.EasingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EasingFmg<T>(this SettersContext<T> self, Easing easing) where T : BaseAnimation
    {
        self.XamlSetters.Add(new Setter
        {
            Property = BaseAnimation.EasingProperty,
            Value = easing
        });
        return self;
    }

    public static SettersContext<T> EasingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Easing>, IPropertySettersBuilder<Easing>> configure) where T : BaseAnimation
    {
        PropertySettersContext<Easing> arg = new PropertySettersContext<Easing>(self.XamlSetters, BaseAnimation.EasingProperty);
        configure(arg).Build();
        return self;
    }
}
