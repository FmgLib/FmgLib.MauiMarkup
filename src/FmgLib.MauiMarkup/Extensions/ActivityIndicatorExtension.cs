﻿namespace FmgLib.MauiMarkup;


public static partial class ActivityIndicatorExtension
{
    public static T Color<T>(this T self,
        Microsoft.Maui.Graphics.Color color)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        self.SetValue(Microsoft.Maui.Controls.ActivityIndicator.ColorProperty, color);
        return self;
    }

    public static T Color<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        var color = configure();
        self.SetValue(Microsoft.Maui.Controls.ActivityIndicator.ColorProperty, color);
        return self;
    }

    public static T Color<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.ActivityIndicator.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Color<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color color)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ActivityIndicator.ColorProperty, Value = color });
        return self;
    }

    public static SettersContext<T> Color<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.ActivityIndicator.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        Microsoft.Maui.Graphics.Color fromValue = self.Color;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.Color = actValue; };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateColorTo", transform, callback, length, easing);
    }

    public static T IsRunning<T>(this T self,
        bool isRunning)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        self.SetValue(Microsoft.Maui.Controls.ActivityIndicator.IsRunningProperty, isRunning);
        return self;
    }

    public static T IsRunning<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        var isRunning = configure();
        self.SetValue(Microsoft.Maui.Controls.ActivityIndicator.IsRunningProperty, isRunning);
        return self;
    }

    public static T IsRunning<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.ActivityIndicator.IsRunningProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsRunning<T>(this SettersContext<T> self,
        bool isRunning)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ActivityIndicator.IsRunningProperty, Value = isRunning });
        return self;
    }

    public static SettersContext<T> IsRunning<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.ActivityIndicator
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.ActivityIndicator.IsRunningProperty);
        configure(context).Build();
        return self;
    }

}
