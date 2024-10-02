using Microsoft.Extensions.Logging;

namespace DalluiApp;

[MauiMarkup(typeof(CoverFlowView), typeof(CardsView), typeof(SKLottieView), typeof(SKAnimatedSurfaceView), typeof(SKFileLottieImageSource))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseCardsView()
            .UseSkiaSharp()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Nexa-ExtraLight.ttf", "NexaLight");
                fonts.AddFont("Nexa-Heavy.ttf", "NexaHeavy");
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>()
            .AddScoped<DashboardView>()
            .AddScoped<GenerationOptionsView>()
            .AddScoped<ImageGeneratorView>();

        return builder.Build();
    }
}
