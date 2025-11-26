using System.Collections.ObjectModel;
using FmgLib.MauiMarkup.App.Samples.Models;

namespace FmgLib.MauiMarkup.App.Samples.ViewModels;

public class DashboardViewModel : BaseViewModel
{
    public DashboardViewModel()
    {
        Title = "Dashboard";
        LoadDashboardData();
    }

    public ObservableCollection<DashboardCard> Cards { get; } = new();

    private void LoadDashboardData()
    {
        Cards.Clear();
        
        Cards.Add(new DashboardCard
        {
            Title = "Total Sales",
            Value = "$24,5K",
            Icon = "💰",
            BackgroundColor = "#6366F1".ToColor(),
            TextColor = Colors.White,
            Trend = "+12.5%",
            IsPositiveTrend = true
        });

        Cards.Add(new DashboardCard
        {
            Title = "New Orders",
            Value = "243",
            Icon = "📦",
            BackgroundColor = "#8B5CF6".ToColor(),
            TextColor = Colors.White,
            Trend = "+8.2%",
            IsPositiveTrend = true
        });

        Cards.Add(new DashboardCard
        {
            Title = "Active Users",
            Value = "1,234",
            Icon = "👥",
            BackgroundColor = "#EC4899".ToColor(),
            TextColor = Colors.White,
            Trend = "+15.3%",
            IsPositiveTrend = true
        });

        Cards.Add(new DashboardCard
        {
            Title = "Revenue",
            Value = "$12.8K",
            Icon = "📈",
            BackgroundColor = "#F59E0B".ToColor(),
            TextColor = Colors.White,
            Trend = "-2.4%",
            IsPositiveTrend = false
        });
    }
}
