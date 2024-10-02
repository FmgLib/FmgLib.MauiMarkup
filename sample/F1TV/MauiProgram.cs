using Microsoft.Extensions.Logging;

namespace F1TV;

[MauiMarkup(typeof(StatusBarBehavior))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("materialdesignicons-webfont.ttf", "IconFontTypes");
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>()
            .AddScoped<MainPage>();

        return builder.Build();
    }
}
