using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TreeViewNodeHolderViewExtension
{
    public static T IsLeafFmg<T>(this T self,
        bool isLeaf)
        where T : TreeViewNodeHolderView
    {
        self.SetValue(TreeViewNodeHolderView.IsLeafProperty, isLeaf);
        return self;
    }

    public static T IsLeafFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TreeViewNodeHolderView
    {
        var context = new PropertyContext<bool>(self, TreeViewNodeHolderView.IsLeafProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsLeafFmg<T>(this SettersContext<T> self,
        bool isLeaf)
        where T : TreeViewNodeHolderView
    {
        self.XamlSetters.Add(new Setter { Property = TreeViewNodeHolderView.IsLeafProperty, Value = isLeaf });
        return self;
    }

    public static SettersContext<T> IsLeafFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TreeViewNodeHolderView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TreeViewNodeHolderView.IsLeafProperty);
        configure(context).Build();
        return self;
    }

    public static T IsExpandedFmg<T>(this T self,
        bool isExpanded)
        where T : TreeViewNodeHolderView
    {
        self.SetValue(TreeViewNodeHolderView.IsExpandedProperty, isExpanded);
        return self;
    }

    public static T IsExpandedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TreeViewNodeHolderView
    {
        var context = new PropertyContext<bool>(self, TreeViewNodeHolderView.IsExpandedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsExpandedFmg<T>(this SettersContext<T> self,
        bool isExpanded)
        where T : TreeViewNodeHolderView
    {
        self.XamlSetters.Add(new Setter { Property = TreeViewNodeHolderView.IsExpandedProperty, Value = isExpanded });
        return self;
    }

    public static SettersContext<T> IsExpandedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TreeViewNodeHolderView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TreeViewNodeHolderView.IsExpandedProperty);
        configure(context).Build();
        return self;
    }

    public static T IsSelectedFmg<T>(this T self,
        bool isSelected)
        where T : TreeViewNodeHolderView
    {
        self.SetValue(TreeViewNodeHolderView.IsSelectedProperty, isSelected);
        return self;
    }

    public static T IsSelectedFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TreeViewNodeHolderView
    {
        var context = new PropertyContext<bool>(self, TreeViewNodeHolderView.IsSelectedProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsSelectedFmg<T>(this SettersContext<T> self,
        bool isSelected)
        where T : TreeViewNodeHolderView
    {
        self.XamlSetters.Add(new Setter { Property = TreeViewNodeHolderView.IsSelectedProperty, Value = isSelected });
        return self;
    }

    public static SettersContext<T> IsSelectedFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TreeViewNodeHolderView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TreeViewNodeHolderView.IsSelectedProperty);
        configure(context).Build();
        return self;
    }
}
