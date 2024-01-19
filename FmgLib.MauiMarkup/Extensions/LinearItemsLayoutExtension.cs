namespace FmgLib.MauiMarkup;



public static partial class LinearItemsLayoutExtension
{
    public static T ItemSpacing<T>(this T self,
        double itemSpacing)
        where T : LinearItemsLayout
    {
        self.SetValue(LinearItemsLayout.ItemSpacingProperty, itemSpacing);
        return self;
    }
    
    public static T ItemSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : LinearItemsLayout
    {
        var context = new PropertyContext<double>(self, LinearItemsLayout.ItemSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemSpacing<T>(this SettersContext<T> self,
        double itemSpacing)
        where T : LinearItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = LinearItemsLayout.ItemSpacingProperty, Value = itemSpacing });
        return self;
    }
    
    public static SettersContext<T> ItemSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : LinearItemsLayout
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, LinearItemsLayout.ItemSpacingProperty);
        configure(context).Build();
        return self;
    }
    
}
