namespace FmgLib.MauiMarkup;



public static partial class SolidColorBrushExtension
{
    public static T ColorFmg<T>(this T self,
        Color color)
        where T : SolidColorBrush
    {
        self.SetValue(SolidColorBrush.ColorProperty, color);
        return self;
    }
    
    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SolidColorBrush
    {
        var context = new PropertyContext<Color>(self, SolidColorBrush.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : SolidColorBrush
    {
        self.XamlSetters.Add(new Setter { Property = SolidColorBrush.ColorProperty, Value = color });
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SolidColorBrush
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SolidColorBrush.ColorProperty);
        configure(context).Build();
        return self;
    }
    
}
