using System.ComponentModel;
using System.Globalization;

namespace FmgLib.MauiMarkup.Localization;

public abstract class BaseTranslator : INotifyPropertyChanged
{
    public CultureInfo CurrentCulture { get; private set; } = CultureInfo.CurrentCulture;

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
