using Microsoft.Maui.Controls.Maps;

namespace FmgLib.MauiMarkup.Maps;

public static partial class PinExtension
{
    public static T TypeFmg<T>(this T self, PinType pinType) where T : Pin
    {
        self.SetValue(Pin.TypeProperty, pinType);
        return self;
    }

    public static T TypeFmg<T>(this T self, Func<PropertyContext<PinType>, IPropertyBuilder<PinType>> configure) where T : Pin
    {
        PropertyContext<PinType> arg = new PropertyContext<PinType>(self, Pin.TypeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TypeFmg<T>(this SettersContext<T> self, PinType pinType) where T : Pin
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Pin.TypeProperty,
            Value = pinType
        });
        return self;
    }

    public static SettersContext<T> TypeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<PinType>, IPropertySettersBuilder<PinType>> configure) where T : Pin
    {
        PropertySettersContext<PinType> arg = new PropertySettersContext<PinType>(self.XamlSetters, Pin.TypeProperty);
        configure(arg).Build();
        return self;
    }

    public static T LocationFmg<T>(this T self, Location location) where T : Pin
    {
        self.SetValue(Pin.LocationProperty, location);
        return self;
    }

    public static T LocationFmg<T>(this T self, Func<PropertyContext<Location>, IPropertyBuilder<Location>> configure) where T : Pin
    {
        PropertyContext<Location> arg = new PropertyContext<Location>(self, Pin.LocationProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LocationFmg<T>(this SettersContext<T> self, Location location) where T : Pin
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Pin.LocationProperty,
            Value = location
        });
        return self;
    }

    public static SettersContext<T> LocationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Location>, IPropertySettersBuilder<Location>> configure) where T : Pin
    {
        PropertySettersContext<Location> arg = new PropertySettersContext<Location>(self.XamlSetters, Pin.LocationProperty);
        configure(arg).Build();
        return self;
    }

    public static T AddressFmg<T>(this T self, string address) where T : Pin
    {
        self.SetValue(Pin.AddressProperty, address);
        return self;
    }

    public static T AddressFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Pin
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Pin.AddressProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> AddressFmg<T>(this SettersContext<T> self, string address) where T : Pin
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Pin.AddressProperty,
            Value = address
        });
        return self;
    }

    public static SettersContext<T> AddressFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Pin
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Pin.AddressProperty);
        configure(arg).Build();
        return self;
    }

    public static T LabelFmg<T>(this T self, string label) where T : Pin
    {
        self.SetValue(Pin.LabelProperty, label);
        return self;
    }

    public static T LabelFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure) where T : Pin
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, Pin.LabelProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LabelFmg<T>(this SettersContext<T> self, string label) where T : Pin
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Pin.LabelProperty,
            Value = label
        });
        return self;
    }

    public static SettersContext<T> LabelFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure) where T : Pin
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, Pin.LabelProperty);
        configure(arg).Build();
        return self;
    }
}
