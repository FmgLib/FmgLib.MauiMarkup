namespace FmgLib.MauiMarkup;

public sealed class PropertyIdiomBuilder<TSource, TProperty> : IPropertyBuilder<TSource, TProperty>
{
    private TProperty newValue;

    private TProperty defaultValue;

    private Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> defaultConfigure;

    private bool isSet;

    private bool defaultIsSet;

    private bool buildValue;

    public PropertyContext<TSource, TProperty> Context { get; set; }

    public PropertyIdiomBuilder(PropertyContext<TSource, TProperty> context)
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

    public PropertyIdiomBuilder<TSource, TProperty> Default(TProperty value)
    {
        if (!defaultIsSet)
        {
            defaultValue = value;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> Default(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!defaultIsSet)
        {
            defaultConfigure = configure;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnPhone(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnPhone(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Phone)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnTablet(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnTablet(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Tablet)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnDesktop(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnDesktop(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Desktop)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnTV(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnTV(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.TV)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnWatch(TProperty value)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }

        return this;
    }

    public PropertyIdiomBuilder<TSource, TProperty> OnWatch(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && DeviceInfo.Idiom == DeviceIdiom.Watch)
        {
            isSet = configure(Context).Build();
        }

        return this;
    }
}
