#nullable enable

using System.Globalization;
using System.Linq.Expressions;

namespace FmgLib.MauiMarkup;

public sealed class PropertyBindingBuilder<T> : IPropertyBuilder<T>
{
    public class ValueConverter : IValueConverter
    {
        internal Func<object, T>? ConvertFunction;

        internal Func<T, object>? ConvertBackFunction;

        public object? Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && ConvertFunction != null)
            {
                return ConvertFunction(value);
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && ConvertBackFunction != null)
            {
                return ConvertBackFunction((T)value);
            }

            return null;
        }
    }

    private Expression<Func<object, T>>? getter;

    private Action<object, T>? setter;

    private string? path;

    private BindingMode _bindingMode = global::Microsoft.Maui.Controls.BindingMode.Default;

    private IValueConverter? converter;

    private ValueConverter? valueConverter;

    private object? converterParameter;

    private string? stringFormat;

    private object? source;

    private object? fallbackValue;

    private object? targetNullValue;

    private PropertyContext<T> _context;

    public PropertyContext<T> Context
    {
        get => _context;
        set => _context = value ?? throw new ArgumentNullException(nameof(value));
    }

    public PropertyBindingBuilder(PropertyContext<T> context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context));
    }

    public bool Build()
    {
        if (getter != null)
        {
            Context.BindableObject.Bind(
                Context.Property,
                getter: getter,
                setter: setter,
                mode: _bindingMode,
                converter: converter,
                converterParameter: converterParameter,
                stringFormat: stringFormat,
                source: source,
                targetNullValue: targetNullValue,
                fallbackValue: fallbackValue);
            
            return true;
        }

        if (!string.IsNullOrWhiteSpace(path))
        {
            var binding = new Binding(path!, _bindingMode, converter, converterParameter, stringFormat, source);
            if (fallbackValue is not null)
                binding.FallbackValue = fallbackValue;
            if (targetNullValue is not null)
                binding.TargetNullValue = targetNullValue;

            Context.BindableObject.SetBinding(Context.Property, binding);
            return true;
        }

        return false;
    }

    public PropertyBindingBuilder<T> Getter<TContext>(Expression<Func<TContext, T>> getter)
    {
        var parameter = Expression.Parameter(typeof(object), "obj");
        var convertedParam = Expression.Convert(parameter, typeof(TContext));
    
        var body = getter.Body;
    
        var newBody = new ParameterReplacer(getter.Parameters[0], convertedParam).Visit(body);
    
        this.getter = Expression.Lambda<Func<object, T>>(newBody, parameter);
    
        return this;
    }

    public PropertyBindingBuilder<T> Setter<TContext>(Action<TContext, T> setter)
    {
        this.setter = (obj, value) =>
        {
            if (obj is TContext contextObj)
            {
                setter(contextObj, value);
            }
        };
    
        return this;
    }

    public PropertyBindingBuilder<T> Path(string path)
    {
        this.path = path;
        return this;
    }

    public PropertyBindingBuilder<T> StringFormat(string stringFormat)
    {
        this.stringFormat = stringFormat;
        return this;
    }

    public PropertyBindingBuilder<T> BindingMode(BindingMode bindingMode)
    {
        _bindingMode = bindingMode;
        return this;
    }

    public PropertyBindingBuilder<T> Converter(IValueConverter converter)
    {
        this.converter = converter;
        return this;
    }

    public PropertyBindingBuilder<T> Parameter(object converterParameter)
    {
        this.converterParameter = converterParameter;
        return this;
    }

    public PropertyBindingBuilder<T> Source(object source)
    {
        this.source = source;
        return this;
    }

    public PropertyBindingBuilder<T> FallbackValue(object fallbackValue)
    {
        this.fallbackValue = fallbackValue;
        return this;
    }

    public PropertyBindingBuilder<T> TargetNullValue(object targetNullValue)
    {
        this.targetNullValue = targetNullValue;
        return this;
    }

    public PropertyBindingBuilder<T> Convert<Q>(Func<Q, T> convert)
    {
        if (valueConverter == null)
        {
            valueConverter = new ValueConverter();
        }

        valueConverter.ConvertFunction = (object e) => convert((Q)e);
        converter = valueConverter;
        return this;
    }

    public PropertyBindingBuilder<T> ConvertBack<Q>(Func<T, Q> convert)
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
