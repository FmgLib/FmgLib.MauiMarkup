namespace FmgLib.MauiMarkup;



public static partial class IndicatorViewExtension
{
    public static T IndicatorsShapeFmg<T>(this T self,
        IndicatorShape indicatorsShape)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.IndicatorsShapeProperty, indicatorsShape);
        return self;
    }
    
    public static T IndicatorsShapeFmg<T>(this T self, Func<PropertyContext<IndicatorShape>, IPropertyBuilder<IndicatorShape>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<IndicatorShape>(self, IndicatorView.IndicatorsShapeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IndicatorsShapeFmg<T>(this SettersContext<T> self,
        IndicatorShape indicatorsShape)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.IndicatorsShapeProperty, Value = indicatorsShape });
        return self;
    }
    
    public static SettersContext<T> IndicatorsShapeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IndicatorShape>, IPropertySettersBuilder<IndicatorShape>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<IndicatorShape>(self.XamlSetters, IndicatorView.IndicatorsShapeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IndicatorLayoutFmg<T>(this T self,
        IBindableLayout indicatorLayout)
        where T : IndicatorView
    {
        self.IndicatorLayout = indicatorLayout;
        return self;
    }
    
    public static T PositionFmg<T>(this T self,
        int position)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.PositionProperty, position);
        return self;
    }
    
    public static T PositionFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<int>(self, IndicatorView.PositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PositionFmg<T>(this SettersContext<T> self,
        int position)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.PositionProperty, Value = position });
        return self;
    }
    
    public static SettersContext<T> PositionFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, IndicatorView.PositionProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CountFmg<T>(this T self,
        int count)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.CountProperty, count);
        return self;
    }
    
    public static T CountFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<int>(self, IndicatorView.CountProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CountFmg<T>(this SettersContext<T> self,
        int count)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.CountProperty, Value = count });
        return self;
    }
    
    public static SettersContext<T> CountFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, IndicatorView.CountProperty);
        configure(context).Build();
        return self;
    }
    
    public static T MaximumVisibleFmg<T>(this T self,
        int maximumVisible)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.MaximumVisibleProperty, maximumVisible);
        return self;
    }
    
    public static T MaximumVisibleFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<int>(self, IndicatorView.MaximumVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MaximumVisibleFmg<T>(this SettersContext<T> self,
        int maximumVisible)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.MaximumVisibleProperty, Value = maximumVisible });
        return self;
    }
    
    public static SettersContext<T> MaximumVisibleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, IndicatorView.MaximumVisibleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IndicatorTemplateFmg<T>(this T self,
        DataTemplate indicatorTemplate)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.IndicatorTemplateProperty, indicatorTemplate);
        return self;
    }
    
    public static T IndicatorTemplateFmg<T>(this T self, Func<PropertyContext<DataTemplate>, IPropertyBuilder<DataTemplate>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<DataTemplate>(self, IndicatorView.IndicatorTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IndicatorTemplateFmg<T>(this SettersContext<T> self,
        DataTemplate indicatorTemplate)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.IndicatorTemplateProperty, Value = indicatorTemplate });
        return self;
    }
    
    public static SettersContext<T> IndicatorTemplateFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<DataTemplate>, IPropertySettersBuilder<DataTemplate>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<DataTemplate>(self.XamlSetters, IndicatorView.IndicatorTemplateProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IndicatorTemplateFmg<T>(this T self, Func<object> loadTemplate)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.IndicatorTemplateProperty, new DataTemplate(loadTemplate));
        return self;
    }
    
    public static T HideSingleFmg<T>(this T self,
        bool hideSingle)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.HideSingleProperty, hideSingle);
        return self;
    }
    
    public static T HideSingleFmg<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<bool>(self, IndicatorView.HideSingleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HideSingleFmg<T>(this SettersContext<T> self,
        bool hideSingle)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.HideSingleProperty, Value = hideSingle });
        return self;
    }
    
    public static SettersContext<T> HideSingleFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, IndicatorView.HideSingleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T IndicatorColorFmg<T>(this T self,
        Color indicatorColor)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.IndicatorColorProperty, indicatorColor);
        return self;
    }
    
    public static T IndicatorColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<Color>(self, IndicatorView.IndicatorColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IndicatorColorFmg<T>(this SettersContext<T> self,
        Color indicatorColor)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.IndicatorColorProperty, Value = indicatorColor });
        return self;
    }
    
    public static SettersContext<T> IndicatorColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, IndicatorView.IndicatorColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateIndicatorColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : IndicatorView
    {
        Color fromValue = self.IndicatorColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.IndicatorColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateIndicatorColorTo", transform, callback, length, easing);
    }
    
    public static T SelectedIndicatorColorFmg<T>(this T self,
        Color selectedIndicatorColor)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.SelectedIndicatorColorProperty, selectedIndicatorColor);
        return self;
    }
    
    public static T SelectedIndicatorColorFmg<T>(this T self, Func<PropertyContext<Color>, IPropertyBuilder<Color>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<Color>(self, IndicatorView.SelectedIndicatorColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SelectedIndicatorColorFmg<T>(this SettersContext<T> self,
        Color selectedIndicatorColor)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.SelectedIndicatorColorProperty, Value = selectedIndicatorColor });
        return self;
    }
    
    public static SettersContext<T> SelectedIndicatorColorFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Color>, IPropertySettersBuilder<Color>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<Color>(self.XamlSetters, IndicatorView.SelectedIndicatorColorProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateSelectedIndicatorColorToFmg<T>(this T self, Color value, uint length = 250, Easing? easing = null)
        where T : IndicatorView
    {
        Color fromValue = self.SelectedIndicatorColor;
        var transform = (double t) => Transformations.ColorTransform(fromValue, value, t);
        var callback = (Color actValue) => { self.SelectedIndicatorColor = actValue; };
        return Transformations.AnimateAsync<Color>(self, "AnimateSelectedIndicatorColorTo", transform, callback, length, easing);
    }
    
    public static T IndicatorSizeFmg<T>(this T self,
        double indicatorSize)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.IndicatorSizeProperty, indicatorSize);
        return self;
    }
    
    public static T IndicatorSizeFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<double>(self, IndicatorView.IndicatorSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IndicatorSizeFmg<T>(this SettersContext<T> self,
        double indicatorSize)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.IndicatorSizeProperty, Value = indicatorSize });
        return self;
    }
    
    public static SettersContext<T> IndicatorSizeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, IndicatorView.IndicatorSizeProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateIndicatorSizeToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : IndicatorView
    {
        double fromValue = self.IndicatorSize;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.IndicatorSize = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateIndicatorSizeTo", transform, callback, length, easing);
    }
    
    public static T ItemsSourceFmg<T>(this T self,
        System.Collections.IEnumerable itemsSource)
        where T : IndicatorView
    {
        self.SetValue(IndicatorView.ItemsSourceProperty, itemsSource);
        return self;
    }
    
    public static T ItemsSourceFmg<T>(this T self, Func<PropertyContext<System.Collections.IEnumerable>, IPropertyBuilder<System.Collections.IEnumerable>> configure)
        where T : IndicatorView
    {
        var context = new PropertyContext<System.Collections.IEnumerable>(self, IndicatorView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self,
        System.Collections.IEnumerable itemsSource)
        where T : IndicatorView
    {
        self.XamlSetters.Add(new Setter { Property = IndicatorView.ItemsSourceProperty, Value = itemsSource });
        return self;
    }
    
    public static SettersContext<T> ItemsSourceFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<System.Collections.IEnumerable>, IPropertySettersBuilder<System.Collections.IEnumerable>> configure)
        where T : IndicatorView
    {
        var context = new PropertySettersContext<System.Collections.IEnumerable>(self.XamlSetters, IndicatorView.ItemsSourceProperty);
        configure(context).Build();
        return self;
    }
    
}