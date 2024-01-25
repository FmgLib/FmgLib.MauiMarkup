using CommunityToolkit.Maui.Layouts;

namespace FmgLib.MauiMarkup.Views;

public static partial class UniformItemsLayoutExtension
{
    public static T MaxRowsFmg<T>(this T self, int maxRows) where T : UniformItemsLayout
    {
        self.SetValue(UniformItemsLayout.MaxRowsProperty, maxRows);
        return self;
    }

    public static T MaxRowsFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : UniformItemsLayout
    {
        var context = new PropertyContext<int>(self, UniformItemsLayout.MaxRowsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaxRowsFmg<T>(this SettersContext<T> self, int maxRows) where T : UniformItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = UniformItemsLayout.MaxRowsProperty, Value = maxRows });
        return self;
    }

    public static SettersContext<T> MaxRowsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : UniformItemsLayout
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, UniformItemsLayout.MaxRowsProperty);
        configure(context).Build();
        return self;
    }

    public static T MaxColumnsFmg<T>(this T self, int maxColumns) where T : UniformItemsLayout
    {
        self.SetValue(UniformItemsLayout.MaxColumnsProperty, maxColumns);
        return self;
    }

    public static T MaxColumnsFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure) where T : UniformItemsLayout
    {
        var context = new PropertyContext<int>(self, UniformItemsLayout.MaxColumnsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MaxColumnsFmg<T>(this SettersContext<T> self, int maxColumns) where T : UniformItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = UniformItemsLayout.MaxColumnsProperty, Value = maxColumns });
        return self;
    }

    public static SettersContext<T> MaxColumnsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure) where T : UniformItemsLayout
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, UniformItemsLayout.MaxColumnsProperty);
        configure(context).Build();
        return self;
    }
}
