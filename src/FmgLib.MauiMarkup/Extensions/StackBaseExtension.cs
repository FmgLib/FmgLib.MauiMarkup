namespace FmgLib.MauiMarkup;



public static partial class StackBaseExtension
{
    public static T Spacing<T>(this T self,
        double spacing)
        where T : StackBase
    {
        self.SetValue(StackBase.SpacingProperty, spacing);
        return self;
    }
    
    public static T Spacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : StackBase
    {
        var context = new PropertyContext<double>(self, StackBase.SpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Spacing<T>(this SettersContext<T> self,
        double spacing)
        where T : StackBase
    {
        self.XamlSetters.Add(new Setter { Property = StackBase.SpacingProperty, Value = spacing });
        return self;
    }
    
    public static SettersContext<T> Spacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : StackBase
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, StackBase.SpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : StackBase
    {
        double fromValue = self.Spacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Spacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateSpacingTo", transform, callback, length, easing);
    }
    
}
