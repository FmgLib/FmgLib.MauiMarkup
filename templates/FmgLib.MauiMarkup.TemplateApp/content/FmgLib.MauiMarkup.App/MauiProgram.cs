using Microsoft.Extensions.Logging;

namespace FmgLib.MauiMarkup.App;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>()
< !--#if (!includeContent)-->
            .AddScoped<MainPage>()
< !--#endif-->
< !--#if (includeContent)-->
            .AddScoped<Samples.GettingStartedPage>()
            .AddScoped<Samples.Pages.DashboardPage>()
            .AddScoped<Samples.Pages.ProductsPage>()
            .AddScoped<Samples.Pages.AnimationsPage>()
< !--#endif-->
            ;

        return builder.Build();
    }
}
