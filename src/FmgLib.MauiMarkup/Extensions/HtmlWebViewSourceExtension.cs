namespace FmgLib.MauiMarkup;



public static partial class HtmlWebViewSourceExtension
{
    public static T BaseUrl<T>(this T self,
        string baseUrl)
        where T : HtmlWebViewSource
    {
        self.SetValue(HtmlWebViewSource.BaseUrlProperty, baseUrl);
        return self;
    }
    
    public static T BaseUrl<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : HtmlWebViewSource
    {
        var context = new PropertyContext<string>(self, HtmlWebViewSource.BaseUrlProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> BaseUrl<T>(this SettersContext<T> self,
        string baseUrl)
        where T : HtmlWebViewSource
    {
        self.XamlSetters.Add(new Setter { Property = HtmlWebViewSource.BaseUrlProperty, Value = baseUrl });
        return self;
    }
    
    public static SettersContext<T> BaseUrl<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : HtmlWebViewSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, HtmlWebViewSource.BaseUrlProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Html<T>(this T self,
        string html)
        where T : HtmlWebViewSource
    {
        self.SetValue(HtmlWebViewSource.HtmlProperty, html);
        return self;
    }
    
    public static T Html<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : HtmlWebViewSource
    {
        var context = new PropertyContext<string>(self, HtmlWebViewSource.HtmlProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Html<T>(this SettersContext<T> self,
        string html)
        where T : HtmlWebViewSource
    {
        self.XamlSetters.Add(new Setter { Property = HtmlWebViewSource.HtmlProperty, Value = html });
        return self;
    }
    
    public static SettersContext<T> Html<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : HtmlWebViewSource
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, HtmlWebViewSource.HtmlProperty);
        configure(context).Build();
        return self;
    }
    
}