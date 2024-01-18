namespace FmgLib.MauiMarkup;

public static class PublicExtension
{
    public static T AssignFmg<T>(this T self, out T obj) where T : Element
    {
        obj = self;
        return obj;
    }

    public static T InvokeOnElementFmg<T>(this T self, Action<T> action) where T : Element
    {
        action(self);
        return self;
    }
}
