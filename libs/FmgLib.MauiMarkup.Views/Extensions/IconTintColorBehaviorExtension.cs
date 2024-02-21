using CommunityToolkit.Maui.Behaviors;

namespace FmgLib.MauiMarkup.Views;

public static partial class IconTintColorBehaviorExtension
{
    public static T TintColorFmg<T>(this T self, Color color) where T : IconTintColorBehavior
    {
        self.SetValue(IconTintColorBehavior.TintColorProperty, color);
        return self;
    }

    public static T TintColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : IconTintColorBehavior
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, IconTintColorBehavior.TintColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> TintColorFmg<T>(this SettersContext<T> self, Color color) where T : IconTintColorBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = IconTintColorBehavior.TintColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> TintColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : IconTintColorBehavior
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, IconTintColorBehavior.TintColorProperty);
        configure(arg).Build();
        return self;
    }
}
