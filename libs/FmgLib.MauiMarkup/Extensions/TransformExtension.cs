﻿namespace FmgLib.MauiMarkup;



public static partial class TransformExtension
{
    public static T Value<T>(this T self,
        Microsoft.Maui.Controls.Shapes.Matrix value)
        where T : Microsoft.Maui.Controls.Shapes.Transform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Transform.ValueProperty, value);
        return self;
    }
    
    public static T Value<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.Matrix>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.Matrix>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Transform
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.Matrix>(self, Microsoft.Maui.Controls.Shapes.Transform.ValueProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Value<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.Matrix value)
        where T : Microsoft.Maui.Controls.Shapes.Transform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Transform.ValueProperty, Value = value });
        return self;
    }
    
    public static SettersContext<T> Value<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.Matrix>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.Matrix>> configure)
        where T : Microsoft.Maui.Controls.Shapes.Transform
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.Matrix>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Transform.ValueProperty);
        configure(context).Build();
        return self;
    }
    
}
