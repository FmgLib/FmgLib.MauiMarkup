namespace FmgLib.MauiMarkup;

public sealed class PropertyThemeBuilder<TSource, TProperty> : IPropertyBuilder<TSource, TProperty>
{
    private TProperty newValue;

    private TProperty defaultValue;

    private Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> defaultConfigure;

    private bool isSet;

    private bool defaultIsSet;

    private bool buildValue;

    public PropertyContext<TSource, TProperty> Context { get; set; }

    public PropertyThemeBuilder(PropertyContext<TSource, TProperty> context)
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

    public PropertyThemeBuilder<TSource, TProperty> Default(TProperty value)
    {
        if (!defaultIsSet)
        {
            defaultValue = value;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyThemeBuilder<TSource, TProperty> Default(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!defaultIsSet)
        {
            defaultConfigure = configure;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyThemeBuilder<TSource, TProperty> OnLight(TProperty value)
    {
        if (!isSet)
        {
            Application? current = Application.Current;
            if (current != null && current.RequestedTheme == AppTheme.Light)
            {
                newValue = value;
                buildValue = true;
                isSet = true;
            }
        }

        return this;
    }

    public PropertyThemeBuilder<TSource, TProperty> OnLight(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet)
        {
            Application? current = Application.Current;
            if (current != null && current.RequestedTheme == AppTheme.Light)
            {
                isSet = configure(Context).Build();
            }
        }

        return this;
    }

    public PropertyThemeBuilder<TSource, TProperty> OnDark(TProperty value)
    {
        if (!isSet)
        {
            Application? current = Application.Current;
            if (current != null && current.RequestedTheme == AppTheme.Dark)
            {
                newValue = value;
                buildValue = true;
                isSet = true;
            }
        }

        return this;
    }

    public PropertyThemeBuilder<TSource, TProperty> OnDark(Func<PropertyContext<TSource, TProperty>, IPropertyBuilder<TSource, TProperty>> configure)
    {
        if (!isSet)
        {
            Application? current = Application.Current;
            if (current != null && current.RequestedTheme == AppTheme.Dark)
            {
                isSet = configure(Context).Build();
            }
        }

        return this;
    }
}
