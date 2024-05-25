namespace FmgLib.MauiMarkup;

public static partial class GestureElementExtension
{
    public static T GestureRecognizers<T>(this T self,
        IList<IGestureRecognizer> gestureRecognizers)
        where T : GestureElement
    {
        foreach (var item in gestureRecognizers)
            self.GestureRecognizers.Add(item);
        return self;
    }

    public static T GestureRecognizers<T>(this T self,
        params IGestureRecognizer[] gestureRecognizers)
        where T : GestureElement
    {
        foreach (var item in gestureRecognizers)
            self.GestureRecognizers.Add(item);
        return self;
    }

    public static T GestureRecognizers<T>(this T self,
        Func<IGestureRecognizer[]> configure)
        where T : GestureElement
    {
        var gestureRecognizers = configure();
        foreach (var item in gestureRecognizers)
            self.GestureRecognizers.Add(item);
        return self;
    }
    
}