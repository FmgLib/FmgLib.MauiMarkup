namespace FmgLib.MauiMarkup;



public static partial class SwitchExtension
{
    public static T OnColorFmg<T>(this T self,
        Color onColor)
        where T : Switch
    {
        self.SetValue(Switch.OnColorProperty, onColor);
        return self;
    }
    
    public static T OnColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Switch
    {
        var context = new PropertyContext<Color>(self, Switch.OnColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> OnColorFmg<T>(this SettersContext<T> self,
        Color onColor)
        where T : Switch
    {
        self.XamlSetters.Add(new Setter { Property = Switch.OnColorProperty, Value = onColor });
        return self;
    }
    
    public static SettersContext<T> OnColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Switch
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Switch.OnColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateOnColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Switch
    {
        Color fromValue = self.OnColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.OnColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateOnColorTo", transform, callback, length, easing);
    }
    
    public static T ThumbColorFmg<T>(this T self,
        Color thumbColor)
        where T : Switch
    {
        self.SetValue(Switch.ThumbColorProperty, thumbColor);
        return self;
    }
    
    public static T ThumbColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : Switch
    {
        var context = new PropertyContext<Color>(self, Switch.ThumbColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ThumbColorFmg<T>(this SettersContext<T> self,
        Color thumbColor)
        where T : Switch
    {
        self.XamlSetters.Add(new Setter { Property = Switch.ThumbColorProperty, Value = thumbColor });
        return self;
    }
    
    public static SettersContext<T> ThumbColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : Switch
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, Switch.ThumbColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateThumbColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : Switch
    {
        Color fromValue = self.ThumbColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.ThumbColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateThumbColorTo", transform, callback, length, easing);
    }
    
    public static T IsToggledFmg<T>(this T self,
        bool isToggled)
        where T : Switch
    {
        self.SetValue(Switch.IsToggledProperty, isToggled);
        return self;
    }
    
    public static T IsToggledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Switch
    {
        var context = new PropertyContext<bool>(self, Switch.IsToggledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsToggledFmg<T>(this SettersContext<T> self,
        bool isToggled)
        where T : Switch
    {
        self.XamlSetters.Add(new Setter { Property = Switch.IsToggledProperty, Value = isToggled });
        return self;
    }
    
    public static SettersContext<T> IsToggledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Switch
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Switch.IsToggledProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnToggledFmg<T>(this T self, EventHandler<ToggledEventArgs> handler)
        where T : Switch
    {
        self.Toggled += handler;
        return self;
    }
    
    public static T OnToggledFmg<T>(this T self, Action<T> action)
        where T : Switch
    {
        self.Toggled += (o, arg) => action(self);
        return self;
    }
    
}
