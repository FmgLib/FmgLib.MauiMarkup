namespace FmgLib.MauiMarkup;

public static class ContentViewExtension
{
    public static T ContentFmg<T>(this T self, View content) where T : ContentView
    {
        self.SetValue(ContentView.ContentProperty, content);
        return self;
    }

    public static T ContentFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure) where T : ContentView
    {
        PropertyContext<View> arg = new PropertyContext<View>(self, ContentView.ContentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, View content) where T : ContentView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ContentView.ContentProperty,
            Value = content
        });
        return self;
    }

    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure) where T : ContentView
    {
        PropertySettersContext<View> arg = new PropertySettersContext<View>(self.XamlSetters, ContentView.ContentProperty);
        configure(arg).Build();
        return self;
    }
}
