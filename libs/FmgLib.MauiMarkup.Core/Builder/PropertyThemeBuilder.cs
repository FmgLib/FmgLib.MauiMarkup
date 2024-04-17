namespace FmgLib.MauiMarkup;

public sealed class PropertyThemeBuilder<T> : IPropertyBuilder<T>
{
    private T newValue;

    private T defaultValue;

    private Func<PropertyContext<T>, IPropertyBuilder<T>> defaultConfigure;

    private bool isSet;

    private bool defaultIsSet;

    private bool buildValue;

    public PropertyContext<T> Context { get; set; }

    public PropertyThemeBuilder(PropertyContext<T> context)
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

    public PropertyThemeBuilder<T> Default(T value)
    {
        if (!defaultIsSet)
        {
            defaultValue = value;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyThemeBuilder<T> Default(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
    {
        if (!defaultIsSet)
        {
            defaultConfigure = configure;
            defaultIsSet = true;
        }

        return this;
    }

    public PropertyThemeBuilder<T> OnLight(T value)
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

    public PropertyThemeBuilder<T> OnLight(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
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

    public PropertyThemeBuilder<T> OnDark(T value)
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

    public PropertyThemeBuilder<T> OnDark(Func<PropertyContext<T>, IPropertyBuilder<T>> configure)
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
