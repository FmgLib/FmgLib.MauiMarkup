using System.Globalization;
using Microsoft.Maui.Controls.Internals;

namespace FmgLib.MauiMarkup;

public sealed class PropertySettersBindingBuilder<TSource, TProperty> : IPropertySettersBuilder<TSource, TProperty>
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

    public PropertySettersContext<TSource, TProperty> Context { get; set; }

    public PropertySettersBindingBuilder(PropertySettersContext<TSource, TProperty> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (path != null)
        {
            Context.XamlSetters.Add(
                new Setter
                {
                    Property = Context.Property,
                    Value = new Binding(path, bindingMode, converter, converterParameter, stringFormat, source)
                        .FallbackValue(fallbackValue)
                        .TargetNullValue(targetNullValue)
                }
            );
            return true;
        }
        else if (getter != null)
        {
            Context.XamlSetters.Add(
                new Setter
                {
                    Property = Context.Property,
                    Value = new TypedBinding<TSource, TProperty>(getter: bindingContext => (getter(bindingContext), true), setter: setter, handlers: new Tuple<Func<TSource, object>, string>[]
                    {
                        new(static source => source, Context.Property.PropertyName)
                    })
                    {
                        Mode = bindingMode,
                        Converter = converter,
                        ConverterParameter = converterParameter,
                        StringFormat = stringFormat,
                        Source = source,
                        TargetNullValue = targetNullValue,
                        FallbackValue = fallbackValue
                    }//Binding.Create(getter, bindingMode, converter, converterParameter, stringFormat, source, fallbackValue, targetNullValue)
                }
            );
            return true;
        }

        return false;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> Path(string path)
    {
        this.path = path;
        return this;
    }
    
    public PropertySettersBindingBuilder<TSource, TProperty> Compiled(Func<TSource, TProperty> getter)
    {
        this.getter = getter;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> Setter(Action<TSource, TProperty> setter)
    {
        this.setter = setter;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> BindingMode(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> Converter(IValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> Parameter(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> Source(TSource source)
    {
        this.source = source;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> Convert<Q>(Func<Q, TProperty> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertFunction = (object e) => convert((Q)e);
        converter = valueConverter;
        return this;
    }

    public PropertySettersBindingBuilder<TSource, TProperty> ConvertBack<Q>(Func<TProperty, Q> convert)
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
