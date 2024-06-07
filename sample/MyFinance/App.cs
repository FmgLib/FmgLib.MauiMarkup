namespace MyFinance;

public partial class App : Application
{
    public static string CurrentUserId = string.Empty;
    public App(IServiceProvider services)
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(services.GetService<AppShell>());
    }
}
