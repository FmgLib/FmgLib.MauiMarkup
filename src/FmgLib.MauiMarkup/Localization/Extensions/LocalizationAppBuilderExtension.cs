using System.Globalization;
using System.Resources;

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

    public static MauiAppBuilder UseMauiMarkupLocalizationWithResx(this MauiAppBuilder builder, ResourceManager resourceManager, string defaultLang = null)
    {
        TranslatorResx.ResourceManager = resourceManager;
        if (!string.IsNullOrEmpty(defaultLang))
            Translator.Instance.ChangeCulture(CultureInfo.GetCultureInfo(defaultLang));

        return builder;
    }
}
