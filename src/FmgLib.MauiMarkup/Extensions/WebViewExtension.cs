namespace FmgLib.MauiMarkup;


public static partial class WebViewExtension
{
    public static T CanGoBack<T>(this T self,
        bool canGoBack)
        where T : WebView
    {
        self.SetValue(WebView.CanGoBackProperty, canGoBack);
        return self;
    }

    public static T CanGoBack<T>(this T self,
        Func<bool> configure)
        where T : WebView
    {
        var canGoBack = configure();
        self.SetValue(WebView.CanGoBackProperty, canGoBack);
        return self;
    }
    
    public static T CanGoBack<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : WebView
    {
        var context = new PropertyContext<bool>(self, WebView.CanGoBackProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanGoBack<T>(this SettersContext<T> self,
        bool canGoBack)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.CanGoBackProperty, Value = canGoBack });
        return self;
    }
    
    public static SettersContext<T> CanGoBack<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, WebView.CanGoBackProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CanGoForward<T>(this T self,
        bool canGoForward)
        where T : WebView
    {
        self.SetValue(WebView.CanGoForwardProperty, canGoForward);
        return self;
    }

    public static T CanGoForward<T>(this T self,
        Func<bool> configure)
        where T : WebView
    {
        var canGoForward = configure();
        self.SetValue(WebView.CanGoForwardProperty, canGoForward);
        return self;
    }
    
    public static T CanGoForward<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : WebView
    {
        var context = new PropertyContext<bool>(self, WebView.CanGoForwardProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanGoForward<T>(this SettersContext<T> self,
        bool canGoForward)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.CanGoForwardProperty, Value = canGoForward });
        return self;
    }
    
    public static SettersContext<T> CanGoForward<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, WebView.CanGoForwardProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Cookies<T>(this T self,
        System.Net.CookieContainer cookies)
        where T : WebView
    {
        self.SetValue(WebView.CookiesProperty, cookies);
        return self;
    }

    public static T Cookies<T>(this T self,
        Func<System.Net.CookieContainer> configure)
        where T : WebView
    {
        var cookies = configure();
        self.SetValue(WebView.CookiesProperty, cookies);
        return self;
    }
    
    public static T Cookies<T>(this T self, Func<PropertyContext<System.Net.CookieContainer>, IPropertyBuilder<System.Net.CookieContainer>> configure)
        where T : WebView
    {
        var context = new PropertyContext<System.Net.CookieContainer>(self, WebView.CookiesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Cookies<T>(this SettersContext<T> self,
        System.Net.CookieContainer cookies)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.CookiesProperty, Value = cookies });
        return self;
    }
    
    public static SettersContext<T> Cookies<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Net.CookieContainer>, IPropertySettersBuilder<System.Net.CookieContainer>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<System.Net.CookieContainer>(self.XamlSetters, WebView.CookiesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Source<T>(this T self,
        WebViewSource source)
        where T : WebView
    {
        self.SetValue(WebView.SourceProperty, source);
        return self;
    }

    public static T Source<T>(this T self,
        Func<WebViewSource> configure)
        where T : WebView
    {
        var source = configure();
        self.SetValue(WebView.SourceProperty, source);
        return self;
    }
    
    public static T Source<T>(this T self, Func<PropertyContext<WebViewSource>, IPropertyBuilder<WebViewSource>> configure)
        where T : WebView
    {
        var context = new PropertyContext<WebViewSource>(self, WebView.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Source<T>(this SettersContext<T> self,
        WebViewSource source)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.SourceProperty, Value = source });
        return self;
    }
    
    public static SettersContext<T> Source<T>(this SettersContext<T> self, Func<PropertySettersContext<WebViewSource>, IPropertySettersBuilder<WebViewSource>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<WebViewSource>(self.XamlSetters, WebView.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T UserAgent<T>(this T self,
        string userAgent)
        where T : WebView
    {
        self.SetValue(WebView.UserAgentProperty, userAgent);
        return self;
    }

    public static T UserAgent<T>(this T self,
        Func<string> configure)
        where T : WebView
    {
        var userAgent = configure();
        self.SetValue(WebView.UserAgentProperty, userAgent);
        return self;
    }
    
    public static T UserAgent<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : WebView
    {
        var context = new PropertyContext<string>(self, WebView.UserAgentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> UserAgent<T>(this SettersContext<T> self,
        string userAgent)
        where T : WebView
    {
        self.XamlSetters.Add(new Setter { Property = WebView.UserAgentProperty, Value = userAgent });
        return self;
    }
    
    public static SettersContext<T> UserAgent<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : WebView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, WebView.UserAgentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnNavigated<T>(this T self, System.EventHandler<WebNavigatedEventArgs> handler)
        where T : WebView
    {
        self.Navigated += handler;
        return self;
    }
    
    public static T OnNavigated<T>(this T self, System.Action<T> action)
        where T : WebView
    {
        self.Navigated += (o, arg) => action(self);
        return self;
    }
        
    public static T OnNavigating<T>(this T self, System.EventHandler<WebNavigatingEventArgs> handler)
        where T : WebView
    {
        self.Navigating += handler;
        return self;
    }
    
    public static T OnNavigating<T>(this T self, System.Action<T> action)
        where T : WebView
    {
        self.Navigating += (o, arg) => action(self);
        return self;
    }
        
}
