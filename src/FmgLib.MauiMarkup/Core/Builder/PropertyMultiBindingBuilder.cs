namespace FmgLib.MauiMarkup;

public sealed class PropertyMultiBindingBuilder<T> : IPropertyBuilder<T>
{
    private BindingMode bindingMode;

    private IMultiValueConverter converter;

    private string converterParameter;

    private string stringFormat;

    private IList<BindingBase> bindings;

    private object fallbackValue;

    private object targetNullValue;

    public PropertyContext<T> Context { get; set; }

    public PropertyMultiBindingBuilder(PropertyContext<T> context)
    {
        Context = context;
        bindings = new List<BindingBase>();
    }

    public bool Build()
    {
        if (bindings != null && bindings.Count > 0)
        {
            Context.BindableObject.SetBinding(Context.Property, new MultiBinding()
            {
                Bindings = bindings,
                Converter = converter,
                ConverterParameter = converterParameter,
                Mode = bindingMode,
                StringFormat = stringFormat,
                FallbackValue = fallbackValue,
                TargetNullValue = targetNullValue
            });
            return true;
        }

        return false;
    }

    public PropertyMultiBindingBuilder<T> Bindings(params BindingBase[] bindings)
    {
        this.bindings ??= new List<BindingBase>();
        foreach (var binding in bindings)
            this.bindings.Add(binding);
        return this;
    }

    public PropertyMultiBindingBuilder<T> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertyMultiBindingBuilder<T> BindingMode(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertyMultiBindingBuilder<T> Converter(IMultiValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertyMultiBindingBuilder<T> Parameter(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertyMultiBindingBuilder<T> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertyMultiBindingBuilder<T> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }
}
