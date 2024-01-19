namespace FmgLib.MauiMarkup;



public static partial class MultiTriggerExtension
{
    public static MultiTrigger ConditionsFmg(this MultiTrigger self,
        IList<Condition> conditions)
    {
        foreach (var item in conditions)
            self.Conditions.Add(item);
        return self;
    }

    public static MultiTrigger ConditionsFmg(this MultiTrigger self,
        params Condition[] conditions)
    {
        foreach (var item in conditions)
            self.Conditions.Add(item);
        return self;
    }
    
    public static MultiTrigger SettersFmg(this MultiTrigger self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static MultiTrigger SettersFmg(this MultiTrigger self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }
    
}
