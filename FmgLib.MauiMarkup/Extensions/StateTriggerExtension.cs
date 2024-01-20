namespace FmgLib.MauiMarkup;



public static partial class StateTriggerExtension
{
    public static StateTrigger IsActiveFmg(this StateTrigger self,
        bool isActive)
    {
        self.SetValue(StateTrigger.IsActiveProperty, isActive);
        return self;
    }
    
    public static StateTrigger IsActiveFmg(this StateTrigger self, Func<PropertyContext<bool>, IPropertyBuilder<bool>> configure)
    {
        var context = new PropertyContext<bool>(self, StateTrigger.IsActiveProperty);
        configure(context).Build();
        return self;
    }
    
    public static SettersContext<StateTrigger> IsActiveFmg(this SettersContext<StateTrigger> self,
        bool isActive)
    {
        self.XamlSetters.Add(new Setter { Property = StateTrigger.IsActiveProperty, Value = isActive });
        return self;
    }
    
    public static SettersContext<StateTrigger> IsActiveFmg(this SettersContext<StateTrigger> self, Func<PropertySettersContext<bool>, IPropertySettersBuilder<bool>> configure)
    {
        var context = new PropertySettersContext<bool>(self.XamlSetters, StateTrigger.IsActiveProperty);
        configure(context).Build();
        return self;
    }
    
}
