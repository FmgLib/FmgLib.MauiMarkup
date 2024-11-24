using System.ComponentModel;
using System.Resources;
using FmgLib.MauiMarkup.Localization;

namespace FmgLib.MauiMarkup;

public class TranslatorResx : BaseTranslator, INotifyPropertyChanged
{
    internal static ResourceManager ResourceManager { get; set; }

    public static TranslatorResx Instance { get; set; } = new TranslatorResx();

    public string this[string key]
    {
        get
        {
            return ResourceManager.GetString(key, CurrentCulture);
        }
    }
}
