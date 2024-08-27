namespace FmgLib.MauiMarkup;


public static partial class FlexLayoutExtension
{
    public static T Direction<T>(this T self,
        Microsoft.Maui.Layouts.FlexDirection direction)
        where T : FlexLayout
    {
        self.SetValue(FlexLayout.DirectionProperty, direction);
        return self;
    }
    
    public static T Direction<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.FlexDirection>, IPropertyBuilder<Microsoft.Maui.Layouts.FlexDirection>> configure)
        where T : FlexLayout
    {
        var context = new PropertyContext<Microsoft.Maui.Layouts.FlexDirection>(self, FlexLayout.DirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Direction<T>(this SettersContext<T> self,
        Microsoft.Maui.Layouts.FlexDirection direction)
        where T : FlexLayout
    {
        self.XamlSetters.Add(new Setter { Property = FlexLayout.DirectionProperty, Value = direction });
        return self;
    }
    
    public static SettersContext<T> Direction<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.FlexDirection>, IPropertySettersBuilder<Microsoft.Maui.Layouts.FlexDirection>> configure)
        where T : FlexLayout
    {
        var context = new PropertySettersContext<Microsoft.Maui.Layouts.FlexDirection>(self.XamlSetters, FlexLayout.DirectionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T JustifyContent<T>(this T self,
        Microsoft.Maui.Layouts.FlexJustify justifyContent)
        where T : FlexLayout
    {
        self.SetValue(FlexLayout.JustifyContentProperty, justifyContent);
        return self;
    }
    
    public static T JustifyContent<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.FlexJustify>, IPropertyBuilder<Microsoft.Maui.Layouts.FlexJustify>> configure)
        where T : FlexLayout
    {
        var context = new PropertyContext<Microsoft.Maui.Layouts.FlexJustify>(self, FlexLayout.JustifyContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> JustifyContent<T>(this SettersContext<T> self,
        Microsoft.Maui.Layouts.FlexJustify justifyContent)
        where T : FlexLayout
    {
        self.XamlSetters.Add(new Setter { Property = FlexLayout.JustifyContentProperty, Value = justifyContent });
        return self;
    }
    
    public static SettersContext<T> JustifyContent<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.FlexJustify>, IPropertySettersBuilder<Microsoft.Maui.Layouts.FlexJustify>> configure)
        where T : FlexLayout
    {
        var context = new PropertySettersContext<Microsoft.Maui.Layouts.FlexJustify>(self.XamlSetters, FlexLayout.JustifyContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T AlignContent<T>(this T self,
        Microsoft.Maui.Layouts.FlexAlignContent alignContent)
        where T : FlexLayout
    {
        self.SetValue(FlexLayout.AlignContentProperty, alignContent);
        return self;
    }
    
    public static T AlignContent<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.FlexAlignContent>, IPropertyBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> configure)
        where T : FlexLayout
    {
        var context = new PropertyContext<Microsoft.Maui.Layouts.FlexAlignContent>(self, FlexLayout.AlignContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AlignContent<T>(this SettersContext<T> self,
        Microsoft.Maui.Layouts.FlexAlignContent alignContent)
        where T : FlexLayout
    {
        self.XamlSetters.Add(new Setter { Property = FlexLayout.AlignContentProperty, Value = alignContent });
        return self;
    }
    
    public static SettersContext<T> AlignContent<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.FlexAlignContent>, IPropertySettersBuilder<Microsoft.Maui.Layouts.FlexAlignContent>> configure)
        where T : FlexLayout
    {
        var context = new PropertySettersContext<Microsoft.Maui.Layouts.FlexAlignContent>(self.XamlSetters, FlexLayout.AlignContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T AlignItems<T>(this T self,
        Microsoft.Maui.Layouts.FlexAlignItems alignItems)
        where T : FlexLayout
    {
        self.SetValue(FlexLayout.AlignItemsProperty, alignItems);
        return self;
    }
    
    public static T AlignItems<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.FlexAlignItems>, IPropertyBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> configure)
        where T : FlexLayout
    {
        var context = new PropertyContext<Microsoft.Maui.Layouts.FlexAlignItems>(self, FlexLayout.AlignItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> AlignItems<T>(this SettersContext<T> self,
        Microsoft.Maui.Layouts.FlexAlignItems alignItems)
        where T : FlexLayout
    {
        self.XamlSetters.Add(new Setter { Property = FlexLayout.AlignItemsProperty, Value = alignItems });
        return self;
    }
    
    public static SettersContext<T> AlignItems<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.FlexAlignItems>, IPropertySettersBuilder<Microsoft.Maui.Layouts.FlexAlignItems>> configure)
        where T : FlexLayout
    {
        var context = new PropertySettersContext<Microsoft.Maui.Layouts.FlexAlignItems>(self.XamlSetters, FlexLayout.AlignItemsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Position<T>(this T self,
        Microsoft.Maui.Layouts.FlexPosition position)
        where T : FlexLayout
    {
        self.SetValue(FlexLayout.PositionProperty, position);
        return self;
    }
    
    public static T Position<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.FlexPosition>, IPropertyBuilder<Microsoft.Maui.Layouts.FlexPosition>> configure)
        where T : FlexLayout
    {
        var context = new PropertyContext<Microsoft.Maui.Layouts.FlexPosition>(self, FlexLayout.PositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Position<T>(this SettersContext<T> self,
        Microsoft.Maui.Layouts.FlexPosition position)
        where T : FlexLayout
    {
        self.XamlSetters.Add(new Setter { Property = FlexLayout.PositionProperty, Value = position });
        return self;
    }
    
    public static SettersContext<T> Position<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.FlexPosition>, IPropertySettersBuilder<Microsoft.Maui.Layouts.FlexPosition>> configure)
        where T : FlexLayout
    {
        var context = new PropertySettersContext<Microsoft.Maui.Layouts.FlexPosition>(self.XamlSetters, FlexLayout.PositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Wrap<T>(this T self,
        Microsoft.Maui.Layouts.FlexWrap wrap)
        where T : FlexLayout
    {
        self.SetValue(FlexLayout.WrapProperty, wrap);
        return self;
    }
    
    public static T Wrap<T>(this T self, Func<PropertyContext<Microsoft.Maui.Layouts.FlexWrap>, IPropertyBuilder<Microsoft.Maui.Layouts.FlexWrap>> configure)
        where T : FlexLayout
    {
        var context = new PropertyContext<Microsoft.Maui.Layouts.FlexWrap>(self, FlexLayout.WrapProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Wrap<T>(this SettersContext<T> self,
        Microsoft.Maui.Layouts.FlexWrap wrap)
        where T : FlexLayout
    {
        self.XamlSetters.Add(new Setter { Property = FlexLayout.WrapProperty, Value = wrap });
        return self;
    }
    
    public static SettersContext<T> Wrap<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Layouts.FlexWrap>, IPropertySettersBuilder<Microsoft.Maui.Layouts.FlexWrap>> configure)
        where T : FlexLayout
    {
        var context = new PropertySettersContext<Microsoft.Maui.Layouts.FlexWrap>(self.XamlSetters, FlexLayout.WrapProperty);
        configure(context).Build();
        return self;
    }
    
}
