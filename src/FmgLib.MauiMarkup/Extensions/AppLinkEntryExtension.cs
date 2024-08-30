﻿namespace FmgLib.MauiMarkup;

public static partial class AppLinkEntryExtension
{
    public static T AppLinkUri<T>(this T self,
        System.Uri appLinkUri)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.AppLinkUriProperty, appLinkUri);
        return self;
    }

    public static T AppLinkUri<T>(this T self,
        Func<System.Uri> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var appLinkUri = configure();
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.AppLinkUriProperty, appLinkUri);
        return self;
    }

    public static T AppLinkUri<T>(this T self, Func<PropertyContext<System.Uri>, IPropertyBuilder<System.Uri>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertyContext<System.Uri>(self, Microsoft.Maui.Controls.AppLinkEntry.AppLinkUriProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> AppLinkUri<T>(this SettersContext<T> self,
        System.Uri appLinkUri)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AppLinkEntry.AppLinkUriProperty, Value = appLinkUri });
        return self;
    }

    public static SettersContext<T> AppLinkUri<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Uri>, IPropertySettersBuilder<System.Uri>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertySettersContext<System.Uri>(self.XamlSetters, Microsoft.Maui.Controls.AppLinkEntry.AppLinkUriProperty);
        configure(context).Build();
        return self;
    }

    public static T Description<T>(this T self,
        string description)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.DescriptionProperty, description);
        return self;
    }

    public static T Description<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var description = configure();
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.DescriptionProperty, description);
        return self;
    }

    public static T Description<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.AppLinkEntry.DescriptionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Description<T>(this SettersContext<T> self,
        string description)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AppLinkEntry.DescriptionProperty, Value = description });
        return self;
    }

    public static SettersContext<T> Description<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.AppLinkEntry.DescriptionProperty);
        configure(context).Build();
        return self;
    }

    public static T IsLinkActive<T>(this T self,
        bool isLinkActive)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.IsLinkActiveProperty, isLinkActive);
        return self;
    }

    public static T IsLinkActive<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var isLinkActive = configure();
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.IsLinkActiveProperty, isLinkActive);
        return self;
    }

    public static T IsLinkActive<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.AppLinkEntry.IsLinkActiveProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsLinkActive<T>(this SettersContext<T> self,
        bool isLinkActive)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AppLinkEntry.IsLinkActiveProperty, Value = isLinkActive });
        return self;
    }

    public static SettersContext<T> IsLinkActive<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.AppLinkEntry.IsLinkActiveProperty);
        configure(context).Build();
        return self;
    }

    public static T Thumbnail<T>(this T self,
        Microsoft.Maui.Controls.ImageSource thumbnail)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.ThumbnailProperty, thumbnail);
        return self;
    }

    public static T Thumbnail<T>(this T self,
        Func<Microsoft.Maui.Controls.ImageSource> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var thumbnail = configure();
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.ThumbnailProperty, thumbnail);
        return self;
    }

    public static T Thumbnail<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.ImageSource>, IPropertyBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.ImageSource>(self, Microsoft.Maui.Controls.AppLinkEntry.ThumbnailProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Thumbnail<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.ImageSource thumbnail)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AppLinkEntry.ThumbnailProperty, Value = thumbnail });
        return self;
    }

    public static SettersContext<T> Thumbnail<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.ImageSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.ImageSource>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.ImageSource>(self.XamlSetters, Microsoft.Maui.Controls.AppLinkEntry.ThumbnailProperty);
        configure(context).Build();
        return self;
    }

    public static T Title<T>(this T self,
        string title)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var title = configure();
        self.SetValue(Microsoft.Maui.Controls.AppLinkEntry.TitleProperty, title);
        return self;
    }

    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.AppLinkEntry.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AppLinkEntry.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.AppLinkEntry
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.AppLinkEntry.TitleProperty);
        configure(context).Build();
        return self;
    }

}