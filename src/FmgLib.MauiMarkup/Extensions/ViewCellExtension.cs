namespace FmgLib.MauiMarkup;



public static partial class ViewCellExtension
{
    public static T View<T>(this T self,
        View view)
        where T : ViewCell
    {
        self.View = view;
        return self;
    }

    public static T View<T>(this T self,
        Func<View> configure)
        where T : ViewCell
    {
        var view = configure();
        self.View = view;
        return self;
    }
    
}
