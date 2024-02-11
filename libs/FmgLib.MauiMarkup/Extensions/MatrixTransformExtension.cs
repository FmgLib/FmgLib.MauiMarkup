﻿namespace FmgLib.MauiMarkup;



public static partial class MatrixTransformExtension
{
    public static T MatrixFmg<T>(this T self,
        Microsoft.Maui.Controls.Shapes.Matrix matrix)
        where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty, matrix);
        return self;
    }
    
    public static T MatrixFmg<T>(this T self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.Matrix>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.Matrix>> configure)
        where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.Matrix>(self, Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> MatrixFmg<T>(this SettersContext<T> self,
        Microsoft.Maui.Controls.Shapes.Matrix matrix)
        where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty, Value = matrix });
        return self;
    }
    
    public static SettersContext<T> MatrixFmg<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.Matrix>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.Matrix>> configure)
        where T : Microsoft.Maui.Controls.Shapes.MatrixTransform
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.Matrix>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.MatrixTransform.MatrixProperty);
        configure(context).Build();
        return self;
    }
    
}
