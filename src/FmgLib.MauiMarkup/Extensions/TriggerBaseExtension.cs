namespace FmgLib.MauiMarkup;



public static partial class TriggerBaseExtension
{
    public static T EnterActions<T>(this T self,
        IList<TriggerAction> enterActions)
        where T : TriggerBase
    {
        foreach (var item in enterActions)
            self.EnterActions.Add(item);
        return self;
    }

    public static T EnterActions<T>(this T self,
        params TriggerAction[] enterActions)
        where T : TriggerBase
    {
        foreach (var item in enterActions)
            self.EnterActions.Add(item);
        return self;
    }

    public static T EnterActions<T>(this T self,
        Func<TriggerAction[]> configure)
        where T : TriggerBase
    {
        var enterActions = configure();
        foreach (var item in enterActions)
            self.EnterActions.Add(item);
        return self;
    }
    
    public static T ExitActions<T>(this T self,
        IList<TriggerAction> exitActions)
        where T : TriggerBase
    {
        foreach (var item in exitActions)
            self.ExitActions.Add(item);
        return self;
    }

    public static T ExitActions<T>(this T self,
        params TriggerAction[] exitActions)
        where T : TriggerBase
    {
        foreach (var item in exitActions)
            self.ExitActions.Add(item);
        return self;
    }

    public static T ExitActions<T>(this T self,
        Func<TriggerAction[]> configure)
        where T : TriggerBase
    {
        var exitActions = configure();
        foreach (var item in exitActions)
            self.ExitActions.Add(item);
        return self;
    }
    
}
