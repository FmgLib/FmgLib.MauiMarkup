using Microsoft.Maui.Controls;
using Microsoft.Maui.LifecycleEvents;
using System.Diagnostics;

namespace FruitApp;

public partial class App : Application
{
    public App()
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(new MainPage());
    }
}

public static class HotReloadExtensions
{
    public static void EnableGlobalHotReload()
    {
        if (Debugger.IsAttached)
        {
            FmgLibHotReloadHandler.UpdateApplicationEvent += (types) =>
            {
                var mainPage = Application.Current.MainPage;

                if (mainPage is Shell shell)
                {
                    var currentPage = shell.CurrentPage;
                    if (currentPage != null && (types == null || types.Contains(currentPage.GetType())))
                    {
                        MainThread.BeginInvokeOnMainThread(() => FmgLibHotReloadHandler.InvokeBuildIfExists(currentPage));
                    }
                }
                else if (mainPage is NavigationPage navigationPage)
                {
                    foreach (var page in navigationPage.Navigation.NavigationStack)
                    {
                        if (types == null || types.Contains(page.GetType()))
                        {
                            MainThread.BeginInvokeOnMainThread(() => FmgLibHotReloadHandler.InvokeBuildIfExists(page));
                        }
                    }
                }
                else if (mainPage is FlyoutPage flyoutPage)
                {
                    var detailPage = flyoutPage.Detail;
                    if (detailPage != null && (types == null || types.Contains(detailPage.GetType())))
                    {
                        MainThread.BeginInvokeOnMainThread(() => FmgLibHotReloadHandler.InvokeBuildIfExists(detailPage));
                    }
                }
                else if (mainPage is TabbedPage tabbedPage)
                {
                    foreach (var tab in tabbedPage.Children)
                    {
                        if (types == null || types.Contains(tab.GetType()))
                        {
                            MainThread.BeginInvokeOnMainThread(() => FmgLibHotReloadHandler.InvokeBuildIfExists(tab));
                        }
                    }
                }
                else if (mainPage is ContentPage contentPage)
                {
                    if (types == null || types.Contains(contentPage.GetType()))
                    {
                        MainThread.BeginInvokeOnMainThread(() => FmgLibHotReloadHandler.InvokeBuildIfExists(contentPage));
                    }
                }
                else if (mainPage is Page page)
                {
                    if (types == null || types.Contains(page.GetType()))
                    {
                        MainThread.BeginInvokeOnMainThread(() => FmgLibHotReloadHandler.InvokeBuildIfExists(page));
                    }
                }
            };
        }
    }

    public static void InitializeBuildForAllPages(this Application app)
    {
        var mainPage = app.MainPage;

        if (mainPage is Shell shell)
        {
            var currentPage = shell.CurrentPage;
            var buildMethod = currentPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(currentPage, null);
            }
        }
        else if (mainPage is NavigationPage navigationPage)
        {
            foreach (var page in navigationPage.Navigation.NavigationStack)
            {
                var buildMethod = page.GetType().GetMethod("Build");
                if (buildMethod != null)
                {
                    buildMethod.Invoke(page, null);
                }
            }
        }
        else if (mainPage is FlyoutPage flyoutPage)
        {
            var detailPage = flyoutPage.Detail;
            var buildMethod = detailPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(detailPage, null);
            }
        }
        else if (mainPage is TabbedPage tabbedPage)
        {
            foreach (var tab in tabbedPage.Children)
            {
                var buildMethod = tab.GetType().GetMethod("Build");
                if (buildMethod != null)
                {
                    buildMethod.Invoke(tab, null);
                }
            }
        }
        else if (mainPage is ContentPage contentPage)
        {
            var buildMethod = mainPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(mainPage, null);
            }
        }
        else if (mainPage is Page page)
        {
            var buildMethod = mainPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(mainPage, null);
            }
        }
    }

    public static MauiApp InitializeBuilds(this MauiApp app)
    {
        var mainPage = app.Services.GetService<Application>()?.MainPage;

        if (mainPage is Shell shell)
        {
            var currentPage = shell.CurrentPage;
            var buildMethod = currentPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(currentPage, null);
            }
        }
        else if (mainPage is NavigationPage navigationPage)
        {
            foreach (var page in navigationPage.Navigation.NavigationStack)
            {
                var buildMethod = page.GetType().GetMethod("Build");
                if (buildMethod != null)
                {
                    buildMethod.Invoke(page, null);
                }
            }
        }
        else if (mainPage is FlyoutPage flyoutPage)
        {
            var detailPage = flyoutPage.Detail;
            var buildMethod = detailPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(detailPage, null);
            }
        }
        else if (mainPage is TabbedPage tabbedPage)
        {
            foreach (var tab in tabbedPage.Children)
            {
                var buildMethod = tab.GetType().GetMethod("Build");
                if (buildMethod != null)
                {
                    buildMethod.Invoke(tab, null);
                }
            }
        }
        else if (mainPage is ContentPage contentPage)
        {
            var buildMethod = mainPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(mainPage, null);
            }
        }
        else if (mainPage is Page page)
        {
            var buildMethod = mainPage.GetType().GetMethod("Build");
            if (buildMethod != null)
            {
                buildMethod.Invoke(mainPage, null);
            }
        }

        return app;
    }

    public static void InitializeHotReloadForAllPages(this Application app)
    {
        app.InitializeBuildForAllPages();
        app.OnPageAppearing((sender, e) =>
        {
            FmgLibHotReloadHandler.InvokeBuildIfExists(e);
        });
    }

    public static MauiAppBuilder UseFmgLibMauiMarkup(this MauiAppBuilder builder, bool enableHotReload = false)
    {
        if (enableHotReload)
        {
            if (Debugger.IsAttached)
            {
                builder.ConfigureLifecycleEvents(events =>
                {
#if __ANDROID__
                events.AddAndroid(android => android.OnCreate((activity, bundle) =>
                {
                    Application.Current?.InitializeHotReloadForAllPages();
                    HotReloadExtensions.EnableGlobalHotReload();
                }));
#elif __IOS__ || MACCATALYST
                events.AddiOS(ios => ios.FinishedLaunching((app, options) =>
                {
                    Application.Current?.InitializeHotReloadForAllPages();
                    HotReloadExtensions.EnableGlobalHotReload();
                    return true;
                }));
#elif WINDOWS
                    events.AddWindows(windows => windows.OnLaunched((app, args) =>
                    {
                        Application.Current?.InitializeHotReloadForAllPages();
                        HotReloadExtensions.EnableGlobalHotReload();
                    }));
#endif

                });
            }
        }
        else
        {
            //builder.Build().InitializeBuilds();
        }

        return builder;
    }
}
