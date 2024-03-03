using UraniumUI.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class ExpanderViewExtension
{
    public static T IsExpandedFmg<T>(this T self, bool isExpanded) where T : ExpanderView
    {
        self.SetValue(ExpanderView.IsExpandedProperty, isExpanded);
        return self;
    }

    public static T IsExpandedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : ExpanderView
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, ExpanderView.IsExpandedProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> IsExpandedFmg<T>(this SettersContext<T> self, bool isExpanded) where T : ExpanderView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ExpanderView.IsExpandedProperty,
            Value = isExpanded
        });
        return self;
    }

    public static SettersContext<T> IsExpandedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : ExpanderView
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, ExpanderView.IsExpandedProperty);
        configure(arg).Build();
        return self;
    }
}
