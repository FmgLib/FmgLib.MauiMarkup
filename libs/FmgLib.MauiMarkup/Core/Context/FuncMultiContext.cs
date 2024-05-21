﻿using System.Globalization;

namespace FmgLib.MauiMarkup;

public class FuncMultiContext<TDest, TParam> : IMultiValueConverter
{
    readonly Func<object[], TDest>? convert;
    readonly Func<TDest?, object?[]>? convertBack;

    readonly Func<object[], TParam?, TDest>? convertWithParam;
    readonly Func<TDest?, TParam?, object?[]>? convertBackWithParam;

    readonly Func<object[], TParam?, CultureInfo, TDest>? convertWithParamAndCulture;
    readonly Func<TDest?, TParam?, CultureInfo, object[]>? convertBackWithParamAndCulture;


    public FuncMultiContext(Func<object[], TParam?, CultureInfo, TDest>? convertWithParamAndCulture = null, Func<TDest?, TParam?, CultureInfo, object[]>? convertBackWithParamAndCulture = null)
    {
        this.convertWithParamAndCulture = convertWithParamAndCulture;
        this.convertBackWithParamAndCulture = convertBackWithParamAndCulture;
    }

    public FuncMultiContext(Func<object[], TParam?, TDest>? convertWithParam = null, Func<TDest?, TParam?, object?[]>? convertBackWithParam = null)
    {
        this.convertWithParam = convertWithParam;
        this.convertBackWithParam = convertBackWithParam;
    }

    public FuncMultiContext(Func<object[], TDest>? convert = null, Func<TDest?, object?[]>? convertBack = null)
    {
        this.convert = convert;
        this.convertBack = convertBack;
    }

    public object? Convert(object[] values, Type targetType, object? parameter, CultureInfo culture)
    {
        if (convert is not null)
        {
            return convert(values);
        }

        if (convertWithParam != null)
        {
            return convertWithParam(
                values,
                parameter != null ? (TParam)parameter : default);
        }

        if (convertWithParamAndCulture != null)
        {
            return convertWithParamAndCulture(
                values,
                parameter != null ? (TParam)parameter : default,
                culture);
        }

        return BindableProperty.UnsetValue;
    }

    public object?[]? ConvertBack(object? value, Type[] targetTypes, object? parameter, CultureInfo culture)
    {
        if (convertBack != null)
        {
            return convertBack(
                value != null ? (TDest)value : default);
        }

        if (convertBackWithParam != null)
        {
            return convertBackWithParam(
                value != null ? (TDest)value : default,
                parameter != null ? (TParam)parameter : default);
        }

        if (convertBackWithParamAndCulture != null)
        {
            return convertBackWithParamAndCulture(
                value != null ? (TDest)value : default,
                parameter != null ? (TParam)parameter : default,
                culture);
        }

        return null;
    }
}

public class FuncMultiContext<TSource1, TSource2, TDest> : FuncMultiContext<TDest, object>
{
    static T? To<T>(object? value) => value != null ? (T)value : default;

    static object?[] ToObjects(ValueTuple<TSource1, TSource2> values) => new object?[] { values.Item1, values.Item2 };

    public FuncMultiContext(Func<ValueTuple<TSource1?, TSource2?>, TDest>? convert = null,
                                Func<TDest?, ValueTuple<TSource1, TSource2>>? convertBack = null)
    : base(convert is null ? default(Func<object[], TDest>) : (object[] values) => convert((To<TSource1>(values[0]), To<TSource2>(values[1]))),
            convertBack is null ? default(Func<TDest?, object?[]>) : (TDest? value) => ToObjects(convertBack(value)))
    {
    }
}

public class FuncMultiContext<TSource1, TSource2, TSource3, TDest> : FuncMultiContext<TDest, object>
{
    static T? To<T>(object? value) => value != null ? (T)value : default;

    static object?[] ToObjects(ValueTuple<TSource1, TSource2, TSource3> values) => new object?[] { values.Item1, values.Item2, values.Item3 };

    public FuncMultiContext(Func<ValueTuple<TSource1?, TSource2?, TSource3?>, TDest>? convert = null,
                                Func<TDest?, ValueTuple<TSource1, TSource2, TSource3>>? convertBack = null)
    : base(convert is null ? default(Func<object[], TDest>) : (object[] values) => convert((To<TSource1>(values[0]), To<TSource2>(values[1]), To<TSource3>(values[2]))),
            convertBack is null ? default(Func<TDest?, object?[]>) : (TDest? value) => ToObjects(convertBack(value)))
    {

    }
}

