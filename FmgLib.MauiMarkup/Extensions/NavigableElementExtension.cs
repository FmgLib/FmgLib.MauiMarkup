namespace FmgLib.MauiMarkup;



public static partial class NavigableElementExtension
{
    public static T StyleFmg<T>(this T self,
        Style style)
        where T : NavigableElement
    {
        self.SetValue(NavigableElement.StyleProperty, style);
        return self;
    }
    
    public static T StyleFmg<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure)
        where T : NavigableElement
    {
        var context = new PropertyContext<Style>(self, NavigableElement.StyleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StyleFmg<T>(this SettersContext<T> self,
        Style style)
        where T : NavigableElement
    {
        self.XamlSetters.Add(new Setter { Property = NavigableElement.StyleProperty, Value = style });
        return self;
    }
    
    public static SettersContext<T> StyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure)
        where T : NavigableElement
    {
        var context = new PropertySettersContext<Style>(self.XamlSetters, NavigableElement.StyleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StyleClassFmg<T>(this T self,
        IList<string> styleClass)
        where T : NavigableElement
    {
        foreach (var item in styleClass)
            self.StyleClass.Add(item);
        return self;
    }

    public static T StyleClassFmg<T>(this T self,
        params string[] styleClass)
        where T : NavigableElement
    {
        foreach (var item in styleClass)
            self.StyleClass.Add(item);
        return self;
    }
    
    public static T @classFmg<T>(this T self,
        IList<string> @class)
        where T : NavigableElement
    {
        foreach (var item in @class)
            self.@class.Add(item);
        return self;
    }

    public static T @classFmg<T>(this T self,
        params string[] @class)
        where T : NavigableElement
    {
        foreach (var item in @class)
            self.@class.Add(item);
        return self;
    }
    
}
