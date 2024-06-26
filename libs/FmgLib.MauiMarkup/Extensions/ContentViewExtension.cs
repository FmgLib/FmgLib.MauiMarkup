﻿namespace FmgLib.MauiMarkup;

public static partial class ContentViewExtension
{
    public static T Content_ContentProp<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentView
    {
        self.Content = content;
        return self;
    }

    public static T Content_ContentProp<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentView
    {
        var content = configure();
        self.Content = content;
        return self;
    }

    public static T Content<T>(this T self,
        Microsoft.Maui.Controls.View content)
        where T : Microsoft.Maui.Controls.ContentView
    {
        self.SetValue(Microsoft.Maui.Controls.ContentView.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentView
    {
        var content = configure();
        self.SetValue(Microsoft.Maui.Controls.ContentView.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View>, IPropertyBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.ContentView
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.ContentView.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View content)
        where T : Microsoft.Maui.Controls.ContentView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ContentView.ContentProperty, Value = content });
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View>, IPropertySettersBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.ContentView
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View>(self.XamlSetters, Microsoft.Maui.Controls.ContentView.ContentProperty);
        configure(context).Build();
        return self;
    }

}