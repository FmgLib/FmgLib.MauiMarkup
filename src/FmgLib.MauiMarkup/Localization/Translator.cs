using System.ComponentModel;
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
}

