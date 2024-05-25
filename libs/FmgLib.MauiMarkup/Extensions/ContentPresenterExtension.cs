﻿namespace FmgLib.MauiMarkup;

public static partial class ContentPresenterExtension
{
    public static T Content<T>(this T self,
            Microsoft.Maui.Controls.View content)
            where T : Microsoft.Maui.Controls.ContentPresenter
    {
        self.SetValue(Microsoft.Maui.Controls.ContentPresenter.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View> configure)
        where T : Microsoft.Maui.Controls.ContentPresenter
    {
        var content = configure();
        self.SetValue(Microsoft.Maui.Controls.ContentPresenter.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View>, IPropertyBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.ContentPresenter
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View>(self, Microsoft.Maui.Controls.ContentPresenter.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View content)
        where T : Microsoft.Maui.Controls.ContentPresenter
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.ContentPresenter.ContentProperty, Value = content });
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View>, IPropertySettersBuilder<Microsoft.Maui.Controls.View>> configure)
        where T : Microsoft.Maui.Controls.ContentPresenter
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View>(self.XamlSetters, Microsoft.Maui.Controls.ContentPresenter.ContentProperty);
        configure(context).Build();
        return self;
    }

}