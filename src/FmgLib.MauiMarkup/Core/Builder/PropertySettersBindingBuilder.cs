using System.Globalization;
using System.Linq.Expressions;
using Microsoft.Maui.Controls.Internals;

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

    private Expression<Func<object, T>> getter;
    
    private Action<object, T> setter;
    
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
        if (getter != null)
        {
            var getterFunc = TypedBindingExtensions.ConvertExpressionToFunc(getter);
            var handlers = new (Func<object, object?>, string)[]
                { ((object b) => b, TypedBindingExtensions.GetMemberName(getter)) };
            Context.XamlSetters.Add(
                new Setter
                {
                    Property = Context.Property,
                    Value = new TypedBinding<object, T>(bindingContext => (getterFunc(bindingContext), true), setter, handlers.Select(x => x.ToTuple()).ToArray())
                    {
                        Mode = bindingMode,
                        Converter = converter,
                        ConverterParameter = converterParameter,
                        StringFormat = stringFormat,
                        Source = source,
                        TargetNullValue = targetNullValue,
                        FallbackValue = fallbackValue
                    }
                }
            );
            return true;
        }
        else if (path != null)
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
    
    public PropertySettersBindingBuilder<T> Getter<TContext>(Expression<Func<TContext, T>> getter)
    {
        var parameter = Expression.Parameter(typeof(object), "obj");
        var convertedParam = Expression.Convert(parameter, typeof(TContext));
    
        var body = getter.Body;
    
        var newBody = new ParameterReplacer(getter.Parameters[0], convertedParam).Visit(body);
    
        this.getter = Expression.Lambda<Func<object, T>>(newBody, parameter);
    
        return this;
    }

    public PropertySettersBindingBuilder<T> Setter<TContext>(Action<TContext, T> setter)
    {
        this.setter = (obj, value) =>
        {
            var contextObj = (TContext)obj;
            setter(contextObj, value);
        };
    
        return this;
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
