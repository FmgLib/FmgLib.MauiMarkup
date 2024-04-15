namespace FmgLib.MauiMarkup;



public static partial class ToolbarItemExtension
{
    public static T Order<T>(this T self,
        ToolbarItemOrder order)
        where T : ToolbarItem
    {
        self.Order = order;
        return self;
    }
    
    public static T Priority<T>(this T self,
        int priority)
        where T : ToolbarItem
    {
        self.Priority = priority;
        return self;
    }
    
}
