using Microsoft.Extensions.Logging;

namespace FruitApp;

[MauiMarkup(typeof(AcrylicView))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseAcrylicView()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Roboto-Bold.ttf", "Bold");
                fonts.AddFont("Roboto-Regular.ttf", "Regular");
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddScoped<MainPage>();

        return builder.Build();
    }
}
