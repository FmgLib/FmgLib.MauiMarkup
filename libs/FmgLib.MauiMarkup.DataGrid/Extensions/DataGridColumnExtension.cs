using Maui.DataGrid;

namespace FmgLib.MauiMarkup.DataGrids;

public static partial class DataGridColumnExtension
{
    public static DataGridColumn WidthFmg(this DataGridColumn self,
        GridLength tabHeaderItemColumnWidth)
    {
        self.SetValue(DataGridColumn.WidthProperty, tabHeaderItemColumnWidth);
        return self;
    }

    public static DataGridColumn WidthFmg(this DataGridColumn self, Func<PropertyContext<GridLength>, IPropertyBuilder<GridLength>> configure)
    {
        var context = new PropertyContext<GridLength>(self, DataGridColumn.WidthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> WidthFmg(this SettersContext<DataGridColumn> self,
        GridLength tabHeaderItemColumnWidth)
    {
        self.XamlSetters.Add(new Setter { Property = DataGridColumn.WidthProperty, Value = tabHeaderItemColumnWidth });
        return self;
    }

    public static SettersContext<DataGridColumn> WidthFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<GridLength>, IPropertySettersBuilder<GridLength>> configure)
    {
        var context = new PropertySettersContext<GridLength>(self.XamlSetters, DataGridColumn.WidthProperty);
        configure(context).Build();
        return self;
    }

    public static DataGridColumn TitleFmg(this DataGridColumn self, string title)
    {
        self.SetValue(DataGridColumn.TitleProperty, title);
        return self;
    }

    public static DataGridColumn TitleFmg(this DataGridColumn self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
    {
        var context = new PropertyContext<string>(self, DataGridColumn.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> TitleFmg(this SettersContext<DataGridColumn> self, string title)
    {
        self.XamlSetters.Add(new Setter { Property = DataGridColumn.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<DataGridColumn> TitleFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DataGridColumn.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static DataGridColumn FormattedTitleFmg(this DataGridColumn self, FormattedString title)
    {
        self.SetValue(DataGridColumn.TitleProperty, title);
        return self;
    }

    public static DataGridColumn FormattedTitleFmg(this DataGridColumn self, Func<PropertyContext<FormattedString>, IPropertyBuilder<FormattedString>> configure)
    {
        var context = new PropertyContext<FormattedString>(self, DataGridColumn.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> FormattedTitleFmg(this SettersContext<DataGridColumn> self, FormattedString title)
    {
        self.XamlSetters.Add(new Setter { Property = DataGridColumn.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<DataGridColumn> FormattedTitleFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<FormattedString>, IPropertySettersBuilder<FormattedString>> configure)
    {
        var context = new PropertySettersContext<FormattedString>(self.XamlSetters, DataGridColumn.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static DataGridColumn PropertyNameFmg(this DataGridColumn self, string name)
    {
        self.SetValue(DataGridColumn.PropertyNameProperty, name);
        return self;
    }

    public static DataGridColumn PropertyNameFmg(this DataGridColumn self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, DataGridColumn.PropertyNameProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> PropertyNameFmg(this SettersContext<DataGridColumn> self, string name)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.PropertyNameProperty,
            Value = name
        });
        return self;
    }

    public static SettersContext<DataGridColumn> PropertyNameFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, DataGridColumn.PropertyNameProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn IsVisibleFmg(this DataGridColumn self, bool isVisible)
    {
        self.SetValue(DataGridColumn.IsVisibleProperty, isVisible);
        return self;
    }

    public static DataGridColumn IsVisibleFmg(this DataGridColumn self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, DataGridColumn.IsVisibleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> IsVisibleFmg(this SettersContext<DataGridColumn> self, bool isVisible)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.IsVisibleProperty,
            Value = isVisible
        });
        return self;
    }

    public static SettersContext<DataGridColumn> IsVisibleFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, DataGridColumn.IsVisibleProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn StringFormatFmg(this DataGridColumn self, string stringFormat)
    {
        self.SetValue(DataGridColumn.StringFormatProperty, stringFormat);
        return self;
    }

    public static DataGridColumn StringFormatFmg(this DataGridColumn self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
    {
        PropertyContext<string> arg = new PropertyContext<string>(self, DataGridColumn.StringFormatProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> StringFormatFmg(this SettersContext<DataGridColumn> self, string stringFormat)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.StringFormatProperty,
            Value = stringFormat
        });
        return self;
    }

    public static SettersContext<DataGridColumn> StringFormatFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
    {
        PropertySettersContext<string> arg = new PropertySettersContext<string>(self.XamlSetters, DataGridColumn.StringFormatProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn CellTemplateFmg(this DataGridColumn self, DataTemplate template)
    {
        self.SetValue(DataGridColumn.CellTemplateProperty, template);
        return self;
    }

    public static DataGridColumn CellTemplateFmg(this DataGridColumn self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
    {
        PropertyContext<DataTemplate> arg = new PropertyContext<DataTemplate>(self, DataGridColumn.CellTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> CellTemplateFmg(this SettersContext<DataGridColumn> self, DataTemplate template)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.CellTemplateProperty,
            Value = template
        });
        return self;
    }

    public static SettersContext<DataGridColumn> CellTemplateFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
    {
        PropertySettersContext<DataTemplate> arg = new PropertySettersContext<DataTemplate>(self.XamlSetters, DataGridColumn.CellTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn EditCellTemplateFmg(this DataGridColumn self, DataTemplate template)
    {
        self.SetValue(DataGridColumn.EditCellTemplateProperty, template);
        return self;
    }

    public static DataGridColumn EditCellTemplateFmg(this DataGridColumn self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
    {
        PropertyContext<DataTemplate> arg = new PropertyContext<DataTemplate>(self, DataGridColumn.EditCellTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> EditCellTemplateFmg(this SettersContext<DataGridColumn> self, DataTemplate template)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.EditCellTemplateProperty,
            Value = template
        });
        return self;
    }

    public static SettersContext<DataGridColumn> EditCellTemplateFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
    {
        PropertySettersContext<DataTemplate> arg = new PropertySettersContext<DataTemplate>(self.XamlSetters, DataGridColumn.EditCellTemplateProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn LineBreakModeFmg(this DataGridColumn self, LineBreakMode mode)
    {
        self.SetValue(DataGridColumn.LineBreakModeProperty, mode);
        return self;
    }

    public static DataGridColumn LineBreakModeFmg(this DataGridColumn self, Func<PropertyContext<LineBreakMode>, IPropertyBuilder<LineBreakMode>> configure)
    {
        PropertyContext<LineBreakMode> arg = new PropertyContext<LineBreakMode>(self, DataGridColumn.LineBreakModeProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> LineBreakModeFmg(this SettersContext<DataGridColumn> self, LineBreakMode mode)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.LineBreakModeProperty,
            Value = mode
        });
        return self;
    }

    public static SettersContext<DataGridColumn> LineBreakModeFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<LineBreakMode>, IPropertySettersBuilder<LineBreakMode>> configure)
    {
        PropertySettersContext<LineBreakMode> arg = new PropertySettersContext<LineBreakMode>(self.XamlSetters, DataGridColumn.LineBreakModeProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn HorizontalContentAlignmentFmg(this DataGridColumn self, LayoutOptions options)
    {
        self.SetValue(DataGridColumn.HorizontalContentAlignmentProperty, options);
        return self;
    }

    public static DataGridColumn HorizontalContentAlignmentFmg(this DataGridColumn self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure)
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, DataGridColumn.HorizontalContentAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> HorizontalContentAlignmentFmg(this SettersContext<DataGridColumn> self, LayoutOptions options)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.HorizontalContentAlignmentProperty,
            Value = options
        });
        return self;
    }

    public static SettersContext<DataGridColumn> HorizontalContentAlignmentFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure)
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, DataGridColumn.HorizontalContentAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn VerticalContentAlignmentFmg(this DataGridColumn self, LayoutOptions options)
    {
        self.SetValue(DataGridColumn.VerticalContentAlignmentProperty, options);
        return self;
    }

    public static DataGridColumn VerticalContentAlignmentFmg(this DataGridColumn self, Func<PropertyContext<LayoutOptions>, IPropertyBuilder<LayoutOptions>> configure)
    {
        PropertyContext<LayoutOptions> arg = new PropertyContext<LayoutOptions>(self, DataGridColumn.VerticalContentAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> VerticalContentAlignmentFmg(this SettersContext<DataGridColumn> self, LayoutOptions options)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.VerticalContentAlignmentProperty,
            Value = options
        });
        return self;
    }

    public static SettersContext<DataGridColumn> VerticalContentAlignmentFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<LayoutOptions>, IPropertySettersBuilder<LayoutOptions>> configure)
    {
        PropertySettersContext<LayoutOptions> arg = new PropertySettersContext<LayoutOptions>(self.XamlSetters, DataGridColumn.VerticalContentAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn SortingEnabledFmg(this DataGridColumn self, bool sortingEnabled)
    {
        self.SetValue(DataGridColumn.SortingEnabledProperty, sortingEnabled);
        return self;
    }

    public static DataGridColumn SortingEnabledFmg(this DataGridColumn self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
    {
        PropertyContext<bool> arg = new PropertyContext<bool>(self, DataGridColumn.SortingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> SortingEnabledFmg(this SettersContext<DataGridColumn> self, bool sortingEnabled)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.SortingEnabledProperty,
            Value = sortingEnabled
        });
        return self;
    }

    public static SettersContext<DataGridColumn> SortingEnabledFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
    {
        PropertySettersContext<bool> arg = new PropertySettersContext<bool>(self.XamlSetters, DataGridColumn.SortingEnabledProperty);
        configure(arg).Build();
        return self;
    }

    public static DataGridColumn HeaderLabelStyleFmg(this DataGridColumn self, Style style)
    {
        self.SetValue(DataGridColumn.HeaderLabelStyleProperty, style);
        return self;
    }

    public static DataGridColumn HeaderLabelStyleFmg(this DataGridColumn self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure)
    {
        PropertyContext<Style> arg = new PropertyContext<Style>(self, DataGridColumn.HeaderLabelStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<DataGridColumn> HeaderLabelStyleFmg(this SettersContext<DataGridColumn> self, Style style)
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGridColumn.HeaderLabelStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<DataGridColumn> HeaderLabelStyleFmg(this SettersContext<DataGridColumn> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure)
    {
        PropertySettersContext<Style> arg = new PropertySettersContext<Style>(self.XamlSetters, DataGridColumn.HeaderLabelStyleProperty);
        configure(arg).Build();
        return self;
    }
}
