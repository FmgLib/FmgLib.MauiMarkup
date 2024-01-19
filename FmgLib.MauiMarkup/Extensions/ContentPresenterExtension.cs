namespace FmgLib.MauiMarkup;

public static partial class ContentPresenterExtension
{
    public static T Content<T>(this T self,
        View content)
        where T : ContentPresenter
    {
        self.SetValue(ContentPresenter.ContentProperty, content);
        return self;
    }
    
    public static T Content<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : ContentPresenter
    {
        var context = new PropertyContext<View>(self, ContentPresenter.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        View content)
        where T : ContentPresenter
    {
        self.XamlSetters.Add(new Setter { Property = ContentPresenter.ContentProperty, Value = content });
        return self;
    }
    
    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : ContentPresenter
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, ContentPresenter.ContentProperty);
        configure(context).Build();
        return self;
    }
    
}