namespace FmgLib.MauiMarkup;

public static partial class KeyboardAcceleratorExtension
{
    public static T Key<T>(this T self,
        string key)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        self.SetValue(Microsoft.Maui.Controls.KeyboardAccelerator.KeyProperty, key);
        return self;
    }

    public static T Key<T>(this T self,
        Func<string> configure)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        var key = configure();
        self.SetValue(Microsoft.Maui.Controls.KeyboardAccelerator.KeyProperty, key);
        return self;
    }

    public static T Key<T>(this T self, Func<PropertyContext<string>, IPropertyBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        var context = new PropertyContext<string>(self, Microsoft.Maui.Controls.KeyboardAccelerator.KeyProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Key<T>(this SettersContext<T> self,
        string key)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.KeyboardAccelerator.KeyProperty, Value = key });
        return self;
    }

    public static SettersContext<T> Key<T>(this SettersContext<T> self, Func<PropertySettersContext<string>, IPropertySettersBuilder<string>> configure)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        var context = new PropertySettersContext<string>(self.XamlSetters, Microsoft.Maui.Controls.KeyboardAccelerator.KeyProperty);
        configure(context).Build();
        return self;
    }

    public static T Modifiers<T>(this T self,
        Microsoft.Maui.KeyboardAcceleratorModifiers modifiers)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        self.SetValue(Microsoft.Maui.Controls.KeyboardAccelerator.ModifiersProperty, modifiers);
        return self;
    }

    public static T Modifiers<T>(this T self,
        Func<Microsoft.Maui.KeyboardAcceleratorModifiers> configure)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        var modifiers = configure();
        self.SetValue(Microsoft.Maui.Controls.KeyboardAccelerator.ModifiersProperty, modifiers);
        return self;
    }

    public static T Modifiers<T>(this T self, Func<PropertyContext<Microsoft.Maui.KeyboardAcceleratorModifiers>, IPropertyBuilder<Microsoft.Maui.KeyboardAcceleratorModifiers>> configure)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        var context = new PropertyContext<Microsoft.Maui.KeyboardAcceleratorModifiers>(self, Microsoft.Maui.Controls.KeyboardAccelerator.ModifiersProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<T> Modifiers<T>(this SettersContext<T> self,
        Microsoft.Maui.KeyboardAcceleratorModifiers modifiers)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.KeyboardAccelerator.ModifiersProperty, Value = modifiers });
        return self;
    }

    public static SettersContext<T> Modifiers<T>(this SettersContext<T> self, Func<PropertySettersContext<Microsoft.Maui.KeyboardAcceleratorModifiers>, IPropertySettersBuilder<Microsoft.Maui.KeyboardAcceleratorModifiers>> configure)
        where T : Microsoft.Maui.Controls.KeyboardAccelerator
    {
        var context = new PropertySettersContext<Microsoft.Maui.KeyboardAcceleratorModifiers>(self.XamlSetters, Microsoft.Maui.Controls.KeyboardAccelerator.ModifiersProperty);
        configure(context).Build();
        return self;
    }

}

