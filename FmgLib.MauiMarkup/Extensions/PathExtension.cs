﻿namespace FmgLib.MauiMarkup;



public static partial class PathExtension
{
    public static Microsoft.Maui.Controls.Shapes.Path Data(this Microsoft.Maui.Controls.Shapes.Path self,
        Microsoft.Maui.Controls.Shapes.Geometry data)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Path.DataProperty, data);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Path Data(this Microsoft.Maui.Controls.Shapes.Path self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.Geometry>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.Geometry>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.Geometry>(self, Microsoft.Maui.Controls.Shapes.Path.DataProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Path> Data(this SettersContext<Microsoft.Maui.Controls.Shapes.Path> self,
        Microsoft.Maui.Controls.Shapes.Geometry data)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Path.DataProperty, Value = data });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Path> Data(this SettersContext<Microsoft.Maui.Controls.Shapes.Path> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.Geometry>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.Geometry>> configure)
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.Geometry>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Path.DataProperty);
        configure(context).Build();
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Path RenderTransform(this Microsoft.Maui.Controls.Shapes.Path self,
        Microsoft.Maui.Controls.Shapes.Transform renderTransform)
    {
        self.SetValue(Microsoft.Maui.Controls.Shapes.Path.RenderTransformProperty, renderTransform);
        return self;
    }
    
    public static Microsoft.Maui.Controls.Shapes.Path RenderTransform(this Microsoft.Maui.Controls.Shapes.Path self, Func<PropertyContext<Microsoft.Maui.Controls.Shapes.Transform>, IPropertyBuilder<Microsoft.Maui.Controls.Shapes.Transform>> configure)
    {
        var context = new PropertyContext<Microsoft.Maui.Controls.Shapes.Transform>(self, Microsoft.Maui.Controls.Shapes.Path.RenderTransformProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Path> RenderTransform(this SettersContext<Microsoft.Maui.Controls.Shapes.Path> self,
        Microsoft.Maui.Controls.Shapes.Transform renderTransform)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Shapes.Path.RenderTransformProperty, Value = renderTransform });
        return self;
    }
    
    public static SettersContext<Microsoft.Maui.Controls.Shapes.Path> RenderTransform(this SettersContext<Microsoft.Maui.Controls.Shapes.Path> self, Func<PropertySettersContext<Microsoft.Maui.Controls.Shapes.Transform>, IPropertySettersBuilder<Microsoft.Maui.Controls.Shapes.Transform>> configure)
    {
        var context = new PropertySettersContext<Microsoft.Maui.Controls.Shapes.Transform>(self.XamlSetters, Microsoft.Maui.Controls.Shapes.Path.RenderTransformProperty);
        configure(context).Build();
        return self;
    }
    
}
