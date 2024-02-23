using SimpleToolkit.SimpleShell.Controls;
using TabBar = SimpleToolkit.SimpleShell.Controls.TabBar;

namespace FmgLib.MauiMarkup.SimpleToolkit;

public static partial class TabBarExtension
{
    public static T ItemsFmg<T>(this T self, IEnumerable<object> items) where T : TabBar
    {
        self.SetValue(TabBar.ItemsProperty, items);
        return self;
    }

    public static T ItemsFmg<T>(this T self, Func<PropertyContext<IEnumerable<object>>, IPropertyBuilder<IEnumerable<object>>> configure) where T : TabBar
    {
        PropertyContext<IEnumerable<object>> arg = new PropertyContext<IEnumerable<object>>(self, TabBar.ItemsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsFmg<T>(this SettersContext<T> self, IEnumerable<object> items) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.ItemsProperty,
            Value = items
        });
        return self;
    }

    public static SettersContext<T> HiddenItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable<object>>, IPropertySettersBuilder<IEnumerable<object>>> configure) where T : TabBar
    {
        PropertySettersContext<IEnumerable<object>> arg = new PropertySettersContext<IEnumerable<object>>(self.XamlSetters, TabBar.HiddenItemsProperty);
        configure(arg).Build();
        return self;
    }

    public static T HiddenItemsFmg<T>(this T self, IEnumerable<object> items) where T : TabBar
    {
        self.SetValue(TabBar.HiddenItemsProperty, items);
        return self;
    }

    public static T HiddenItemsFmg<T>(this T self, Func<PropertyContext<IEnumerable<object>>, IPropertyBuilder<IEnumerable<object>>> configure) where T : TabBar
    {
        PropertyContext<IEnumerable<object>> arg = new PropertyContext<IEnumerable<object>>(self, TabBar.HiddenItemsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> HiddenItemsFmg<T>(this SettersContext<T> self, IEnumerable<object> items) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.HiddenItemsProperty,
            Value = items
        });
        return self;
    }

    public static SettersContext<T> ItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable<object>>, IPropertySettersBuilder<IEnumerable<object>>> configure) where T : TabBar
    {
        PropertySettersContext<IEnumerable<object>> arg = new PropertySettersContext<IEnumerable<object>>(self.XamlSetters, TabBar.ItemsProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, object item) where T : TabBar
    {
        self.SetValue(TabBar.SelectedItemProperty, item);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : TabBar
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, TabBar.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, object item) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.SelectedItemProperty,
            Value = item
        });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : TabBar
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, TabBar.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextSelectionColorFmg<T>(this T self,
        Color selectionColor)
        where T : TabBar
    {
        self.SetValue(TabBar.TextSelectionColorProperty, selectionColor);
        return self;
    }

    public static T TextSelectionColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<Color>(self, TabBar.TextSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextSelectionColorFmg<T>(this SettersContext<T> self,
        Color selectionColor)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.TextSelectionColorProperty, Value = selectionColor });
        return self;
    }

    public static SettersContext<T> TextSelectionColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabBar.TextSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : TabBar
    {
        self.SetValue(TabBar.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<Color>(self, TabBar.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabBar.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T IconSelectionColorFmg<T>(this T self,
        Color selectionColor)
        where T : TabBar
    {
        self.SetValue(TabBar.IconSelectionColorProperty, selectionColor);
        return self;
    }

    public static T IconSelectionColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<Color>(self, TabBar.IconSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconSelectionColorFmg<T>(this SettersContext<T> self,
        Color selectionColor)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.IconSelectionColorProperty, Value = selectionColor });
        return self;
    }

    public static SettersContext<T> IconSelectionColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabBar.IconSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static T IconColorFmg<T>(this T self,
       Color iconColor)
       where T : TabBar
    {
        self.SetValue(TabBar.IconColorProperty, iconColor);
        return self;
    }

    public static T IconColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<Color>(self, TabBar.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconColorFmg<T>(this SettersContext<T> self,
        Color iconColor)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.IconColorProperty, Value = iconColor });
        return self;
    }

    public static SettersContext<T> IconColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, TabBar.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static T DesignLanguageFmg<T>(this T self, DesignLanguage designLanguage) where T : TabBar
    {
        self.SetValue(TabBar.DesignLanguageProperty, designLanguage);
        return self;
    }

    public static T DesignLanguageFmg<T>(this T self, Func<PropertyContext<DesignLanguage>, IPropertyBuilder<DesignLanguage>> configure) where T : TabBar
    {
        PropertyContext<DesignLanguage> arg = new PropertyContext<DesignLanguage>(self, TabBar.DesignLanguageProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DesignLanguageFmg<T>(this SettersContext<T> self, DesignLanguage designLanguage) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.DesignLanguageProperty,
            Value = designLanguage
        });
        return self;
    }

    public static SettersContext<T> DesignLanguageFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DesignLanguage>, IPropertySettersBuilder<DesignLanguage>> configure) where T : TabBar
    {
        PropertySettersContext<DesignLanguage> arg = new PropertySettersContext<DesignLanguage>(self.XamlSetters, TabBar.DesignLanguageProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemWidthRequestFmg<T>(this T self, double widthRequest) where T : TabBar
    {
        self.SetValue(TabBar.ItemWidthRequestProperty, widthRequest);
        return self;
    }

    public static T ItemWidthRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : TabBar
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, TabBar.ItemWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemWidthRequestFmg<T>(this SettersContext<T> self, double widthRequest) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.ItemWidthRequestProperty,
            Value = widthRequest
        });
        return self;
    }

    public static SettersContext<T> ItemWidthRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : TabBar
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, TabBar.ItemWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemsAlignmentFmg<T>(this T self, LayoutAlignment layoutAlignment) where T : TabBar
    {
        self.SetValue(TabBar.ItemsAlignmentProperty, layoutAlignment);
        return self;
    }

    public static T ItemsAlignmentFmg<T>(this T self, Func<PropertyContext<LayoutAlignment>, IPropertyBuilder<LayoutAlignment>> configure) where T : TabBar
    {
        PropertyContext<LayoutAlignment> arg = new PropertyContext<LayoutAlignment>(self, TabBar.ItemsAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsAlignmentFmg<T>(this SettersContext<T> self, LayoutAlignment layoutAlignment) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.ItemsAlignmentProperty,
            Value = layoutAlignment
        });
        return self;
    }

    public static SettersContext<T> ItemsAlignmentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<LayoutAlignment>, IPropertySettersBuilder<LayoutAlignment>> configure) where T : TabBar
    {
        PropertySettersContext<LayoutAlignment> arg = new PropertySettersContext<LayoutAlignment>(self.XamlSetters, TabBar.ItemsAlignmentProperty);
        configure(arg).Build();
        return self;
    }

    public static T IsScrollableFmg<T>(this T self,
        bool isScrollable)
        where T : TabBar
    {
        self.SetValue(TabBar.IsScrollableProperty, isScrollable);
        return self;
    }

    public static T IsScrollableFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<bool>(self, TabBar.IsScrollableProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsScrollableFmg<T>(this SettersContext<T> self,
        bool isScrollable)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.IsScrollableProperty, Value = isScrollable });
        return self;
    }

    public static SettersContext<T> IsScrollableFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TabBar.IsScrollableProperty);
        configure(context).Build();
        return self;
    }

    public static T PrimaryBrushFmg<T>(this T self, Brush primaryBrush) where T : TabBar
    {
        self.SetValue(TabBar.PrimaryBrushProperty, primaryBrush);
        return self;
    }

    public static T PrimaryBrushFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure) where T : TabBar
    {
        PropertyContext<Brush> arg = new PropertyContext<Brush>(self, TabBar.PrimaryBrushProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> PrimaryBrushFmg<T>(this SettersContext<T> self, Brush primaryBrush) where T : TabBar
    {
        self.XamlSetters.Add(new Setter
        {
            Property = TabBar.PrimaryBrushProperty,
            Value = primaryBrush
        });
        return self;
    }

    public static SettersContext<T> PrimaryBrushFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure) where T : TabBar
    {
        PropertySettersContext<Brush> arg = new PropertySettersContext<Brush>(self.XamlSetters, TabBar.PrimaryBrushProperty);
        configure(arg).Build();
        return self;
    }

    public static T ShowButtonWhenMoreItemsDoNotFitFmg<T>(this T self,
        bool showButtonWhenMoreItemsDoNotFit)
        where T : TabBar
    {
        self.SetValue(TabBar.ShowButtonWhenMoreItemsDoNotFitProperty, showButtonWhenMoreItemsDoNotFit);
        return self;
    }

    public static T ShowButtonWhenMoreItemsDoNotFitFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<bool>(self, TabBar.ShowButtonWhenMoreItemsDoNotFitProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShowButtonWhenMoreItemsDoNotFitFmg<T>(this SettersContext<T> self,
        bool showButtonWhenMoreItemsDoNotFit)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.ShowButtonWhenMoreItemsDoNotFitProperty, Value = showButtonWhenMoreItemsDoNotFit });
        return self;
    }

    public static SettersContext<T> ShowButtonWhenMoreItemsDoNotFitFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TabBar.ShowButtonWhenMoreItemsDoNotFitProperty);
        configure(context).Build();
        return self;
    }

    public static T ShowMenuOnMoreButtonClickFmg<T>(this T self,
        bool showMenuOnMoreButtonClick)
        where T : TabBar
    {
        self.SetValue(TabBar.ShowMenuOnMoreButtonClickProperty, showMenuOnMoreButtonClick);
        return self;
    }

    public static T ShowMenuOnMoreButtonClickFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<bool>(self, TabBar.ShowMenuOnMoreButtonClickProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> ShowMenuOnMoreButtonClickFmg<T>(this SettersContext<T> self,
        bool showMenuOnMoreButtonClick)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.ShowMenuOnMoreButtonClickProperty, Value = showMenuOnMoreButtonClick });
        return self;
    }

    public static SettersContext<T> ShowMenuOnMoreButtonClickFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, TabBar.ShowMenuOnMoreButtonClickProperty);
        configure(context).Build();
        return self;
    }

    public static T MoreTitleFmg<T>(this T self,
        string title)
        where T : TabBar
    {
        self.SetValue(TabBar.MoreTitleProperty, title);
        return self;
    }

    public static T MoreTitleFmg<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<string>(self, TabBar.MoreTitleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MoreTitleFmg<T>(this SettersContext<T> self,
        string title)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.MoreTitleProperty, Value = title });
        return self;
    }

    public static SettersContext<T> MoreTitleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, TabBar.MoreTitleProperty);
        configure(context).Build();
        return self;
    }

    public static T MoreIconFmg<T>(this T self,
        ImageSource iconImageSource)
        where T : TabBar
    {
        self.SetValue(TabBar.MoreIconProperty, iconImageSource);
        return self;
    }

    public static T MoreIconFmg<T>(this T self, Func<PropertyContext<ImageSource>, IPropertyBuilder<ImageSource>> configure)
        where T : TabBar
    {
        var context = new PropertyContext<ImageSource>(self, TabBar.MoreIconProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> MoreIconFmg<T>(this SettersContext<T> self,
        ImageSource iconImageSource)
        where T : TabBar
    {
        self.XamlSetters.Add(new Setter { Property = TabBar.MoreIconProperty, Value = iconImageSource });
        return self;
    }

    public static SettersContext<T> MoreIconFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<ImageSource>, IPropertySettersBuilder<ImageSource>> configure)
        where T : TabBar
    {
        var context = new PropertySettersContext<ImageSource>(self.XamlSetters, TabBar.MoreIconProperty);
        configure(context).Build();
        return self;
    }
}
