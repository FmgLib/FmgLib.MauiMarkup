namespace FmgLib.MauiMarkup;

public static class PublicExtension
{
    public static T Assign<T>(this T self, out T obj) where T : BindableObject
    {
        obj = self;
        return obj;
    }

    public static T InvokeOnElement<T>(this T self, Action<T> action) where T : BindableObject
    {
        action(self);
        return self;
    }
}
