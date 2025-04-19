namespace FmgLib.MauiMarkup;

public sealed class PropertyPlatformBuilder<T> : IPropertyBuilder<T>
{
    private T newValue;

    private T defaultValue;

    private Func<PropertyContext<T>, IPropertyBuilder<T>> defaultConfigure;

    private bool isSet;

    private bool defaultIsSet;

    private bool buildValue;

    public PropertyContext<T> Context { get; set; }

    public PropertyPlatformBuilder(PropertyContext<T> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (buildValue)
        {
            Context.BindableObject.SetValue(Context.Property, newValue);
        }
        else if (!isSet && defaultIsSet)
        {
            if (defaultConfigure != null)
            {
                isSet = defaultConfigure(Context).Build();
            }
            else
            {
                Context.BindableObject.SetValue(Context.Property, defaultValue);
            }
        }

        return isSet;
    }

    public PropertyPlatformBuilder<T> Default(T value)
    {
        if (!defaultIsSet)
        {
            defaultValue = value;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> Default(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!defaultIsSet)
        {
            defaultConfigure = configure;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnMacCatalyst(T value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.MacCatalyst)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnMacCatalyst(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.MacCatalyst)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OniOS(T value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.iOS)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OniOS(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.iOS)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnAndroid(T value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Android)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnAndroid(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Android)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnWinUI(T value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnWinUI(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnTizen(T value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Tizen)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<T> OnTizen(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Tizen)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }
}
