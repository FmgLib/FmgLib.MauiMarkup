using FmgLib.MauiMarkup.App.Samples.Models;
using FmgLib.MauiMarkup.App.Samples.ViewModels;
using Microsoft.Maui.Controls.Shapes;

namespace FmgLib.MauiMarkup.App.Samples.Pages;

public partial class DashboardPage : ContentPage, IFmgLibHotReload
{
    private readonly DashboardViewModel _viewModel;

    public DashboardPage()
    {
        _viewModel = new DashboardViewModel();
        BindingContext = _viewModel;
        
        this.InitializeHotReload();
    }

    public void Build()
    {
        this
        .Title("Dashboard")
        .Content(
            new ScrollView()
            .Content(
                new VerticalStackLayout()
                .Padding(20)
                .Spacing(24)
                .Children(
                    // Header Section
                    new VerticalStackLayout()
                    .Spacing(8)
                    .Children(
                        new Label()
                        .Text("Welcome back! 👋")
                        .FontSize(28)
                        .FontAttributes(Bold)
                        .TextColor("#1A1A1A".ToColor()),

                        new Label()
                        .Text(DateTime.Now.ToString("MMMM dd, yyyy"))
                        .FontSize(14)
                        .TextColor(Colors.Gray)
                    ),

                    // Stats Cards Grid
                    new Grid()
                    .RowDefinitions(e => e.Auto().Auto())
                    .ColumnDefinitions(e => e.Star().Star())
                    .RowSpacing(16)
                    .ColumnSpacing(16)
                    .Children(
                        StatsCardWithGradient("Total Sales", "$24.5K", "💰", "#6366F1", "#8B5CF6", "+12.5%", true).Row(0).Column(0),
                        StatsCardWithGradient("New Orders", "243", "📦", "#8B5CF6", "#EC4899", "+8.2%", true).Row(0).Column(1),
                        StatsCardWithGradient("Active Users", "1,234", "👥", "#EC4899", "#F59E0B", "+15.3%", true).Row(1).Column(0),
                        StatsCardWithGradient("Revenue", "$12.8K", "📈", "#F59E0B", "#EF4444", "-2.4%", false).Row(1).Column(1)
                    ),

                    // Recent Activity Section
                    new VerticalStackLayout()
                    .Spacing(12)
                    .Children(
                        new Label()
                        .Text("Recent Activity")
                        .FontSize(20)
                        .FontAttributes(Bold)
                        .TextColor("#1A1A1A".ToColor()),

                        ActivityItem("🎉", "New user registered", "2 minutes ago", "#6366F1"),
                        ActivityItem("💳", "Payment received", "15 minutes ago", "#10B981"),
                        ActivityItem("📊", "Report generated", "1 hour ago", "#F59E0B"),
                        ActivityItem("🔔", "New notification", "2 hours ago", "#8B5CF6")
                    ),

                    // Quick Actions
                    new VerticalStackLayout()
                    .Spacing(12)
                    .Children(
                        new Label()
                        .Text("Quick Actions")
                        .FontSize(20)
                        .FontAttributes(Bold)
                        .TextColor("#1A1A1A".ToColor()),

                        new Grid()
                        .ColumnDefinitions(e => e.Star().Star().Star())
                        .ColumnSpacing(12)
                        .Children(
                            QuickActionButton("➕\nAdd", "#6366F1").Column(0),
                            QuickActionButton("📤\nExport", "#8B5CF6").Column(1),
                            QuickActionButton("📊\nReport", "#EC4899").Column(2)
                        )
                    )
                )
            )
        );
    }

