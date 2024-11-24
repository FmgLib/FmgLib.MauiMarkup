using MyMauiMarkupApp.Resources;

namespace MyMauiMarkupApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiMarkupLocalization("en-US")
            .UseMauiMarkupLocalizationWithResx(AppResources.ResourceManager, "en-US")
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });


        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>()
            .AddScoped<MainPage>();

        return builder.Build();
    }
}
