using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class DataGridColumnExtension
{
    public static T TitleFmg<T>(this T self,
        string title)
        where T : DataGridColumn
    {
        self.SetValue(DataGridColumn.TitleProperty, title);
        return self;
    }

    public static T TitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : DataGridColumn
    {
        var context = new PropertyContext<string>(self, DataGridColumn.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self,
        string title)
        where T : DataGridColumn
    {
        self.XamlSetters.Add(new Setter { Property = DataGridColumn.TitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> TitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : DataGridColumn
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, DataGridColumn.TitleProperty);
        configure(context).Build();
        return self;
    }

    public static T IsVisibleFmg<T>(this T self,
        bool isVisible)
        where T : DataGridColumn
    {
        self.SetValue(DataGridColumn.IsVisibleProperty, isVisible);
        return self;
    }

    public static T IsVisibleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : DataGridColumn
    {
        var context = new PropertyContext<bool>(self, DataGridColumn.IsVisibleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self,
        bool isVisible)
        where T : DataGridColumn
    {
        self.XamlSetters.Add(new Setter { Property = DataGridColumn.IsVisibleProperty, Value = isVisible });
        return self;
    }

    public static SettersContext<T> IsVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : DataGridColumn
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, DataGridColumn.IsVisibleProperty);
        configure(context).Build();
        return self;
    }
}
