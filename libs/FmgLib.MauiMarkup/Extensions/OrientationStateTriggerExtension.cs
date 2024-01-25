namespace FmgLib.MauiMarkup;



public static partial class OrientationStateTriggerExtension
{
    public static OrientationStateTrigger OrientationFmg(this OrientationStateTrigger self,
        DisplayOrientation orientation)
    {
        self.SetValue(OrientationStateTrigger.OrientationProperty, orientation);
        return self;
    }
    
    public static OrientationStateTrigger OrientationFmg(this OrientationStateTrigger self, Func<PropertyContext<DisplayOrientation>, IPropertyBuilder<DisplayOrientation>> configure)
    {
        var context = new PropertyContext<DisplayOrientation>(self, OrientationStateTrigger.OrientationProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<OrientationStateTrigger> OrientationFmg(this SettersContext<OrientationStateTrigger> self,
        DisplayOrientation orientation)
    {
        self.XamlSetters.Add(new Setter { Property = OrientationStateTrigger.OrientationProperty, Value = orientation });
        return self;
    }
    
    public static SettersContext<OrientationStateTrigger> OrientationFmg(this SettersContext<OrientationStateTrigger> self, Func<PropertySettersContext<DisplayOrientation>, IPropertySettersBuilder<DisplayOrientation>> configure)
    {
        var context = new PropertySettersContext<DisplayOrientation>(self.XamlSetters, OrientationStateTrigger.OrientationProperty);
        configure(context).Build();
        return self;
    }
    
}
