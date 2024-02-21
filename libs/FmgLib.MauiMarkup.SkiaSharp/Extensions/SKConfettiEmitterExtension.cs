using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiEmitterExtension
{
    public static T ParticleRateFmg<T>(this T self, int particleRate) where T : SKConfettiEmitter
    {
        self.SetValue(SKConfettiEmitter.ParticleRateProperty, particleRate);
        return self;
    }

    public static T ParticleRateFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : SKConfettiEmitter
    {
        var context = new PropertyContext<int>(self, SKConfettiEmitter.ParticleRateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ParticleRateFmg<T>(this SettersContext<T> self, int particleRate) where T : SKConfettiEmitter
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiEmitter.ParticleRateProperty, Value = particleRate });
        return self;
    }

    public static SettersContext<T> ParticleRateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : SKConfettiEmitter
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SKConfettiEmitter.ParticleRateProperty);
        configure(context).Build();
        return self;
    }

    public static T MaxParticlesFmg<T>(this T self, int maxParticles) where T : SKConfettiEmitter
    {
        self.SetValue(SKConfettiEmitter.MaxParticlesProperty, maxParticles);
        return self;
    }

    public static T MaxParticlesFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : SKConfettiEmitter
    {
        var context = new PropertyContext<int>(self, SKConfettiEmitter.MaxParticlesProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaxParticlesFmg<T>(this SettersContext<T> self, int maxParticles) where T : SKConfettiEmitter
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiEmitter.MaxParticlesProperty, Value = maxParticles });
        return self;
    }

    public static SettersContext<T> MaxParticlesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : SKConfettiEmitter
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, SKConfettiEmitter.MaxParticlesProperty);
        configure(context).Build();
        return self;
    }

    public static T DurationFmg<T>(this T self,
        double duration)
        where T : SKConfettiEmitter
    {
        self.SetValue(SKConfettiEmitter.DurationProperty, duration);
        return self;
    }

    public static T DurationFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiEmitter
    {
        var context = new PropertyContext<double>(self, SKConfettiEmitter.DurationProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> DurationFmg<T>(this SettersContext<T> self,
        double duration)
        where T : SKConfettiEmitter
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiEmitter.DurationProperty, Value = duration });
        return self;
    }

    public static SettersContext<T> DurationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiEmitter
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiEmitter.DurationProperty);
        configure(context).Build();
        return self;
    }

    public static T IsCompleteFmg<T>(this T self,
        bool isComplete)
        where T : SKConfettiEmitter
    {
        self.SetValue(SKConfettiEmitter.IsCompleteProperty, isComplete);
        return self;
    }

    public static T IsCompleteFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKConfettiEmitter
    {
        var context = new PropertyContext<bool>(self, SKConfettiEmitter.IsCompleteProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self,
        bool isComplete)
        where T : SKConfettiEmitter
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiEmitter.IsCompleteProperty, Value = isComplete });
        return self;
    }

    public static SettersContext<T> IsCompleteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKConfettiEmitter
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKConfettiEmitter.IsCompleteProperty);
        configure(context).Build();
        return self;
    }
}
