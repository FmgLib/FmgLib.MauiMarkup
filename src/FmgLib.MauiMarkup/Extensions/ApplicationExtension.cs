namespace FmgLib.MauiMarkup;

public static partial class ApplicationExtension
{
    public static T OnModalPopped<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPoppedEventArgs>? handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPopped += handler;
        return self;
    }

    public static T OnModalPopped<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPopped += (o, arg) => action(self);
        return self;
    }

    public static T OnModalPopping<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPoppingEventArgs>? handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPopping += handler;
        return self;
    }

    public static T OnModalPopping<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPopping += (o, arg) => action(self);
        return self;
    }

    public static T OnModalPushed<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPushedEventArgs>? handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPushed += handler;
        return self;
    }

    public static T OnModalPushed<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPushed += (o, arg) => action(self);
        return self;
    }

    public static T OnModalPushing<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.ModalPushingEventArgs>? handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPushing += handler;
        return self;
    }

    public static T OnModalPushing<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.ModalPushing += (o, arg) => action(self);
        return self;
    }

    public static T OnPageAppearing<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.Page>? handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.PageAppearing += handler;
        return self;
    }

    public static T OnPageAppearing<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.PageAppearing += (o, arg) => action(self);
        return self;
    }

    public static T OnPageDisappearing<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.Page>? handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.PageDisappearing += handler;
        return self;
    }

    public static T OnPageDisappearing<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.PageDisappearing += (o, arg) => action(self);
        return self;
    }

    public static T OnRequestedThemeChanged<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.AppThemeChangedEventArgs> handler)
        where T : Microsoft.Maui.Controls.Application
    {
        self.RequestedThemeChanged += handler;
        return self;
    }

    public static T OnRequestedThemeChanged<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.Application
    {
        self.RequestedThemeChanged += (o, arg) => action(self);
        return self;
    }

    public static T MainPage<T>(this T self, Page? mainPage) where T : Application
    {
        self.MainPage = mainPage;
        return self;
    }

    public static T Resources<T>(this T self, ResourceDictionary resources) where T : Application
    {
        self.Resources = resources;
        return self;
    }

    public static T MergedResources<T>(this T self, params ResourceDictionary[] resources) where T : Application
    {
        foreach (var resource in resources)
        {
            self.Resources.MergedDictionaries.Add(resource);
        }
        return self;
    }

    public static T UserAppTheme<T>(this T self, AppTheme userAppTheme) where T : Application
    {
        self.UserAppTheme = userAppTheme;
        return self;
    }
}
