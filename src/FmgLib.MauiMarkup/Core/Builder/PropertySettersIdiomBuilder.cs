namespace FmgLib.MauiMarkup;

public sealed class PropertySettersIdiomBuilder<TSource, TProperty> : IPropertySettersBuilder<TSource, TProperty>
{
    public PropertySettersContext<TSource, TProperty> Context { get; set; }

    TProperty newValue;
    TProperty defaultValue;
    Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> defaultConfigure;

    bool isSet;
    bool defaultIsSet;
    bool buildValue;

    public PropertySettersIdiomBuilder(PropertySettersContext<TSource, TProperty> context)
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


    public PropertySettersIdiomBuilder<TSource, TProperty> Default(TProperty value)
    {
        if (!defaultIsSet)
        {
            this.defaultValue = value;
            this.defaultIsSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<TSource, TProperty> Default(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!defaultIsSet)
        {
            this.defaultConfigure = configure;
            this.defaultIsSet = true;
        }
        return this;
    }


    public PropertySettersIdiomBuilder<TSource, TProperty> OnPhone(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<TSource, TProperty> OnPhone(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<TSource, TProperty> OnTablet(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<TSource, TProperty> OnTablet(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<TSource, TProperty> OnDesktop(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<TSource, TProperty> OnDesktop(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<TSource, TProperty> OnTV(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<TSource, TProperty> OnTV(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersIdiomBuilder<TSource, TProperty> OnWatch(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersIdiomBuilder<TSource, TProperty> OnWatch(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
            isSet = configure(Context).Build();
        return this;
    }
}
