﻿namespace FmgLib.MauiMarkup;



public static partial class RoundRectangleExtension
{
    public static Microsoft.Maui.Controls.Shapes.RoundRectangle CornerRadius(this Microsoft.Maui.Controls.Shapes.RoundRectangle self,
        CornerRadius cornerRadius)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, cornerRadius);
        return self;
    }

    public static Microsoft.Maui.Controls.Shapes.RoundRectangle CornerRadius(this Microsoft.Maui.Controls.Shapes.RoundRectangle self, Func<PropertyContext<CornerRadius>, IPropertyBuilder<CornerRadius>> configure)
    {
        var context = new PropertyContext<CornerRadius>(self, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.RoundRectangle> CornerRadius(this SettersContext<Microsoft.Maui.Controls.Shapes.RoundRectangle> self,
        CornerRadius cornerRadius)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, Value = cornerRadius });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.RoundRectangle> CornerRadius(this SettersContext<Microsoft.Maui.Controls.Shapes.RoundRectangle> self, Func<PropertySettersContext<CornerRadius>, IPropertySettersBuilder<CornerRadius>> configure)
    {
        var context = new PropertySettersContext<CornerRadius>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty);
        configure(context).Build();
        return self;
    }


    public static Microsoft.Maui.Controls.Shapes.RoundRectangle CornerRadius(this Microsoft.Maui.Controls.Shapes.RoundRectangle self,
        double topLeft, double topRight, double bottomLeft, double bottomRight)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, new CornerRadius(topLeft, topRight, bottomLeft, bottomRight));
        return self;
    }

    public static SettersContext<Microsoft.Maui.Controls.Shapes.RoundRectangle> CornerRadius(this SettersContext<Microsoft.Maui.Controls.Shapes.RoundRectangle> self,
        double topLeft, double topRight, double bottomLeft, double bottomRight)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.RoundRectangle.CornerRadiusProperty, Value = new CornerRadius(topLeft, topRight, bottomLeft, bottomRight) });
        return self;
    }
}
