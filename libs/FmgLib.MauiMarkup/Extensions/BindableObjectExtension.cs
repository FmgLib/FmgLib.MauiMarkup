using System.ComponentModel;

namespace FmgLib.MauiMarkup;

public static partial class BindableObjectExtension
{
    public static T Bind<T>(this T self, BindableProperty targetProperty, string path = Binding.SelfPath, BindingMode mode = BindingMode.Default, IValueConverter? converter = null, object? converterParameter = null, string? stringFormat = null, object? source = null, object? targetNullValue = null, object? fallbackValue = null) where T : BindableObject
    {
        self.SetBinding(
            targetProperty,
            new Binding(path, mode, converter, converterParameter, stringFormat, source)
            {
                TargetNullValue = targetNullValue,
                FallbackValue = fallbackValue
            });

        return self;
    }

    public static T Bind<T, TSource, TDest>(this T self, BindableProperty targetProperty, string path = Binding.SelfPath, BindingMode mode = BindingMode.Default, Func<TSource?, TDest>? convert = null, Func<TDest?, TSource>? convertBack = null, string? stringFormat = null, object? source = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    {
        var converter = new FuncContext<TSource, TDest, object>(convert, convertBack);
        self.SetBinding(
            targetProperty,
            new Binding(path, mode, converter, null, stringFormat, source)
            {
                TargetNullValue = targetNullValue,
                FallbackValue = fallbackValue
            });

        return self;
    }

    public static T Bind<T, TSource, TParam, TDest>(this T self, BindableProperty targetProperty, string path = Binding.SelfPath, BindingMode mode = BindingMode.Default, Func<TSource?, TParam?, TDest>? convert = null, Func<TDest?, TParam?, TSource>? convertBack = null, TParam? converterParameter = default, string? stringFormat = null, object? source = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    {
        var converter = new FuncContext<TSource, TDest, TParam>(convert, convertBack);
        self.SetBinding(
            targetProperty,
            new Binding(path, mode, converter, converterParameter, stringFormat, source)
            {
                TargetNullValue = targetNullValue,
                FallbackValue = fallbackValue
            });

        return self;
    }

    public static T Bind<T, TSource1, TSource2, TDest>(this T self, BindableProperty targetProperty, BindingBase binding1, BindingBase binding2, Func<ValueTuple<TSource1?, TSource2?>, TDest>? convert = null, Func<TDest?, ValueTuple<TSource1, TSource2>>? convertBack = null, BindingMode mode = BindingMode.Default, string? stringFormat = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    => self.Bind(
        targetProperty,
        new List<BindingBase> { binding1, binding2 },
        new FuncMultiContext<TSource1, TSource2, TDest>(convert, convertBack),
        null,
        mode,
        stringFormat,
        targetNullValue,
        fallbackValue);

    public static T Bind<T, TSource1, TSource2, TParam, TDest>(this T self, BindableProperty targetProperty, BindingBase binding1, BindingBase binding2, Func<ValueTuple<TSource1?, TSource2?>, TParam?, TDest>? convert = null, Func<TDest?, TParam?, ValueTuple<TSource1, TSource2>>? convertBack = null, TParam? converterParameter = default, BindingMode mode = BindingMode.Default, string? stringFormat = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    => self.Bind(
        targetProperty,
        new List<BindingBase> { binding1, binding2 },
        new FuncMultiContextWithParam<TSource1, TSource2, TDest, TParam>(convert, convertBack),
        converterParameter,
        mode,
        stringFormat,
        targetNullValue,
        fallbackValue);

    public static T Bind<T, TSource1, TSource2, TSource3, TDest>(this T self, BindableProperty targetProperty, BindingBase binding1, BindingBase binding2, BindingBase binding3, Func<ValueTuple<TSource1?, TSource2?, TSource3?>, TDest>? convert = null, Func<TDest?, ValueTuple<TSource1, TSource2, TSource3>>? convertBack = null, BindingMode mode = BindingMode.Default, string? stringFormat = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    => self.Bind(
        targetProperty,
        new List<BindingBase> { binding1, binding2, binding3 },
        new FuncMultiContext<TSource1, TSource2, TSource3, TDest>(convert, convertBack),
        null,
        mode,
        stringFormat,
        targetNullValue,
        fallbackValue);

    public static T Bind<T, TSource1, TSource2, TSource3, TParam, TDest>(this T self, BindableProperty targetProperty, BindingBase binding1, BindingBase binding2, BindingBase binding3, Func<ValueTuple<TSource1?, TSource2?, TSource3?>, TParam?, TDest>? convert = null, Func<TDest?, TParam?, ValueTuple<TSource1, TSource2, TSource3>>? convertBack = null, TParam? converterParameter = default, BindingMode mode = BindingMode.Default, string? stringFormat = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    => self.Bind(
        targetProperty,
        new List<BindingBase> { binding1, binding2, binding3 },
        new FuncMultiContextWithParam<TSource1, TSource2, TSource3, TDest, TParam>(convert, convertBack),
        converterParameter,
        mode,
        stringFormat,
        targetNullValue,
        fallbackValue);

    public static T Bind<T, TSource1, TSource2, TSource3, TSource4, TDest>(this T self, BindableProperty targetProperty, BindingBase binding1, BindingBase binding2, BindingBase binding3, BindingBase binding4, Func<ValueTuple<TSource1?, TSource2?, TSource3?, TSource4?>, TDest>? convert = null, Func<TDest?, ValueTuple<TSource1, TSource2, TSource3, TSource4>>? convertBack = null, BindingMode mode = BindingMode.Default, string? stringFormat = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    => self.Bind(
        targetProperty,
        new List<BindingBase> { binding1, binding2, binding3, binding4 },
        new FuncMultiContext<TSource1, TSource2, TSource3, TSource4, TDest>(convert, convertBack),
        null,
        mode,
        stringFormat,
        targetNullValue,
        fallbackValue);

    public static T Bind<T, TSource1, TSource2, TSource3, TSource4, TParam, TDest>(this T self, BindableProperty targetProperty, BindingBase binding1, BindingBase binding2, BindingBase binding3, BindingBase binding4, Func<ValueTuple<TSource1?, TSource2?, TSource3?, TSource4?>, TParam?, TDest>? convert = null, Func<TDest?, TParam?, ValueTuple<TSource1, TSource2, TSource3, TSource4>>? convertBack = null, TParam? converterParameter = default, BindingMode mode = BindingMode.Default, string? stringFormat = null, TDest? targetNullValue = default, TDest? fallbackValue = default) where T : BindableObject
    => self.Bind(
        targetProperty,
        new List<BindingBase> { binding1, binding2, binding3, binding4 },
        new FuncMultiContextWithParam<TSource1, TSource2, TSource3, TSource4, TDest, TParam>(convert, convertBack),
        converterParameter,
        mode,
        stringFormat,
        targetNullValue,
        fallbackValue);

    public static T Bind<T>(this T self, BindableProperty targetProperty, IList<BindingBase> bindings, IMultiValueConverter converter, object? converterParameter = default, BindingMode mode = BindingMode.Default, string? stringFormat = null, object? targetNullValue = null, object? fallbackValue = null) where T : BindableObject
    {
        self.SetBinding(targetProperty, new MultiBinding
        {
            Bindings = bindings,
            Converter = converter,
            ConverterParameter = converterParameter,
            Mode = mode,
            StringFormat = stringFormat,
            TargetNullValue = targetNullValue,
            FallbackValue = fallbackValue
        });

        return self;
    }

    public static T BindTemplatedParent<T>(this T self, BindableProperty property, string sourcePath, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string converterParameter = null, string stringFormat = null) where T : BindableObject
    {
        self.SetBinding(property, new Binding(sourcePath, mode, converter, converterParameter, stringFormat, RelativeBindingSource.TemplatedParent));
        return self;
    }

    public static T AppThemeBinding<T, TValue>(this T self, BindableProperty bindableProperty, TValue light, TValue dark) where T : BindableObject
    {
        self.SetAppTheme(bindableProperty, light, dark);

        return self;
    }

    public static T AppThemeColorBinding<T>(this T self, BindableProperty bindableProperty, Color light, Color dark) where T : BindableObject
    {
        self.SetAppThemeColor(bindableProperty, light, dark);

        return self;
    }

    public static T RegisterName<T>(this T self, string name, BindableObject scopedElement) where T : BindableObject
    {
        INameScope nameScope = NameScope.GetNameScope(scopedElement);
        if (nameScope == null)
        {
            nameScope = new NameScope();
            NameScope.SetNameScope(scopedElement, nameScope);
        }

        nameScope.RegisterName(name, self);
        return self;
    }

    public static T BindingContext<T>(this T self, object bindingContext) where T : BindableObject
    {
        self.SetValue(BindableObject.BindingContextProperty, bindingContext);
        return self;
    }

    public static T BindingContext<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : BindableObject
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, BindableObject.BindingContextProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BindingContext<T>(this SettersContext<T> self, object bindingContext) where T : BindableObject
    {
        self.XamlSetters.Add(new Setter
        {
            Property = BindableObject.BindingContextProperty,
            Value = bindingContext
        });
        return self;
    }

    public static SettersContext<T> BindingContext<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : BindableObject
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, BindableObject.BindingContextProperty);
        configure(arg).Build();
        return self;
    }

    public static T OnPropertyChanged<T>(this T self, PropertyChangedEventHandler handler) where T : BindableObject
    {
        self.PropertyChanged += handler;
        return self;
    }

    public static T OnPropertyChanged<T>(this T self, Action<T> action) where T : BindableObject
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.PropertyChanged += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnPropertyChanging<T>(this T self, Microsoft.Maui.Controls.PropertyChangingEventHandler handler) where T : BindableObject
    {
        self.PropertyChanging += handler;
        return self;
    }

    public static T OnPropertyChanging<T>(this T self, Action<T> action) where T : BindableObject
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.PropertyChanging += delegate
        {
            action2(self2);
        };
        return self2;
    }

    public static T OnBindingContextChanged<T>(this T self, EventHandler handler) where T : BindableObject
    {
        self.BindingContextChanged += handler;
        return self;
    }

    public static T OnBindingContextChanged<T>(this T self, Action<T> action) where T : BindableObject
    {
        Action<T> action2 = action;
        T self2 = self;
        self2.BindingContextChanged += delegate
        {
            action2(self2);
        };
        return self2;
    }

}