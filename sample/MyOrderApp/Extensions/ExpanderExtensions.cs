using SkiaSharp.Extended.UI.Controls;

namespace MyOrderApp.Extensions;

public static class ExpanderExtensions
{
    public static T HeaderFmg<T>(this T item, IView content) where T : Expander
    {
        item.SetValue(Expander.HeaderProperty, content);

        return item;
    }

    public static T ContentsFmg<T>(this T item, IView content) where T : Expander
    {
        item.SetValue(Expander.ContentProperty, content);

        return item;
    }

    public static T IsExpandedFmg<T>(this T item, bool isExpanded) where T : Expander
    {
        item.SetValue(Expander.IsExpandedProperty, isExpanded);

        return item;
    }

    public static T SKSourceFmg<T>(this T item, object source) where T : SKLottieView
    {
        item.SetValue(SKLottieView.SourceProperty, source);

        return item;
    }

    public static T RepeatCountFmg<T>(this T item, int count) where T : SKLottieView
    {
        item.SetValue(SKLottieView.RepeatCountProperty, count);

        return item;
    }
}
