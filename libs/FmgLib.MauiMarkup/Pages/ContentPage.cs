namespace FmgLib.MauiMarkup;

public abstract class FmgLibContentPage : ContentPage, IFmgLibHotReload
{
    protected FmgLibContentPage()
    {
        FmgLibHotReloadHandler.UpdateApplicationEvent += ReloadUI;
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
        FmgLibHotReloadHandler.UpdateApplicationEvent += ReloadUI;
        Build();
    }
}
