using System.Globalization;

namespace FmgLib.MauiMarkup;

public static class TranslateExtension
{
    public static string ToTranslate(this string key)
    {
        return Translator.Instance[key];
    }

    public static string ToTranslate(this string key, string cultureName)
    {
        return Translator.Instance.TranslateString(key, CultureInfo.GetCultureInfo(cultureName));
    }


    public static string ToTranslateResx(this string key)
    {
        return TranslatorResx.Instance[key];
    }

    public static string ToTranslateResx(this string key, string cultureName)
    {
        return TranslatorResx.Instance.TranslateString(key, CultureInfo.GetCultureInfo(cultureName));
    }
}