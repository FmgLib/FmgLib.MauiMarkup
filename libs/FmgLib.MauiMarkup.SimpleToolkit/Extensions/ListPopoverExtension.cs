using SimpleToolkit.SimpleShell.Controls;

namespace FmgLib.MauiMarkup.SimpleToolkit;

public static partial class ListPopoverExtension
{
    public static T MaximumWidthRequestFmg<T>(this T self, double maximumWidthRequest) where T : ListPopover
    {
        self.SetValue(ListPopover.MaximumWidthRequestProperty, maximumWidthRequest);
        return self;
    }

    public static T MaximumWidthRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : ListPopover
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, ListPopover.MaximumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MaximumWidthRequestFmg<T>(this SettersContext<T> self, double maximumWidthRequest) where T : ListPopover
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ListPopover.MaximumWidthRequestProperty,
            Value = maximumWidthRequest
        });
        return self;
    }

    public static SettersContext<T> MaximumWidthRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : ListPopover
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, ListPopover.MaximumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static T MinimumWidthRequestFmg<T>(this T self, double minimumWidthRequest) where T : ListPopover
    {
        self.SetValue(ListPopover.MinimumWidthRequestProperty, minimumWidthRequest);
        return self;
    }

    public static T MinimumWidthRequestFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure) where T : ListPopover
    {
        PropertyContext<double> arg = new PropertyContext<double>(self, ListPopover.MinimumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> MinimumWidthRequestFmg<T>(this SettersContext<T> self, double minimumWidthRequest) where T : ListPopover
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ListPopover.MinimumWidthRequestProperty,
            Value = minimumWidthRequest
        });
        return self;
    }

    public static SettersContext<T> MinimumWidthRequestFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure) where T : ListPopover
    {
        PropertySettersContext<double> arg = new PropertySettersContext<double>(self.XamlSetters, ListPopover.MinimumWidthRequestProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectionBrushFmg<T>(this T self,
        Brush selectionBrush)
        where T : ListPopover
    {
        self.SetValue(ListPopover.SelectionBrushProperty, selectionBrush);
        return self;
    }

    public static T SelectionBrushFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : ListPopover
    {
        var context = new PropertyContext<Brush>(self, ListPopover.SelectionBrushProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SelectionBrushFmg<T>(this SettersContext<T> self,
        Brush selectionBrush)
        where T : ListPopover
    {
        self.XamlSetters.Add(new Setter { Property = ListPopover.SelectionBrushProperty, Value = selectionBrush });
        return self;
    }

    public static SettersContext<T> SelectionBrushFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : ListPopover
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, ListPopover.SelectionBrushProperty);
        configure(context).Build();
        return self;
    }

    public static T BackgroundFmg<T>(this T self, Brush background) where T : ListPopover
    {
        self.SetValue(ListPopover.BackgroundProperty, background);
        return self;
    }

    public static T BackgroundFmg<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure) where T : ListPopover
    {
        PropertyContext<Brush> arg = new PropertyContext<Brush>(self, ListPopover.BackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> BackgroundFmg<T>(this SettersContext<T> self, Brush background) where T : ListPopover
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ListPopover.BackgroundProperty,
            Value = background
        });
        return self;
    }

    public static SettersContext<T> BackgroundFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure) where T : ListPopover
    {
        PropertySettersContext<Brush> arg = new PropertySettersContext<Brush>(self.XamlSetters, ListPopover.BackgroundProperty);
        configure(arg).Build();
        return self;
    }

    public static T TextSelectionColorFmg<T>(this T self,
        Color selectionColor)
        where T : ListPopover
    {
        self.SetValue(ListPopover.TextSelectionColorProperty, selectionColor);
        return self;
    }

    public static T TextSelectionColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertyContext<Color>(self, ListPopover.TextSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextSelectionColorFmg<T>(this SettersContext<T> self,
        Color selectionColor)
        where T : ListPopover
    {
        self.XamlSetters.Add(new Setter { Property = ListPopover.TextSelectionColorProperty, Value = selectionColor });
        return self;
    }

    public static SettersContext<T> TextSelectionColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ListPopover.TextSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static T TextColorFmg<T>(this T self,
        Color textColor)
        where T : ListPopover
    {
        self.SetValue(ListPopover.TextColorProperty, textColor);
        return self;
    }

    public static T TextColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertyContext<Color>(self, ListPopover.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self,
        Color textColor)
        where T : ListPopover
    {
        self.XamlSetters.Add(new Setter { Property = ListPopover.TextColorProperty, Value = textColor });
        return self;
    }

    public static SettersContext<T> TextColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ListPopover.TextColorProperty);
        configure(context).Build();
        return self;
    }

    public static T IconSelectionColorFmg<T>(this T self,
        Color selectionColor)
        where T : ListPopover
    {
        self.SetValue(ListPopover.IconSelectionColorProperty, selectionColor);
        return self;
    }

    public static T IconSelectionColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertyContext<Color>(self, ListPopover.IconSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconSelectionColorFmg<T>(this SettersContext<T> self,
        Color selectionColor)
        where T : ListPopover
    {
        self.XamlSetters.Add(new Setter { Property = ListPopover.IconSelectionColorProperty, Value = selectionColor });
        return self;
    }

    public static SettersContext<T> IconSelectionColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ListPopover.IconSelectionColorProperty);
        configure(context).Build();
        return self;
    }

    public static T IconColorFmg<T>(this T self,
       Color iconColor)
       where T : ListPopover
    {
        self.SetValue(ListPopover.IconColorProperty, iconColor);
        return self;
    }

    public static T IconColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertyContext<Color>(self, ListPopover.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IconColorFmg<T>(this SettersContext<T> self,
        Color iconColor)
        where T : ListPopover
    {
        self.XamlSetters.Add(new Setter { Property = ListPopover.IconColorProperty, Value = iconColor });
        return self;
    }

    public static SettersContext<T> IconColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : ListPopover
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, ListPopover.IconColorProperty);
        configure(context).Build();
        return self;
    }

    public static T DesignLanguageFmg<T>(this T self, DesignLanguage designLanguage) where T : ListPopover
    {
        self.SetValue(ListPopover.DesignLanguageProperty, designLanguage);
        return self;
    }

    public static T DesignLanguageFmg<T>(this T self, Func<PropertyContext<DesignLanguage>, IPropertyBuilder<DesignLanguage>> configure) where T : ListPopover
    {
        PropertyContext<DesignLanguage> arg = new PropertyContext<DesignLanguage>(self, ListPopover.DesignLanguageProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> DesignLanguageFmg<T>(this SettersContext<T> self, DesignLanguage designLanguage) where T : ListPopover
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ListPopover.DesignLanguageProperty,
            Value = designLanguage
        });
        return self;
    }

    public static SettersContext<T> DesignLanguageFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DesignLanguage>, IPropertySettersBuilder<DesignLanguage>> configure) where T : ListPopover
    {
        PropertySettersContext<DesignLanguage> arg = new PropertySettersContext<DesignLanguage>(self.XamlSetters, ListPopover.DesignLanguageProperty);
        configure(arg).Build();
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, object item) where T : ListPopover
    {
        self.SetValue(ListPopover.SelectedItemProperty, item);
        return self;
    }

    public static T SelectedItemFmg<T>(this T self, Func<PropertyContext<object>, IPropertyBuilder<object>> configure) where T : ListPopover
    {
        PropertyContext<object> arg = new PropertyContext<object>(self, ListPopover.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, object item) where T : ListPopover
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ListPopover.SelectedItemProperty,
            Value = item
        });
        return self;
    }

    public static SettersContext<T> SelectedItemFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<object>, IPropertySettersBuilder<object>> configure) where T : ListPopover
    {
        PropertySettersContext<object> arg = new PropertySettersContext<object>(self.XamlSetters, ListPopover.SelectedItemProperty);
        configure(arg).Build();
        return self;
    }

    public static T ItemsFmg<T>(this T self, IEnumerable<object> items) where T : ListPopover
    {
        self.SetValue(ListPopover.ItemsProperty, items);
        return self;
    }

    public static T ItemsFmg<T>(this T self, Func<PropertyContext<IEnumerable<object>>, IPropertyBuilder<IEnumerable<object>>> configure) where T : ListPopover
    {
        PropertyContext<IEnumerable<object>> arg = new PropertyContext<IEnumerable<object>>(self, ListPopover.ItemsProperty);
        configure(arg).Build();
        return self;
    }

    public static SettersContext<T> ItemsFmg<T>(this SettersContext<T> self, IEnumerable<object> items) where T : ListPopover
    {
        self.XamlSetters.Add(new Setter
        {
            Property = ListPopover.ItemsProperty,
            Value = items
        });
        return self;
    }

    public static SettersContext<T> ItemsFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IEnumerable<object>>, IPropertySettersBuilder<IEnumerable<object>>> configure) where T : ListPopover
    {
        PropertySettersContext<IEnumerable<object>> arg = new PropertySettersContext<IEnumerable<object>>(self.XamlSetters, ListPopover.ItemsProperty);
        configure(arg).Build();
        return self;
    }
}
