namespace FmgLib.MauiMarkup;



public static partial class TranslateTransformExtension
{
    public static T XFmg<T>(this T self,
        double x)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty, x);
        return self;
    }
    
    public static T XFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> XFmg<T>(this SettersContext<T> self,
        double x)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty, Value = x });
        return self;
    }
    
    public static SettersContext<T> XFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.TranslateTransform.XProperty);
        configure(context).Build();
        return self;
    }
    
    public static T YFmg<T>(this T self,
        double y)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty, y);
        return self;
    }
    
    public static T YFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> YFmg<T>(this SettersContext<T> self,
        double y)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty, Value = y });
        return self;
    }
    
    public static SettersContext<T> YFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.TranslateTransform
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.TranslateTransform.YProperty);
        configure(context).Build();
        return self;
    }
    
}
