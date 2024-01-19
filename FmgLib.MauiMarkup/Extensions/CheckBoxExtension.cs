namespace FmgLib.MauiMarkup;

public static partial class CheckBoxExtension
{
    public static T ColorFmg<T>(this T self,
        Color color)
        where T : CheckBox
    {
        self.SetValue(CheckBox.ColorProperty, color);
        return self;
    }
    
    public static T ColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<Color>(self, CheckBox.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self,
        Color color)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.ColorProperty, Value = color });
        return self;
    }
    
    public static SettersContext<T> ColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, CheckBox.ColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : CheckBox
    {
        Color fromValue = self.Color;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.Color = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateColorTo", transform, callback, length, easing);
    }
    
    public static T IsCheckedFmg<T>(this T self,
        bool isChecked)
        where T : CheckBox
    {
        self.SetValue(CheckBox.IsCheckedProperty, isChecked);
        return self;
    }
    
    public static T IsCheckedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : CheckBox
    {
        var context = new PropertyContext<bool>(self, CheckBox.IsCheckedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsCheckedFmg<T>(this SettersContext<T> self,
        bool isChecked)
        where T : CheckBox
    {
        self.XamlSetters.Add(new Setter { Property = CheckBox.IsCheckedProperty, Value = isChecked });
        return self;
    }
    
    public static SettersContext<T> IsCheckedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : CheckBox
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, CheckBox.IsCheckedProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnCheckedChangedFmg<T>(this T self, EventHandler<CheckedChangedEventArgs> handler)
        where T : CheckBox
    {
        self.CheckedChanged += handler;
        return self;
    }
    
    public static T OnCheckedChangedFmg<T>(this T self, Action<T> action)
        where T : CheckBox
    {
        self.CheckedChanged += (o, arg) => action(self);
        return self;
    }
    
}