public class FuncMultiContext<TSource1, TSource2, TSource3, TSource4, TDest> : FuncMultiContext<TDest, object>
{
    static T? To<T>(object? value) => value != null ? (T)value : default;

    static object?[] ToObjects(ValueTuple<TSource1, TSource2, TSource3, TSource4> values) => new object?[] { values.Item1, values.Item2, values.Item3, values.Item4 };

    public FuncMultiContext(Func<ValueTuple<TSource1?, TSource2?, TSource3?, TSource4?>, TDest>? convert = null,
                                Func<TDest?, ValueTuple<TSource1, TSource2, TSource3, TSource4>>? convertBack = null)
    : base(convert is null ? default(Func<object[], TDest>) : (object[] values) => convert((To<TSource1>(values[0]), To<TSource2>(values[1]), To<TSource3>(values[2]), To<TSource4>(values[3]))),
            convertBack is null ? default(Func<TDest?, object?[]>) : (TDest? value) => ToObjects(convertBack(value)))
    {

    }
}

public class FuncMultiContextWithParam<TSource1, TSource2, TDest, TParam> : FuncMultiContext<TDest, TParam>
{
    static T? To<T>(object? value) => value != null ? (T)value : default;

    static object?[] ToObjects(ValueTuple<TSource1, TSource2> values) => new object?[] { values.Item1, values.Item2 };

    public FuncMultiContextWithParam(Func<ValueTuple<TSource1?, TSource2?>, TParam?, TDest>? convert = null,
                                        Func<TDest?, TParam?, ValueTuple<TSource1, TSource2>>? convertBack = null)
    : base(convert is null ? default(Func<object[], TParam?, TDest>) : (object[] values, TParam? param) => convert((To<TSource1>(values[0]), To<TSource2>(values[1])), param),
            convertBack is null ? default(Func<TDest?, TParam?, object?[]>) : (TDest? value, TParam? param) => ToObjects(convertBack(value, param)))
    {
    }
}

public class FuncMultiContextWithParam<TSource1, TSource2, TSource3, TDest, TParam> : FuncMultiContext<TDest, TParam>
{
    static T? To<T>(object value) => value != null ? (T)value : default;

    static object?[] ToObjects(ValueTuple<TSource1, TSource2, TSource3> values) => new object?[] { values.Item1, values.Item2, values.Item3 };

    public FuncMultiContextWithParam(Func<ValueTuple<TSource1?, TSource2?, TSource3?>, TParam?, TDest>? convert = null,
                                        Func<TDest?, TParam?, ValueTuple<TSource1, TSource2, TSource3>>? convertBack = null)
    : base(convert is null ? default(Func<object[], TParam?, TDest>) : (object[] values, TParam? param) => convert((To<TSource1>(values[0]), To<TSource2>(values[1]), To<TSource3>(values[2])), param),
            convertBack is null ? default(Func<TDest?, TParam?, object?[]>) : (TDest? value, TParam? param) => ToObjects(convertBack(value, param)))
    {

    }
}

public class FuncMultiContextWithParam<TSource1, TSource2, TSource3, TSource4, TDest, TParam> : FuncMultiContext<TDest, TParam>
{
    static T? To<T>(object? value) => value != null ? (T)value : default;

    static object?[] ToObjects(ValueTuple<TSource1, TSource2, TSource3, TSource4> values) => new object?[] { values.Item1, values.Item2, values.Item3, values.Item4 };

    public FuncMultiContextWithParam(Func<ValueTuple<TSource1?, TSource2?, TSource3?, TSource4?>, TParam?, TDest>? convert = null,
                                        Func<TDest?, TParam?, ValueTuple<TSource1, TSource2, TSource3, TSource4>>? convertBack = null)
    : base(convert is null ? default(Func<object[], TParam?, TDest>) : (object[] values, TParam? param) => convert((To<TSource1>(values[0]), To<TSource2>(values[1]), To<TSource3>(values[2]), To<TSource4>(values[3])), param),
            convertBack is null ? default(Func<TDest?, TParam?, object?[]>) : (TDest? value, TParam? param) => ToObjects(convertBack(value, param)))
    {

    }
}
