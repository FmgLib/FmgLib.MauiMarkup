namespace FmgLib.MauiMarkup;


public static partial class WebViewExtension
{
    public static T CanGoBack<T>(this T self,
        bool canGoBack)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.SetValue(Microsoft.Maui.Controls.WebView.CanGoBackProperty, canGoBack);
        return self;
    }

    public static T CanGoBack<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var canGoBack = configure();
        self.SetValue(Microsoft.Maui.Controls.WebView.CanGoBackProperty, canGoBack);
        return self;
    }
    
    public static T CanGoBack<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.WebView.CanGoBackProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanGoBack<T>(this SettersContext<T> self,
        bool canGoBack)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.WebView.CanGoBackProperty, Value = canGoBack });
        return self;
    }
    
    public static SettersContext<T> CanGoBack<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.WebView.CanGoBackProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CanGoForward<T>(this T self,
        bool canGoForward)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.SetValue(Microsoft.Maui.Controls.WebView.CanGoForwardProperty, canGoForward);
        return self;
    }

    public static T CanGoForward<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var canGoForward = configure();
        self.SetValue(Microsoft.Maui.Controls.WebView.CanGoForwardProperty, canGoForward);
        return self;
    }
    
    public static T CanGoForward<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.WebView.CanGoForwardProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CanGoForward<T>(this SettersContext<T> self,
        bool canGoForward)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.WebView.CanGoForwardProperty, Value = canGoForward });
        return self;
    }
    
    public static SettersContext<T> CanGoForward<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.WebView.CanGoForwardProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Cookies<T>(this T self,
        System.Net.CookieContainer cookies)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.SetValue(Microsoft.Maui.Controls.WebView.CookiesProperty, cookies);
        return self;
    }

    public static T Cookies<T>(this T self,
        Func<System.Net.CookieContainer> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var cookies = configure();
        self.SetValue(Microsoft.Maui.Controls.WebView.CookiesProperty, cookies);
        return self;
    }
    
    public static T Cookies<T>(this T self, Func<PropertyContext<System.Net.CookieContainer>, IPropertyBuilder<System.Net.CookieContainer>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertyContext<System.Net.CookieContainer>(self, Microsoft.Maui.Controls.WebView.CookiesProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Cookies<T>(this SettersContext<T> self,
        System.Net.CookieContainer cookies)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.WebView.CookiesProperty, Value = cookies });
        return self;
    }
    
    public static SettersContext<T> Cookies<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Net.CookieContainer>, IPropertySettersBuilder<System.Net.CookieContainer>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertySettersContext<System.Net.CookieContainer>(self.XamlSetters, Microsoft.Maui.Controls.WebView.CookiesProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Source<T>(this T self,
        Microsoft.Maui.Controls.WebViewSource source)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.SetValue(Microsoft.Maui.Controls.WebView.SourceProperty, source);
        return self;
    }

    public static T Source<T>(this T self,
        Func<Microsoft.Maui.Controls.WebViewSource> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var source = configure();
        self.SetValue(Microsoft.Maui.Controls.WebView.SourceProperty, source);
        return self;
    }
    
    public static T Source<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.WebViewSource>, IPropertyBuilder<Microsoft.Maui.Controls.WebViewSource>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.WebViewSource>(self, Microsoft.Maui.Controls.WebView.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Source<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.WebViewSource source)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.WebView.SourceProperty, Value = source });
        return self;
    }
    
    public static SettersContext<T> Source<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.WebViewSource>, IPropertySettersBuilder<Microsoft.Maui.Controls.WebViewSource>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.WebViewSource>(self.XamlSetters, Microsoft.Maui.Controls.WebView.SourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static T UserAgent<T>(this T self,
        string userAgent)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.SetValue(Microsoft.Maui.Controls.WebView.UserAgentProperty, userAgent);
        return self;
    }

    public static T UserAgent<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var userAgent = configure();
        self.SetValue(Microsoft.Maui.Controls.WebView.UserAgentProperty, userAgent);
        return self;
    }
    
    public static T UserAgent<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.WebView.UserAgentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> UserAgent<T>(this SettersContext<T> self,
        string userAgent)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.WebView.UserAgentProperty, Value = userAgent });
        return self;
    }
    
    public static SettersContext<T> UserAgent<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.WebView
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.WebView.UserAgentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnNavigated<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.WebNavigatedEventArgs> handler)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.Navigated += handler;
        return self;
    }
    
    public static T OnNavigated<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.Navigated += (o, arg) => action(self);
        return self;
    }
        
    public static T OnNavigating<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.WebNavigatingEventArgs> handler)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.Navigating += handler;
        return self;
    }
    
    public static T OnNavigating<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.Navigating += (o, arg) => action(self);
        return self;
    }
        
    public static T OnProcessTerminated<T>(this T self, System.EventHandler<Microsoft.Maui.Controls.WebViewProcessTerminatedEventArgs> handler)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.ProcessTerminated += handler;
        return self;
    }
    
    public static T OnProcessTerminated<T>(this T self, System.Action<T> action)
        where T : Microsoft.Maui.Controls.WebView
    {
        self.ProcessTerminated += (o, arg) => action(self);
        return self;
    }
        
}
