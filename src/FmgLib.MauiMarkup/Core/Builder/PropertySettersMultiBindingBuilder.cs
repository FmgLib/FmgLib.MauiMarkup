namespace FmgLib.MauiMarkup;

public sealed class PropertySettersMultiBindingBuilder<T> : IPropertySettersBuilder<T>
{
    private BindingMode bindingMode;

    private IMultiValueConverter converter;

    private string converterParameter;

    private string stringFormat;

    private IList<BindingBase> bindings;

    private object fallbackValue;

    private object targetNullValue;

    public PropertySettersContext<T> Context { get; set; }

    public PropertySettersMultiBindingBuilder(PropertySettersContext<T> context)
    {
        Context = context;
        bindings = new List<BindingBase>();
    }

    public bool Build()
    {
        if (bindings != null && bindings.Count > 0)
        {
            Context.XamlSetters.Add(new Setter 
            {
                Property = Context.Property,
                Value = new MultiBinding()
                {
                    Bindings = bindings,
                    Converter = converter,
                    ConverterParameter = converterParameter,
                    Mode = bindingMode,
                    StringFormat = stringFormat,
                    FallbackValue = fallbackValue,
                    TargetNullValue = targetNullValue
                }

            });
            return true;
        }

        return false;
    }

    public PropertySettersMultiBindingBuilder<T> Bindings(params BindingBase[] bindings)
    {
        this.bindings ??= new List<BindingBase>();
        foreach (var binding in bindings)
            this.bindings.Add(binding);
        return this;
    }

    public PropertySettersMultiBindingBuilder<T> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertySettersMultiBindingBuilder<T> BindingMode(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertySettersMultiBindingBuilder<T> Converter(IMultiValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertySettersMultiBindingBuilder<T> Parameter(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertySettersMultiBindingBuilder<T> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertySettersMultiBindingBuilder<T> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }
}
