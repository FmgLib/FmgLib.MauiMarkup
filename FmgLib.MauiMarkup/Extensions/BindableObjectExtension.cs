using System.ComponentModel;

namespace FmgLib.MauiMarkup;

public static partial class BindableObjectExtension
{
    public static T Bind<T>(this T self, BindableProperty property, string sourcePath, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string converterParameter = null, string stringFormat = null, object source = null) where T : BindableObject
    {
        self.SetBinding(property, new Binding(sourcePath, mode, converter, converterParameter, stringFormat, source));
        return self;
    }

    public static T BindTemplatedParent<T>(this T self, BindableProperty property, string sourcePath, BindingMode mode = BindingMode.Default, IValueConverter converter = null, string converterParameter = null, string stringFormat = null) where T : BindableObject
    {
        self.SetBinding(property, new Binding(sourcePath, mode, converter, converterParameter, stringFormat, RelativeBindingSource.TemplatedParent));
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