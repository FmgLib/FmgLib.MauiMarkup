using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class SetFocusOnEntryCompletedBehaviorExtension
{
    public static T NextElementFmg<T>(this T self, VisualElement visualElement) where T : SetFocusOnEntryCompletedBehavior
    {
        self.SetValue(SetFocusOnEntryCompletedBehavior.NextElementProperty, visualElement);
        return self;
    }

    public static T NextElementFmg<T>(this T self, Func<PropertyContext<VisualElement>, IPropertyBuilder<VisualElement>> configure) where T : SetFocusOnEntryCompletedBehavior
    {
        PropertyContext<VisualElement> arg = new PropertyContext<VisualElement>(self, SetFocusOnEntryCompletedBehavior.NextElementProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> NextElementFmg<T>(this SettersContext<T> self, VisualElement visualElement) where T : SetFocusOnEntryCompletedBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = SetFocusOnEntryCompletedBehavior.NextElementProperty,
            Value = visualElement
        });
        return self;
    }

    public static SettersContext<T> NextElementFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<VisualElement>, IPropertySettersBuilder<VisualElement>> configure) where T : SetFocusOnEntryCompletedBehavior
    {
        PropertySettersContext<VisualElement> arg = new PropertySettersContext<VisualElement>(self.XamlSetters, SetFocusOnEntryCompletedBehavior.NextElementProperty);
        configure(arg).Build();
        return self;
    }
}
