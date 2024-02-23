using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using System.Runtime.Versioning;

namespace FmgLib.MauiMarkup.Views;

[UnsupportedOSPlatform("Windows"), UnsupportedOSPlatform("MacCatalyst"), UnsupportedOSPlatform("MacOS"), UnsupportedOSPlatform("Tizen")]
public static partial class StatusBarBehaviorExtension
{
    public static T StatusBarColorFmg<T>(this T self, Color color) where T : StatusBarBehavior
    {
        self.SetValue(StatusBarBehavior.StatusBarColorProperty, color);
        return self;
    }

    public static T StatusBarColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : StatusBarBehavior
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, StatusBarBehavior.StatusBarColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> StatusBarColorFmg<T>(this SettersContext<T> self, Color color) where T : StatusBarBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatusBarBehavior.StatusBarColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> StatusBarColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : StatusBarBehavior
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, StatusBarBehavior.StatusBarColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T StatusBarStyleFmg<T>(this T self, StatusBarStyle style) where T : StatusBarBehavior
    {
        self.SetValue(StatusBarBehavior.StatusBarStyleProperty, style);
        return self;
    }

    public static T StatusBarStyleFmg<T>(this T self, Func<PropertyContext<StatusBarStyle>, IPropertyBuilder<StatusBarStyle>> configure) where T : StatusBarBehavior
    {
        PropertyContext<StatusBarStyle> arg = new PropertyContext<StatusBarStyle>(self, StatusBarBehavior.StatusBarStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> StatusBarStyleFmg<T>(this SettersContext<T> self, StatusBarStyle style) where T : StatusBarBehavior
    {
        self.XamlSetters.Add(new Setter
        {
            Property = StatusBarBehavior.StatusBarStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<T> StatusBarStyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<StatusBarStyle>, IPropertySettersBuilder<StatusBarStyle>> configure) where T : StatusBarBehavior
    {
        PropertySettersContext<StatusBarStyle> arg = new PropertySettersContext<StatusBarStyle>(self.XamlSetters, StatusBarBehavior.StatusBarStyleProperty);
        configure(arg).Build();
        return self;
    }
}
