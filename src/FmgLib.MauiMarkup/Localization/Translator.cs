using System.ComponentModel;
using System.Globalization;
using FmgLib.MauiMarkup.Localization;

namespace FmgLib.MauiMarkup;

public class Translator : BaseTranslator, INotifyPropertyChanged
{
    public static Translator Instance { get; set; } = new Translator();

    public string this[string key]
    {
        get
        {
            return LocalizationData.Data.GetTranslation(key, CurrentCulture.Name);
        }
    }

    public string TranslateString(string key, CultureInfo culture)
    {
        return LocalizationData.Data.GetTranslation(key, culture.Name);
    }
}

