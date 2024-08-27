namespace FmgLib.MauiMarkup;



public static partial class MultiTriggerExtension
{
    public static MultiTrigger Conditions(this MultiTrigger self,
        IList<Condition> conditions)
    {
        foreach (var item in conditions)
            self.Conditions.Add(item);
        return self;
    }

    public static MultiTrigger Conditions(this MultiTrigger self,
        params Condition[] conditions)
    {
        foreach (var item in conditions)
            self.Conditions.Add(item);
        return self;
    }

    public static MultiTrigger Conditions(this MultiTrigger self,
        Func<Condition[]> configure)
    {
        var conditions = configure();
        foreach (var item in conditions)
            self.Conditions.Add(item);
        return self;
    }
    
    public static MultiTrigger Setters(this MultiTrigger self,
        IList<Setter> setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static MultiTrigger Setters(this MultiTrigger self,
        params Setter[] setters)
    {
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }

    public static MultiTrigger Setters(this MultiTrigger self,
        Func<Setter[]> configure)
    {
        var setters = configure();
        foreach (var item in setters)
            self.Setters.Add(item);
        return self;
    }
    
}
