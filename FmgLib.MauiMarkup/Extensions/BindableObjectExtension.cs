namespace FmgLib.MauiMarkup;

public static partial class BindableObjectExtension
{
    public static T BindingContext<T>(this T self,
        object bindingContext)
        where T : BindableObject
    {
        self.SetValue(BindableObject.BindingContextProperty, bindingContext);
        return self;
    }
    
    public static T BindingContext<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : BindableObject
    {
        var context = new PropertyContext<object>(self, BindableObject.BindingContextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BindingContext<T>(this SettersContext<T> self,
        object bindingContext)
        where T : BindableObject
    {
        self.XamlSetters.Add(new Setter { Property = BindableObject.BindingContextProperty, Value = bindingContext });
        return self;
    }
    
    public static SettersContext<T> BindingContext<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : BindableObject
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, BindableObject.BindingContextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnPropertyChanged<T>(this T self, System.ComponentModel.PropertyChangedEventHandler handler)
        where T : BindableObject
    {
        self.PropertyChanged += handler;
        return self;
    }
    
    public static T OnPropertyChanged<T>(this T self, Action<T> action)
        where T : BindableObject
    {
        self.PropertyChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPropertyChanging<T>(this T self, PropertyChangingEventHandler handler)
        where T : BindableObject
    {
        self.PropertyChanging += handler;
        return self;
    }
    
    public static T OnPropertyChanging<T>(this T self, Action<T> action)
        where T : BindableObject
    {
        self.PropertyChanging += (o, arg) => action(self);
        return self;
    }
    
    public static T OnBindingContextChanged<T>(this T self, EventHandler handler)
        where T : BindableObject
    {
        self.BindingContextChanged += handler;
        return self;
    }
    
    public static T OnBindingContextChanged<T>(this T self, Action<T> action)
        where T : BindableObject
    {
        self.BindingContextChanged += (o, arg) => action(self);
        return self;
    }
    
}