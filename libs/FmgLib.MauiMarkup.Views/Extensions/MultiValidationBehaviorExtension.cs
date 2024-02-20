using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class MultiValidationBehaviorExtension
{
    public static T ErrorsFmg<T>(this T self, List<object?> errors) where T : MultiValidationBehavior
    {
        self.SetValue(MultiValidationBehavior.ErrorsProperty, errors);
        return self;
    }

    public static T ErrorsFmg<T>(this T self, Func<PropertyContext<List<object?>>, IPropertyBuilder<List<object?>>> configure) where T : MultiValidationBehavior
    {
        PropertyContext<List<object?>> arg = new PropertyContext<List<object?>>(self, MultiValidationBehavior.ErrorsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ErrorsFmg<T>(this SettersContext<T> self, List<object?> errors) where T : MultiValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MultiValidationBehavior.ErrorsProperty,
            Value = errors
        });
        return self;
    }

    public static SettersContext<T> ErrorsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<List<object?>>, IPropertySettersBuilder<List<object?>>> configure) where T : MultiValidationBehavior
    {
        PropertySettersContext<List<object?>> arg = new PropertySettersContext<List<object?>>(self.XamlSetters, MultiValidationBehavior.ErrorsProperty);
        configure(arg).Build();
        return self;
    }

    public static T ErrorFmg<T>(this T self, object error) where T : MultiValidationBehavior
    {
        self.SetValue(MultiValidationBehavior.ErrorProperty, error);
        return self;
    }

    public static T ErrorFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : MultiValidationBehavior
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, MultiValidationBehavior.ErrorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ErrorFmg<T>(this SettersContext<T> self, object error) where T : MultiValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = MultiValidationBehavior.ErrorProperty,
            Value = error
        });
        return self;
    }

    public static SettersContext<T> ErrorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : MultiValidationBehavior
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, MultiValidationBehavior.ErrorProperty);
        configure(arg).Build();
        return self;
    }
}
