namespace FmgLib.MauiMarkup;



public static partial class TemplatedPageExtension
{
    public static T ControlTemplate<T>(this T self,
        ControlTemplate controlTemplate)
        where T : TemplatedPage
    {
        self.SetValue(TemplatedPage.ControlTemplateProperty, controlTemplate);
        return self;
    }
    
    public static T ControlTemplate<T>(this T self, Func<PropertyContext<ControlTemplate>, IPropertyBuilder<ControlTemplate>> configure)
        where T : TemplatedPage
    {
        var context = new PropertyContext<ControlTemplate>(self, TemplatedPage.ControlTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ControlTemplate<T>(this SettersContext<T> self,
        ControlTemplate controlTemplate)
        where T : TemplatedPage
    {
        self.XamlSetters.Add(new Setter { Property = TemplatedPage.ControlTemplateProperty, Value = controlTemplate });
        return self;
    }
    
    public static SettersContext<T> ControlTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<ControlTemplate>, IPropertySettersBuilder<ControlTemplate>> configure)
        where T : TemplatedPage
    {
        var context = new PropertySettersContext<ControlTemplate>(self.XamlSetters, TemplatedPage.ControlTemplateProperty);
        configure(context).Build();
        return self;
    }
    
}
