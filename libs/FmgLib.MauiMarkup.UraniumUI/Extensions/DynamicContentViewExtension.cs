using UraniumUI.Views;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class DynamicContentViewExtension
{
    public static T ValueFmg<T>(this T self,
        object value)
        where T : DynamicContentView
    {
        self.SetValue(DynamicContentView.ValueProperty, value);
        return self;
    }

    public static T ValueFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : DynamicContentView
    {
        var context = new PropertyContext<object>(self, DynamicContentView.ValueProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self,
        object value)
        where T : DynamicContentView
    {
        self.XamlSetters.Add(new Setter { Property = DynamicContentView.ValueProperty, Value = value });
        return self;
    }

    public static SettersContext<T> ValueFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : DynamicContentView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, DynamicContentView.ValueProperty);
        configure(context).Build();
        return self;
    }
}
