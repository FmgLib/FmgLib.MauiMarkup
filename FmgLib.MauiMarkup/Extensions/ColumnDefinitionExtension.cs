namespace FmgLib.MauiMarkup;

public static partial class ColumnDefinitionExtension
{
    public static ColumnDefinition WidthFmg(this ColumnDefinition self,
        GridLength width)
    {
        self.SetValue(ColumnDefinition.WidthProperty, width);
        return self;
    }
    
    public static ColumnDefinition WidthFmg(this ColumnDefinition self, Func<PropertyContext<GridLength>, IPropertyBuilder<GridLength>> configure)
    {
        var context = new PropertyContext<GridLength>(self, ColumnDefinition.WidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<ColumnDefinition> WidthFmg(this SettersContext<ColumnDefinition> self,
        GridLength width)
    {
        self.XamlSetters.Add(new Setter { Property = ColumnDefinition.WidthProperty, Value = width });
        return self;
    }
    
    public static SettersContext<ColumnDefinition> WidthFmg(this SettersContext<ColumnDefinition> self, Func<PropertySettersContext<GridLength>, IPropertySettersBuilder<GridLength>> configure)
    {
        var context = new PropertySettersContext<GridLength>(self.XamlSetters, ColumnDefinition.WidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static ColumnDefinition OnSizeChangedFmg(this ColumnDefinition self, EventHandler handler)
    {
        self.SizeChanged += handler;
        return self;
    }
    
    public static ColumnDefinition OnSizeChangedFmg(this ColumnDefinition self, Action<ColumnDefinition> action)
    {
        self.SizeChanged += (o, arg) => action(self);
        return self;
    }
    
}