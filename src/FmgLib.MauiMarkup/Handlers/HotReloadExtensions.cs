using System.Diagnostics;

namespace FmgLib.MauiMarkup;

public static class HotReloadExtensions
{
    public static TPage InitializeHotReload<TPage>(this TPage page) where TPage : IFmgLibHotReload
    {
        page.Build();

        if (Debugger.IsAttached)
        {
            FmgLibHotReloadHandler.UpdateApplicationEvent += (types) =>
            {
                if (types == null || types.Contains(page.GetType()))
                {
                    MainThread.BeginInvokeOnMainThread(page.Build);
                }
            };
        }

        return page;
    }
}