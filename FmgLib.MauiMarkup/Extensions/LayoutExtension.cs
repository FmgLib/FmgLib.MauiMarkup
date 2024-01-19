namespace FmgLib.MauiMarkup;



public static partial class LayoutExtension
{
    public static T ChildrenFmg<T>(this T self,
        IList<Microsoft.Maui.IView> children)
        where T : Layout
    {
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }

    public static T ChildrenFmg<T>(this T self,
        params Microsoft.Maui.IView[] children)
        where T : Layout
    {
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }
    
    public static T IsClippedToBoundsFmg<T>(this T self,
        bool isClippedToBounds)
        where T : Layout
    {
        self.SetValue(Layout.IsClippedToBoundsProperty, isClippedToBounds);
        return self;
    }
    
    public static T IsClippedToBoundsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Layout
    {
        var context = new PropertyContext<bool>(self, Layout.IsClippedToBoundsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsClippedToBoundsFmg<T>(this SettersContext<T> self,
        bool isClippedToBounds)
        where T : Layout
    {
        self.XamlSetters.Add(new Setter { Property = Layout.IsClippedToBoundsProperty, Value = isClippedToBounds });
        return self;
    }
    
    public static SettersContext<T> IsClippedToBoundsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Layout
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Layout.IsClippedToBoundsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PaddingFmg<T>(this T self,
        Thickness padding)
        where T : Layout
    {
        self.SetValue(Layout.PaddingProperty, padding);
        return self;
    }
    
    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : Layout
    {
        var context = new PropertyContext<Thickness>(self, Layout.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self,
        Thickness padding)
        where T : Layout
    {
        self.XamlSetters.Add(new Setter { Property = Layout.PaddingProperty, Value = padding });
        return self;
    }
    
    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : Layout
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, Layout.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IgnoreSafeAreaFmg<T>(this T self,
        bool ignoreSafeArea)
        where T : Layout
    {
        self.IgnoreSafeArea = ignoreSafeArea;
        return self;
    }
    
    public static T CascadeInputTransparentFmg<T>(this T self,
        bool cascadeInputTransparent)
        where T : Layout
    {
        self.SetValue(Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
        return self;
    }
    
    public static T CascadeInputTransparentFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Layout
    {
        var context = new PropertyContext<bool>(self, Layout.CascadeInputTransparentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CascadeInputTransparentFmg<T>(this SettersContext<T> self,
        bool cascadeInputTransparent)
        where T : Layout
    {
        self.XamlSetters.Add(new Setter { Property = Layout.CascadeInputTransparentProperty, Value = cascadeInputTransparent });
        return self;
    }
    
    public static SettersContext<T> CascadeInputTransparentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Layout
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Layout.CascadeInputTransparentProperty);
        configure(context).Build();
        return self;
    }
    
}
