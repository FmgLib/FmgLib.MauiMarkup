using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiSystemExtension
{
    public static T IsCompleteFmg<T>(this T self,
        bool isComplete)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.IsCompleteProperty, isComplete);
        return self;
    }

    public static T IsCompleteFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<bool>(self, SKConfettiSystem.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self,
        bool isComplete)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.IsCompleteProperty, Value = isComplete });
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKConfettiSystem.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static T IsAnimationEnabledFmg<T>(this T self,
        bool isAnimationEnabled)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.IsAnimationEnabledProperty, isAnimationEnabled);
        return self;
    }

    public static T IsAnimationEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<bool>(self, SKConfettiSystem.IsAnimationEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsAnimationEnabledFmg<T>(this SettersContext<T> self,
        bool isAnimationEnabled)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.IsAnimationEnabledProperty, Value = isAnimationEnabled });
        return self;
    }

    public static SettersContext<T> IsAnimationEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKConfettiSystem.IsAnimationEnabledProperty);
        configure(context).Build();
        return self;
    }
}
