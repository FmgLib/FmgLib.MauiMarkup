using System.Collections;

namespace FmgLib.MauiMarkup.Core;

public static partial class IEnumerableExtension
{
    public static void AddFmg<T>(this T self, Func<T, T> configure)
        where T : BindableObject, IEnumerable
    {
        configure(self);
    }

    public static void AddFmg<T>(this T self, Action<T> configure)
        where T : Layout, IEnumerable
    {
        configure(self);
    }
}
