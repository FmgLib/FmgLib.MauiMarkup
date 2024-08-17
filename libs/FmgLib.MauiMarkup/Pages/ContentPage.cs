using System.Diagnostics;

namespace FmgLib.MauiMarkup;

public abstract class FmgLibContentPage : ContentPage, IFmgLibHotReload
{
    protected FmgLibContentPage()
    {
        if (Debugger.IsAttached)
        {
            FmgLibHotReloadHandler.UpdateApplicationEvent += ReloadUI;
        }

        Build();
    }

    public abstract void Build();

    protected void ReloadUI(Type[]? obj)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Build();
        });
    }
}

public abstract class FmgLibContentPage<TViewModel> : FmgLibContentPage, IFmgLibHotReload
{
    protected new TViewModel BindingContext => (TViewModel)base.BindingContext;

    protected FmgLibContentPage(TViewModel viewModel)
    {
        base.BindingContext = viewModel;

        if (Debugger.IsAttached)
        {
            FmgLibHotReloadHandler.UpdateApplicationEvent += ReloadUI;
        }

        Build();
    }
}
