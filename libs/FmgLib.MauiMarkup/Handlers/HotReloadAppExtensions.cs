using Microsoft.Maui.LifecycleEvents;
using System.Reflection;

namespace FmgLib.MauiMarkup;

public static class HotReloadAppExtensions
{
    public static MauiAppBuilder UseFmgLibHotReload(this MauiAppBuilder builder)
    {
        builder.ConfigureLifecycleEvents(events =>
        {
            events.AddEvent<Action<string>>(nameof(Application.MainPage), _ =>
            {
                RegisterHotReloadForPages();
            });
        });

        return builder;
    }

    private static void RegisterHotReloadForPages()
    {
        var reloadablePages = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => typeof(IFmgLibHotReload).IsAssignableFrom(t) && !t.IsAbstract && t.IsSubclassOf(typeof(Page)))
            .ToList();

        foreach (var pageType in reloadablePages)
        {
            if (Activator.CreateInstance(pageType) is IFmgLibHotReload reloadablePage)
            {
                reloadablePage.InitializeHotReload();
            }
        }
    }
}
