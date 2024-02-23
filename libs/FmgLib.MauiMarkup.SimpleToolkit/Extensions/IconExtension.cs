using SimpleToolkit.Core;

namespace FmgLib.MauiMarkup.SimpleToolkit;

public static partial class IconExtension
{
    public static T TintColorFmg<T>(this T self,
        Color tintColor)
        where T : Icon
    {
        self.SetValue(Icon.TintColorProperty, tintColor);
        return self;
    }

    public static T TintColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Icon
    {
        var context = new PropertyContext<Color>(self, Icon.TintColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TintColorFmg<T>(this SettersContext<T> self,
        Color tintColor)
        where T : Icon
    {
        self.XamlSetters.Add(new Setter { Property = Icon.TintColorProperty, Value = tintColor });
        return self;
    }

    public static SettersContext<T> TintColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Icon
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Icon.TintColorProperty);
        configure(context).Build();
        return self;
    }
}
