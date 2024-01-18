namespace FmgLib.MauiMarkup;

public static class StackBaseExtension
{
    public static T SpacingFmg<T>(this T self, double spacing) where T : StackBase
    {
        self.SetValue(StackBase.SpacingProperty, spacing);
        return self;
    }

    public static T SpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : StackBase
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, StackBase.SpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SpacingFmg<T>(this SettersContext<T> self, double spacing) where T : StackBase
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StackBase.SpacingProperty,
            Value = spacing
        });
        return self;
    }

    public static SettersContext<T> SpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : StackBase
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, StackBase.SpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateSpacingToFmg<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : StackBase
    {
        T self2 = self;
        double fromValue = self2.Spacing;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.Spacing = actValue;
        }, element: self2, name: "AnimateSpacingTo", length: length, easing: easing);
    }
}
