namespace FmgLib.MauiMarkup;

public sealed class PropertySettersPlatformBuilder<TSource, TProperty> : IPropertySettersBuilder<TSource, TProperty>
{
    public PropertySettersContext<TSource, TProperty> Context { get; set; }

    TProperty newValue;
    TProperty defaultValue;
    Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> defaultConfigure;

    bool isSet;
    bool defaultIsSet;
    bool buildValue;

    public PropertySettersPlatformBuilder(PropertySettersContext<TSource, TProperty> context)
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


    public PropertySettersPlatformBuilder<TSource, TProperty> Default(TProperty value)
    {
        if (!defaultIsSet)
        {
            this.defaultValue = value;
            this.defaultIsSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<TSource, TProperty> Default(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!defaultIsSet)
        {
            this.defaultConfigure = configure;
            this.defaultIsSet = true;
        }
        return this;
    }


    public PropertySettersPlatformBuilder<TSource, TProperty> OnMacCatalyst(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.MacCatalyst)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<TSource, TProperty> OnMacCatalyst(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.MacCatalyst)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<TSource, TProperty> OniOS(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.iOS)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<TSource, TProperty> OniOS(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.iOS)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<TSource, TProperty> OnAndroid(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<TSource, TProperty> OnAndroid(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Android)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<TSource, TProperty> OnWinUI(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.WinUI)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<TSource, TProperty> OnWinUI(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.WinUI)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersPlatformBuilder<TSource, TProperty> OnTizen(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Tizen)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersPlatformBuilder<TSource, TProperty> OnTizen(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == Microsoft.Maui.Devices.DevicePlatform.Tizen)
            isSet = configure(Context).Build();
        return this;
    }
}
