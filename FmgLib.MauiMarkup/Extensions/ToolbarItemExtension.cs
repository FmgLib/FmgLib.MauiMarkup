namespace FmgLib.MauiMarkup;



public static partial class ToolbarItemExtension
{
    public static T OrderFmg<T>(this T self,
        ToolbarItemOrder order)
        where T : ToolbarItem
    {
        self.Order = order;
        return self;
    }
    
    public static T PriorityFmg<T>(this T self,
        int priority)
        where T : ToolbarItem
    {
        self.Priority = priority;
        return self;
    }
    
}
