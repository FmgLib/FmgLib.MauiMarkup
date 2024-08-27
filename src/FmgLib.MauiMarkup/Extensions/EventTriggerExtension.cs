namespace FmgLib.MauiMarkup;

public static partial class EventTriggerExtension
{
    public static EventTrigger Actions(this EventTrigger self,
        IList<TriggerAction> actions)
    {
        foreach (var item in actions)
            self.Actions.Add(item);
        return self;
    }

    public static EventTrigger Actions(this EventTrigger self,
        params TriggerAction[] actions)
    {
        foreach (var item in actions)
            self.Actions.Add(item);
        return self;
    }

    public static EventTrigger Actions(this EventTrigger self,
        Func<TriggerAction[]> configure)
    {
        var actions = configure();
        foreach (var item in actions)
            self.Actions.Add(item);
        return self;
    }
    
    public static EventTrigger Event(this EventTrigger self,
        string @event)
    {
        self.Event = @event;
        return self;
    }
    
}