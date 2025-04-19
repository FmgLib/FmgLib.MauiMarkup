﻿namespace FmgLib.MauiMarkup;

public sealed class PropertySettersThemeBuilder<T> : IPropertySettersBuilder<T>
{
    public PropertySettersContext<T> Context { get; set; }

    T newValue;
    T defaultValue;
    Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> defaultConfigure;

    bool isSet;
    bool defaultIsSet;
    bool buildValue;

    public PropertySettersThemeBuilder(PropertySettersContext<T> context)
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


    public PropertySettersThemeBuilder<T> Default(T value)
    {
        if (!defaultIsSet)
        {
            this.defaultValue = value;
            this.defaultIsSet = true;
        }
        return this;
    }

    public PropertySettersThemeBuilder<T> Default(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!defaultIsSet)
        {
            this.defaultConfigure = configure;
            this.defaultIsSet = true;
        }
        return this;
    }


    public PropertySettersThemeBuilder<T> OnLight(T value)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Light)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersThemeBuilder<T> OnLight(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Light)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersThemeBuilder<T> OnDark(T value)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Dark)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersThemeBuilder<T> OnDark(Func<PropertySettersContext<T>, IPropertySettersBuilder<T>> configure)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Dark)
            isSet = configure(Context).Build();
        return this;
    }
}
