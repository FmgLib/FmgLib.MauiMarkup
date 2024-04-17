namespace FmgLib.MauiMarkup;



public static partial class UriImageSourceExtension
{
    public static UriImageSource CacheValidity(this UriImageSource self,
        TimeSpan cacheValidity)
    {
        self.SetValue(UriImageSource.CacheValidityProperty, cacheValidity);
        return self;
    }
    
    public static UriImageSource CacheValidity(this UriImageSource self, Func<PropertyContext<TimeSpan>, IPropertyBuilder<TimeSpan>> configure)
    {
        var context = new PropertyContext<TimeSpan>(self, UriImageSource.CacheValidityProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<UriImageSource> CacheValidity(this SettersContext<UriImageSource> self,
        TimeSpan cacheValidity)
    {
        self.XamlSetters.Add(new Setter { Property = UriImageSource.CacheValidityProperty, Value = cacheValidity });
        return self;
    }
    
    public static SettersContext<UriImageSource> CacheValidity(this SettersContext<UriImageSource> self, Func<PropertySettersContext<TimeSpan>, IPropertySettersBuilder<TimeSpan>> configure)
    {
        var context = new PropertySettersContext<TimeSpan>(self.XamlSetters, UriImageSource.CacheValidityProperty);
        configure(context).Build();
        return self;
    }
    
    public static UriImageSource CachingEnabled(this UriImageSource self,
        bool cachingEnabled)
    {
        self.SetValue(UriImageSource.CachingEnabledProperty, cachingEnabled);
        return self;
    }
    
    public static UriImageSource CachingEnabled(this UriImageSource self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
    {
        var context = new PropertyContext<bool>(self, UriImageSource.CachingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<UriImageSource> CachingEnabled(this SettersContext<UriImageSource> self,
        bool cachingEnabled)
    {
        self.XamlSetters.Add(new Setter { Property = UriImageSource.CachingEnabledProperty, Value = cachingEnabled });
        return self;
    }
    
    public static SettersContext<UriImageSource> CachingEnabled(this SettersContext<UriImageSource> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, UriImageSource.CachingEnabledProperty);
        configure(context).Build();
        return self;
    }
    
    public static UriImageSource Uri(this UriImageSource self,
        Uri uri)
    {
        self.SetValue(UriImageSource.UriProperty, uri);
        return self;
    }
    
    public static UriImageSource Uri(this UriImageSource self, Func<PropertyContext<Uri>, IPropertyBuilder<Uri>> configure)
    {
        var context = new PropertyContext<Uri>(self, UriImageSource.UriProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<UriImageSource> Uri(this SettersContext<UriImageSource> self,
        Uri uri)
    {
        self.XamlSetters.Add(new Setter { Property = UriImageSource.UriProperty, Value = uri });
        return self;
    }
    
    public static SettersContext<UriImageSource> Uri(this SettersContext<UriImageSource> self, Func<PropertySettersContext<Uri>, IPropertySettersBuilder<Uri>> configure)
    {
        var context = new PropertySettersContext<Uri>(self.XamlSetters, UriImageSource.UriProperty);
        configure(context).Build();
        return self;
    }
    
}
