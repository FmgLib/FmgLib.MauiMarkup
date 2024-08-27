namespace FmgLib.MauiMarkup;



public static partial class StackLayoutExtension
{
    public static T Orientation<T>(this T self,
        StackOrientation orientation)
        where T : StackLayout
    {
        self.SetValue(StackLayout.OrientationProperty, orientation);
        return self;
    }
    
    public static T Orientation<T>(this T self, Func<PropertyContext<StackOrientation>, IPropertyBuilder<StackOrientation>> configure)
        where T : StackLayout
    {
        var context = new PropertyContext<StackOrientation>(self, StackLayout.OrientationProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Orientation<T>(this SettersContext<T> self,
        StackOrientation orientation)
        where T : StackLayout
    {
        self.XamlSetters.Add(new Setter { Property = StackLayout.OrientationProperty, Value = orientation });
        return self;
    }
    
    public static SettersContext<T> Orientation<T>(this SettersContext<T> self, Func<PropertySettersContext<StackOrientation>, IPropertySettersBuilder<StackOrientation>> configure)
        where T : StackLayout
    {
        var context = new PropertySettersContext<StackOrientation>(self.XamlSetters, StackLayout.OrientationProperty);
        configure(context).Build();
        return self;
    }
    
}
