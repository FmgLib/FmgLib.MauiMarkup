namespace FmgLib.MauiMarkup;



public static partial class ViewCellExtension
{
    public static T ViewFmg<T>(this T self,
        View view)
        where T : ViewCell
    {
        self.View = view;
        return self;
    }
    
}
