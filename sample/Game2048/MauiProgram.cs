using Microsoft.Maui.LifecycleEvents;

namespace Game2048Maui;

[MauiMarkup(typeof(SKLottieView), typeof(SKFileLottieImageSource), typeof(SKAnimatedSurfaceView))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseSkiaSharp()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
                fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemibold");
                fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
            })
            .ConfigureLifecycleEvents(events =>
            {
#if ANDROID
              events.AddAndroid(android => android
                  .OnCreate((activity, bundle) => MakeStatusBarTranslucent(activity)));

              static void MakeStatusBarTranslucent(Android.App.Activity activity)
              {
                  activity.Window.SetFlags(Android.Views.WindowManagerFlags.LayoutNoLimits, Android.Views.WindowManagerFlags.LayoutNoLimits);

                  activity.Window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);

                  activity.Window.SetStatusBarColor(Android.Graphics.Color.Transparent);
              }
#endif
            });

        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddScopedWithShellRoute<MainPage,MainPageViewModel>("//MainPage");

        return builder.Build();
    }
}