using System.Collections;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TabViewExtension
{
    public static T ItemsFmg<T>(this T self,
        IList<TabItem> items)
        where T : TabView
    {
        self.SetValue(TabView.ItemsProperty, items);
        return self;
    }

    public static T ItemsFmg<T>(this T self, Func<PropertyContext<IList<TabItem>>, IPropertyBuilder<IList<TabItem>>> configure)
        where T : TabView
    {
        var context = new PropertyContext<IList<TabItem>>(self, TabView.ItemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsFmg<T>(this SettersContext<T> self,
        IList<TabItem> items)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.ItemsProperty, Value = items });
        return self;
    }

    public static SettersContext<T> ItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList<TabItem>>, IPropertySettersBuilder<IList<TabItem>>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<IList<TabItem>>(self.XamlSetters, TabView.ItemsProperty);
        configure(context).Build();
        return self;
    }

    public static T TabHeaderItemTemplateFmg<T>(this T self,
        DataTemplate dataTemplate)
        where T : TabView
    {
        self.SetValue(TabView.TabHeaderItemTemplateProperty, dataTemplate);
        return self;
    }

    public static T TabHeaderItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : TabView
    {
        var context = new PropertyContext<DataTemplate>(self, TabView.TabHeaderItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TabHeaderItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate dataTemplate)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.TabHeaderItemTemplateProperty, Value = dataTemplate });
        return self;
    }

    public static SettersContext<T> TabHeaderItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, TabView.TabHeaderItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T TabHeaderItemColumnWidthFmg<T>(this T self,
        GridLength tabHeaderItemColumnWidth)
        where T : TabView
    {
        self.SetValue(TabView.TabHeaderItemColumnWidthProperty, tabHeaderItemColumnWidth);
        return self;
    }

    public static T TabHeaderItemColumnWidthFmg<T>(this T self, Func<PropertyContext<GridLength>, IPropertyBuilder<GridLength>> configure)
        where T : TabView
    {
        var context = new PropertyContext<GridLength>(self, TabView.TabHeaderItemColumnWidthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TabHeaderItemColumnWidthFmg<T>(this SettersContext<T> self,
        GridLength tabHeaderItemColumnWidth)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.TabHeaderItemColumnWidthProperty, Value = tabHeaderItemColumnWidth });
        return self;
    }

    public static SettersContext<T> TabHeaderItemColumnWidthFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<GridLength>, IPropertySettersBuilder<GridLength>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<GridLength>(self.XamlSetters, TabView.TabHeaderItemColumnWidthProperty);
        configure(context).Build();
        return self;
    }

    public static T CurrentItemFmg<T>(this T self,
        object currentItem)
        where T : TabView
    {
        self.SetValue(TabView.CurrentItemProperty, currentItem);
        return self;
    }

    public static T CurrentItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : TabView
    {
        var context = new PropertyContext<object>(self, TabView.CurrentItemProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> CurrentItemFmg<T>(this SettersContext<T> self,
        object currentItem)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.CurrentItemProperty, Value = currentItem });
        return self;
    }

    public static SettersContext<T> CurrentItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, TabView.CurrentItemProperty);
        configure(context).Build();
        return self;
    }

    public static T TabPlacementFmg<T>(this T self,
        TabViewTabPlacement tabPlacement)
        where T : TabView
    {
        self.SetValue(TabView.TabPlacementProperty, tabPlacement);
        return self;
    }

    public static T TabPlacementFmg<T>(this T self, Func<PropertyContext<TabViewTabPlacement>, IPropertyBuilder<TabViewTabPlacement>> configure)
        where T : TabView
    {
        var context = new PropertyContext<TabViewTabPlacement>(self, TabView.TabPlacementProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TabPlacementFmg<T>(this SettersContext<T> self,
        TabViewTabPlacement tabPlacement)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.TabPlacementProperty, Value = tabPlacement });
        return self;
    }

    public static SettersContext<T> TabPlacementFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TabViewTabPlacement>, IPropertySettersBuilder<TabViewTabPlacement>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<TabViewTabPlacement>(self.XamlSetters, TabView.TabPlacementProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self,
        IList itemsSource)
        where T : TabView
    {
        self.SetValue(TabView.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : TabView
    {
        var context = new PropertyContext<IList>(self, TabView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList itemsSource)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, TabView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self,
        DataTemplate itemTemplate)
        where T : TabView
    {
        self.SetValue(TabView.ItemTemplateProperty, itemTemplate);
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : TabView
    {
        var context = new PropertyContext<DataTemplate>(self, TabView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, TabView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedTabFmg<T>(this T self,
        TabItem tabItem)
        where T : TabView
    {
        self.SetValue(TabView.SelectedTabProperty, tabItem);
        return self;
    }

    public static T SelectedTabFmg<T>(this T self, Func<PropertyContext<TabItem>, IPropertyBuilder<TabItem>> configure)
        where T : TabView
    {
        var context = new PropertyContext<TabItem>(self, TabView.SelectedTabProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedTabFmg<T>(this SettersContext<T> self,
        TabItem tabItem)
        where T : TabView
    {
        self.XamlSetters.Add(new Setter { Property = TabView.SelectedTabProperty, Value = tabItem });
        return self;
    }

    public static SettersContext<T> SelectedTabFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<TabItem>, IPropertySettersBuilder<TabItem>> configure)
        where T : TabView
    {
        var context = new PropertySettersContext<TabItem>(self.XamlSetters, TabView.SelectedTabProperty);
        configure(context).Build();
        return self;
    }
}
