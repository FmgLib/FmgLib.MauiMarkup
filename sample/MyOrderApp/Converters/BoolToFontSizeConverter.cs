using System.Globalization;

namespace MyOrderApp.Converters;

public class BoolToFontSizeConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var data = (bool)value;

        return data ? 10 : 12;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
