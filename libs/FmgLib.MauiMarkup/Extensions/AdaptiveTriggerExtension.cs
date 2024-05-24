﻿namespace FmgLib.MauiMarkup;

public static partial class AdaptiveTriggerExtension
{
    public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowHeight(this Microsoft.Maui.Controls.AdaptiveTrigger self,
        double minWindowHeight)
    {
        self.SetValue(Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty, minWindowHeight);
        return self;
    }

    public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowHeight(this Microsoft.Maui.Controls.AdaptiveTrigger self,
        Func<double> configure)
    {
        var minWindowHeight = configure();
        self.SetValue(Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty, minWindowHeight);
        return self;
    }

    public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowHeight(this Microsoft.Maui.Controls.AdaptiveTrigger self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> MinWindowHeight(this SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> self,
        double minWindowHeight)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty, Value = minWindowHeight });
        return self;
    }

    public static SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> MinWindowHeight(this SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowHeightProperty);
        configure(context).Build();
        return self;
    }

    public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowWidth(this Microsoft.Maui.Controls.AdaptiveTrigger self,
        double minWindowWidth)
    {
        self.SetValue(Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty, minWindowWidth);
        return self;
    }

    public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowWidth(this Microsoft.Maui.Controls.AdaptiveTrigger self,
        Func<double> configure)
    {
        var minWindowWidth = configure();
        self.SetValue(Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty, minWindowWidth);
        return self;
    }

    public static Microsoft.Maui.Controls.AdaptiveTrigger MinWindowWidth(this Microsoft.Maui.Controls.AdaptiveTrigger self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty);
        configure(context).Build();
        return self;
    }

    public static SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> MinWindowWidth(this SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> self,
        double minWindowWidth)
    {
        self.XamlSetters.Add(new Setter { Property = Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty, Value = minWindowWidth });
        return self;
    }

    public static SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> MinWindowWidth(this SettersContext<Microsoft.Maui.Controls.AdaptiveTrigger> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, Microsoft.Maui.Controls.AdaptiveTrigger.MinWindowWidthProperty);
        configure(context).Build();
        return self;
    }

}
