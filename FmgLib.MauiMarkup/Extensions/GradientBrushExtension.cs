namespace FmgLib.MauiMarkup;

public static partial class GradientBrushExtension
{
    public static T GradientStops<T>(this T self,
        IList<GradientStop> gradientStops)
        where T : GradientBrush
    {
        foreach (var item in gradientStops)
            self.GradientStops.Add(item);
        return self;
    }

    public static T GradientStops<T>(this T self,
        params GradientStop[] gradientStops)
        where T : GradientBrush
    {
        foreach (var item in gradientStops)
            self.GradientStops.Add(item);
        return self;
    }
    
    public static T GradientStops<T>(this T self, Func<PropertyContext<GradientStopCollection>, IPropertyBuilder<GradientStopCollection>> configure)
        where T : GradientBrush
    {
        var context = new PropertyContext<GradientStopCollection>(self, GradientBrush.GradientStopsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnInvalidateGradientBrushRequested<T>(this T self, EventHandler handler)
        where T : GradientBrush
    {
        self.InvalidateGradientBrushRequested += handler;
        return self;
    }
    
    public static T OnInvalidateGradientBrushRequested<T>(this T self, Action<T> action)
        where T : GradientBrush
    {
        self.InvalidateGradientBrushRequested += (o, arg) => action(self);
        return self;
    }
    
}