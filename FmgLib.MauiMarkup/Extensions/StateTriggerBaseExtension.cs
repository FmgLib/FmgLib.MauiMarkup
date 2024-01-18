namespace FmgLib.MauiMarkup;



public static partial class StateTriggerBaseExtension
{
    public static T OnIsActiveChanged<T>(this T self, EventHandler handler)
        where T : StateTriggerBase
    {
        self.IsActiveChanged += handler;
        return self;
    }
    
    public static T OnIsActiveChanged<T>(this T self, Action<T> action)
        where T : StateTriggerBase
    {
        self.IsActiveChanged += (o, arg) => action(self);
        return self;
    }
    
}
