namespace FmgLib.MauiMarkup;

public static partial class GestureElementExtension
{
    public static T GestureRecognizersFmg<T>(this T self,
        IList<IGestureRecognizer> gestureRecognizers)
        where T : GestureElement
    {
        foreach (var item in gestureRecognizers)
            self.GestureRecognizers.Add(item);
        return self;
    }

    public static T GestureRecognizersFmg<T>(this T self,
        params IGestureRecognizer[] gestureRecognizers)
        where T : GestureElement
    {
        foreach (var item in gestureRecognizers)
            self.GestureRecognizers.Add(item);
        return self;
    }
    
}