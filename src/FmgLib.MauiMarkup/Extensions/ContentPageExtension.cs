﻿namespace FmgLib.MauiMarkup;

public static partial class ContentPageExtension
{
    public static T Content_ContentProp<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentPage
    {
        self.Content = content;
        return self;
    }

    public static T Content_ContentProp<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var content = configure();
        self.Content = content;
        return self;
    }

    public static T Content<T>(this T self,
        Microsoft.Maui.Controls.View content)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        self.SetValue(Microsoft.Maui.Controls.ContentPage.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var content = configure();
        self.SetValue(Microsoft.Maui.Controls.ContentPage.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View>, IPropertyBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.ContentPage.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View content)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ContentPage.ContentProperty, Value = content });
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View>, IPropertySettersBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View>(self.XamlSetters, Microsoft.Maui.Controls.ContentPage.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static T HideSoftInputOnTapped<T>(this T self,
        bool hideSoftInputOnTapped)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        self.SetValue(Microsoft.Maui.Controls.ContentPage.HideSoftInputOnTappedProperty, hideSoftInputOnTapped);
        return self;
    }

    public static T HideSoftInputOnTapped<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var hideSoftInputOnTapped = configure();
        self.SetValue(Microsoft.Maui.Controls.ContentPage.HideSoftInputOnTappedProperty, hideSoftInputOnTapped);
        return self;
    }

    public static T HideSoftInputOnTapped<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.ContentPage.HideSoftInputOnTappedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HideSoftInputOnTapped<T>(this SettersContext<T> self,
        bool hideSoftInputOnTapped)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ContentPage.HideSoftInputOnTappedProperty, Value = hideSoftInputOnTapped });
        return self;
    }

    public static SettersContext<T> HideSoftInputOnTapped<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.ContentPage
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.ContentPage.HideSoftInputOnTappedProperty);
        configure(context).Build();
        return self;
    }

}