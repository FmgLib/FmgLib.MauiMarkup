namespace FmgLib.MauiMarkup;

public static partial class GridExtension
{
    public static T RowDefinitions<T>(this T self, Action<RowDefinitionBuilder> configure) where T : Grid
    {
        RowDefinitionBuilder rowDefinitionBuilder = new RowDefinitionBuilder();
        configure(rowDefinitionBuilder);
        foreach (RowDefinition ıtem in rowDefinitionBuilder.Items)
        {
            self.RowDefinitions.Add(ıtem);
        }

        return self;
    }

    public static T ColumnDefinitions<T>(this T self, Action<ColumnDefinitionBuilder> configure) where T : Grid
    {
        ColumnDefinitionBuilder columnDefinitionBuilder = new ColumnDefinitionBuilder();
        configure(columnDefinitionBuilder);
        foreach (ColumnDefinition ıtem in columnDefinitionBuilder.Items)
        {
            self.ColumnDefinitions.Add(ıtem);
        }

        return self;
    }

    public static T Spacing<T>(this T self, double columnSpacing, double rowSpacing) where T : Grid
    {
        self.SetValue(Grid.ColumnSpacingProperty, columnSpacing);
        self.SetValue(Grid.RowSpacingProperty, rowSpacing);
        return self;
    }

    public static T Spacing<T>(this T self, double spacing) where T : Grid
    {
        self.SetValue(Grid.ColumnSpacingProperty, spacing);
        self.SetValue(Grid.RowSpacingProperty, spacing);
        return self;
    }

    public static T ColumnDefinitions<T>(this T self, IList<ColumnDefinition> columnDefinitions) where T : Grid
    {
        foreach (ColumnDefinition columnDefinition in columnDefinitions)
        {
            self.ColumnDefinitions.Add(columnDefinition);
        }

        return self;
    }

    public static T ColumnDefinitions<T>(this T self, params ColumnDefinition[] columnDefinitions) where T : Grid
    {
        foreach (ColumnDefinition item in columnDefinitions)
        {
            self.ColumnDefinitions.Add(item);
        }

        return self;
    }

    public static T ColumnDefinitions<T>(this T self, Func<PropertyContext<ColumnDefinitionCollection>, IPropertyBuilder<ColumnDefinitionCollection>> configure) where T : Grid
    {
        PropertyContext<ColumnDefinitionCollection> arg = new PropertyContext<ColumnDefinitionCollection>(self, Grid.ColumnDefinitionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T RowDefinitions<T>(this T self, IList<RowDefinition> rowDefinitions) where T : Grid
    {
        foreach (RowDefinition rowDefinition in rowDefinitions)
        {
            self.RowDefinitions.Add(rowDefinition);
        }

        return self;
    }

    public static T RowDefinitions<T>(this T self, params RowDefinition[] rowDefinitions) where T : Grid
    {
        foreach (RowDefinition item in rowDefinitions)
        {
            self.RowDefinitions.Add(item);
        }

        return self;
    }

    public static T RowDefinitions<T>(this T self, Func<PropertyContext<RowDefinitionCollection>, IPropertyBuilder<RowDefinitionCollection>> configure) where T : Grid
    {
        PropertyContext<RowDefinitionCollection> arg = new PropertyContext<RowDefinitionCollection>(self, Grid.RowDefinitionsProperty);
        configure(arg).Build();
        return self;
    }

    public static T RowSpacing<T>(this T self, double rowSpacing) where T : Grid
    {
        self.SetValue(Grid.RowSpacingProperty, rowSpacing);
        return self;
    }

    public static T RowSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Grid
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Grid.RowSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RowSpacing<T>(this SettersContext<T> self, double rowSpacing) where T : Grid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.RowSpacingProperty,
            Value = rowSpacing
        });
        return self;
    }

    public static SettersContext<T> RowSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Grid
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Grid.RowSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateRowSpacingTo<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Grid
    {
        T self2 = self;
        double fromValue = self2.RowSpacing;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.RowSpacing = actValue;
        }, element: self2, name: "AnimateRowSpacingTo", length: length, easing: easing);
    }

    public static T ColumnSpacing<T>(this T self, double columnSpacing) where T : Grid
    {
        self.SetValue(Grid.ColumnSpacingProperty, columnSpacing);
        return self;
    }

    public static T ColumnSpacing<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : Grid
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, Grid.ColumnSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ColumnSpacing<T>(this SettersContext<T> self, double columnSpacing) where T : Grid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = Grid.ColumnSpacingProperty,
            Value = columnSpacing
        });
        return self;
    }

    public static SettersContext<T> ColumnSpacing<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : Grid
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, Grid.ColumnSpacingProperty);
        configure(arg).Build();
        return self;
    }

    public static Task<bool> AnimateColumnSpacingTo<T>(this T self, double value, uint length = 250u, Easing? easing = null) where T : Grid
    {
        T self2 = self;
        double fromValue = self2.ColumnSpacing;
        return Transformations.AnimateAsync(transform: (double t) => Transformations.DoubleTransform(fromValue, value, t), callback: delegate (double actValue)
        {
            self2.ColumnSpacing = actValue;
        }, element: self2, name: "AnimateColumnSpacingTo", length: length, easing: easing);
    }

}