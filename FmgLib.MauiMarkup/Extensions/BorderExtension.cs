namespace FmgLib.MauiMarkup;


public static partial class BorderExtension
{
    public static T ContentFmg<T>(this T self,
        View? content)
        where T : Border
    {
        self.SetValue(Border.ContentProperty, content);
        return self;
    }
    
    public static T ContentFmg<T>(this T self, Func<PropertyContext<View?>, IPropertyBuilder<View?>> configure)
        where T : Border
    {
        var context = new PropertyContext<View?>(self, Border.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self,
        View? content)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.ContentProperty, Value = content });
        return self;
    }
    
    public static SettersContext<T> ContentFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<View?>, IPropertySettersBuilder<View?>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<View?>(self.XamlSetters, Border.ContentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T PaddingFmg<T>(this T self,
        Thickness padding)
        where T : Border
    {
        self.SetValue(Border.PaddingProperty, padding);
        return self;
    }
    
    public static T PaddingFmg<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : Border
    {
        var context = new PropertyContext<Thickness>(self, Border.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self,
        Thickness padding)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.PaddingProperty, Value = padding });
        return self;
    }
    
    public static SettersContext<T> PaddingFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, Border.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeShapeFmg<T>(this T self,
        IShape? strokeShape)
        where T : Border
    {
        self.SetValue(Border.StrokeShapeProperty, strokeShape);
        return self;
    }
    
    public static T StrokeShapeFmg<T>(this T self, Func<PropertyContext<IShape?>, IPropertyBuilder<IShape?>> configure)
        where T : Border
    {
        var context = new PropertyContext<IShape?>(self, Border.StrokeShapeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeShapeFmg<T>(this SettersContext<T> self,
        IShape? strokeShape)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeShapeProperty, Value = strokeShape });
        return self;
    }
    
    public static SettersContext<T> StrokeShapeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<IShape?>, IPropertySettersBuilder<IShape?>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<IShape?>(self.XamlSetters, Border.StrokeShapeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeFmg<T>(this T self,
        Brush? stroke)
        where T : Border
    {
        self.SetValue(Border.StrokeProperty, stroke);
        return self;
    }
    
    public static T StrokeFmg<T>(this T self, Func<PropertyContext<Brush?>, IPropertyBuilder<Brush?>> configure)
        where T : Border
    {
        var context = new PropertyContext<Brush?>(self, Border.StrokeProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeFmg<T>(this SettersContext<T> self,
        Brush? stroke)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeProperty, Value = stroke });
        return self;
    }
    
    public static SettersContext<T> StrokeFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Brush?>, IPropertySettersBuilder<Brush?>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<Brush?>(self.XamlSetters, Border.StrokeProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeThicknessFmg<T>(this T self,
        double strokeThickness)
        where T : Border
    {
        self.SetValue(Border.StrokeThicknessProperty, strokeThickness);
        return self;
    }
    
    public static T StrokeThicknessFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Border
    {
        var context = new PropertyContext<double>(self, Border.StrokeThicknessProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeThicknessFmg<T>(this SettersContext<T> self,
        double strokeThickness)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeThicknessProperty, Value = strokeThickness });
        return self;
    }
    
    public static SettersContext<T> StrokeThicknessFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Border.StrokeThicknessProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateStrokeThicknessToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Border
    {
        double fromValue = self.StrokeThickness;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeThickness = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeThicknessTo", transform, callback, length, easing);
    }
    
    public static T StrokeDashArrayFmg<T>(this T self,
        IList<double> strokeDashArray)
        where T : Border
    {
        foreach (var item in strokeDashArray)
            self.StrokeDashArray?.Add(item);
        return self;
    }

    public static T StrokeDashArrayFmg<T>(this T self,
        params double[] strokeDashArray)
        where T : Border
    {
        foreach (var item in strokeDashArray)
            self.StrokeDashArray?.Add(item);
        return self;
    }
    
    public static T StrokeDashArrayFmg<T>(this T self, Func<PropertyContext<DoubleCollection?>, IPropertyBuilder<DoubleCollection?>> configure)
        where T : Border
    {
        var context = new PropertyContext<DoubleCollection?>(self, Border.StrokeDashArrayProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeDashOffsetFmg<T>(this T self,
        double strokeDashOffset)
        where T : Border
    {
        self.SetValue(Border.StrokeDashOffsetProperty, strokeDashOffset);
        return self;
    }
    
    public static T StrokeDashOffsetFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Border
    {
        var context = new PropertyContext<double>(self, Border.StrokeDashOffsetProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeDashOffsetFmg<T>(this SettersContext<T> self,
        double strokeDashOffset)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeDashOffsetProperty, Value = strokeDashOffset });
        return self;
    }
    
    public static SettersContext<T> StrokeDashOffsetFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Border.StrokeDashOffsetProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateStrokeDashOffsetToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Border
    {
        double fromValue = self.StrokeDashOffset;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeDashOffset = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeDashOffsetTo", transform, callback, length, easing);
    }
    
    public static T StrokeLineCapFmg<T>(this T self,
        Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : Border
    {
        self.SetValue(Border.StrokeLineCapProperty, strokeLineCap);
        return self;
    }
    
    public static T StrokeLineCapFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineCap>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> configure)
        where T : Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineCap>(self, Border.StrokeLineCapProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeLineCapFmg<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.PenLineCap strokeLineCap)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeLineCapProperty, Value = strokeLineCap });
        return self;
    }
    
    public static SettersContext<T> StrokeLineCapFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineCap>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.PenLineCap>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineCap>(self.XamlSetters, Border.StrokeLineCapProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeLineJoinFmg<T>(this T self,
        Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : Border
    {
        self.SetValue(Border.StrokeLineJoinProperty, strokeLineJoin);
        return self;
    }
    
    public static T StrokeLineJoinFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> configure)
        where T : Border
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self, Border.StrokeLineJoinProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeLineJoinFmg<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.PenLineJoin strokeLineJoin)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeLineJoinProperty, Value = strokeLineJoin });
        return self;
    }
    
    public static SettersContext<T> StrokeLineJoinFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.PenLineJoin>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.PenLineJoin>(self.XamlSetters, Border.StrokeLineJoinProperty);
        configure(context).Build();
        return self;
    }
    
    public static T StrokeMiterLimitFmg<T>(this T self,
        double strokeMiterLimit)
        where T : Border
    {
        self.SetValue(Border.StrokeMiterLimitProperty, strokeMiterLimit);
        return self;
    }
    
    public static T StrokeMiterLimitFmg<T>(this T self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
        where T : Border
    {
        var context = new PropertyContext<double>(self, Border.StrokeMiterLimitProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> StrokeMiterLimitFmg<T>(this SettersContext<T> self,
        double strokeMiterLimit)
        where T : Border
    {
        self.XamlSetters.Add(new Setter { Property = Border.StrokeMiterLimitProperty, Value = strokeMiterLimit });
        return self;
    }
    
    public static SettersContext<T> StrokeMiterLimitFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
        where T : Border
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Border.StrokeMiterLimitProperty);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateStrokeMiterLimitToFmg<T>(this T self, double value, uint length = 250, Easing? easing = null)
        where T : Border
    {
        double fromValue = self.StrokeMiterLimit;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.StrokeMiterLimit = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateStrokeMiterLimitTo", transform, callback, length, easing);
    }
    
}