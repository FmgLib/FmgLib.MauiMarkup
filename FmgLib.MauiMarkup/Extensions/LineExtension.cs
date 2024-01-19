﻿namespace FmgLib.MauiMarkup;



public static partial class LineExtension
{
    public static Microsoft.Maui.Controls.Shapes.Line X1(this Microsoft.Maui.Controls.Shapes.Line self,
        double x1)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Line.X1Property, x1);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line X1(this Microsoft.Maui.Controls.Shapes.Line self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Line.X1Property);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> X1(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self,
        double x1)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Line.X1Property, Value = x1 });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> X1(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Line.X1Property);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateX1To(this Microsoft.Maui.Controls.Shapes.Line self, double value, uint length = 250, Easing? easing = null)
    {
        double fromValue = self.X1;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.X1 = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateX1To", transform, callback, length, easing);
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line Y1(this Microsoft.Maui.Controls.Shapes.Line self,
        double y1)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Line.Y1Property, y1);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line Y1(this Microsoft.Maui.Controls.Shapes.Line self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Line.Y1Property);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> Y1(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self,
        double y1)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Line.Y1Property, Value = y1 });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> Y1(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Line.Y1Property);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateY1To(this Microsoft.Maui.Controls.Shapes.Line self, double value, uint length = 250, Easing? easing = null)
    {
        double fromValue = self.Y1;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Y1 = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateY1To", transform, callback, length, easing);
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line X2(this Microsoft.Maui.Controls.Shapes.Line self,
        double x2)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Line.X2Property, x2);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line X2(this Microsoft.Maui.Controls.Shapes.Line self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Line.X2Property);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> X2(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self,
        double x2)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Line.X2Property, Value = x2 });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> X2(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Line.X2Property);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateX2To(this Microsoft.Maui.Controls.Shapes.Line self, double value, uint length = 250, Easing? easing = null)
    {
        double fromValue = self.X2;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.X2 = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateX2To", transform, callback, length, easing);
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line Y2(this Microsoft.Maui.Controls.Shapes.Line self,
        double y2)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Line.Y2Property, y2);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Line Y2(this Microsoft.Maui.Controls.Shapes.Line self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.Shapes.Line.Y2Property);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> Y2(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self,
        double y2)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Line.Y2Property, Value = y2 });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Line> Y2(this SettersContext<Microsoft.Maui.Controls.Shapes.Line> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Line.Y2Property);
        configure(context).Build();
        return self;
    }
    
    public static Task<bool> AnimateY2To(this Microsoft.Maui.Controls.Shapes.Line self, double value, uint length = 250, Easing? easing = null)
    {
        double fromValue = self.Y2;
        var transform = (double t) => Transformations.DoubleTransform(fromValue, value, t);
        var callback = (double actValue) => { self.Y2 = actValue; };
        return Transformations.AnimateAsync<double>(self, "AnimateY2To", transform, callback, length, easing);
    }
    
}
