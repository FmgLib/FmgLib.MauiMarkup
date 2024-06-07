using System.Globalization;

namespace MyOrderApp.Converters;

public class BoolToFavoriteImageConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var data = (bool)value;

        return data ? "favorite.png" : "not_favorite.png";
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
