using Maui.DataGrid;
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
}