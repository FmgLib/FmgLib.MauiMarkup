namespace FmgLib.MauiMarkup;

public sealed class PropertyIdiomBuilder<T> : IPropertyBuilder<T>
{
    private T newValue;

    private T defaultValue;

    private Func<PropertyContext<T>, IPropertyBuilder<T>> defaultConfigure;

    private bool isSet;

    private bool defaultIsSet;

    private bool buildValue;

    public PropertyContext<T> Context { get; set; }

    public PropertyIdiomBuilder(PropertyContext<T> context)
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

    public PropertyIdiomBuilder<T> DefaultFmg(T value)
    {
        if (!defaultIsSet)
        {
            defaultValue = value;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> DefaultFmg(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!defaultIsSet)
        {
            defaultConfigure = configure;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnPhoneFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnPhoneFmg(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnTabletFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnTabletFmg(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnDesktopFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnDesktopFmg(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnTVFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnTVFmg(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnWatchFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<T> OnWatchFmg(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }
}
