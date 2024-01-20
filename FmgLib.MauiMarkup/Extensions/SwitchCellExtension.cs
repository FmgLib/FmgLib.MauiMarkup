namespace FmgLib.MauiMarkup;



public static partial class SwitchCellExtension
{
    public static T OnColorFmg<T>(this T self,
        Color onColor)
        where T : SwitchCell
    {
        self.SetValue(SwitchCell.OnColorProperty, onColor);
        return self;
    }
    
    public static T OnColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : SwitchCell
    {
        var context = new PropertyContext<Color>(self, SwitchCell.OnColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OnColorFmg<T>(this SettersContext<T> self,
        Color onColor)
        where T : SwitchCell
    {
        self.XamlSetters.Add(new Setter { Property = SwitchCell.OnColorProperty, Value = onColor });
        return self;
    }
    
    public static SettersContext<T> OnColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : SwitchCell
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, SwitchCell.OnColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnFmg<T>(this T self,
        bool on)
        where T : SwitchCell
    {
        self.SetValue(SwitchCell.OnProperty, on);
        return self;
    }
    
    public static T OnFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : SwitchCell
    {
        var context = new PropertyContext<bool>(self, SwitchCell.OnProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OnFmg<T>(this SettersContext<T> self,
        bool on)
        where T : SwitchCell
    {
        self.XamlSetters.Add(new Setter { Property = SwitchCell.OnProperty, Value = on });
        return self;
    }
    
    public static SettersContext<T> OnFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : SwitchCell
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, SwitchCell.OnProperty);
        configure(context).Build();
        return self;
    }
    
    public static T TextFmg<T>(this T self,
        string text)
        where T : SwitchCell
    {
        self.SetValue(SwitchCell.TextProperty, text);
        return self;
    }
    
    public static T TextFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : SwitchCell
    {
        var context = new PropertyContext<string>(self, SwitchCell.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self,
        string text)
        where T : SwitchCell
    {
        self.XamlSetters.Add(new Setter { Property = SwitchCell.TextProperty, Value = text });
        return self;
    }
    
    public static SettersContext<T> TextFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : SwitchCell
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, SwitchCell.TextProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnOnChangedFmg<T>(this T self, EventHandler<ToggledEventArgs> handler)
        where T : SwitchCell
    {
        self.OnChanged += handler;
        return self;
    }
    
    public static T OnOnChangedFmg<T>(this T self, Action<T> action)
        where T : SwitchCell
    {
        self.OnChanged += (o, arg) => action(self);
        return self;
    }
    
}
