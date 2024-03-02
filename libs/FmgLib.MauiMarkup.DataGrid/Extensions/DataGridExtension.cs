using Maui.DataGrid;
using Microsoft.Maui.Controls.Shapes;
using System.Collections;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FmgLib.MauiMarkup.DataGrids;

public static partial class MyClass
{
    public static T ActiveRowColorFmg<T>(this T self, Color color) where T : DataGrid
    {
        self.SetValue(DataGrid.ActiveRowColorProperty, color);
        return self;
    }

    public static T ActiveRowColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : DataGrid
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, DataGrid.ActiveRowColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ActiveRowColorFmg<T>(this SettersContext<T> self, Color color) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.ActiveRowColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> ActiveRowColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : DataGrid
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, DataGrid.ActiveRowColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T HeaderBackgroundFmg<T>(this T self, Color color) where T : DataGrid
    {
        self.SetValue(DataGrid.HeaderBackgroundProperty, color);
        return self;
    }

    public static T HeaderBackgroundFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : DataGrid
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, DataGrid.HeaderBackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HeaderBackgroundFmg<T>(this SettersContext<T> self, Color color) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.HeaderBackgroundProperty,
            Value = color
        });
        return self;
    }

    public static T FooterBackgroundFmg<T>(this T self, Color color) where T : DataGrid
    {
        self.SetValue(DataGrid.FooterBackgroundProperty, color);
        return self;
    }

    public static T FooterBackgroundFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : DataGrid
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, DataGrid.FooterBackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> FooterBackgroundFmg<T>(this SettersContext<T> self, Color color) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.FooterBackgroundProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> FooterBackgroundFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : DataGrid
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, DataGrid.FooterBackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Color color) where T : DataGrid
    {
        self.SetValue(DataGrid.BorderColorProperty, color);
        return self;
    }

    public static T BorderColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure) where T : DataGrid
    {
        PropertyContext<Color> arg = new PropertyContext<Color>(self, DataGrid.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Color color) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.BorderColorProperty,
            Value = color
        });
        return self;
    }

    public static SettersContext<T> BorderColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure) where T : DataGrid
    {
        PropertySettersContext<Color> arg = new PropertySettersContext<Color>(self.XamlSetters, DataGrid.BorderColorProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemSizingStrategyFmg<T>(this T self, ItemSizingStrategy itemSizingStrategy) where T : DataGrid
    {
        self.SetValue(DataGrid.ItemSizingStrategyProperty, itemSizingStrategy);
        return self;
    }

    public static T ItemSizingStrategyFmg<T>(this T self, Func<PropertyContext<ItemSizingStrategy>, IPropertyBuilder<ItemSizingStrategy>> configure) where T : DataGrid
    {
        PropertyContext<ItemSizingStrategy> arg = new PropertyContext<ItemSizingStrategy>(self, DataGrid.ItemSizingStrategyProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemSizingStrategyFmg<T>(this SettersContext<T> self, ItemSizingStrategy itemSizingStrategy) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.ItemSizingStrategyProperty,
            Value = itemSizingStrategy
        });
        return self;
    }

    public static SettersContext<T> ItemSizingStrategyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ItemSizingStrategy>, IPropertySettersBuilder<ItemSizingStrategy>> configure) where T : DataGrid
    {
        PropertySettersContext<ItemSizingStrategy> arg = new PropertySettersContext<ItemSizingStrategy>(self.XamlSetters, DataGrid.ItemSizingStrategyProperty);
        configure(arg).Build();
        return self;
    }

    public static T RowToEditFmg<T>(this T self, object rowToEdit) where T : DataGrid
    {
        self.SetValue(DataGrid.RowToEditProperty, rowToEdit);
        return self;
    }

    public static T RowToEditFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : DataGrid
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, DataGrid.RowToEditProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RowToEditFmg<T>(this SettersContext<T> self, object rowToEdit) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.RowToEditProperty,
            Value = rowToEdit
        });
        return self;
    }

    public static SettersContext<T> RowToEditFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : DataGrid
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, DataGrid.RowToEditProperty);
        configure(arg).Build();
        return self;
    }

    public static T RowsBackgroundColorPaletteFmg<T>(this T self, IColorProvider colorProvider) where T : DataGrid
    {
        self.SetValue(DataGrid.RowsBackgroundColorPaletteProperty, colorProvider);
        return self;
    }

    public static T RowsBackgroundColorPaletteFmg<T>(this T self, Func<PropertyContext<IColorProvider>, IPropertyBuilder<IColorProvider>> configure) where T : DataGrid
    {
        PropertyContext<IColorProvider> arg = new PropertyContext<IColorProvider>(self, DataGrid.RowsBackgroundColorPaletteProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RowsBackgroundColorPaletteFmg<T>(this SettersContext<T> self, IColorProvider colorProvider) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.RowsBackgroundColorPaletteProperty,
            Value = colorProvider
        });
        return self;
    }

    public static SettersContext<T> RowsBackgroundColorPaletteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IColorProvider>, IPropertySettersBuilder<IColorProvider>> configure) where T : DataGrid
    {
        PropertySettersContext<IColorProvider> arg = new PropertySettersContext<IColorProvider>(self.XamlSetters, DataGrid.RowsBackgroundColorPaletteProperty);
        configure(arg).Build();
        return self;
    }

    public static T RowsTextColorPaletteFmg<T>(this T self, IColorProvider colorProvider) where T : DataGrid
    {
        self.SetValue(DataGrid.RowsTextColorPaletteProperty, colorProvider);
        return self;
    }

    public static T RowsTextColorPaletteFmg<T>(this T self, Func<PropertyContext<IColorProvider>, IPropertyBuilder<IColorProvider>> configure) where T : DataGrid
    {
        PropertyContext<IColorProvider> arg = new PropertyContext<IColorProvider>(self, DataGrid.RowsTextColorPaletteProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> RowsTextColorPaletteFmg<T>(this SettersContext<T> self, IColorProvider colorProvider) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.RowsTextColorPaletteProperty,
            Value = colorProvider
        });
        return self;
    }

    public static SettersContext<T> RowsTextColorPaletteFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IColorProvider>, IPropertySettersBuilder<IColorProvider>> configure) where T : DataGrid
    {
        PropertySettersContext<IColorProvider> arg = new PropertySettersContext<IColorProvider>(self.XamlSetters, DataGrid.RowsTextColorPaletteProperty);
        configure(arg).Build();
        return self;
    }

    public static T ColumnsFmg<T>(this T self, ObservableCollection<DataGridColumn> collection) where T : DataGrid
    {
        self.SetValue(DataGrid.ColumnsProperty, collection);
        return self;
    }

    public static T ColumnsFmg<T>(this T self, Func<PropertyContext<ObservableCollection<DataGridColumn>>, IPropertyBuilder<ObservableCollection<DataGridColumn>>> configure) where T : DataGrid
    {
        PropertyContext<ObservableCollection<DataGridColumn>> arg = new PropertyContext<ObservableCollection<DataGridColumn>>(self, DataGrid.ColumnsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ColumnsFmg<T>(this SettersContext<T> self, ObservableCollection<DataGridColumn> collection) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.ColumnsProperty,
            Value = collection
        });
        return self;
    }

    public static SettersContext<T> ColumnsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ObservableCollection<DataGridColumn>>, IPropertySettersBuilder<ObservableCollection<DataGridColumn>>> configure) where T : DataGrid
    {
        PropertySettersContext<ObservableCollection<DataGridColumn>> arg = new PropertySettersContext<ObservableCollection<DataGridColumn>>(self.XamlSetters, DataGrid.ColumnsProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, IEnumerable source) where T : DataGrid
    {
        self.SetValue(DataGrid.ItemsSourceProperty, source);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IEnumerable>, IPropertyBuilder<IEnumerable>> configure) where T : DataGrid
    {
        PropertyContext<IEnumerable> arg = new PropertyContext<IEnumerable>(self, DataGrid.ItemsSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, IEnumerable source) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.ItemsSourceProperty,
            Value = source
        });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable>, IPropertySettersBuilder<IEnumerable>> configure) where T : DataGrid
    {
        PropertySettersContext<IEnumerable> arg = new PropertySettersContext<IEnumerable>(self.XamlSetters, DataGrid.ItemsSourceProperty);
        configure(arg).Build();
        return self;
    }

    public static T PaginationEnabledFmg<T>(this T self,
        bool enabled)
        where T : DataGrid
    {
        self.SetValue(DataGrid.PaginationEnabledProperty, enabled);
        return self;
    }

    public static T PaginationEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.PaginationEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PaginationEnabledFmg<T>(this SettersContext<T> self,
        bool enabled)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.PaginationEnabledProperty, Value = enabled });
        return self;
    }

    public static SettersContext<T> PaginationEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.PaginationEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T PageCountFmg<T>(this T self,
        int count)
        where T : DataGrid
    {
        self.SetValue(DataGrid.PageCountProperty, count);
        return self;
    }

    public static T PageCountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<int>(self, DataGrid.PageCountProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PageCountFmg<T>(this SettersContext<T> self,
        int count)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.PageCountProperty, Value = count });
        return self;
    }

    public static SettersContext<T> PageCountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, DataGrid.PageCountProperty);
        configure(context).Build();
        return self;
    }

    public static T PageSizeFmg<T>(this T self,
        int size)
        where T : DataGrid
    {
        self.SetValue(DataGrid.PageSizeProperty, size);
        return self;
    }

    public static T PageSizeFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<int>(self, DataGrid.PageSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PageSizeFmg<T>(this SettersContext<T> self,
        int size)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.PageSizeProperty, Value = size });
        return self;
    }

    public static SettersContext<T> PageSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, DataGrid.PageSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T PageSizeListFmg<T>(this T self, ObservableCollection<int> sizeList) where T : DataGrid
    {
        self.SetValue(DataGrid.PageSizeListProperty, sizeList);
        return self;
    }

    public static T PageSizeListFmg<T>(this T self, Func<PropertyContext<ObservableCollection<int>>, IPropertyBuilder<ObservableCollection<int>>> configure) where T : DataGrid
    {
        PropertyContext<ObservableCollection<int>> arg = new PropertyContext<ObservableCollection<int>>(self, DataGrid.PageSizeListProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PageSizeListFmg<T>(this SettersContext<T> self, ObservableCollection<int> sizeList) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.PageSizeListProperty,
            Value = sizeList
        });
        return self;
    }

    public static SettersContext<T> PageSizeListFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ObservableCollection<int>>, IPropertySettersBuilder<ObservableCollection<int>>> configure) where T : DataGrid
    {
        PropertySettersContext<ObservableCollection<int>> arg = new PropertySettersContext<ObservableCollection<int>>(self.XamlSetters, DataGrid.PageSizeListProperty);
        configure(arg).Build();
        return self;
    }

    public static T PageSizeVisibleFmg<T>(this T self,
        bool sizeVisible)
        where T : DataGrid
    {
        self.SetValue(DataGrid.PageSizeVisibleProperty, sizeVisible);
        return self;
    }

    public static T PageSizeVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.PageSizeVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PageSizeVisibleFmg<T>(this SettersContext<T> self,
        bool sizeVisible)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.PageSizeVisibleProperty, Value = sizeVisible });
        return self;
    }

    public static SettersContext<T> PageSizeVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.PageSizeVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static T PaginationStepperStyleFmg<T>(this T self, Style style) where T : DataGrid
    {
        self.SetValue(DataGrid.PaginationStepperStyleProperty, style);
        return self;
    }

    public static T PaginationStepperStyleFmg<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure) where T : DataGrid
    {
        PropertyContext<Style> arg = new PropertyContext<Style>(self, DataGrid.PaginationStepperStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PaginationStepperStyleFmg<T>(this SettersContext<T> self, Style style) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.PaginationStepperStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<T> PaginationStepperStyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure) where T : DataGrid
    {
        PropertySettersContext<Style> arg = new PropertySettersContext<Style>(self.XamlSetters, DataGrid.PaginationStepperStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static T RowHeightFmg<T>(this T self,
        int height)
        where T : DataGrid
    {
        self.SetValue(DataGrid.RowHeightProperty, height);
        return self;
    }

    public static T RowHeightFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<int>(self, DataGrid.RowHeightProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RowHeightFmg<T>(this SettersContext<T> self,
        int height)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.RowHeightProperty, Value = height });
        return self;
    }

    public static SettersContext<T> RowHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, DataGrid.RowHeightProperty);
        configure(context).Build();
        return self;
    }

    public static T FooterHeightFmg<T>(this T self,
        int height)
        where T : DataGrid
    {
        self.SetValue(DataGrid.FooterHeightProperty, height);
        return self;
    }

    public static T FooterHeightFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<int>(self, DataGrid.FooterHeightProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FooterHeightFmg<T>(this SettersContext<T> self,
        int height)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.FooterHeightProperty, Value = height });
        return self;
    }

    public static SettersContext<T> FooterHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, DataGrid.FooterHeightProperty);
        configure(context).Build();
        return self;
    }

    public static T HeaderHeightFmg<T>(this T self,
        int height)
        where T : DataGrid
    {
        self.SetValue(DataGrid.HeaderHeightProperty, height);
        return self;
    }

    public static T HeaderHeightFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<int>(self, DataGrid.HeaderHeightProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HeaderHeightFmg<T>(this SettersContext<T> self,
        int height)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.HeaderHeightProperty, Value = height });
        return self;
    }

    public static SettersContext<T> HeaderHeightFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, DataGrid.HeaderHeightProperty);
        configure(context).Build();
        return self;
    }

    public static T IsSortableFmg<T>(this T self,
        bool isSortable)
        where T : DataGrid
    {
        self.SetValue(DataGrid.IsSortableProperty, isSortable);
        return self;
    }

    public static T IsSortableFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.IsSortableProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsSortableFmg<T>(this SettersContext<T> self,
        bool isSortable)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.IsSortableProperty, Value = isSortable });
        return self;
    }

    public static SettersContext<T> IsSortableFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.IsSortableProperty);
        configure(context).Build();
        return self;
    }

    public static T FontFamilyFmg<T>(this T self,
        string fontFamily)
        where T : DataGrid
    {
        self.SetValue(DataGrid.FontFamilyProperty, fontFamily);
        return self;
    }

    public static T FontFamilyFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<string>(self, DataGrid.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self,
        string fontFamily)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.FontFamilyProperty, Value = fontFamily });
        return self;
    }

    public static SettersContext<T> FontFamilyFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DataGrid.FontFamilyProperty);
        configure(context).Build();
        return self;
    }

    public static T FontSizeFmg<T>(this T self,
        double fontSize)
        where T : DataGrid
    {
        self.SetValue(DataGrid.FontSizeProperty, fontSize);
        return self;
    }

    public static T FontSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<double>(self, DataGrid.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self,
        double fontSize)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.FontSizeProperty, Value = fontSize });
        return self;
    }

    public static SettersContext<T> FontSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, DataGrid.FontSizeProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, object item) where T : DataGrid
    {
        self.SetValue(DataGrid.SelectedItemProperty, item);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : DataGrid
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, DataGrid.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, object item) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.SelectedItemProperty,
            Value = item
        });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : DataGrid
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, DataGrid.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectionEnabledFmg<T>(this T self,
        bool selectionEnabled)
        where T : DataGrid
    {
        self.SetValue(DataGrid.SelectionEnabledProperty, selectionEnabled);
        return self;
    }

    public static T SelectionEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.SelectionEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionEnabledFmg<T>(this SettersContext<T> self,
        bool selectionEnabled)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.SelectionEnabledProperty, Value = selectionEnabled });
        return self;
    }

    public static SettersContext<T> SelectionEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.SelectionEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T RefreshingEnabledFmg<T>(this T self,
        bool refreshingEnabled)
        where T : DataGrid
    {
        self.SetValue(DataGrid.RefreshingEnabledProperty, refreshingEnabled);
        return self;
    }

    public static T RefreshingEnabledFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.RefreshingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RefreshingEnabledFmg<T>(this SettersContext<T> self,
        bool refreshingEnabled)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.RefreshingEnabledProperty, Value = refreshingEnabled });
        return self;
    }

    public static SettersContext<T> RefreshingEnabledFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.RefreshingEnabledProperty);
        configure(context).Build();
        return self;
    }

    public static T PullToRefreshCommandFmg<T>(this T self, ICommand command) where T : DataGrid
    {
        self.SetValue(DataGrid.PullToRefreshCommandProperty, command);
        return self;
    }

    public static T PullToRefreshCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : DataGrid
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, DataGrid.PullToRefreshCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PullToRefreshCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.PullToRefreshCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> PullToRefreshCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : DataGrid
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, DataGrid.PullToRefreshCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsRefreshingFmg<T>(this T self,
        bool isRefreshing)
        where T : DataGrid
    {
        self.SetValue(DataGrid.IsRefreshingProperty, isRefreshing);
        return self;
    }

    public static T IsRefreshingFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsRefreshingFmg<T>(this SettersContext<T> self,
        bool isRefreshing)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.IsRefreshingProperty, Value = isRefreshing });
        return self;
    }

    public static SettersContext<T> IsRefreshingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.IsRefreshingProperty);
        configure(context).Build();
        return self;
    }

    public static T BorderThicknessFmg<T>(this T self,
        Thickness borderThickness)
        where T : DataGrid
    {
        self.SetValue(DataGrid.BorderThicknessProperty, borderThickness);
        return self;
    }

    public static T BorderThicknessFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<Thickness>(self, DataGrid.BorderThicknessProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> BorderThicknessFmg<T>(this SettersContext<T> self,
        Thickness borderThickness)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.BorderThicknessProperty, Value = borderThickness });
        return self;
    }

    public static SettersContext<T> BorderThicknessFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, DataGrid.BorderThicknessProperty);
        configure(context).Build();
        return self;
    }

    public static T HeaderBordersVisibleFmg<T>(this T self,
        bool bordersVisible)
        where T : DataGrid
    {
        self.SetValue(DataGrid.HeaderBordersVisibleProperty, bordersVisible);
        return self;
    }

    public static T HeaderBordersVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.HeaderBordersVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> HeaderBordersVisibleFmg<T>(this SettersContext<T> self,
        bool bordersVisible)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.HeaderBordersVisibleProperty, Value = bordersVisible });
        return self;
    }

    public static SettersContext<T> HeaderBordersVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.HeaderBordersVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static T SortedColumnIndexFmg<T>(this T self,
        SortData sortData)
        where T : DataGrid
    {
        self.SetValue(DataGrid.SortedColumnIndexProperty, sortData);
        return self;
    }

    public static T SortedColumnIndexFmg<T>(this T self, Func<PropertyContext<SortData>, IPropertyBuilder<SortData>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<SortData>(self, DataGrid.SortedColumnIndexProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SortedColumnIndexFmg<T>(this SettersContext<T> self,
        SortData sortData)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.SortedColumnIndexProperty, Value = sortData });
        return self;
    }

    public static SettersContext<T> SortedColumnIndexFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SortData>, IPropertySettersBuilder<SortData>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<SortData>(self.XamlSetters, DataGrid.SortedColumnIndexProperty);
        configure(context).Build();
        return self;
    }

    public static T PageNumberFmg<T>(this T self,
        int number)
        where T : DataGrid
    {
        self.SetValue(DataGrid.PageNumberProperty, number);
        return self;
    }

    public static T PageNumberFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<int>(self, DataGrid.PageNumberProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> PageNumberFmg<T>(this SettersContext<T> self,
        int number)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.PageNumberProperty, Value = number });
        return self;
    }

    public static SettersContext<T> PageNumberFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, DataGrid.PageNumberProperty);
        configure(context).Build();
        return self;
    }

    public static T HeaderLabelStyleFmg<T>(this T self, Style style) where T : DataGrid
    {
        self.SetValue(DataGrid.HeaderLabelStyleProperty, style);
        return self;
    }

    public static T HeaderLabelStyleFmg<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure) where T : DataGrid
    {
        PropertyContext<Style> arg = new PropertyContext<Style>(self, DataGrid.HeaderLabelStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HeaderLabelStyleFmg<T>(this SettersContext<T> self, Style style) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.HeaderLabelStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<T> HeaderLabelStyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure) where T : DataGrid
    {
        PropertySettersContext<Style> arg = new PropertySettersContext<Style>(self.XamlSetters, DataGrid.HeaderLabelStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static T SortIconFmg<T>(this T self,
        Polygon polygon)
        where T : DataGrid
    {
        self.SetValue(DataGrid.SortIconProperty, polygon);
        return self;
    }

    public static T SortIconFmg<T>(this T self, Func<PropertyContext<Polygon>, IPropertyBuilder<Polygon>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<Polygon>(self, DataGrid.SortIconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SortIconFmg<T>(this SettersContext<T> self,
        Polygon polygon)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.SortIconProperty, Value = polygon });
        return self;
    }

    public static SettersContext<T> SortIconFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Polygon>, IPropertySettersBuilder<Polygon>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<Polygon>(self.XamlSetters, DataGrid.SortIconProperty);
        configure(context).Build();
        return self;
    }

    public static T SortIconStyleFmg<T>(this T self, Style style) where T : DataGrid
    {
        self.SetValue(DataGrid.SortIconStyleProperty, style);
        return self;
    }

    public static T SortIconStyleFmg<T>(this T self, Func<PropertyContext<Style>, IPropertyBuilder<Style>> configure) where T : DataGrid
    {
        PropertyContext<Style> arg = new PropertyContext<Style>(self, DataGrid.SortIconStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SortIconStyleFmg<T>(this SettersContext<T> self, Style style) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.SortIconStyleProperty,
            Value = style
        });
        return self;
    }

    public static SettersContext<T> SortIconStyleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Style>, IPropertySettersBuilder<Style>> configure) where T : DataGrid
    {
        PropertySettersContext<Style> arg = new PropertySettersContext<Style>(self.XamlSetters, DataGrid.SortIconStyleProperty);
        configure(arg).Build();
        return self;
    }

    public static T NoDataViewFmg<T>(this T self,
        View view)
        where T : DataGrid
    {
        self.SetValue(DataGrid.NoDataViewProperty, view);
        return self;
    }

    public static T NoDataViewFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<View>(self, DataGrid.NoDataViewProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> NoDataViewFmg<T>(this SettersContext<T> self,
        View view)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.NoDataViewProperty, Value = view });
        return self;
    }

    public static SettersContext<T> NoDataViewFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, DataGrid.NoDataViewProperty);
        configure(context).Build();
        return self;
    }
}
