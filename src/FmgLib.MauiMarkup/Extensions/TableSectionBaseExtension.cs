namespace FmgLib.MauiMarkup;



public static partial class TableSectionBaseExtension
{
    public static T Title<T>(this T self,
        string title)
        where T : TableSectionBase
    {
        self.SetValue(TableSectionBase.TitleProperty, title);
        return self;
    }
    
    public static T Title<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TableSectionBase
    {
        var context = new PropertyContext<string>(self, TableSectionBase.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self,
        string title)
        where T : TableSectionBase
    {
        self.XamlSetters.Add(new Setter { Property = TableSectionBase.TitleProperty, Value = title });
        return self;
    }
    
    public static SettersContext<T> Title<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TableSectionBase
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TableSectionBase.TitleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextColor<T>(this T self,
        Color textColor)
        where T : TableSectionBase
    {
        self.SetValue(TableSectionBase.TextColorProperty, textColor);
        return self;
    }
    
    public static T TextColor<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TableSectionBase
    {
        var context = new PropertyContext<Color>(self, TableSectionBase.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self,
        Color textColor)
        where T : TableSectionBase
    {
        self.XamlSetters.Add(new Setter { Property = TableSectionBase.TextColorProperty, Value = textColor });
        return self;
    }
    
    public static SettersContext<T> TextColor<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TableSectionBase
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TableSectionBase.TextColorProperty);
        configure(context).Build();
        return self;
    }
    
}
