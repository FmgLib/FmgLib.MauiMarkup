﻿namespace FmgLib.MauiMarkup;

public static partial class BoxViewExtension
{
    public static T Color<T>(this T self,
        Microsoft.Maui.Graphics.Color color)
        where T : Microsoft.Maui.Controls.BoxView
    {
        self.SetValue(Microsoft.Maui.Controls.BoxView.ColorProperty, color);
        return self;
    }

    public static T Color<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.BoxView
    {
        var color = configure();
        self.SetValue(Microsoft.Maui.Controls.BoxView.ColorProperty, color);
        return self;
    }

    public static T Color<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.BoxView
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.BoxView.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Color<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color color)
        where T : Microsoft.Maui.Controls.BoxView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BoxView.ColorProperty, Value = color });
        return self;
    }

    public static SettersContext<T> Color<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.BoxView
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.BoxView.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.BoxView
    {
        Microsoft.Maui.Graphics.Color fromValue = self.Color;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.Color = actValue; };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateColorTo", transform, callback, length, easing);
    }

    public static T CornerRadius<T>(this T self,
        Microsoft.Maui.CornerRadius cornerRadius)
        where T : Microsoft.Maui.Controls.BoxView
    {
        self.SetValue(Microsoft.Maui.Controls.BoxView.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadius<T>(this T self,
        Func<Microsoft.Maui.CornerRadius> configure)
        where T : Microsoft.Maui.Controls.BoxView
    {
        var cornerRadius = configure();
        self.SetValue(Microsoft.Maui.Controls.BoxView.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static T CornerRadius<T>(this T self, Func<PropertyContext<Microsoft.Maui.CornerRadius>, IPropertyBuilder<Microsoft.Maui.CornerRadius>> configure)
        where T : Microsoft.Maui.Controls.BoxView
    {
        var context = new PropertyContext<Microsoft.Maui.CornerRadius>(self, Microsoft.Maui.Controls.BoxView.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self,
        Microsoft.Maui.CornerRadius cornerRadius)
        where T : Microsoft.Maui.Controls.BoxView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.BoxView.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }

    public static SettersContext<T> CornerRadius<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.CornerRadius>, IPropertySettersBuilder<Microsoft.Maui.CornerRadius>> configure)
        where T : Microsoft.Maui.Controls.BoxView
    {
        var context = new PropertySettersContext<Microsoft.Maui.CornerRadius>(self.XamlSetters, Microsoft.Maui.Controls.BoxView.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }

}
