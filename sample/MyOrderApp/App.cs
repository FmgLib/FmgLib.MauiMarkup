namespace MyOrderApp;

public partial class App : Application
{
    public static string AuthKey = string.Empty;

    public App(IServiceProvider services)
    {
        this
            .Resources(AppStyles.Default)
            .MainPage(services.GetService<AppShell>());

        TemplateData template = new TemplateData();
    }
}
