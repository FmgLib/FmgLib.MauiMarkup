namespace FmgLib.MauiMarkup;

public sealed class PropertyPlatformBuilder<TSource, TProperty> : IPropertyBuilder<TSource, TProperty>
{
    private TProperty newValue;

    private TProperty defaultValue;

    private Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> defaultConfigure;

    private bool isSet;

    private bool defaultIsSet;

    private bool buildValue;

    public PropertyContext<TSource, TProperty> Context { get; set; }

    public PropertyPlatformBuilder(PropertyContext<TSource, TProperty> context)
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

    public PropertyPlatformBuilder<TSource, TProperty> Default(TProperty value)
    {
        if (!defaultIsSet)
        {
            defaultValue = value;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> Default(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!defaultIsSet)
        {
            defaultConfigure = configure;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnMacCatalyst(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.MacCatalyst)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnMacCatalyst(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.MacCatalyst)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OniOS(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.iOS)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OniOS(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.iOS)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnAndroid(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Android)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnAndroid(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Android)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnWinUI(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnWinUI(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnTizen(TProperty value)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Tizen)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyPlatformBuilder<TSource, TProperty> OnTizen(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Platform == DevicePlatform.Tizen)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }
}
