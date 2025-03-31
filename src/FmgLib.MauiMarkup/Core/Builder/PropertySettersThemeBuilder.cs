namespace FmgLib.MauiMarkup;

public sealed class PropertySettersThemeBuilder<TSource, TProperty> : IPropertySettersBuilder<TSource, TProperty>
{
    public PropertySettersContext<TSource, TProperty> Context { get; set; }

    TProperty newValue;
    TProperty defaultValue;
    Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> defaultConfigure;

    bool isSet;
    bool defaultIsSet;
    bool buildValue;

    public PropertySettersThemeBuilder(PropertySettersContext<TSource, TProperty> context)
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


    public PropertySettersThemeBuilder<TSource, TProperty> Default(TProperty value)
    {
        if (!defaultIsSet)
        {
            this.defaultValue = value;
            this.defaultIsSet = true;
        }
        return this;
    }

    public PropertySettersThemeBuilder<TSource, TProperty> Default(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!defaultIsSet)
        {
            this.defaultConfigure = configure;
            this.defaultIsSet = true;
        }
        return this;
    }


    public PropertySettersThemeBuilder<TSource, TProperty> OnLight(TProperty value)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Light)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersThemeBuilder<TSource, TProperty> OnLight(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Light)
            isSet = configure(Context).Build();
        return this;
    }


    public PropertySettersThemeBuilder<TSource, TProperty> OnDark(TProperty value)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Dark)
        {
            newValue = value;
            buildValue = true;
            isSet = true;
        }
        return this;
    }

    public PropertySettersThemeBuilder<TSource, TProperty> OnDark(Func<PropertySettersContext<TSource, TProperty>, IPropertySettersBuilder<TSource, TProperty>> configure)
    {
        if (!isSet && Application.Current?.RequestedTheme == AppTheme.Dark)
            isSet = configure(Context).Build();
        return this;
    }
}
