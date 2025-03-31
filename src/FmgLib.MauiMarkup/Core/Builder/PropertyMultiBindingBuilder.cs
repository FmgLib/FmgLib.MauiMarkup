namespace FmgLib.MauiMarkup;

public sealed class PropertyMultiBindingBuilder<TSource, TProperty> : IPropertyBuilder<TSource, TProperty>
{
    private BindingMode bindingMode;

    private IMultiValueConverter converter;

    private string converterParameter;

    private string stringFormat;

    private IList<BindingBase> bindings;

    private object fallbackValue;

    private object targetNullValue;

    public PropertyContext<TSource, TProperty> Context { get; set; }

    public PropertyMultiBindingBuilder(PropertyContext<TSource, TProperty> context)
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

    public PropertyMultiBindingBuilder<TSource, TProperty> Bindings(params BindingBase[] bindings)
    {
        this.bindings ??= new List<BindingBase>();
        foreach (var binding in bindings)
            this.bindings.Add(binding);
        return this;
    }

    public PropertyMultiBindingBuilder<TSource, TProperty> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertyMultiBindingBuilder<TSource, TProperty> BindingMode(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertyMultiBindingBuilder<TSource, TProperty> Converter(IMultiValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertyMultiBindingBuilder<TSource, TProperty> Parameter(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertyMultiBindingBuilder<TSource, TProperty> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertyMultiBindingBuilder<TSource, TProperty> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }
}
