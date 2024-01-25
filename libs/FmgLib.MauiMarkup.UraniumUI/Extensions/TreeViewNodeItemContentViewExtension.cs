using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TreeViewNodeItemContentViewNodeItemContentViewExtension
{
    public static T ItemTemplateFmg<T>(this T self,
        DataTemplate itemTemplate)
        where T : TreeViewNodeItemContentView
    {
        self.SetValue(TreeViewNodeItemContentView.ItemTemplateProperty, itemTemplate);
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : TreeViewNodeItemContentView
    {
        var context = new PropertyContext<DataTemplate>(self, TreeViewNodeItemContentView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : TreeViewNodeItemContentView
    {
        self.XamlSetters.Add(new Setter { Property = TreeViewNodeItemContentView.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : TreeViewNodeItemContentView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, TreeViewNodeItemContentView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemFmg<T>(this T self,
        object item)
        where T : TreeViewNodeItemContentView
    {
        self.SetValue(TreeViewNodeItemContentView.ItemProperty, item);
        return self;
    }

    public static T ItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : TreeViewNodeItemContentView
    {
        var context = new PropertyContext<object>(self, TreeViewNodeItemContentView.ItemProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemFmg<T>(this SettersContext<T> self,
        object item)
        where T : TreeViewNodeItemContentView
    {
        self.XamlSetters.Add(new Setter { Property = TreeViewNodeItemContentView.ItemProperty, Value = item });
        return self;
    }

    public static SettersContext<T> ItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : TreeViewNodeItemContentView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, TreeViewNodeItemContentView.ItemProperty);
        configure(context).Build();
        return self;
    }
}
