namespace FmgLib.MauiMarkup;

public static partial class DeviceStateTriggerExtension
{
    public static DeviceStateTrigger Device(this DeviceStateTrigger self,
        string device)
    {
        self.SetValue(DeviceStateTrigger.DeviceProperty, device);
        return self;
    }
    
    public static DeviceStateTrigger Device(this DeviceStateTrigger self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
    {
        var context = new PropertyContext<string>(self, DeviceStateTrigger.DeviceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<DeviceStateTrigger> Device(this SettersContext<DeviceStateTrigger> self,
        string device)
    {
        self.XamlSetters.Add(new Setter { Property = DeviceStateTrigger.DeviceProperty, Value = device });
        return self;
    }
    
    public static SettersContext<DeviceStateTrigger> Device(this SettersContext<DeviceStateTrigger> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DeviceStateTrigger.DeviceProperty);
        configure(context).Build();
        return self;
    }
    
}