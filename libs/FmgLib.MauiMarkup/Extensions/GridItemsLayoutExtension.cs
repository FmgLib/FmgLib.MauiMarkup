﻿namespace FmgLib.MauiMarkup;

public static partial class GridItemsLayoutExtension
{
    public static T SpanFmg<T>(this T self,
        int span)
        where T : GridItemsLayout
    {
        self.SetValue(GridItemsLayout.SpanProperty, span);
        return self;
    }
    
    public static T SpanFmg<T>(this T self, Func<PropertyContext<int>, IPropertyBuilder<int>> configure)
        where T : GridItemsLayout
    {
        var context = new PropertyContext<int>(self, GridItemsLayout.SpanProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> SpanFmg<T>(this SettersContext<T> self,
        int span)
        where T : GridItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridItemsLayout.SpanProperty, Value = span });
        return self;
    }
    
    public static SettersContext<T> SpanFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<int>, IPropertySettersBuilder<int>> configure)
        where T : GridItemsLayout
    {
        var context = new PropertySettersContext<int>(self.XamlSetters, GridItemsLayout.SpanProperty);
        configure(context).Build();
        return self;
    }
    
    public static T VerticalItemSpacingFmg<T>(this T self,
        double verticalItemSpacing)
        where T : GridItemsLayout
    {
        self.SetValue(GridItemsLayout.VerticalItemSpacingProperty, verticalItemSpacing);
        return self;
    }
    
    public static T VerticalItemSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : GridItemsLayout
    {
        var context = new PropertyContext<double>(self, GridItemsLayout.VerticalItemSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> VerticalItemSpacingFmg<T>(this SettersContext<T> self,
        double verticalItemSpacing)
        where T : GridItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridItemsLayout.VerticalItemSpacingProperty, Value = verticalItemSpacing });
        return self;
    }
    
    public static SettersContext<T> VerticalItemSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : GridItemsLayout
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, GridItemsLayout.VerticalItemSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T HorizontalItemSpacingFmg<T>(this T self,
        double horizontalItemSpacing)
        where T : GridItemsLayout
    {
        self.SetValue(GridItemsLayout.HorizontalItemSpacingProperty, horizontalItemSpacing);
        return self;
    }
    
    public static T HorizontalItemSpacingFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : GridItemsLayout
    {
        var context = new PropertyContext<double>(self, GridItemsLayout.HorizontalItemSpacingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> HorizontalItemSpacingFmg<T>(this SettersContext<T> self,
        double horizontalItemSpacing)
        where T : GridItemsLayout
    {
        self.XamlSetters.Add(new Setter { Property = GridItemsLayout.HorizontalItemSpacingProperty, Value = horizontalItemSpacing });
        return self;
    }
    
    public static SettersContext<T> HorizontalItemSpacingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : GridItemsLayout
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, GridItemsLayout.HorizontalItemSpacingProperty);
        configure(context).Build();
        return self;
    }
    
}