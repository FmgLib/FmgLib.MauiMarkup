using System.Reflection;
using Microsoft.Maui.Graphics;

namespace FmgLib.MauiMarkup.App.Samples;

public partial class GettingStartedPage : ContentPage, IFmgLibHotReload
{
    public GettingStartedPage()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        var accent = AppColors.Primary;
        var secondary = Colors.DarkSlateBlue;

        this
        .Content(
            new ScrollView()
            .Content(
                new VerticalStackLayout()
                .Spacing(22)
                .Padding(16, 20)
                .Children(
                    new Label()
                    .Text("Welcome to FmgLib MauiMarkup")
                    .FontSize(30)
                    .FontAttributes(Bold)
                    .TextColor(accent)
                    .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                    new Label()
                    .Text("Hands-on sample showing .NET 10 MAUI controls and fluent C# markup.")
                    .FontSize(16)
                    .TextColor(Colors.DarkGray),

                    new Grid()
                    .ColumnDefinitions(e => e.Star().Star())
                    .RowDefinitions(e => e.Auto().Auto())
                    .Children(
                        Card("dotnet", version ?? "n/a", Colors.White, secondary).Row(0).Column(0),
                        Card("Markup", "Fluent C# UI, no XAML", Colors.White, accent).Row(0).Column(1),
                        Card("Templates", "Pick .NET 9 or 10 + content", Colors.White, Colors.Teal).Row(1).Column(0),
                        Card("Controls", "New SearchBar/Picker/HybridWebView APIs", Colors.White, Colors.OrangeRed).Row(1).Column(1)
                    ),

                    ControlsGallery(accent),

                    new Border()
                    .Stroke(Colors.LightGray)
                    .StrokeThickness(1)
                    .Padding(12)
                    .Content(
                        new VerticalStackLayout()
                        .Spacing(6)
                        .Children(
                            new Label().Text("Tips").FontAttributes(Bold),
                            new Label().Text("• Use Picker.Open()/Close() to control dropdown programmatically."),
                            new Label().Text("• RefreshView.IsRefreshEnabled toggles pull-to-refresh without disabling content."),
                            new Label().Text("• HybridWebView adds WebViewInitializing/WebViewInitialized hooks.")
                        )
                    )
                )
            )
        );
    }

    Border Card(string title, string subtitle, Color background, Color accent)
    {
        return new Border()
        .Stroke(accent)
        .StrokeThickness(1.5)
        .Background(background)
        .Padding(12)
        .Content(
            new VerticalStackLayout()
            .Spacing(6)
            .Children(
                new Label().Text(title).FontAttributes(Bold).TextColor(accent),
                new Label().Text(subtitle).TextColor(Colors.DimGray).FontSize(13)
            )
        );
    }

    View ControlsGallery(Color accent)
    {
        Picker themePicker = null;
        RefreshView refreshView = null;
        HybridWebView hybrid = null;

        return new Border()
        .Stroke(Colors.LightGray)
        .StrokeThickness(1)
        .Padding(14)
        .Content(
            new VerticalStackLayout()
            .Spacing(14)
            .Children(
                new Label().Text("Controls gallery").FontAttributes(Bold).FontSize(18),

                new VerticalStackLayout()
                .Spacing(6)
                .Children(
                    new Label().Text("Picker (programmatic open/close)").TextColor(Colors.DarkSlateGray),
                    new HorizontalStackLayout()
                    .Spacing(8)
                    .Children(
                        new Picker()
                        .Title("Choose theme")
                        .ItemsSource(new[] { "System", "Light", "Dark" })
                        .SelectedIndex(0)
                        .Assign(out themePicker),
                        new Button().Text("Open").OnClicked((s, e) => themePicker.Open()),
                        new Button().Text("Close").OnClicked((s, e) => themePicker.Close())
                    )
                ),

                new VerticalStackLayout()
                .Spacing(6)
                .Children(
                    new Label().Text("RefreshView (enable/disable)").TextColor(Colors.DarkSlateGray),
                    new RefreshView()
                    .IsRefreshEnabled(true)
                    .Content(
                        new StackLayout()
                        .Spacing(4)
                        .Children(
                            new Label().Text("Pull to refresh is enabled").TextColor(accent),
                            new Label().Text("Toggle to simulate read-only mode.")
                        )
                    )
                    .Assign(out refreshView),
                    new Switch().OffColor(Colors.Gray).OnToggled((s, e) => refreshView.IsRefreshEnabled = e.Value).IsToggled(true)
                ),

                new VerticalStackLayout()
                .Spacing(6)
                .Children(
                    new Label().Text("HybridWebView (init events)").TextColor(Colors.DarkSlateGray),
                    new HybridWebView()
                    .HybridRoot("wwwroot")
                    .OnWebViewInitializing((webview, args) => Console.WriteLine("Initializing HybridWebView"))
                    .OnWebViewInitialized((webview, args) => Console.WriteLine("HybridWebView initialized"))
                    .Assign(out hybrid),
                    new Label().Text("Exceptions from JS bubble to .NET in .NET 10").FontSize(12).TextColor(Colors.DimGray)
                ),

                new VerticalStackLayout()
                .Spacing(6)
                .Children(
                    new Label().Text("SearchBar (SearchIconColor + ReturnType)").TextColor(Colors.DarkSlateGray),
                    new SearchBar()
                    .Placeholder("Try searching")
                    .SearchIconColor(accent)
                    .ReturnType(ReturnType.Search)
                    .SearchCommand(new Command(() => Console.WriteLine("Search executed"))),
                    new Label().Text("Keyboard helpers: SearchHandler.ShowSoftInputAsync() and HideSoftInputAsync().").FontSize(12).TextColor(Colors.DimGray)
                )
            )
        );
    }
}
