namespace MyOrderApp.Views;

public abstract class BasePage<TViewModel> : ContentPage where TViewModel : BaseViewModel 
{
    protected BasePage(TViewModel viewModel, string title)
    {
        base.BindingContext = viewModel;
        Title = title;

        Build();
    }

    protected new TViewModel BindingContext => (TViewModel)base.BindingContext;

    public abstract void Build();

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        Build();
#if DEBUG
        HotReloadHandler.UpdateApplicationEvent += ReloadUI;
#endif
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        base.OnNavigatingFrom(args);
#if DEBUG
        HotReloadHandler.UpdateApplicationEvent += ReloadUI;
#endif
    }

    private void ReloadUI(Type[]? obj)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Build();
        });
    }
}
