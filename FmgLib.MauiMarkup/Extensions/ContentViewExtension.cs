namespace FmgLib.MauiMarkup;

public static partial class ContentViewExtension
{
    public static T Content<T>(this T self,
        View content)
        where T : ContentView
    {
        self.SetValue(ContentView.ContentProperty, content);
        return self;
    }
    
    public static T Content<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : ContentView
    {
        var context = new PropertyContext<View>(self, ContentView.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        View content)
        where T : ContentView
    {
        self.XamlSetters.Add(new Setter { Property = ContentView.ContentProperty, Value = content });
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : ContentView
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, ContentView.ContentProperty);
        configure(context).Build();
        return self;
    }
    
}