namespace FmgLib.MauiMarkup;

public sealed class PropertySettersIdiomBuilder<T> : IPropertySettersBuilder<T>
{
    public PropertySettersContext<T> Context { get; set; }

    T newValue;
    T defaultValue;
    Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> defaultConfigure;

    bool isSet;
    bool defaultIsSet;
    bool buildValue;

    public PropertySettersIdiomBuilder(PropertySettersContext<T> context)
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


    public PropertySettersIdiomBuilder<T> DefaultFmg(T value)
    {
        if (!defaultIsSet)
        {
            this.defaultValue = value;
            this.defaultIsSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<T> DefaultFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!defaultIsSet)
        {
            this.defaultConfigure = configure;
            this.defaultIsSet = true;
        }
        return this;
    }


    public PropertySettersIdiomBuilder<T> OnPhoneFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<T> OnPhoneFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<T> OnTabletFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<T> OnTabletFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<T> OnDesktopFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<T> OnDesktopFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<T> OnTVFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<T> OnTVFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<T> OnWatchFmg(T value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<T> OnWatchFmg(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
            isSet = configure(Context).Build();
        return this;
    }
}
