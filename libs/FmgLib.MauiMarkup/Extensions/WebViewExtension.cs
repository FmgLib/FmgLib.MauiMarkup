namespace FmgLib.MauiMarkup;



public static partial class WebViewExtension
{
    public static T CookiesFmg<T>(this T self,
        System.Net.CookieContainer cookies)
        where T : WebView
    {
        self.SetValue(WebView.CookiesProperty, cookies);
        return self;
    }
    
    public static T CookiesFmg<T>(this T self, Func<PropertyContext<System.Net.CookieContainer>, IPropertyBuilder<System.Net.CookieContainer>> configure)
        where T : WebView
    {
        var context = new PropertyContext<System.Net.CookieContainer>(self, WebView.CookiesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CookiesFmg<T>(this SettersContext<T> self,
        System.Net.CookieContainer cookies)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.CookiesProperty, Value = cookies });
        return self;
    }
    
    public static SettersContext<T> CookiesFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Net.CookieContainer>, IPropertySettersBuilder<System.Net.CookieContainer>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<System.Net.CookieContainer>(self.XamlSetters, WebView.CookiesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SourceFmg<T>(this T self,
        WebViewSource source)
        where T : WebView
    {
        self.SetValue(WebView.SourceProperty, source);
        return self;
    }
    
    public static T SourceFmg<T>(this T self, Func<PropertyContext<WebViewSource>, IPropertyBuilder<WebViewSource>> configure)
        where T : WebView
    {
        var context = new PropertyContext<WebViewSource>(self, WebView.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self,
        WebViewSource source)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.SourceProperty, Value = source });
        return self;
    }
    
    public static SettersContext<T> SourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<WebViewSource>, IPropertySettersBuilder<WebViewSource>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<WebViewSource>(self.XamlSetters, WebView.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnNavigatedFmg<T>(this T self, EventHandler<WebNavigatedEventArgs> handler)
        where T : WebView
    {
        self.Navigated += handler;
        return self;
    }
    
    public static T OnNavigatedFmg<T>(this T self, Action<T> action)
        where T : WebView
    {
        self.Navigated += (o, arg) => action(self);
        return self;
    }
    
    public static T OnNavigatingFmg<T>(this T self, EventHandler<WebNavigatingEventArgs> handler)
        where T : WebView
    {
        self.Navigating += handler;
        return self;
    }
    
    public static T OnNavigatingFmg<T>(this T self, Action<T> action)
        where T : WebView
    {
        self.Navigating += (o, arg) => action(self);
        return self;
    }
    
}

#pragma warning restore CS8601
#nullable restore
