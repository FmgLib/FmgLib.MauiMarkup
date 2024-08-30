namespace FmgLib.MauiMarkup.Core;

public static class ColorExtension
{
    public static Color ToColorFromArgb(this string code)
        => Color.FromArgb(code);

    public static Color ToColorFromRgba(this string code)
        => Color.FromRgba(code);

    public static Color ToColor(this string code)
        => Color.Parse(code);
}