    private Border StatsCardWithGradient(string title, string value, string icon, string colorStart, string colorEnd, string trend, bool isPositive)
    {
        return new Border()
            .StrokeThickness(0)
            .StrokeShape(new RoundRectangle().CornerRadius(20))
            .HeightRequest(140)
            .Background(new LinearGradientBrush()
                .StartPoint(new Point(0, 0))
                .EndPoint(new Point(1, 1))
                .GradientStops(
                    new GradientStop().Color(colorStart.ToColor()).Offset(0),
                    new GradientStop().Color(colorEnd.ToColor()).Offset(1)
                )
            )
            .Shadow(new Shadow()
                .Brush(new SolidColorBrush($"#40{colorStart.TrimStart('#')}".ToColor()))
                .Offset(new Point(0, 4))
                .Radius(12)
            )
            .Content(
                new Grid()
                .Padding(16)
                .RowDefinitions(e => e.Auto().Star().Auto())
                .Children(
                    // Icon
                    new Label()
                    .Row(0)
                    .Text(icon)
                    .FontSize(32),

                    // Value
                    new Label()
                    .Row(1)
                    .Text(value)
                    .FontSize(28)
                    .FontAttributes(Bold)
                    .TextColor(Colors.White)
                    .CenterVertical(),

                    // Title and Trend
                    new Grid()
                    .Row(2)
                    .ColumnDefinitions(e => e.Star().Auto())
                    .Children(
                        new Label()
                        .Column(0)
                        .Text(title)
                        .FontSize(13)
                        .TextColor("#F0F0F0".ToColor()),

                        new Border()
                        .Column(1)
                        .Padding(6, 2)
                        .StrokeThickness(0)
                        .BackgroundColor("#40FFFFFF".ToColor())
                        .StrokeShape(new RoundRectangle().CornerRadius(8))
                        .Content(
                            new Label()
                            .Text($"{(isPositive ? "↗" : "↘")} {trend}")
                            .FontSize(11)
                            .FontAttributes(Bold)
                            .TextColor(Colors.White)
                        )
                    )
                )
            );
    }

    private Border ActivityItem(string icon, string title, string time, string accentColor)
    {
        return new Border()
            .Padding(16)
            .StrokeThickness(1)
            .Stroke("#F0F0F0".ToColor())
            .BackgroundColor(Colors.White)
            .StrokeShape(new RoundRectangle().CornerRadius(12))
            .Content(
                new Grid()
                .ColumnDefinitions(e => e.Auto().Star().Auto())
                .ColumnSpacing(12)
                .Children(
                    new Border()
                    .Column(0)
                    .WidthRequest(40).HeightRequest(40)
                    .BackgroundColor($"{accentColor}20".ToColor())
                    .StrokeThickness(0)
                    .StrokeShape(new RoundRectangle().CornerRadius(10))
                    .Content(
                        new Label()
                        .Text(icon)
                        .FontSize(20)
                        .Center()
                    ),

                    new VerticalStackLayout()
                    .Column(1)
                    .Spacing(4)
                    .CenterVertical()
                    .Children(
                        new Label()
                        .Text(title)
                        .FontSize(14)
                        .FontAttributes(Bold)
                        .TextColor("#1A1A1A".ToColor()),

                        new Label()
                        .Text(time)
                        .FontSize(12)
                        .TextColor(Colors.Gray)
                    ),

                    new Label()
                    .Column(2)
                    .Text("→")
                    .FontSize(20)
                    .TextColor(Colors.LightGray)
                    .CenterVertical()
                )
            );
    }

    private Border QuickActionButton(string text, string colorHex)
    {
        return new Border()
            .StrokeThickness(0)
            .BackgroundColor(colorHex.ToColor())
            .StrokeShape(new RoundRectangle().CornerRadius(12))
            .HeightRequest(80)
            .Shadow(new Shadow()
                .Brush(new SolidColorBrush($"#40{colorHex.TrimStart('#')}".ToColor()))
                .Offset(new Point(0, 4))
                .Radius(8)
            )
            .Content(
                new Label()
                .Text(text)
                .FontSize(16)
                .FontAttributes(Bold)
                .TextColor(Colors.White)
                .Center()
                .HorizontalTextAlignment(TextAlignment.Center)
            );
    }
}
