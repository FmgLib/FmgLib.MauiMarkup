using UraniumUI.Layouts;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class GridLayoutExtension
{
    public static T RowCountFmg<T>(this T self,
        int count)
        where T : GridLayout
    {
        self.SetValue(GridLayout.RowCountProperty, count);
        return self;
    }

    public static T RowCountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : GridLayout
    {
        var context = new PropertyContext<int>(self, GridLayout.RowCountProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RowCountFmg<T>(this SettersContext<T> self,
        int count)
        where T : GridLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridLayout.RowCountProperty, Value = count });
        return self;
    }

    public static SettersContext<T> RowCountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : GridLayout
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, GridLayout.RowCountProperty);
        configure(context).Build();
        return self;
    }

    public static T ColumnCountFmg<T>(this T self,
        int count)
        where T : GridLayout
    {
        self.SetValue(GridLayout.ColumnCountProperty, count);
        return self;
    }

    public static T ColumnCountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : GridLayout
    {
        var context = new PropertyContext<int>(self, GridLayout.ColumnCountProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ColumnCountFmg<T>(this SettersContext<T> self,
        int count)
        where T : GridLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridLayout.ColumnCountProperty, Value = count });
        return self;
    }

    public static SettersContext<T> ColumnCountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : GridLayout
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, GridLayout.ColumnCountProperty);
        configure(context).Build();
        return self;
    }

    public static T ColumnGridLengthFmg<T>(this T self, GridLength gridLength) where T : GridLayout
    {
        self.SetValue(GridLayout.ColumnGridLengthProperty, gridLength);
        return self;
    }

    public static T ColumnGridLengthFmg<T>(this T self, Func<PropertyContext<GridLength>, IPropertyBuilder<GridLength>> configure) where T : GridLayout
    {
        var context = new PropertyContext<GridLength>(self, GridLayout.ColumnGridLengthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ColumnGridLengthFmg<T>(this SettersContext<T> self, GridLength gridLength) where T : GridLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridLayout.ColumnGridLengthProperty, Value = gridLength });
        return self;
    }

    public static SettersContext<T> ColumnGridLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<GridLength>, IPropertySettersBuilder<GridLength>> configure) 
        where T : GridLayout
    {
        var context = new PropertySettersContext<GridLength>(self.XamlSetters, GridLayout.ColumnGridLengthProperty);
        configure(context).Build();
        return self;
    }

    public static T RowGridLengthFmg<T>(this T self, GridLength gridLength) where T : GridLayout
    {
        self.SetValue(GridLayout.RowGridLengthProperty, gridLength);
        return self;
    }

    public static T RowGridLengthFmg<T>(this T self, Func<PropertyContext<GridLength>, IPropertyBuilder<GridLength>> configure) where T : GridLayout
    {
        var context = new PropertyContext<GridLength>(self, GridLayout.RowGridLengthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RowGridLengthFmg<T>(this SettersContext<T> self, GridLength gridLength) where T : GridLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridLayout.RowGridLengthProperty, Value = gridLength });
        return self;
    }

    public static SettersContext<T> RowGridLengthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<GridLength>, IPropertySettersBuilder<GridLength>> configure) 
        where T : GridLayout
    {
        var context = new PropertySettersContext<GridLength>(self.XamlSetters, GridLayout.RowGridLengthProperty);
        configure(context).Build();
        return self;
    }
}
