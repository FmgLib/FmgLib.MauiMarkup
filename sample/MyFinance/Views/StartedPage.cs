namespace MyFinance.Views;

public partial class StartedPage : FmgLibContentPage
{
    public override void Build()
    {
        bool skipStartedPage;
        var isStarted = SecureStorage.GetAsync("IsStarted").GetAwaiter().GetResult();
        if (!string.IsNullOrEmpty(isStarted) && bool.TryParse(isStarted, out skipStartedPage) && !skipStartedPage)
            skipStartedPage = true;
        else
            skipStartedPage = false;

        this
        .ShellNavBarIsVisible(false)
        .Behaviors(
            new StatusBarBehavior()
            .StatusBarColor(DeepSkyBlue)
        )
        .OnLoaded(async (sender, e) =>
        {
            if (skipStartedPage)
            {
                if (await CheckLogin())
                    await AppShell.Current.GoToAsync("//MainPage", true);
                else
                    await AppShell.Current.GoToAsync("//LoginPage", true);
            }
        })
        .Content(
            new Grid()
            .RowDefinitions(e => e.Star(1.2).Star(5).Star(3).Star(0.8))
            .RowSpacing(15)
            .Margin(20,15)
            .Children(
                new ActivityIndicator()
                .IsRunning(skipStartedPage)
                .IsVisible(skipStartedPage)
                .RowSpan(4)
                .Center()
                .SizeRequest(75, 75),

                new HorizontalStackLayout()
                .IsVisible(!skipStartedPage)
                .CenterHorizontal()
                .Spacing(5)
                .Margin(0,25,0,0)
                .Children(
                    new Label()
                    .Text("My")
                    .TextColor(DeepSkyBlue)
                    .FontSize(44)
                    .FontAttributes(Bold),

                    new Label()
                    .Text("FINANCE")
                    .TextColor(Black)
                    .FontSize(44)
                    .FontAttributes(Bold)
                ),

                new Image()
                .IsVisible(!skipStartedPage)
                .Source("getstarted")
                .SizeRequest(300,500)
                .Row(1),

                new VerticalStackLayout()
                .IsVisible(!skipStartedPage)
                .Spacing(10)
                .Row(2)
                .Children(
                    new Label()
                    .Text("New age of the financial structure")
                    .TextColor(DeepSkyBlue)
                    .FontSize(34)
                    .FontAttributes(Bold),

                    new Label()
                    .Text("Start exploring the crypto world now with our app it's easy and secure")
                    .TextColor(Black)
                    .FontAttributes(Italic)
                    .FontSize(16)
                ),

                new Button()
                .IsVisible(!skipStartedPage)
                .Text("Get started")
                .BackgroundColor(DeepSkyBlue)
                .TextColor(Black)
                .FontSize(16)
                .Row(3)
                .OnClicked(async (sender,arg) =>
                {
                    await SecureStorage.SetAsync("IsStarted", "false");
                    await AppShell.Current.GoToAsync("//LoginPage", true);
                })
            )
        );
    }

    private async Task<bool> CheckLogin()
    {
        var auth = await SecureStorage.GetAsync("USERAUTH");

        if (string.IsNullOrEmpty(auth))
            return false;

        var info = AuthCheckHelper.ParseBasicAuthToken(auth);
        if (info.Item3.Value.Date < DateTime.Now.Date)
        {
            SecureStorage.Remove("USERAUTH");
            Preferences.Remove(nameof(App.CurrentUserId));

            return false;
        }

        Preferences.Set(nameof(App.CurrentUserId), info.Item4.ToString());

        return true;
    }
}
