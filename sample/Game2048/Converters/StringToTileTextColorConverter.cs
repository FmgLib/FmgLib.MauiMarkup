using System.Globalization;

namespace Game2048Maui.Converters;

public class StringToTileTextColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        int.TryParse(value.ToString(), out int parsedValue);
        switch (parsedValue)
        {
            case 0:
                return Color.FromArgb("#968269");
            case 2:
                return Color.FromArgb("#87755e");
            case 4:
                return Color.FromArgb("#5e4621");
            case 8:
                return Color.FromArgb("#746767");
            case 16:
                return Color.FromArgb("#877878");
            case 32:
                return Color.FromArgb("#f77e69");
            case 64:
                return Color.FromArgb("#f76148");
            case 128:
                return Color.FromArgb("#EBD69A");
            case 256:
                return Color.FromArgb("#e6ca7f");
            case 512:
                return Color.FromArgb("#ddb955");
            case 1024:
                return Color.FromArgb("#d5a72a");
            case 2048:
                return Color.FromArgb("#aa8622");
            case 4096:
            case 8192:
            case 16384:
                return Color.FromArgb("#EBD69A");
            default:
                return Color.FromArgb("#beafa0");
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (bool)value ? 1 : 0;
    }
}
