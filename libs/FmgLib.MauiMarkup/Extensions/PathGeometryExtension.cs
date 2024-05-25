﻿namespace FmgLib.MauiMarkup;



public static partial class PathGeometryExtension
{
    public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
        IList<Microsoft.Maui.Controls.Shapes.PathFigure> figures)
    {
        foreach (var item in figures)
            self.Figures.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
        params Microsoft.Maui.Controls.Shapes.PathFigure[] figures)
    {
        foreach (var item in figures)
            self.Figures.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
        Func<Microsoft.Maui.Controls.Shapes.PathFigure[]> configure)
    {
        var figures = configure();
        foreach (var item in figures)
            self.Figures.Add(item);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathGeometry Figures(this Microsoft.Maui.Controls.Shapes.PathGeometry self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PathFigureCollection>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PathFigureCollection>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PathFigureCollection>(self, Microsoft.Maui.Controls.Shapes.PathGeometry.FiguresProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathGeometry FillRule(this Microsoft.Maui.Controls.Shapes.PathGeometry self,
        Microsoft.Maui.Controls.Shapes.FillRule fillRule)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty, fillRule);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathGeometry FillRule(this Microsoft.Maui.Controls.Shapes.PathGeometry self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.FillRule>(self, Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathGeometry> FillRule(this SettersContext<Microsoft.Maui.Controls.Shapes.PathGeometry> self,
        Microsoft.Maui.Controls.Shapes.FillRule fillRule)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty, Value = fillRule });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathGeometry> FillRule(this SettersContext<Microsoft.Maui.Controls.Shapes.PathGeometry> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.FillRule>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.FillRule>> configure)
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.FillRule>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.PathGeometry.FillRuleProperty);
        configure(context).Build();
        return self;
    }
    
}
