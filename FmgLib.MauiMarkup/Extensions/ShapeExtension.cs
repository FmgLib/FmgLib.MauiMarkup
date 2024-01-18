﻿namespace FmgLib.MauiMarkup;



public static partial class ShapeExtension
{
    public static T Fill<T>(this T self,
        Brush fill)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.FillProperty, fill);
        return self;
    }
    
    public static T Fill<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<Brush>(self, Microsoft.Maui.Controls.Shapes.Shape.FillProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Fill<T>(this SettersContext<T> self,
        Brush fill)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.FillProperty, Value = fill });
        return self;
    }
    
    public static SettersContext<T> Fill<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.FillProperty);
        configure(context).Build();
        return self;
    }
    
    public static T Stroke<T>(this T self,
        Brush stroke)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty, stroke);
        return self;
    }
    
    public static T Stroke<T>(this T self, Func<PropertyContext<Brush>, IPropertyBuilder<Brush>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<Brush>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Stroke<T>(this SettersContext<T> self,
        Brush stroke)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty, Value = stroke });
        return self;
    }
    
    public static SettersContext<T> Stroke<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush>, IPropertySettersBuilder<Brush>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<Brush>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.StrokeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeThickness<T>(this T self,
        double strokeThickness)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, strokeThickness);
        return self;
    }
    
    public static T StrokeThickness<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeThickness<T>(this SettersContext<T> self,
        double strokeThickness)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty, Value = strokeThickness });
        return self;
    }
    
    public static SettersContext<T> StrokeThickness<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.StrokeThicknessProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateStrokeThicknessTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        double fromValue = self.StrokeThickness;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeThickness = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeThicknessTo", transform, callback, length, easing);
    }
    
    public static T StrokeDashArray<T>(this T self,
        IList<double> strokeDashArray)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        foreach (var item in strokeDashArray)
            self.StrokeDashArray.Add(item);
        return self;
    }

    public static T StrokeDashArray<T>(this T self,
        params double[] strokeDashArray)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        foreach (var item in strokeDashArray)
            self.StrokeDashArray.Add(item);
        return self;
    }
    
    public static T StrokeDashArray<T>(this T self, Func<PropertyContext<DoubleCollection>, IPropertyBuilder<DoubleCollection>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<DoubleCollection>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashArrayProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeDashOffset<T>(this T self,
        double strokeDashOffset)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, strokeDashOffset);
        return self;
    }
    
    public static T StrokeDashOffset<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeDashOffset<T>(this SettersContext<T> self,
        double strokeDashOffset)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty, Value = strokeDashOffset });
        return self;
    }
    
    public static SettersContext<T> StrokeDashOffset<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.StrokeDashOffsetProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateStrokeDashOffsetTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        double fromValue = self.StrokeDashOffset;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeDashOffset = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeDashOffsetTo", transform, callback, length, easing);
    }
    
    public static T StrokeLineCap<T>(this T self,
        Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty, strokeLineCap);
        return self;
    }
    
    public static T StrokeLineCap<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineCap>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineCap>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeLineCap<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty, Value = strokeLineCap });
        return self;
    }
    
    public static SettersContext<T> StrokeLineCap<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineCap>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineCap>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineCapProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeLineJoin<T>(this T self,
        Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty, strokeLineJoin);
        return self;
    }
    
    public static T StrokeLineJoin<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeLineJoin<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty, Value = strokeLineJoin });
        return self;
    }
    
    public static SettersContext<T> StrokeLineJoin<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.StrokeLineJoinProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeMiterLimit<T>(this T self,
        double strokeMiterLimit)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, strokeMiterLimit);
        return self;
    }
    
    public static T StrokeMiterLimit<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeMiterLimit<T>(this SettersContext<T> self,
        double strokeMiterLimit)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty, Value = strokeMiterLimit });
        return self;
    }
    
    public static SettersContext<T> StrokeMiterLimit<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.StrokeMiterLimitProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateStrokeMiterLimitTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        double fromValue = self.StrokeMiterLimit;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeMiterLimit = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeMiterLimitTo", transform, callback, length, easing);
    }
    
    public static T Aspect<T>(this T self,
        Stretch aspect)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Shape.AspectProperty, aspect);
        return self;
    }
    
    public static T Aspect<T>(this T self, Func<PropertyContext<Stretch>, IPropertyBuilder<Stretch>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertyContext<Stretch>(self, Microsoft.Maui.Controls.Shapes.Shape.AspectProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Aspect<T>(this SettersContext<T> self,
        Stretch aspect)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Shape.AspectProperty, Value = aspect });
        return self;
    }
    
    public static SettersContext<T> Aspect<T>(this SettersContext<T> self, Func<PropertySettersContext<Stretch>, IPropertySettersBuilder<Stretch>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Shape
    {
        var context = new PropertySettersContext<Stretch>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Shape.AspectProperty);
        configure(context).Build();
        return self;
    }
    
}
