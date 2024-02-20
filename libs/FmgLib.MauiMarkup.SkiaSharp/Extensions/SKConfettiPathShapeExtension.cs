using SkiaSharp;
using SkiaSharp.Extended.UI.Controls;

namespace FmgLib.MauiMarkup.SkiaSharp;

public static partial class SKConfettiPathShapeExtension
{
    public static T PathFmg<T>(this T self,
        SKPath path)
        where T : SKConfettiPathShape
    {
        self.SetValue(SKConfettiPathShape.PathProperty, path);
        return self;
    }

    public static T PathFmg<T>(this T self, Func<PropertyContext<SKPath>, IPropertyBuilder<SKPath>> configure)
        where T : SKConfettiPathShape
    {
        var context = new PropertyContext<SKPath>(self, SKConfettiPathShape.PathProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PathFmg<T>(this SettersContext<T> self,
        SKPath path)
        where T : SKConfettiPathShape
    {
        self.XamlSetters.Add(new Setter { Property = SKConfettiPathShape.PathProperty, Value = path });
        return self;
    }

    public static SettersContext<T> PathFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SKPath>, IPropertySettersBuilder<SKPath>> configure)
        where T : SKConfettiPathShape
    {
        var context = new PropertySettersContext<SKPath>(self.XamlSetters, SKConfettiPathShape.PathProperty);
        configure(context).Build();
        return self;
    }
}
