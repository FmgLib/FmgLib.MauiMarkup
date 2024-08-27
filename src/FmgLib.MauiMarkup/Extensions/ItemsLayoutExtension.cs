namespace FmgLib.MauiMarkup;



public static partial class ItemsLayoutExtension
{
    public static T SnapPointsAlignment<T>(this T self,
        SnapPointsAlignment snapPointsAlignment)
        where T : ItemsLayout
    {
        self.SetValue(ItemsLayout.SnapPointsAlignmentProperty, snapPointsAlignment);
        return self;
    }
    
    public static T SnapPointsAlignment<T>(this T self, Func<PropertyContext<SnapPointsAlignment>, IPropertyBuilder<SnapPointsAlignment>> configure)
        where T : ItemsLayout
    {
        var context = new PropertyContext<SnapPointsAlignment>(self, ItemsLayout.SnapPointsAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SnapPointsAlignment<T>(this SettersContext<T> self,
        SnapPointsAlignment snapPointsAlignment)
        where T : ItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = ItemsLayout.SnapPointsAlignmentProperty, Value = snapPointsAlignment });
        return self;
    }
    
    public static SettersContext<T> SnapPointsAlignment<T>(this SettersContext<T> self, Func<PropertySettersContext<SnapPointsAlignment>, IPropertySettersBuilder<SnapPointsAlignment>> configure)
        where T : ItemsLayout
    {
        var context = new PropertySettersContext<SnapPointsAlignment>(self.XamlSetters, ItemsLayout.SnapPointsAlignmentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T SnapPointsType<T>(this T self,
        SnapPointsType snapPointsType)
        where T : ItemsLayout
    {
        self.SetValue(ItemsLayout.SnapPointsTypeProperty, snapPointsType);
        return self;
    }
    
    public static T SnapPointsType<T>(this T self, Func<PropertyContext<SnapPointsType>, IPropertyBuilder<SnapPointsType>> configure)
        where T : ItemsLayout
    {
        var context = new PropertyContext<SnapPointsType>(self, ItemsLayout.SnapPointsTypeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SnapPointsType<T>(this SettersContext<T> self,
        SnapPointsType snapPointsType)
        where T : ItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = ItemsLayout.SnapPointsTypeProperty, Value = snapPointsType });
        return self;
    }
    
    public static SettersContext<T> SnapPointsType<T>(this SettersContext<T> self, Func<PropertySettersContext<SnapPointsType>, IPropertySettersBuilder<SnapPointsType>> configure)
        where T : ItemsLayout
    {
        var context = new PropertySettersContext<SnapPointsType>(self.XamlSetters, ItemsLayout.SnapPointsTypeProperty);
        configure(context).Build();
        return self;
    }
    
}