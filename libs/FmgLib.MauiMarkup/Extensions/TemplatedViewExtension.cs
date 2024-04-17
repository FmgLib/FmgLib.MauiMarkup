namespace FmgLib.MauiMarkup;



public static partial class TemplatedViewExtension
{
    public static T ControlTemplate<T>(this T self,
        ControlTemplate controlTemplate)
        where T : TemplatedView
    {
        self.SetValue(TemplatedView.ControlTemplateProperty, controlTemplate);
        return self;
    }
    
    public static T ControlTemplate<T>(this T self, Func<PropertyContext<ControlTemplate>, IPropertyBuilder<ControlTemplate>> configure)
        where T : TemplatedView
    {
        var context = new PropertyContext<ControlTemplate>(self, TemplatedView.ControlTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ControlTemplate<T>(this SettersContext<T> self,
        ControlTemplate controlTemplate)
        where T : TemplatedView
    {
        self.XamlSetters.Add(new Setter { Property = TemplatedView.ControlTemplateProperty, Value = controlTemplate });
        return self;
    }
    
    public static SettersContext<T> ControlTemplate<T>(this SettersContext<T> self, Func<PropertySettersContext<ControlTemplate>, IPropertySettersBuilder<ControlTemplate>> configure)
        where T : TemplatedView
    {
        var context = new PropertySettersContext<ControlTemplate>(self.XamlSetters, TemplatedView.ControlTemplateProperty);
        configure(context).Build();
        return self;
    }
    
}
