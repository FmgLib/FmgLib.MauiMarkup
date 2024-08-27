﻿namespace FmgLib.MauiMarkup;



public static partial class PathFigureExtension
{
    public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        IList<Microsoft.Maui.Controls.Shapes.PathSegment> segments)
    {
        foreach (var item in segments)
            self.Segments.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        params Microsoft.Maui.Controls.Shapes.PathSegment[] segments)
    {
        foreach (var item in segments)
            self.Segments.Add(item);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        Func<Microsoft.Maui.Controls.Shapes.PathSegment[]> configure)
    {
        var segments = configure();
        foreach (var item in segments)
            self.Segments.Add(item);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure Segments(this Microsoft.Maui.Controls.Shapes.PathFigure self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PathSegmentCollection>(self, Microsoft.Maui.Controls.Shapes.PathFigure.SegmentsProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure StartPoint(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        Point startPoint)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty, startPoint);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure StartPoint(this Microsoft.Maui.Controls.Shapes.PathFigure self, Func<PropertyContext<Point>, IPropertyBuilder<Point>> configure)
    {
        var context = new PropertyContext<Point>(self, Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> StartPoint(this SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> self,
        Point startPoint)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty, Value = startPoint });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> StartPoint(this SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> self, Func<PropertySettersContext<Point>, IPropertySettersBuilder<Point>> configure)
    {
        var context = new PropertySettersContext<Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.PathFigure.StartPointProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure IsClosed(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        bool isClosed)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty, isClosed);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure IsClosed(this Microsoft.Maui.Controls.Shapes.PathFigure self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> IsClosed(this SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> self,
        bool isClosed)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty, Value = isClosed });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> IsClosed(this SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.PathFigure.IsClosedProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure IsFilled(this Microsoft.Maui.Controls.Shapes.PathFigure self,
        bool isFilled)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty, isFilled);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.PathFigure IsFilled(this Microsoft.Maui.Controls.Shapes.PathFigure self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> IsFilled(this SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> self,
        bool isFilled)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty, Value = isFilled });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> IsFilled(this SettersContext<Microsoft.Maui.Controls.Shapes.PathFigure> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.PathFigure.IsFilledProperty);
        configure(context).Build();
        return self;
    }
    
}
