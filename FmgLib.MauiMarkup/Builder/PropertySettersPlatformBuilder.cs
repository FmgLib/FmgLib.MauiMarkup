namespace FmgLib.MauiMarkup;

public sealed class PropertySettersPlatformBuilder<T> : IPropertySettersBuilder<T>
{
    public PropertySettersContext<T> Context { get; set; }

    T newValue;
    T defaultValue;
    Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> defaultConfigure;

    bool isSet;
    bool defaultIsSet;
    bool buildValue;

    public PropertySettersPlatformBuilder(PropertySettersContext<T> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (buildValue)
            Context.XamlSetters.Add(new Setter { Property = Context.Property, Value = newValue });
        else if (!isSet)
        {
            if (defaultIsSet)
            {
                if (defaultConfigure != null)
                    isSet = defaultConfigure(Context).Build();
                else
                    Context.XamlSetters.Add(new Setter { Property = Context.Property, Value = defaultValue });
            }

        }
        return isSet;
    }


    public PropertySettersPlatformBuilder<T> DefaultFmg(T value)
    {
        if (!defaultIsSet)
        {
            this.defaultValue = value;
            this.defaultIsSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<T> DefaultFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!defaultIsSet)
        {
            this.defaultConfigure = configure;
            this.defaultIsSet = true;
        }
        return this;
    }


    public PropertySettersPlatformBuilder<T> OnMacCatalystFmg(T value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.MacCatalyst)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<T> OnMacCatalystFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.MacCatalyst)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<T> OniOSFmg(T value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.iOS)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<T> OniOSFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.iOS)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<T> OnAndroidFmg(T value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<T> OnAndroidFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<T> OnWinUIFmg(T value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.WinUI)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<T> OnWinUIFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.WinUI)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<T> OnTizenFmg(T value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Tizen)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<T> OnTizenFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Tizen)
            isSet = configure(Context).Build();
        return this;
    }
}
