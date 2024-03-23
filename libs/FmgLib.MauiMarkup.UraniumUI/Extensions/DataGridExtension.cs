using System.Collections;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class DataGridExtension
{
    public static T ItemsSourceFmg<T>(this T self,
        IList itemsSource)
        where T : DataGrid
    {
        self.SetValue(DataGrid.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<IList>(self, DataGrid.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList itemsSource)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, DataGrid.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T CellItemTemplateFmg<T>(this T self,
        DataTemplate dataTemplate)
        where T : DataGrid
    {
        self.SetValue(DataGrid.CellItemTemplateProperty, dataTemplate);
        return self;
    }

    public static T CellItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<DataTemplate>(self, DataGrid.CellItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CellItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate dataTemplate)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.CellItemTemplateProperty, Value = dataTemplate });
        return self;
    }

    public static SettersContext<T> CellItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, DataGrid.CellItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T TitleTemplateFmg<T>(this T self,
        DataTemplate titleTemplate)
        where T : DataGrid
    {
        self.SetValue(DataGrid.TitleTemplateProperty, titleTemplate);
        return self;
    }

    public static T TitleTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<DataTemplate>(self, DataGrid.TitleTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate titleTemplate)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.TitleTemplateProperty, Value = titleTemplate });
        return self;
    }

    public static SettersContext<T> TitleTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, DataGrid.TitleTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T LineSeparatorColorFmg<T>(this T self,
        Color lineSeparatorColor)
        where T : DataGrid
    {
        self.SetValue(DataGrid.LineSeparatorColorProperty, lineSeparatorColor);
        return self;
    }

    public static T LineSeparatorColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<Color>(self, DataGrid.LineSeparatorColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> LineSeparatorColorFmg<T>(this SettersContext<T> self,
        Color lineSeparatorColor)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.LineSeparatorColorProperty, Value = lineSeparatorColor });
        return self;
    }

    public static SettersContext<T> LineSeparatorColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, DataGrid.LineSeparatorColorProperty);
        configure(context).Build();
        return self;
    }

    public static T UseAutoColumnsFmg<T>(this T self,
        bool useAutoColumns)
        where T : DataGrid
    {
        self.SetValue(DataGrid.UseAutoColumnsProperty, useAutoColumns);
        return self;
    }

    public static T UseAutoColumnsFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<bool>(self, DataGrid.UseAutoColumnsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> UseAutoColumnsFmg<T>(this SettersContext<T> self,
        bool useAutoColumns)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.UseAutoColumnsProperty, Value = useAutoColumns });
        return self;
    }

    public static SettersContext<T> UseAutoColumnsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGrid.UseAutoColumnsProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self,
       IList selectedItems)
       where T : DataGrid
    {
        self.SetValue(DataGrid.SelectedItemsProperty, selectedItems);
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<IList>(self, DataGrid.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemsFmg<T>(this SettersContext<T> self,
        IList selectedItems)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.SelectedItemsProperty, Value = selectedItems });
        return self;
    }

    public static SettersContext<T> SelectedItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, DataGrid.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectionColorFmg<T>(this T self,
        Color selectionColor)
        where T : DataGrid
    {
        self.SetValue(DataGrid.SelectionColorProperty, selectionColor);
        return self;
    }

    public static T SelectionColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<Color>(self, DataGrid.SelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionColorFmg<T>(this SettersContext<T> self,
        Color selectionColor)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.SelectionColorProperty, Value = selectionColor });
        return self;
    }

    public static SettersContext<T> SelectionColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, DataGrid.SelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static T EmptyViewFmg<T>(this T self,
        View emptyView)
        where T : DataGrid
    {
        self.SetValue(DataGrid.EmptyViewProperty, emptyView);
        return self;
    }

    public static T EmptyViewFmg<T>(this T self, Func<PropertyContext<View>, IPropertyBuilder<View>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<View>(self, DataGrid.EmptyViewProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> EmptyViewFmg<T>(this SettersContext<T> self,
        View emptyView)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.EmptyViewProperty, Value = emptyView });
        return self;
    }

    public static SettersContext<T> EmptyViewFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View>, IPropertySettersBuilder<View>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<View>(self.XamlSetters, DataGrid.EmptyViewProperty);
        configure(context).Build();
        return self;
    }

    public static T EmptyViewTemplateFmg<T>(this T self,
        DataTemplate emptyViewTemplate)
        where T : DataGrid
    {
        self.SetValue(DataGrid.EmptyViewTemplateProperty, emptyViewTemplate);
        return self;
    }

    public static T EmptyViewTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : DataGrid
    {
        var context = new PropertyContext<DataTemplate>(self, DataGrid.EmptyViewTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> EmptyViewTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate emptyViewTemplate)
        where T : DataGrid
    {
        self.XamlSetters.Add(new Setter { Property = DataGrid.EmptyViewTemplateProperty, Value = emptyViewTemplate });
        return self;
    }

    public static SettersContext<T> EmptyViewTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : DataGrid
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, DataGrid.EmptyViewTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ColumnsFmg<T>(this T self, IList<DataGridColumn> collection) where T : DataGrid
    {
        self.SetValue(DataGrid.ColumnsProperty, collection);
        return self;
    }

    public static T ColumnsFmg<T>(this T self, Func<PropertyContext<IList<DataGridColumn>>, IPropertyBuilder<IList<DataGridColumn>>> configure) where T : DataGrid
    {
        PropertyContext<IList<DataGridColumn>> arg = new PropertyContext<IList<DataGridColumn>>(self, DataGrid.ColumnsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ColumnsFmg<T>(this SettersContext<T> self, IList<DataGridColumn> collection) where T : DataGrid
    {
        self.XamlSetters.Add(new Setter
        {
            Property = DataGrid.ColumnsProperty,
            Value = collection
        });
        return self;
    }

    public static SettersContext<T> ColumnsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList<DataGridColumn>>, IPropertySettersBuilder<IList<DataGridColumn>>> configure) where T : DataGrid
    {
        PropertySettersContext<IList<DataGridColumn>> arg = new PropertySettersContext<IList<DataGridColumn>>(self.XamlSetters, DataGrid.ColumnsProperty);
        configure(arg).Build();
        return self;
    }
}
