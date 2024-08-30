namespace FmgLib.MauiMarkup;

public static partial class ToolTipPropertiesExtension
{
    public static T ToolTipPropertiesText<T>(this T view, string text) where T : View
    {
        ToolTipProperties.SetText(view, text);

        return view;
    }
}
