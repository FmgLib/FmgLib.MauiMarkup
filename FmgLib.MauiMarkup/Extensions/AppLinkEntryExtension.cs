namespace FmgLib.MauiMarkup;

public static partial class AppLinkEntryExtension
{
    public static T AppLinkUri<T>(this T self,
        Uri appLinkUri)
        where T : AppLinkEntry
    {
        self.SetValue(AppLinkEntry.AppLinkUriProperty, appLinkUri);
        return self;
    }
    
    public static T AppLinkUri<T>(this T self, Func<PropertyContext<Uri>, IPropertyBuilder<Uri>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertyContext<Uri>(self, AppLinkEntry.AppLinkUriProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AppLinkUri<T>(this SettersContext<T> self,
        Uri appLinkUri)
        where T : AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = AppLinkEntry.AppLinkUriProperty, Value = appLinkUri });
        return self;
    }
    
    public static SettersContext<T> AppLinkUri<T>(this SettersContext<T> self, Func<PropertySettersContext<Uri>, IPropertySettersBuilder<Uri>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertySettersContext<Uri>(self.XamlSetters, AppLinkEntry.AppLinkUriProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Description<T>(this T self,
        string description)
        where T : AppLinkEntry
    {
        self.SetValue(AppLinkEntry.DescriptionProperty, description);
        return self;
    }
    
    public static T Description<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertyContext<string>(self, AppLinkEntry.DescriptionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Description<T>(this SettersContext<T> self,
        string description)
        where T : AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = AppLinkEntry.DescriptionProperty, Value = description });
        return self;
    }
    
    public static SettersContext<T> Description<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AppLinkEntry.DescriptionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IsLinkActive<T>(this T self,
        bool isLinkActive)
        where T : AppLinkEntry
    {
        self.SetValue(AppLinkEntry.IsLinkActiveProperty, isLinkActive);
        return self;
    }
    
    public static T IsLinkActive<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertyContext<bool>(self, AppLinkEntry.IsLinkActiveProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsLinkActive<T>(this SettersContext<T> self,
        bool isLinkActive)
        where T : AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = AppLinkEntry.IsLinkActiveProperty, Value = isLinkActive });
        return self;
    }
    
    public static SettersContext<T> IsLinkActive<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, AppLinkEntry.IsLinkActiveProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Thumbnail<T>(this T self,
        ImageSource thumbnail)
        where T : AppLinkEntry
    {
        self.SetValue(AppLinkEntry.ThumbnailProperty, thumbnail);
        return self;
    }
    
    public static T Thumbnail<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertyContext<ImageSource>(self, AppLinkEntry.ThumbnailProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Thumbnail<T>(this SettersContext<T> self,
        ImageSource thumbnail)
        where T : AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = AppLinkEntry.ThumbnailProperty, Value = thumbnail });
        return self;
    }
    
    public static SettersContext<T> Thumbnail<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, AppLinkEntry.ThumbnailProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Title<T>(this T self,
        string title)
        where T : AppLinkEntry
    {
        self.SetValue(AppLinkEntry.TitleProperty, title);
        return self;
    }
    
    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertyContext<string>(self, AppLinkEntry.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : AppLinkEntry
    {
        self.XamlSetters.Add(new Setter { Property = AppLinkEntry.TitleProperty, Value = title });
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : AppLinkEntry
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, AppLinkEntry.TitleProperty);
        configure(context).Build();
        return self;
    }
    
}