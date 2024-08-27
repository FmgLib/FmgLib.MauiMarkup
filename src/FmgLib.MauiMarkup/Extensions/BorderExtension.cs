﻿namespace FmgLib.MauiMarkup;


public static partial class BorderExtension
{
    public static T Content_ContentProp<T>(this T self,
        Microsoft.Maui.Controls.View? content)
        where T : Microsoft.Maui.Controls.Border
    {
        self.Content = content;
        return self;
    }

    public static T Content_ContentProp<T>(this T self,
        Func<Microsoft.Maui.Controls.View?> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var content = configure();
        self.Content = content;
        return self;
    }

    public static T Content<T>(this T self,
        Microsoft.Maui.Controls.View? content)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self,
        Func<Microsoft.Maui.Controls.View?> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var content = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.ContentProperty, content);
        return self;
    }

    public static T Content<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.View?>, IPropertyBuilder<Microsoft.Maui.Controls.View?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.View?>(self, Microsoft.Maui.Controls.Border.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.View? content)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.ContentProperty, Value = content });
        return self;
    }

    public static SettersContext<T> Content<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.View?>, IPropertySettersBuilder<Microsoft.Maui.Controls.View?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.View?>(self.XamlSetters, Microsoft.Maui.Controls.Border.ContentProperty);
        configure(context).Build();
        return self;
    }

    public static T Padding<T>(this T self,
        Microsoft.Maui.Thickness padding)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.PaddingProperty, padding);
        return self;
    }

    public static T Padding<T>(this T self,
        Func<Microsoft.Maui.Thickness> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var padding = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.PaddingProperty, padding);
        return self;
    }

    public static T Padding<T>(this T self, Func<PropertyContext<Microsoft.Maui.Thickness>, IPropertyBuilder<Microsoft.Maui.Thickness>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Thickness>(self, Microsoft.Maui.Controls.Border.PaddingProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self,
        Microsoft.Maui.Thickness padding)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.PaddingProperty, Value = padding });
        return self;
    }

    public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Thickness>, IPropertySettersBuilder<Microsoft.Maui.Thickness>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Border.PaddingProperty);
        configure(context).Build();
        return self;
    }

    public static T Stroke<T>(this T self,
        Microsoft.Maui.Controls.Brush? stroke)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeProperty, stroke);
        return self;
    }

    public static T Stroke<T>(this T self,
        Func<Microsoft.Maui.Controls.Brush?> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var stroke = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeProperty, stroke);
        return self;
    }

    public static T Stroke<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Brush?>, IPropertyBuilder<Microsoft.Maui.Controls.Brush?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Brush?>(self, Microsoft.Maui.Controls.Border.StrokeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Stroke<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Brush? stroke)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeProperty, Value = stroke });
        return self;
    }

    public static SettersContext<T> Stroke<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Brush?>, IPropertySettersBuilder<Microsoft.Maui.Controls.Brush?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Brush?>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeProperty);
        configure(context).Build();
        return self;
    }

    public static T StrokeDashArray<T>(this T self,
        Microsoft.Maui.Controls.DoubleCollection? strokeDashArray)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeDashArrayProperty, strokeDashArray);
        return self;
    }

    public static T StrokeDashArray<T>(this T self,
        Func<Microsoft.Maui.Controls.DoubleCollection?> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeDashArray = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeDashArrayProperty, strokeDashArray);
        return self;
    }

    public static T StrokeDashArray<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.DoubleCollection?>, IPropertyBuilder<Microsoft.Maui.Controls.DoubleCollection?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.DoubleCollection?>(self, Microsoft.Maui.Controls.Border.StrokeDashArrayProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeDashArray<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.DoubleCollection? strokeDashArray)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeDashArrayProperty, Value = strokeDashArray });
        return self;
    }

    public static SettersContext<T> StrokeDashArray<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.DoubleCollection?>, IPropertySettersBuilder<Microsoft.Maui.Controls.DoubleCollection?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.DoubleCollection?>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeDashArrayProperty);
        configure(context).Build();
        return self;
    }

    public static T StrokeDashOffset<T>(this T self,
        double strokeDashOffset)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, strokeDashOffset);
        return self;
    }

    public static T StrokeDashOffset<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeDashOffset = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, strokeDashOffset);
        return self;
    }

    public static T StrokeDashOffset<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeDashOffset<T>(this SettersContext<T> self,
        double strokeDashOffset)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty, Value = strokeDashOffset });
        return self;
    }

    public static SettersContext<T> StrokeDashOffset<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeDashOffsetProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateStrokeDashOffsetTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Border
    {
        double fromValue = self.StrokeDashOffset;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeDashOffset = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeDashOffsetTo", transform, callback, length, easing);
    }

    public static T StrokeLineCap<T>(this T self,
        Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeLineCapProperty, strokeLineCap);
        return self;
    }

    public static T StrokeLineCap<T>(this T self,
        Func<Microsoft.Maui.Controls.Shapes.PenLineCap> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeLineCap = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeLineCapProperty, strokeLineCap);
        return self;
    }

    public static T StrokeLineCap<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineCap>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineCap>(self, Microsoft.Maui.Controls.Border.StrokeLineCapProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeLineCap<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeLineCapProperty, Value = strokeLineCap });
        return self;
    }

    public static SettersContext<T> StrokeLineCap<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineCap>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineCap>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeLineCapProperty);
        configure(context).Build();
        return self;
    }

    public static T StrokeLineJoin<T>(this T self,
        Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeLineJoinProperty, strokeLineJoin);
        return self;
    }

    public static T StrokeLineJoin<T>(this T self,
        Func<Microsoft.Maui.Controls.Shapes.PenLineJoin> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeLineJoin = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeLineJoinProperty, strokeLineJoin);
        return self;
    }

    public static T StrokeLineJoin<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self, Microsoft.Maui.Controls.Border.StrokeLineJoinProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeLineJoin<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeLineJoinProperty, Value = strokeLineJoin });
        return self;
    }

    public static SettersContext<T> StrokeLineJoin<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeLineJoinProperty);
        configure(context).Build();
        return self;
    }

    public static T StrokeMiterLimit<T>(this T self,
        double strokeMiterLimit)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, strokeMiterLimit);
        return self;
    }

    public static T StrokeMiterLimit<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeMiterLimit = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, strokeMiterLimit);
        return self;
    }

    public static T StrokeMiterLimit<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeMiterLimit<T>(this SettersContext<T> self,
        double strokeMiterLimit)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty, Value = strokeMiterLimit });
        return self;
    }

    public static SettersContext<T> StrokeMiterLimit<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeMiterLimitProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateStrokeMiterLimitTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Border
    {
        double fromValue = self.StrokeMiterLimit;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeMiterLimit = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeMiterLimitTo", transform, callback, length, easing);
    }

    public static T StrokeShape<T>(this T self,
        Microsoft.Maui.Graphics.IShape? strokeShape)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeShapeProperty, strokeShape);
        return self;
    }

    public static T StrokeShape<T>(this T self,
        Func<Microsoft.Maui.Graphics.IShape?> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeShape = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeShapeProperty, strokeShape);
        return self;
    }

    public static T StrokeShape<T>(this T self, Func<PropertyContext<Microsoft.Maui.Graphics.IShape?>, IPropertyBuilder<Microsoft.Maui.Graphics.IShape?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<Microsoft.Maui.Graphics.IShape?>(self, Microsoft.Maui.Controls.Border.StrokeShapeProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeShape<T>(this SettersContext<T> self,
        Microsoft.Maui.Graphics.IShape? strokeShape)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeShapeProperty, Value = strokeShape });
        return self;
    }

    public static SettersContext<T> StrokeShape<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Graphics.IShape?>, IPropertySettersBuilder<Microsoft.Maui.Graphics.IShape?>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Graphics.IShape?>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeShapeProperty);
        configure(context).Build();
        return self;
    }

    public static T StrokeThickness<T>(this T self,
        double strokeThickness)
        where T : Microsoft.Maui.Controls.Border
    {
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeThicknessProperty, strokeThickness);
        return self;
    }

    public static T StrokeThickness<T>(this T self,
        Func<double> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var strokeThickness = configure();
        self.SetValue(Microsoft.Maui.Controls.Border.StrokeThicknessProperty, strokeThickness);
        return self;
    }

    public static T StrokeThickness<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Border.StrokeThicknessProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> StrokeThickness<T>(this SettersContext<T> self,
        double strokeThickness)
        where T : Microsoft.Maui.Controls.Border
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Border.StrokeThicknessProperty, Value = strokeThickness });
        return self;
    }

    public static SettersContext<T> StrokeThickness<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Microsoft.Maui.Controls.Border
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Border.StrokeThicknessProperty);
        configure(context).Build();
        return self;
    }

    public static Task<bool> AnimateStrokeThicknessTo<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Microsoft.Maui.Controls.Border
    {
        double fromValue = self.StrokeThickness;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeThickness = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeThicknessTo", transform, callback, length, easing);
    }

}
