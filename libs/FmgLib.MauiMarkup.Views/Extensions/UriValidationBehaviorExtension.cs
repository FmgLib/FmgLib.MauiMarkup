using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class UriValidationBehaviorExtension
{
    public static T UriKindFmg<T>(this T self, UriKind uriKind) where T : UriValidationBehavior
    {
        self.SetValue(UriValidationBehavior.UriKindProperty, uriKind);
        return self;
    }

    public static T UriKindFmg<T>(this T self, Func<PropertyContext<UriKind>, IPropertyBuilder<UriKind>> configure) where T : UriValidationBehavior
    {
        PropertyContext<UriKind> arg = new PropertyContext<UriKind>(self, UriValidationBehavior.UriKindProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> UriKindFmg<T>(this SettersContext<T> self, UriKind uriKind) where T : UriValidationBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = UriValidationBehavior.UriKindProperty,
            Value = uriKind
        });
        return self;
    }

    public static SettersContext<T> UriKindFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<UriKind>, IPropertySettersBuilder<UriKind>> configure) where T : UriValidationBehavior
    {
        PropertySettersContext<UriKind> arg = new PropertySettersContext<UriKind>(self.XamlSetters, UriValidationBehavior.UriKindProperty);
        configure(arg).Build();
        return self;
    }
}
