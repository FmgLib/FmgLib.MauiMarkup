using System.Globalization;

namespace FmgLib.MauiMarkup;

public sealed class PropertySettersBindingBuilder<T> : IPropertySettersBuilder<T>
{
    public class ValueConverter : IValueConverter
    {
        internal Func<object, T> ConvertFunction;

        internal Func<T, object> ConvertBackFunction;

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
                return ConvertBackFunction((T)value);
            }

            return null;
        }
    }

    private string path;

    private BindingMode bindingMode;

    private IValueConverter converter;

    private ValueConverter valueConverter;

    private string converterParameter;

    private string stringFormat;

    private object source;

    private object fallbackValue;

    private object targetNullValue;

    public PropertySettersContext<T> Context { get; set; }

    public PropertySettersBindingBuilder(PropertySettersContext<T> context)
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

        return false;
    }

    public PropertySettersBindingBuilder<T> Path(string path)
    {
        this.path = path;
        return this;
    }

    public PropertySettersBindingBuilder<T> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertySettersBindingBuilder<T> BindingMode(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertySettersBindingBuilder<T> Converter(IValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertySettersBindingBuilder<T> Parameter(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertySettersBindingBuilder<T> Source(object source)
    {
        this.source = source;
        return this;
    }

    public PropertySettersBindingBuilder<T> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertySettersBindingBuilder<T> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }

    public PropertySettersBindingBuilder<T> Convert<Q>(Func<Q, T> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertFunction = (object e) => convert((Q)e);
        converter = valueConverter;
        return this;
    }

    public PropertySettersBindingBuilder<T> ConvertBack<Q>(Func<T, Q> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertBackFunction = (T e) => convert(e);
        converter = valueConverter;
        return this;
    }
}
