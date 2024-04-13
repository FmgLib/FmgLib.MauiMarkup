namespace FmgLib.MauiMarkup;



public static partial class VisualStateExtension
{
    public static VisualState NameFmg(this VisualState self,
        string name)
    {
        self.Name = name;
        return self;
    }
    
    public static VisualState SettersFmg(this VisualState self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static VisualState SettersFmg(this VisualState self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static T TargetNameFmg<T>(this T self, string targetName)
            where T : IList<Setter>
    {
        foreach (var setter in self)
            setter.TargetName = targetName;
        return self;
    }

    public static VisualState StateTriggersFmg(this VisualState self,
        IList<StateTriggerBase> stateTriggers)
    {
        foreach (var item in stateTriggers)
            self.StateTriggers.Add(item);
        return self;
    }

    public static VisualState StateTriggersFmg(this VisualState self,
        params StateTriggerBase[] stateTriggers)
    {
        foreach (var item in stateTriggers)
            self.StateTriggers.Add(item);
        return self;
    }
    
    public static VisualState TargetTypeFmg(this VisualState self,
        Type targetType)
    {
        self.TargetType = targetType;
        return self;
    }
    
}
