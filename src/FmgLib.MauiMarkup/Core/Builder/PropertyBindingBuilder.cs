using System.Globalization;

namespace FmgLib.MauiMarkup;

public sealed class PropertyBindingBuilder<TSource, TProperty> : IPropertyBuilder<TSource, TProperty>
{
    public class ValueConverter : IValueConverter
    {
        internal Func<object, TProperty> ConvertFunction;

        internal Func<TProperty, object> ConvertBackFunction;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && ConvertFunction != null)
            {
                return ConvertFunction(value);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && ConvertBackFunction != null)
            {
                return ConvertBackFunction((TProperty)value);
            }

            return null;
        }
    }

    private string path;
    
    private Func<TSource, TProperty> getter;
    
    private Action<TSource, TProperty> setter;

    private BindingMode bindingMode;

    private IValueConverter converter;

    private ValueConverter valueConverter;

    private string converterParameter;

    private string stringFormat;

    private TSource source;

    private object fallbackValue;

    private object targetNullValue;

    public PropertyContext<TSource, TProperty> Context { get; set; }

    public PropertyBindingBuilder(PropertyContext<TSource, TProperty> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (path != null)
        {
            Context.BindableObject.SetBinding(Context.Property, new Binding(path, bindingMode, converter, converterParameter, stringFormat, source)
                                                                .FallbackValue(fallbackValue)
                                                                .TargetNullValue(targetNullValue));
            return true;
        }
        else if (getter != null)
        {
            Context.BindableObject.Bind(Context.Property, 
                getter: getter,
                setter: setter,
                handlers: new (Func<TSource, object>, string)[]
                {
                    new(static source => source, Context.Property.PropertyName),
                },
                mode: bindingMode, 
                converter: converter, 
                converterParameter: converterParameter, 
                stringFormat: stringFormat, 
                source: source, 
                fallbackValue: fallbackValue, 
                targetNullValue: targetNullValue);
            
            return true;
        }
        
        return false;
    }

    public PropertyBindingBuilder<TSource, TProperty> Path(string path)
    {
        this.path = path;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> Compiled(Func<TSource, TProperty> getter)
    {
        this.getter = getter;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> Setter(Action<TSource, TProperty> setter)
    {
        this.setter = setter;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> BindingMode(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> Converter(IValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> Parameter(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> Source(TSource source)
    {
        this.source = source;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> Convert<Q>(Func<Q, TProperty> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertFunction = (object e) => convert((Q)e);
        converter = valueConverter;
        return this;
    }

    public PropertyBindingBuilder<TSource, TProperty> ConvertBack<Q>(Func<TProperty, Q> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertBackFunction = (TProperty e) => convert(e);
        converter = valueConverter;
        return this;
    }
}
