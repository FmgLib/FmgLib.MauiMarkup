namespace FmgLib.MauiMarkup;

public static partial class ContentPageExtension
{
    public static T Content<T>(this T self, View content) where T : ContentPage
    {
        self.SetValue(ContentPage.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure) where T : ContentPage
    {
        PropertyContext<View> arg = new PropertyContext<View>(self, ContentPage.ContentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, View content) where T : ContentPage
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ContentPage.ContentProperty,
            Value = content
        });
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure) where T : ContentPage
    {
        PropertySettersContext<View> arg = new PropertySettersContext<View>(self.XamlSetters, ContentPage.ContentProperty);
        configure(arg).Build();
        return self;
    }

}