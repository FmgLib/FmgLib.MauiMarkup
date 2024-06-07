namespace MyOrderApp.Views;

public partial class LoadingPage : BasePage<LoadingPageViewModel>
{
    public LoadingPage(LoadingPageViewModel viewModel) : base(viewModel, "Loading Page")
    {
    }

    public override void Build()
    {
        this
            .BackgroundImageSource("background.jpg")
            .Content(
                new StackLayout()
                .Center()
                .Children(
                    new ActivityIndicator()
                        .IsRunning(true)
                        .HeightRequest(70)
                        .WidthRequest(70)
                        .Center()
                        .InvokeOnElement(ai => ai.Loaded += (sender, e) =>
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
