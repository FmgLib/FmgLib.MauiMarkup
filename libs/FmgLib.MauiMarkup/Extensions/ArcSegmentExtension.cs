﻿namespace FmgLib.MauiMarkup;


public static partial class ShapesArcSegmentExtension
{
    public static T IsLargeArc<T>(this T self,
        bool isLargeArc)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, isLargeArc);
        return self;
    }

    public static T IsLargeArc<T>(this T self,
        Func<bool> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var isLargeArc = configure();
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, isLargeArc);
        return self;
    }

    public static T IsLargeArc<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> IsLargeArc<T>(this SettersContext<T> self,
        bool isLargeArc)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty, Value = isLargeArc });
        return self;
    }

    public static SettersContext<T> IsLargeArc<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.IsLargeArcProperty);
        configure(context).Build();
        return self;
    }

    public static T Point<T>(this T self,
        Microsoft.Maui.Graphics.Point point)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, point);
        return self;
    }

    public static T Point<T>(this T self,
        Func<Microsoft.Maui.Graphics.Point> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var point = configure();
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, point);
        return self;
    }

    public static T Point<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Point>, IPropertyBuilder<Microsoft.Maui.Graphics.Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Point>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Point<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Point point)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty, Value = point });
        return self;
    }

    public static SettersContext<T> Point<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Point>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Point>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Point>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.PointProperty);
        configure(context).Build();
        return self;
    }

    public static T RotationAngle<T>(this T self,
        double rotationAngle)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, rotationAngle);
        return self;
    }

    public static T RotationAngle<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var rotationAngle = configure();
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, rotationAngle);
        return self;
    }

    public static T RotationAngle<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> RotationAngle<T>(this SettersContext<T> self,
        double rotationAngle)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty, Value = rotationAngle });
        return self;
    }

    public static SettersContext<T> RotationAngle<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.RotationAngleProperty);
        configure(context).Build();
        return self;
    }

    public static T Size<T>(this T self,
        Microsoft.Maui.Graphics.Size size)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, size);
        return self;
    }

    public static T Size<T>(this T self,
        Func<Microsoft.Maui.Graphics.Size> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var size = configure();
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, size);
        return self;
    }

    public static T Size<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.Size>, IPropertyBuilder<Microsoft.Maui.Graphics.Size>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.Size>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Size<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.Size size)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty, Value = size });
        return self;
    }

    public static SettersContext<T> Size<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.Size>, IPropertySettersBuilder<Microsoft.Maui.Graphics.Size>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.Size>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.SizeProperty);
        configure(context).Build();
        return self;
    }

    public static T SweepDirection<T>(this T self,
        Microsoft.Maui.Controls.SweepDirection sweepDirection)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, sweepDirection);
        return self;
    }

    public static T SweepDirection<T>(this T self,
        Func<Microsoft.Maui.Controls.SweepDirection> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var sweepDirection = configure();
        self.SetValue(Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, sweepDirection);
        return self;
    }

    public static T SweepDirection<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.SweepDirection>, IPropertyBuilder<Microsoft.Maui.Controls.SweepDirection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.SweepDirection>(self, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> SweepDirection<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.SweepDirection sweepDirection)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty, Value = sweepDirection });
        return self;
    }

    public static SettersContext<T> SweepDirection<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.SweepDirection>, IPropertySettersBuilder<Microsoft.Maui.Controls.SweepDirection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.ArcSegment
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.SweepDirection>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.ArcSegment.SweepDirectionProperty);
        configure(context).Build();
        return self;
    }

}