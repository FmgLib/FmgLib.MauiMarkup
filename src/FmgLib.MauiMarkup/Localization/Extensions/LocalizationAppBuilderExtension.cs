using System.Globalization;

namespace FmgLib.MauiMarkup;

public static class LocalizationAppBuilderExtension
{
    public static MauiAppBuilder UseMauiMarkupLocalization(this MauiAppBuilder builder, string defaultLang = null, params string[] filePaths)
    {
        _ = JsonLocalizationExtensions.LoadLocalizationDataAsync(filePaths);
        if (!string.IsNullOrEmpty(defaultLang))
            Translator.Instance.ChangeCulture(CultureInfo.GetCultureInfo(defaultLang));

        return builder;
    }
}
