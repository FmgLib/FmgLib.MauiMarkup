namespace FmgLib.MauiMarkup;

public static class LinearItemsLayoutExtension
{
    public static T ItemSpacingFmg<T>(this T self, double itemSpacing) where T : LinearItemsLayout
    {
        self.SetValue(LinearItemsLayout.ItemSpacingProperty, itemSpacing);
        return self;
    }

    public static T ItemSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : LinearItemsLayout
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, LinearItemsLayout.ItemSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemSpacingFmg<T>(this SettersContext<T> self, double itemSpacing) where T : LinearItemsLayout
    {
        self.XamlSetters.Add(new Setter
        {
            Property = LinearItemsLayout.ItemSpacingProperty,
            Value = itemSpacing
        });
        return self;
    }

    public static SettersContext<T> ItemSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : LinearItemsLayout
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, LinearItemsLayout.ItemSpacingProperty);
        configure(arg).Build();
        return self;
    }
}
