namespace FmgLib.MauiMarkup;



public static partial class UrlWebViewSourceExtension
{
    public static T Url<T>(this T self,
        string url)
        where T : UrlWebViewSource
    {
        self.SetValue(UrlWebViewSource.UrlProperty, url);
        return self;
    }
    
    public static T Url<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : UrlWebViewSource
    {
        var context = new PropertyContext<string>(self, UrlWebViewSource.UrlProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Url<T>(this SettersContext<T> self,
        string url)
        where T : UrlWebViewSource
    {
        self.XamlSetters.Add(new Setter { Property = UrlWebViewSource.UrlProperty, Value = url });
        return self;
    }
    
    public static SettersContext<T> Url<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : UrlWebViewSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, UrlWebViewSource.UrlProperty);
        configure(context).Build();
        return self;
    }
    
}
