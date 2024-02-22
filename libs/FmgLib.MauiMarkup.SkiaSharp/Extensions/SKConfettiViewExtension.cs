using SkiaSharp;
using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiViewExtension
{
    public static T IsCompleteFmg<T>(this T self,
        bool isComplete)
        where T : SKConfettiView
    {
        self.SetValue(SKConfettiView.IsCompleteProperty, isComplete);
        return self;
    }

    public static T IsCompleteFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKConfettiView
    {
        var context = new PropertyContext<bool>(self, SKConfettiView.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self,
        bool isComplete)
        where T : SKConfettiView
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiView.IsCompleteProperty, Value = isComplete });
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKConfettiView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKConfettiView.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static T SystemsFmg<T>(this T self,
    SKConfettiSystemCollection systems)
    where T : SKConfettiView
    {
        self.SetValue(SKConfettiView.SystemsProperty, systems);
        return self;
    }

    public static T SystemsFmg<T>(this T self, Func<PropertyContext<SKConfettiSystemCollection>, IPropertyBuilder<SKConfettiSystemCollection>> configure)
        where T : SKConfettiView
    {
        var context = new PropertyContext<SKConfettiSystemCollection>(self, SKConfettiView.SystemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SystemsFmg<T>(this SettersContext<T> self,
        SKConfettiSystemCollection systems)
        where T : SKConfettiView
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiView.SystemsProperty, Value = systems });
        return self;
    }

    public static SettersContext<T> SystemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKConfettiSystemCollection>, IPropertySettersBuilder<SKConfettiSystemCollection>> configure)
        where T : SKConfettiView
    {
        var context = new PropertySettersContext<SKConfettiSystemCollection>(self.XamlSetters, SKConfettiView.SystemsProperty);
        configure(context).Build();
        return self;
    }
}
