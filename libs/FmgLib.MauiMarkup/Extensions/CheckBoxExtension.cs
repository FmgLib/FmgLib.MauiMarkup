﻿namespace FmgLib.MauiMarkup;

public static partial class CheckBoxExtension
{
    public static T Color<T>(this T self,
        Microsoft.Maui.Graphics.Color color)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        self.SetValue(Microsoft.Maui.Controls.CheckBox.ColorProperty, color);
        return self;
    }

    public static T Color<T>(this T self,
        Func<Microsoft.Maui.Graphics.Color> configure)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        var color = configure();
        self.SetValue(Microsoft.Maui.Controls.CheckBox.ColorProperty, color);
        return self;
    }

    public static T Color<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Color>, IPropertyBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Color>(self, Microsoft.Maui.Controls.CheckBox.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Color<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Color color)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CheckBox.ColorProperty, Value = color });
        return self;
    }

    public static SettersContext<T> Color<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Color>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Color>> configure)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Color>(self.XamlSetters, Microsoft.Maui.Controls.CheckBox.ColorProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateColorTo<T>(this T self, Microsoft.Maui.Graphics.Color value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        Microsoft.Maui.Graphics.Color fromValue = self.Color;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Microsoft.Maui.Graphics.Color actValue) => { self.Color = actValue; };
        return Transformations.AnimateAsync<Microsoft.Maui.Graphics.Color>(self, "AnimateColorTo", transform, callback, length, easing);
    }

    public static T IsChecked<T>(this T self,
        bool isChecked)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        self.SetValue(Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, isChecked);
        return self;
    }

    public static T IsChecked<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        var isChecked = configure();
        self.SetValue(Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, isChecked);
        return self;
    }

    public static T IsChecked<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.CheckBox.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsChecked<T>(this SettersContext<T> self,
        bool isChecked)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.CheckBox.IsCheckedProperty, Value = isChecked });
        return self;
    }

    public static SettersContext<T> IsChecked<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.CheckBox.IsCheckedProperty);
        configure(context).Build();
        return self;
    }

    public static T OnCheckedChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.CheckedChangedEventArgs> handler)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        self.CheckedChanged += handler;
        return self;
    }

    public static T OnCheckedChanged<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.CheckBox
    {
        self.CheckedChanged += (o, arg) => action(self);
        return self;
    }

}
