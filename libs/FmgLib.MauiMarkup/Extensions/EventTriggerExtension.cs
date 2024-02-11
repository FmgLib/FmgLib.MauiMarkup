namespace FmgLib.MauiMarkup;

public static partial class EventTriggerExtension
{
    public static EventTrigger ActionsFmg(this EventTrigger self,
        IList<TriggerAction> actions)
    {
        foreach (var item in actions)
            self.Actions.Add(item);
        return self;
    }

    public static EventTrigger ActionsFmg(this EventTrigger self,
        params TriggerAction[] actions)
    {
        foreach (var item in actions)
            self.Actions.Add(item);
        return self;
    }
    
    public static EventTrigger EventFmg(this EventTrigger self,
        string @event)
    {
        self.Event = @event;
        return self;
    }
    
}