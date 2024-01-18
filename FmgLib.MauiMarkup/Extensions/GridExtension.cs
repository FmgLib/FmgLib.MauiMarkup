namespace FmgLib.MauiMarkup;

public static partial class GridExtension
{
    public static T ColumnDefinitions<T>(this T self,
        IList<ColumnDefinition> columnDefinitions)
        where T : Grid
    {
        foreach (var item in columnDefinitions)
            self.ColumnDefinitions.Add(item);
        return self;
    }

    public static T ColumnDefinitions<T>(this T self,
        params ColumnDefinition[] columnDefinitions)
        where T : Grid
    {
        foreach (var item in columnDefinitions)
            self.ColumnDefinitions.Add(item);
        return self;
    }
    
    public static T ColumnDefinitions<T>(this T self, Func<PropertyContext<ColumnDefinitionCollection>, IPropertyBuilder<ColumnDefinitionCollection>> configure)
        where T : Grid
    {
        var context = new PropertyContext<ColumnDefinitionCollection>(self, Grid.ColumnDefinitionsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RowDefinitions<T>(this T self,
        IList<RowDefinition> rowDefinitions)
        where T : Grid
    {
        foreach (var item in rowDefinitions)
            self.RowDefinitions.Add(item);
        return self;
    }

    public static T RowDefinitions<T>(this T self,
        params RowDefinition[] rowDefinitions)
        where T : Grid
    {
        foreach (var item in rowDefinitions)
            self.RowDefinitions.Add(item);
        return self;
    }
    
    public static T RowDefinitions<T>(this T self, Func<PropertyContext<RowDefinitionCollection>, IPropertyBuilder<RowDefinitionCollection>> configure)
        where T : Grid
    {
        var context = new PropertyContext<RowDefinitionCollection>(self, Grid.RowDefinitionsProperty);
        configure(context).Build();
        return self;
    }
    
    public static T RowSpacing<T>(this T self,
        double rowSpacing)
        where T : Grid
    {
        self.SetValue(Grid.RowSpacingProperty, rowSpacing);
        return self;
    }
    
    public static T RowSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Grid
    {
        var context = new PropertyContext<double>(self, Grid.RowSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> RowSpacing<T>(this SettersContext<T> self,
        double rowSpacing)
        where T : Grid
    {
        self.XamlSetters.Add(new Setter { Property = Grid.RowSpacingProperty, Value = rowSpacing });
        return self;
    }
    
    public static SettersContext<T> RowSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Grid
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Grid.RowSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateRowSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Grid
    {
        double fromValue = self.RowSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.RowSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateRowSpacingTo", transform, callback, length, easing);
    }
    
    public static T ColumnSpacing<T>(this T self,
        double columnSpacing)
        where T : Grid
    {
        self.SetValue(Grid.ColumnSpacingProperty, columnSpacing);
        return self;
    }
    
    public static T ColumnSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Grid
    {
        var context = new PropertyContext<double>(self, Grid.ColumnSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ColumnSpacing<T>(this SettersContext<T> self,
        double columnSpacing)
        where T : Grid
    {
        self.XamlSetters.Add(new Setter { Property = Grid.ColumnSpacingProperty, Value = columnSpacing });
        return self;
    }
    
    public static SettersContext<T> ColumnSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Grid
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Grid.ColumnSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateColumnSpacingTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Grid
    {
        double fromValue = self.ColumnSpacing;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.ColumnSpacing = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateColumnSpacingTo", transform, callback, length, easing);
    }
    
}