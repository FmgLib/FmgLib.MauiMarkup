namespace FmgLib.MauiMarkup;

public static partial class AdaptiveTriggerExtension
{
    public static AdaptiveTrigger MinWindowHeight(this AdaptiveTrigger self, double minWindowHeight)
    {
        self.SetValue(AdaptiveTrigger.MinWindowHeightProperty, minWindowHeight);
        return self;
    }
    
    public static AdaptiveTrigger MinWindowHeight(this AdaptiveTrigger self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, AdaptiveTrigger.MinWindowHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<AdaptiveTrigger> MinWindowHeight(this SettersContext<AdaptiveTrigger> self, double minWindowHeight)
    {
        self.XamlSetters.Add(new Setter { Property = AdaptiveTrigger.MinWindowHeightProperty, Value = minWindowHeight });
        return self;
    }
    
    public static SettersContext<AdaptiveTrigger> MinWindowHeight(this SettersContext<AdaptiveTrigger> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, AdaptiveTrigger.MinWindowHeightProperty);
        configure(context).Build();
        return self;
    }
    
    public static AdaptiveTrigger MinWindowWidth(this AdaptiveTrigger self, double minWindowWidth)
    {
        self.SetValue(AdaptiveTrigger.MinWindowWidthProperty, minWindowWidth);
        return self;
    }
    
    public static AdaptiveTrigger MinWindowWidth(this AdaptiveTrigger self, Func<PropertyContext<double>, IPropertyBuilder<double>> configure)
    {
        var context = new PropertyContext<double>(self, AdaptiveTrigger.MinWindowWidthProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<AdaptiveTrigger> MinWindowWidth(this SettersContext<AdaptiveTrigger> self, double minWindowWidth)
    {
        self.XamlSetters.Add(new Setter { Property = AdaptiveTrigger.MinWindowWidthProperty, Value = minWindowWidth });
        return self;
    }
    
    public static SettersContext<AdaptiveTrigger> MinWindowWidth(this SettersContext<AdaptiveTrigger> self, Func<PropertySettersContext<double>, IPropertySettersBuilder<double>> configure)
    {
        var context = new PropertySettersContext<double>(self.XamlSetters, AdaptiveTrigger.MinWindowWidthProperty);
        configure(context).Build();
        return self;
    }
    
}
