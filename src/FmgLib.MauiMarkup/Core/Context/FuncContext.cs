using System.Globalization;

namespace FmgLib.MauiMarkup;

public class FuncContext<TSource, TDest, TParam> : IValueConverter
{
    readonly Func<TSource?, TDest?>? convert;
    readonly Func<TDest?, TSource?>? convertBack;

    readonly Func<TSource?, TParam?, TDest?>? convertWithParam;
    readonly Func<TDest?, TParam?, TSource?>? convertBackWithParam;

    readonly Func<TSource?, TParam?, CultureInfo?, TDest?>? convertWithParamAndCulture;
    readonly Func<TDest?, TParam?, CultureInfo?, TSource?>? convertBackWithParamAndCulture;

    public FuncContext(Func<TSource?, TParam?, CultureInfo?, TDest>? convertWithParamAndCulture = null, Func<TDest?, TParam?, CultureInfo?, TSource>? convertBackWithParamAndCulture = null)
    {
        this.convertWithParamAndCulture = convertWithParamAndCulture;
        this.convertBackWithParamAndCulture = convertBackWithParamAndCulture;
    }

    public FuncContext(Func<TSource?, TParam?, TDest>? convertWithParam = null, Func<TDest?, TParam?, TSource>? convertBackWithParam = null)
    {
        this.convertWithParam = convertWithParam;
        this.convertBackWithParam = convertBackWithParam;
    }

    public FuncContext(Func<TSource?, TDest?>? convert = null, Func<TDest?, TSource?>? convertBack = null)
    {
        this.convert = convert;
        this.convertBack = convertBack;
    }

    public object? Convert(object? value, Type? targetType, object? parameter, CultureInfo? culture)
    {
        if (convert != null)
        {
            return convert.Invoke(
                value != null ? (TSource)value : default(TSource));
        }

        if (convertWithParam != null)
        {
            return convertWithParam.Invoke(
                value != null ? (TSource)value : default(TSource),
                parameter != null ? (TParam)parameter : default(TParam));
        }

        if (convertWithParamAndCulture != null)
        {
            return convertWithParamAndCulture.Invoke(
                value != null ? (TSource)value : default(TSource),
                parameter != null ? (TParam)parameter : default(TParam),
                culture);
        }

        return default(TDest);
    }

    public object? ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
    {
        if (convertBack != null)
        {
            return convertBack.Invoke(
                value != null ? (TDest)value : default(TDest));
        }

        if (convertBackWithParam != null)
        {
            return convertBackWithParam.Invoke(
                value != null ? (TDest)value : default(TDest),
                parameter != null ? (TParam)parameter : default(TParam));
        }

        if (convertBackWithParamAndCulture != null)
        {
            return convertBackWithParamAndCulture.Invoke(
                value != null ? (TDest)value : default(TDest),
                parameter != null ? (TParam)parameter : default(TParam),
                culture);
        }

        return default(TSource);
    }
}

public class FuncContext<TSource, TDest> : FuncContext<TSource, TDest, object>
{
    public FuncContext(Func<TSource?, TDest>? convert = null, Func<TDest?, TSource>? convertBack = null)
        : base(convert, convertBack)
    {
    }
}

public class FuncContext<TSource> : FuncContext<TSource, object, object>
{
    public FuncContext(Func<TSource?, object>? convert = null, Func<object?, TSource>? convertBack = null)
        : base(convert, convertBack)
    {
    }
}

public class FuncContext : FuncContext<object, object, object>
{
    public FuncContext(Func<object?, object>? convert = null, Func<object?, object>? convertBack = null)
        : base(convert, convertBack)
    {
    }
}

public class ToStringConverter : FuncContext<object, string>
{
    public ToStringConverter(string format = "{0}")
        : base(o => string.Format(CultureInfo.InvariantCulture, format, o))
    {
    }
}

public class NotConverter : FuncContext<bool, bool>
{
    static readonly Lazy<NotConverter> instance = new(() => new NotConverter());

    public static NotConverter Instance => instance.Value;

    public NotConverter() : base(t => !t, t => !t)
    {
    }
}
