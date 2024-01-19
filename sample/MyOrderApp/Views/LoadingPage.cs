namespace MyOrderApp.Views;

public partial class LoadingPage : BasePage<LoadingPageViewModel>
{
    public LoadingPage(LoadingPageViewModel viewModel) : base(viewModel, "Loading Page")
    {
    }

    public override void Build()
    {
        this
            .BackgroundImageSourceFmg("background.jpg")
            .ContentFmg(
                new StackLayout()
                .CenterFmg()
                .ChildrenFmg(
                    new ActivityIndicator()
                        .IsRunningFmg(true)
                        .HeightRequestFmg(70)
                        .WidthRequestFmg(70)
                        .CenterFmg()
                        .InvokeOnElementFmg(ai => ai.Loaded += (sender, e) =>
                        {
                            CheckLogin();
                        })
                    )
            );
    }

    private async void CheckLogin()
    {
        string authKey = Preferences.Get(nameof(App.AuthKey), string.Empty);

        if (string.IsNullOrEmpty(authKey))
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        else
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    }
}
