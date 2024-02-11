using CommunityToolkit.Maui.Views;
using System.Collections;

namespace FmgLib.MauiMarkup.Views;

public static partial class SemanticOrderViewExtension
{
    public static T ViewOrderFmg<T>(this T self, IEnumerable objects) where T : SemanticOrderView
    {
        self.SetValue(SemanticOrderView.ViewOrderProperty, objects);
        return self;
    }

    public static T ViewOrderFmg<T>(this T self, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : SemanticOrderView
    {
        PropertyContext<IEnumerable> arg = new PropertyContext<IEnumerable>(self, SemanticOrderView.ViewOrderProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ViewOrderFmg<T>(this SettersContext<T> self, IEnumerable objects) where T : SemanticOrderView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SemanticOrderView.ViewOrderProperty,
            Value = objects
        });
        return self;
    }

    public static SettersContext<T> ViewOrderFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable>, IPropertySettersBuilder<IEnumerable>> configure) where T : SemanticOrderView
    {
        PropertySettersContext<IEnumerable> arg = new PropertySettersContext<IEnumerable>(self.XamlSetters, SemanticOrderView.ViewOrderProperty);
        configure(arg).Build();
        return self;
    }
}
