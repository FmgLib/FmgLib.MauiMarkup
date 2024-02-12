using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiSystemExtension
{
    public static T EmitterBoundsFmg<T>(this T self, SKConfettiEmitterBounds emitterBounds) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.EmitterBoundsProperty, emitterBounds);
        return self;
    }

    public static T EmitterBoundsFmg<T>(this T self, Func<PropertyContext<SKConfettiEmitterBounds>, IPropertyBuilder<SKConfettiEmitterBounds>> configure) where T : SKConfettiSystem
    {
        PropertyContext<SKConfettiEmitterBounds> arg = new PropertyContext<SKConfettiEmitterBounds>(self, SKConfettiSystem.EmitterBoundsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EmitterBoundsFmg<T>(this SettersContext<T> self, SKConfettiEmitterBounds emitterBounds) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.EmitterBoundsProperty,
            Value = emitterBounds
        });
        return self;
    }

    public static SettersContext<T> EmitterBoundsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKConfettiEmitterBounds>, IPropertySettersBuilder<SKConfettiEmitterBounds>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<SKConfettiEmitterBounds> arg = new PropertySettersContext<SKConfettiEmitterBounds>(self.XamlSetters, SKConfettiSystem.EmitterBoundsProperty);
        configure(arg).Build();
        return self;
    }

    public static T EmitterFmg<T>(this T self, SKConfettiEmitter emitter) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.EmitterProperty, emitter);
        return self;
    }

    public static T EmitterFmg<T>(this T self, Func<PropertyContext<SKConfettiEmitter>, IPropertyBuilder<SKConfettiEmitter>> configure) where T : SKConfettiSystem
    {
        PropertyContext<SKConfettiEmitter> arg = new PropertyContext<SKConfettiEmitter>(self, SKConfettiSystem.EmitterProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EmitterFmg<T>(this SettersContext<T> self, SKConfettiEmitter emitter) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.EmitterProperty,
            Value = emitter
        });
        return self;
    }

    public static SettersContext<T> EmitterFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKConfettiEmitter>, IPropertySettersBuilder<SKConfettiEmitter>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<SKConfettiEmitter> arg = new PropertySettersContext<SKConfettiEmitter>(self.XamlSetters, SKConfettiSystem.EmitterProperty);
        configure(arg).Build();
        return self;
    }

    public static T ColorsFmg<T>(this T self, SKConfettiColorCollection colors) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.ColorsProperty, colors);
        return self;
    }

    public static T ColorsFmg<T>(this T self, Func<PropertyContext<SKConfettiColorCollection>, IPropertyBuilder<SKConfettiColorCollection>> configure) where T : SKConfettiSystem
    {
        PropertyContext<SKConfettiColorCollection> arg = new PropertyContext<SKConfettiColorCollection>(self, SKConfettiSystem.ColorsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ColorsFmg<T>(this SettersContext<T> self, SKConfettiColorCollection colors) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.ColorsProperty,
            Value = colors
        });
        return self;
    }

    public static SettersContext<T> ColorsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKConfettiColorCollection>, IPropertySettersBuilder<SKConfettiColorCollection>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<SKConfettiColorCollection> arg = new PropertySettersContext<SKConfettiColorCollection>(self.XamlSetters, SKConfettiSystem.ColorsProperty);
        configure(arg).Build();
        return self;
    }

    public static T PhysicsFmg<T>(this T self, SKConfettiPhysicsCollection physics) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.PhysicsProperty, physics);
        return self;
    }

    public static T PhysicsFmg<T>(this T self, Func<PropertyContext<SKConfettiPhysicsCollection>, IPropertyBuilder<SKConfettiPhysicsCollection>> configure) where T : SKConfettiSystem
    {
        PropertyContext<SKConfettiPhysicsCollection> arg = new PropertyContext<SKConfettiPhysicsCollection>(self, SKConfettiSystem.PhysicsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PhysicsFmg<T>(this SettersContext<T> self, SKConfettiPhysicsCollection physics) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.PhysicsProperty,
            Value = physics
        });
        return self;
    }

    public static SettersContext<T> PhysicsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKConfettiPhysicsCollection>, IPropertySettersBuilder<SKConfettiPhysicsCollection>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<SKConfettiPhysicsCollection> arg = new PropertySettersContext<SKConfettiPhysicsCollection>(self.XamlSetters, SKConfettiSystem.PhysicsProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShapesFmg<T>(this T self, SKConfettiShapeCollection shapes) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.ShapesProperty, shapes);
        return self;
    }

    public static T ShapesFmg<T>(this T self, Func<PropertyContext<SKConfettiShapeCollection>, IPropertyBuilder<SKConfettiShapeCollection>> configure) where T : SKConfettiSystem
    {
        PropertyContext<SKConfettiShapeCollection> arg = new PropertyContext<SKConfettiShapeCollection>(self, SKConfettiSystem.ShapesProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ShapesFmg<T>(this SettersContext<T> self, SKConfettiShapeCollection shapes) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.ShapesProperty,
            Value = shapes
        });
        return self;
    }

    public static SettersContext<T> ShapesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKConfettiShapeCollection>, IPropertySettersBuilder<SKConfettiShapeCollection>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<SKConfettiShapeCollection> arg = new PropertySettersContext<SKConfettiShapeCollection>(self.XamlSetters, SKConfettiSystem.ShapesProperty);
        configure(arg).Build();
        return self;
    }

    public static T StartAngleFmg<T>(this T self, double startAngle) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.StartAngleProperty, startAngle);
        return self;
    }

    public static T StartAngleFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : SKConfettiSystem
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, SKConfettiSystem.StartAngleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> StartAngleFmg<T>(this SettersContext<T> self, double startAngle) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.StartAngleProperty,
            Value = startAngle
        });
        return self;
    }

    public static SettersContext<T> StartAngleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.StartAngleProperty);
        configure(arg).Build();
        return self;
    }

    public static T EndAngleFmg<T>(this T self, double endAngle) where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.EndAngleProperty, endAngle);
        return self;
    }

    public static T EndAngleFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : SKConfettiSystem
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, SKConfettiSystem.EndAngleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> EndAngleFmg<T>(this SettersContext<T> self, double endAngle) where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SKConfettiSystem.EndAngleProperty,
            Value = endAngle
        });
        return self;
    }

    public static SettersContext<T> EndAngleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : SKConfettiSystem
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.EndAngleProperty);
        configure(arg).Build();
        return self;
    }

    public static T MinimumInitialVelocityFmg<T>(this T self,
        double minimumInitialVelocity)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.MinimumInitialVelocityProperty, minimumInitialVelocity);
        return self;
    }

    public static T MinimumInitialVelocityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<double>(self, SKConfettiSystem.MinimumInitialVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MinimumInitialVelocityFmg<T>(this SettersContext<T> self,
        double minimumInitialVelocity)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.MinimumInitialVelocityProperty, Value = minimumInitialVelocity });
        return self;
    }

    public static SettersContext<T> MinimumInitialVelocityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.MinimumInitialVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static T MaximumInitialVelocityFmg<T>(this T self,
        double maximumInitialVelocity)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.MaximumInitialVelocityProperty, maximumInitialVelocity);
        return self;
    }

    public static T MaximumInitialVelocityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<double>(self, SKConfettiSystem.MaximumInitialVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaximumInitialVelocityFmg<T>(this SettersContext<T> self,
        double maximumInitialVelocity)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.MaximumInitialVelocityProperty, Value = maximumInitialVelocity });
        return self;
    }

    public static SettersContext<T> MaximumInitialVelocityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.MaximumInitialVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static T MinimumRotationVelocityFmg<T>(this T self,
        double minimumRotationVelocity)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.MinimumRotationVelocityProperty, minimumRotationVelocity);
        return self;
    }

    public static T MinimumRotationVelocityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<double>(self, SKConfettiSystem.MinimumRotationVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MinimumRotationVelocityFmg<T>(this SettersContext<T> self,
        double minimumRotationVelocity)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.MinimumRotationVelocityProperty, Value = minimumRotationVelocity });
        return self;
    }

    public static SettersContext<T> MinimumRotationVelocityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.MinimumRotationVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static T MaximumRotationVelocityFmg<T>(this T self,
        double maximumRotationVelocity)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.MaximumRotationVelocityProperty, maximumRotationVelocity);
        return self;
    }

    public static T MaximumRotationVelocityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<double>(self, SKConfettiSystem.MaximumRotationVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaximumRotationVelocityFmg<T>(this SettersContext<T> self,
        double maximumRotationVelocity)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.MaximumRotationVelocityProperty, Value = maximumRotationVelocity });
        return self;
    }

    public static SettersContext<T> MaximumRotationVelocityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.MaximumRotationVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static T MaximumVelocityFmg<T>(this T self,
        double maximumVelocity)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.MaximumVelocityProperty, maximumVelocity);
        return self;
    }

    public static T MaximumVelocityFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<double>(self, SKConfettiSystem.MaximumVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaximumVelocityFmg<T>(this SettersContext<T> self,
        double maximumVelocity)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.MaximumVelocityProperty, Value = maximumVelocity });
        return self;
    }

    public static SettersContext<T> MaximumVelocityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.MaximumVelocityProperty);
        configure(context).Build();
        return self;
    }

    public static T LifetimeFmg<T>(this T self,
        double lifetime)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.LifetimeProperty, lifetime);
        return self;
    }

    public static T LifetimeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<double>(self, SKConfettiSystem.LifetimeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> LifetimeFmg<T>(this SettersContext<T> self,
        double lifetime)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.LifetimeProperty, Value = lifetime });
        return self;
    }

    public static SettersContext<T> LifetimeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, SKConfettiSystem.LifetimeProperty);
        configure(context).Build();
        return self;
    }

    public static T FadeOutFmg<T>(this T self,
        bool fadeOut)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.FadeOutProperty, fadeOut);
        return self;
    }

    public static T FadeOutFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<bool>(self, SKConfettiSystem.FadeOutProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FadeOutFmg<T>(this SettersContext<T> self,
        bool fadeOut)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.FadeOutProperty, Value = fadeOut });
        return self;
    }

    public static SettersContext<T> FadeOutFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SKConfettiSystem.FadeOutProperty);
        configure(context).Build();
        return self;
    }

    public static T GravityFmg<T>(this T self,
        Point gravity)
        where T : SKConfettiSystem
    {
        self.SetValue(SKConfettiSystem.GravityProperty, gravity);
        return self;
    }

    public static T GravityFmg<T>(this T self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertyContext<Point>(self, SKConfettiSystem.GravityProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> GravityFmg<T>(this SettersContext<T> self,
        Point gravity)
        where T : SKConfettiSystem
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiSystem.GravityProperty, Value = gravity });
        return self;
    }

    public static SettersContext<T> GravityFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
        where T : SKConfettiSystem
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, SKConfettiSystem.GravityProperty);
        configure(context).Build();
        return self;
    }

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
