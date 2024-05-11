namespace FmgLib.MauiMarkup;

public abstract class FmgLibContentPage : ContentPage, IFmgLibHotReload
{
    protected FmgLibContentPage()
    {
        Build();
        FmgLibHotReloadHandler.UpdateApplicationEvent += ReloadUI;
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
        Build();
        base.BindingContext = viewModel;
        FmgLibHotReloadHandler.UpdateApplicationEvent += ReloadUI;
    }
}
