namespace FmgLib.MauiMarkup;

public static partial class HybridWebViewExtension
{
    public static T DefaultFile<T>(this T self,
        string? defaultFile)
        where T : HybridWebView
    {
        self.SetValue(HybridWebView.DefaultFileProperty, defaultFile);
        return self;
    }

    public static T DefaultFile<T>(this T self,
        Func<string?> configure)
        where T : HybridWebView
    {
        var defaultFile = configure();
        self.SetValue(HybridWebView.DefaultFileProperty, defaultFile);
        return self;
    }
    
    public static T DefaultFile<T>(this T self, Func<PropertyContext<string?>, IPropertyBuilder<string?>> configure)
        where T : HybridWebView
    {
        var context = new PropertyContext<string?>(self, HybridWebView.DefaultFileProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> DefaultFile<T>(this SettersContext<T> self,
        string? defaultFile)
        where T : HybridWebView
    {
        self.XamlSetters.Add(new Setter { Property = HybridWebView.DefaultFileProperty, Value = defaultFile });
        return self;
    }
    
    public static SettersContext<T> DefaultFile<T>(this SettersContext<T> self, Func<PropertySettersContext<string?>, IPropertySettersBuilder<string?>> configure)
        where T : HybridWebView
    {
        var context = new PropertySettersContext<string?>(self.XamlSetters, HybridWebView.DefaultFileProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HybridRoot<T>(this T self,
        string? hybridRoot)
        where T : HybridWebView
    {
        self.SetValue(HybridWebView.HybridRootProperty, hybridRoot);
        return self;
    }

    public static T HybridRoot<T>(this T self,
        Func<string?> configure)
        where T : HybridWebView
    {
        var hybridRoot = configure();
        self.SetValue(HybridWebView.HybridRootProperty, hybridRoot);
        return self;
    }
    
    public static T HybridRoot<T>(this T self, Func<PropertyContext<string?>, IPropertyBuilder<string?>> configure)
        where T : HybridWebView
    {
        var context = new PropertyContext<string?>(self, HybridWebView.HybridRootProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HybridRoot<T>(this SettersContext<T> self,
        string? hybridRoot)
        where T : HybridWebView
    {
        self.XamlSetters.Add(new Setter { Property = HybridWebView.HybridRootProperty, Value = hybridRoot });
        return self;
    }
    
    public static SettersContext<T> HybridRoot<T>(this SettersContext<T> self, Func<PropertySettersContext<string?>, IPropertySettersBuilder<string?>> configure)
        where T : HybridWebView
    {
        var context = new PropertySettersContext<string?>(self.XamlSetters, HybridWebView.HybridRootProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnRawMessageReceived<T>(this T self, System.EventHandler<HybridWebViewRawMessageReceivedEventArgs>? handler)
        where T : HybridWebView
    {
        self.RawMessageReceived += handler;
        return self;
    }
    
    public static T OnRawMessageReceived<T>(this T self, System.Action<T> action)
        where T : HybridWebView
    {
        self.RawMessageReceived += (o, arg) => action(self);
        return self;
    }

    public static T OnWebViewInitializing<T>(this T self, EventHandler<WebViewInitializingEventArgs>? handler)
        where T : HybridWebView
    {
        self.WebViewInitializing += handler;
        return self;
    }

    public static T OnWebViewInitializing<T>(this T self, Action<T, WebViewInitializingEventArgs> action)
        where T : HybridWebView
    {
        self.WebViewInitializing += (o, args) => action(self, args);
        return self;
    }

    public static T OnWebViewInitialized<T>(this T self, EventHandler<WebViewInitializedEventArgs>? handler)
        where T : HybridWebView
    {
        self.WebViewInitialized += handler;
        return self;
    }

    public static T OnWebViewInitialized<T>(this T self, Action<T, WebViewInitializedEventArgs> action)
        where T : HybridWebView
    {
        self.WebViewInitialized += (o, args) => action(self, args);
        return self;
    }
}
