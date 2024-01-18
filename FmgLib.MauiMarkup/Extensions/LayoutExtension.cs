namespace FmgLib.MauiMarkup;

public static class LayoutExtension
{
    public static void AddFmg<T>(this T self, IEnumerable<View> items) where T : Layout
    {
        foreach (View i in items)
        {
            self.Children.Add(i);
        }
    }

    public static T ChildrenFmg<T>(this T self, IList<IView> children) where T : Layout
    {
        foreach (IView child in children)
        {
            self.Children.Add(child);
        }

        return self;
    }

    public static T ChildrenFmg<T>(this T self, params IView[] children) where T : Layout
    {
        foreach (IView child in children)
        {
            self.Children.Add(child);
        }

        return self;
    }

    public static T IsClippedToBoundsFmg<T>(this T self, bool isClippedToBounds) where T : Layout
    {
        self.SetValue(Layout.IsClippedToBoundsProperty, isClippedToBounds);

        return self;
    }

    public static T IsClippedToBoundsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Layout
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Layout.IsClippedToBoundsProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> IsClippedToBoundsFmg<T>(this SettersContext<T> self, bool isClippedToBounds) where T : Layout
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Layout.IsClippedToBoundsProperty,
            Value = isClippedToBounds
        });

        return self;
    }

    public static SettersContext<T> IsClippedToBoundsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Layout
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Layout.IsClippedToBoundsProperty);
        configure(arg).Build();

        return self;
    }

    public static T PaddingFmg<T>(this T self, Thickness padding) where T : Layout
    {
        self.SetValue(Layout.PaddingProperty, padding);

        return self;
    }

    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure) where T : Layout
    {
        PropertyContext<Thickness> arg = new PropertyContext<Thickness>(self, Layout.PaddingProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Thickness padding) where T : Layout
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Layout.PaddingProperty,
            Value = padding
        });

        return self;
    }

    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure) where T : Layout
    {
        PropertySettersContext<Thickness> arg = new PropertySettersContext<Thickness>(self.XamlSetters, Layout.PaddingProperty);
        configure(arg).Build();

        return self;
    }

    public static T IgnoreSafeAreaFmg<T>(this T self, bool ignoreSafeArea) where T : Layout
    {
        self.IgnoreSafeArea = ignoreSafeArea;

        return self;
    }

    public static T CascadeInputTransparentFmg<T>(this T self, bool cascadeInputTransparent) where T : Layout
    {
        self.SetValue(Layout.CascadeInputTransparentProperty, cascadeInputTransparent);

        return self;
    }

    public static T CascadeInputTransparentFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure) where T : Layout
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, Layout.CascadeInputTransparentProperty);
        configure(arg).Build();

        return self;
    }

    public static SettersContext<T> CascadeInputTransparentFmg<T>(this SettersContext<T> self, bool cascadeInputTransparent) where T : Layout
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Layout.CascadeInputTransparentProperty,
            Value = cascadeInputTransparent
        });

        return self;
    }

    public static SettersContext<T> CascadeInputTransparentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure) where T : Layout
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, Layout.CascadeInputTransparentProperty);
        configure(arg).Build();

        return self;
    }
}
