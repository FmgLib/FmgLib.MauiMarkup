﻿namespace FmgLib.MauiMarkup;

public static partial class GeometryGroupExtension
{
    public static T Children<T>(this T self,
        IList<Microsoft.Maui.Controls.Shapes.Geometry> children)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }

    public static T Children<T>(this T self,
        params Microsoft.Maui.Controls.Shapes.Geometry[] children)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        foreach (var item in children)
            self.Children.Add(item);
        return self;
    }
    
    public static T Children<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.GeometryCollection>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.GeometryCollection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.GeometryCollection>(self, Microsoft.Maui.Controls.Shapes.GeometryGroup.ChildrenProperty);
        configure(context).Build();
        return self;
    }
    
    public static T FillRule<T>(this T self,
        Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty, fillRule);
        return self;
    }
    
    public static T FillRule<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>(self, Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> FillRule<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.FillRule fillRule)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty, Value = fillRule });
        return self;
    }
    
    public static SettersContext<T> FillRule<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.FillRule>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.GeometryGroup.FillRuleProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnInvalidateGeometryRequested<T>(this T self, EventHandler handler)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        self.InvalidateGeometryRequested += handler;
        return self;
    }
    
    public static T OnInvalidateGeometryRequested<T>(this T self, Action<T> action)
        where T : Microsoft.Maui.Controls.Shapes.GeometryGroup
    {
        self.InvalidateGeometryRequested += (o, arg) => action(self);
        return self;
    }
    
}