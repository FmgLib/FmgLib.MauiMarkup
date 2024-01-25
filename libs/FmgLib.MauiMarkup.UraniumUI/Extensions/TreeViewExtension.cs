using System.Collections;
using System.Windows.Input;
using UraniumUI.Material.Controls;

namespace FmgLib.MauiMarkup.UraniumUI;

public static partial class TreeViewExtension
{
    public static T SelectionModeFmg<T>(this T self,
        SelectionMode selectionMode)
        where T : TreeView
    {
        self.SetValue(TreeView.SelectionModeProperty, selectionMode);
        return self;
    }

    public static T SelectionModeFmg<T>(this T self, Func<PropertyContext<SelectionMode>, IPropertyBuilder<SelectionMode>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<SelectionMode>(self, TreeView.SelectionModeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionModeFmg<T>(this SettersContext<T> self,
        SelectionMode selectionMode)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.SelectionModeProperty, Value = selectionMode });
        return self;
    }

    public static SettersContext<T> SelectionModeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<SelectionMode>, IPropertySettersBuilder<SelectionMode>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<SelectionMode>(self.XamlSetters, TreeView.SelectionModeProperty);
        configure(context).Build();
        return self;
    }

    public static T UseAnimationFmg<T>(this T self,
        bool useAnimation)
        where T : TreeView
    {
        self.SetValue(TreeView.UseAnimationProperty, useAnimation);
        return self;
    }

    public static T UseAnimationFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<bool>(self, TreeView.UseAnimationProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> UseAnimationFmg<T>(this SettersContext<T> self,
        bool useAnimation)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.UseAnimationProperty, Value = useAnimation });
        return self;
    }

    public static SettersContext<T> UseAnimationFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TreeView.UseAnimationProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self,
        IList itemsSource)
        where T : TreeView
    {
        self.SetValue(TreeView.ItemsSourceProperty, itemsSource);
        return self;
    }

    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<IList>(self, TreeView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        IList itemsSource)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.ItemsSourceProperty, Value = itemsSource });
        return self;
    }

    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, TreeView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemFmg<T>(this T self,
        object selectedItem)
        where T : TreeView
    {
        self.SetValue(TreeView.SelectedItemProperty, selectedItem);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<object>(self, TreeView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self,
        object selectedItem)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.SelectedItemProperty, Value = selectedItem });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<object>(self.XamlSetters, TreeView.SelectedItemProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self,
       IList selectedItems)
       where T : TreeView
    {
        self.SetValue(TreeView.SelectedItemsProperty, selectedItems);
        return self;
    }

    public static T SelectedItemsFmg<T>(this T self, Func<PropertyContext<IList>, IPropertyBuilder<IList>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<IList>(self, TreeView.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemsFmg<T>(this SettersContext<T> self,
        IList selectedItems)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.SelectedItemsProperty, Value = selectedItems });
        return self;
    }

    public static SettersContext<T> SelectedItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IList>, IPropertySettersBuilder<IList>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<IList>(self.XamlSetters, TreeView.SelectedItemsProperty);
        configure(context).Build();
        return self;
    }

    public static T ExpanderTemplateFmg<T>(this T self,
        DataTemplate dataTemplate)
        where T : TreeView
    {
        self.SetValue(TreeView.ExpanderTemplateProperty, dataTemplate);
        return self;
    }

    public static T ExpanderTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<DataTemplate>(self, TreeView.ExpanderTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ExpanderTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate dataTemplate)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.ExpanderTemplateProperty, Value = dataTemplate });
        return self;
    }

    public static SettersContext<T> ExpanderTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, TreeView.ExpanderTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self,
        DataTemplate itemTemplate)
        where T : TreeView
    {
        self.SetValue(TreeView.ItemTemplateProperty, itemTemplate);
        return self;
    }

    public static T ItemTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<DataTemplate>(self, TreeView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate itemTemplate)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.ItemTemplateProperty, Value = itemTemplate });
        return self;
    }

    public static SettersContext<T> ItemTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, TreeView.ItemTemplateProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectionColorFmg<T>(this T self,
        Color selectionColor)
        where T : TreeView
    {
        self.SetValue(TreeView.SelectionColorProperty, selectionColor);
        return self;
    }

    public static T SelectionColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<Color>(self, TreeView.SelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionColorFmg<T>(this SettersContext<T> self,
        Color selectionColor)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.SelectionColorProperty, Value = selectionColor });
        return self;
    }

    public static SettersContext<T> SelectionColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TreeView.SelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static T SelectionBrushFmg<T>(this T self,
        Brush selectionBrush)
        where T : TreeView
    {
        self.SetValue(TreeView.SelectionBrushProperty, selectionBrush);
        return self;
    }

    public static T SelectionBrushFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : TreeView
    {
        var context = new PropertyContext<Brush>(self, TreeView.SelectionBrushProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionBrushFmg<T>(this SettersContext<T> self,
        Brush selectionBrush)
        where T : TreeView
    {
        self.XamlSetters.Add(new Setter { Property = TreeView.SelectionBrushProperty, Value = selectionBrush });
        return self;
    }

    public static SettersContext<T> SelectionBrushFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : TreeView
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, TreeView.SelectionBrushProperty);
        configure(context).Build();
        return self;
    }

    public static T LoadChildrenCommandFmg<T>(this T self, ICommand command) where T : TreeView
    {
        self.SetValue(TreeView.LoadChildrenCommandProperty, command);
        return self;
    }

    public static T LoadChildrenCommandFmg<T>(this T self, Func<PropertyContext<ICommand>, IPropertyBuilder<ICommand>> configure) where T : TreeView
    {
        PropertyContext<ICommand> arg = new PropertyContext<ICommand>(self, TreeView.LoadChildrenCommandProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> LoadChildrenCommandFmg<T>(this SettersContext<T> self, ICommand command) where T : TreeView
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TreeView.LoadChildrenCommandProperty,
            Value = command
        });
        return self;
    }

    public static SettersContext<T> LoadChildrenCommandFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ICommand>, IPropertySettersBuilder<ICommand>> configure) where T : TreeView
    {
        PropertySettersContext<ICommand> arg = new PropertySettersContext<ICommand>(self.XamlSetters, TreeView.LoadChildrenCommandProperty);
        configure(arg).Build();
        return self;
    }
}
