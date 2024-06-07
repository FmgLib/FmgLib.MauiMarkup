using System.Globalization;

namespace MyFinance.Utilities;

public static class DateTimeHelper
{
    public static IList<string> GetDayNames(IList<DateTime> dates)
    {
        List<string> dayNames = new List<string>();
        var culture = new CultureInfo("tr-TR");

        foreach (var date in dates)
        {
            try
            {
                DateTime dateTime = new DateTime(date.Year, date.Month, date.Day);
                string dayName = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
                dayNames.Add(dayName);
            }
            catch (ArgumentOutOfRangeException)
            {
                dayNames.Add("Invalid day");
            }
        }

        return dayNames;
    }

    public static IList<string> GetMonthNames(IList<DateTime> dates)
    {
        List<string> monthNames = new List<string>();
        var culture = new CultureInfo("tr-TR");

        foreach (var date in dates)
        {
            try
            {
                DateTime dateTime = new DateTime(date.Year, date.Month, 1);
                string monthName = culture.DateTimeFormat.GetMonthName(date.Month);
                monthNames.Add(monthName);
            }
            catch (ArgumentOutOfRangeException)
            {
                monthNames.Add("Invalid day");
            }
        }

        return monthNames;
    }
}
