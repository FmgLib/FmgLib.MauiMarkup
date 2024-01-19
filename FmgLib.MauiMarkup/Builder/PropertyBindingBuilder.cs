using System.Globalization;

namespace FmgLib.MauiMarkup;

public sealed class PropertyBindingBuilder<T> : IPropertyBuilder<T>
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

    public PropertyContext<T> Context { get; set; }

    public PropertyBindingBuilder(PropertyContext<T> context)
    {
        Context = context;
    }

    public bool Build()
    {
        if (path != null)
        {
            Context.BindableObject.SetBinding(Context.Property, new Binding(path, bindingMode, converter, converterParameter, stringFormat, source));
            return true;
        }

        return false;
    }

    public PropertyBindingBuilder<T> PathFmg(string path)
    {
        this.path = path;
        return this;
    }

    public PropertyBindingBuilder<T> StringFormatFmg(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertyBindingBuilder<T> BindingModeFmg(BindingMode bindingMode)
    {
        this.bindingMode = bindingMode;
        return this;
    }

    public PropertyBindingBuilder<T> ConverterFmg(IValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertyBindingBuilder<T> ParameterFmg(string converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertyBindingBuilder<T> SourceFmg(object source)
    {
        this.source = source;
        return this;
    }

    public PropertyBindingBuilder<T> ConvertFmg<Q>(Func<Q, T> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertFunction = (object e) => convert((Q)e);
        converter = valueConverter;
        return this;
    }

    public PropertyBindingBuilder<T> ConvertBackFmg<Q>(Func<T, Q> convert)
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
