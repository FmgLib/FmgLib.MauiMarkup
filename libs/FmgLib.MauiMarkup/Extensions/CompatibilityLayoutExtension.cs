﻿namespace FmgLib.MauiMarkup;


public static partial class CompatibilityLayoutExtension
{
    public static T IsClippedToBounds<T>(this T self,
        bool isClippedToBounds)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, isClippedToBounds);
        return self;
    }
    
    public static T IsClippedToBounds<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> IsClippedToBounds<T>(this SettersContext<T> self,
        bool isClippedToBounds)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty, Value = isClippedToBounds });
        return self;
    }
    
    public static SettersContext<T> IsClippedToBounds<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty);
        configure(context).Build();
        return self;
    }

    public static T Padding<T>(this T self, double horizontalSize, double verticalSize) where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, new Thickness(horizontalSize, verticalSize));
        return self;
    }

    public static T Padding<T>(this T self, double left, double top, double right, double bottom) where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self, object _ = null, double left = 0.0, double top = 0.0, double right = 0.0, double bottom = 0.0) where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, new Thickness(left, top, right, bottom));
        return self;
    }

    public static T Padding<T>(this T self,
        Thickness padding)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, padding);
        return self;
    }
    
    public static T Padding<T>(this T self, Func<PropertyContext<Thickness>, IPropertyBuilder<Thickness>> configure)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        var context = new PropertyContext<Thickness>(self, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> Padding<T>(this SettersContext<T> self,
        Thickness padding)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty, Value = padding });
        return self;
    }
    
    public static SettersContext<T> Padding<T>(this SettersContext<T> self, Func<PropertySettersContext<Thickness>, IPropertySettersBuilder<Thickness>> configure)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        var context = new PropertySettersContext<Thickness>(self.XamlSetters, Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty);
        configure(context).Build();
        return self;
    }
    
    public static T CascadeInputTransparent<T>(this T self,
        bool cascadeInputTransparent)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.SetValue(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, cascadeInputTransparent);
        return self;
    }
    
    public static T CascadeInputTransparent<T>(this T self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        var context = new PropertyContext<bool>(self, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<T> CascadeInputTransparent<T>(this SettersContext<T> self,
        bool cascadeInputTransparent)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty, Value = cascadeInputTransparent });
        return self;
    }
    
    public static SettersContext<T> CascadeInputTransparent<T>(this SettersContext<T> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty);
        configure(context).Build();
        return self;
    }
    
    public static T OnLayoutChanged<T>(this T self, EventHandler handler)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.LayoutChanged += handler;
        return self;
    }
    
    public static T OnLayoutChanged<T>(this T self, Action<T> action)
        where T : Microsoft.Maui.Controls.Compatibility.Layout
    {
        self.LayoutChanged += (o, arg) => action(self);
        return self;
    }
    
}