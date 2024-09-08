using System.ComponentModel;
using System.Globalization;

namespace FmgLib.MauiMarkup;

public class Translator : INotifyPropertyChanged
{
    public CultureInfo CurrentCulture { get; private set; } = CultureInfo.CurrentCulture;

    public static Translator Instance { get; set; } = new Translator();

    public string this[string key]
    {
        get
        {
            return LocalizationData.Data.GetTranslation(key, CurrentCulture.Name);
        }
    }

    public void ChangeCulture(CultureInfo culture)
    {
        CurrentCulture = culture;
        OnPropertyChanged();
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    public void OnPropertyChanged()
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
    }
}

