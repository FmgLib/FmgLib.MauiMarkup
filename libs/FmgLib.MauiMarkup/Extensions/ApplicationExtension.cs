namespace FmgLib.MauiMarkup;

public static partial class ApplicationExtension
{
    public static T MainPageFmg<T>(this T self, Page? mainPage) where T : Application
    {
        self.MainPage = mainPage;
        return self;
    }
    
    public static T ResourcesFmg<T>(this T self, ResourceDictionary resources) where T : Application
    {
        self.Resources = resources;
        return self;
    }
    
    public static T UserAppThemeFmg<T>(this T self, AppTheme userAppTheme) where T : Application
    {
        self.UserAppTheme = userAppTheme;
        return self;
    }
    
    public static T OnRequestedThemeChangedFmg<T>(this T self, EventHandler<AppThemeChangedEventArgs> handler) where T : Application
    {
        self.RequestedThemeChanged += handler;
        return self;
    }
    
    public static T OnRequestedThemeChangedFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.RequestedThemeChanged += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPoppedFmg<T>(this T self, EventHandler<ModalPoppedEventArgs>? handler) where T : Application
    {
        self.ModalPopped += handler;
        return self;
    }
    
    public static T OnModalPoppedFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.ModalPopped += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPoppingFmg<T>(this T self, EventHandler<ModalPoppingEventArgs>? handler) where T : Application
    {
        self.ModalPopping += handler;
        return self;
    }
    
    public static T OnModalPoppingFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.ModalPopping += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPushedFmg<T>(this T self, EventHandler<ModalPushedEventArgs>? handler) where T : Application
    {
        self.ModalPushed += handler;
        return self;
    }
    
    public static T OnModalPushedFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.ModalPushed += (o, arg) => action(self);
        return self;
    }
    
    public static T OnModalPushingFmg<T>(this T self, EventHandler<ModalPushingEventArgs>? handler) where T : Application
    {
        self.ModalPushing += handler;
        return self;
    }
    
    public static T OnModalPushingFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.ModalPushing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPageAppearingFmg<T>(this T self, EventHandler<Page>? handler) where T : Application
    {
        self.PageAppearing += handler;
        return self;
    }
    
    public static T OnPageAppearingFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.PageAppearing += (o, arg) => action(self);
        return self;
    }
    
    public static T OnPageDisappearingFmg<T>(this T self, EventHandler<Page>? handler) where T : Application
    {
        self.PageDisappearing += handler;
        return self;
    }
    
    public static T OnPageDisappearingFmg<T>(this T self, Action<T> action) where T : Application
    {
        self.PageDisappearing += (o, arg) => action(self);
        return self;
    }
    
}
