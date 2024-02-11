namespace FmgLib.MauiMarkup;



public static partial class RowDefinitionExtension
{
    public static RowDefinition HeightFmg(this RowDefinition self,
        GridLength height)
    {
        self.SetValue(RowDefinition.HeightProperty, height);
        return self;
    }
    
    public static RowDefinition HeightFmg(this RowDefinition self, Func<PropertyContext<GridLength>, IPropertyBuilder<GridLength>> configure)
    {
        var context = new PropertyContext<GridLength>(self, RowDefinition.HeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<RowDefinition> HeightFmg(this SettersContext<RowDefinition> self,
        GridLength height)
    {
        self.XamlSetters.Add(new Setter { Property = RowDefinition.HeightProperty, Value = height });
        return self;
    }
    
    public static SettersContext<RowDefinition> HeightFmg(this SettersContext<RowDefinition> self, Func<PropertySettersContext<GridLength>, IPropertySettersBuilder<GridLength>> configure)
    {
        var context = new PropertySettersContext<GridLength>(self.XamlSetters, RowDefinition.HeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static RowDefinition OnSizeChangedFmg(this RowDefinition self, EventHandler handler)
    {
        self.SizeChanged += handler;
        return self;
    }
    
    public static RowDefinition OnSizeChangedFmg(this RowDefinition self, Action<RowDefinition> action)
    {
        self.SizeChanged += (o, arg) => action(self);
        return self;
    }
    
}