namespace FmgLib.MauiMarkup.App.Samples.Models;

public class DashboardCard
{
    public string Title { get; set; } = string.Empty;
    public string Value { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
    public Color BackgroundColor { get; set; } = Colors.Blue;
    public Color TextColor { get; set; } = Colors.White;
    public string Trend { get; set; } = string.Empty;
    public bool IsPositiveTrend { get; set; }
}
