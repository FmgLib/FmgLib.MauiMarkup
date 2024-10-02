namespace DalluiApp;

public partial class App : Application
{
    public App()
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(new AppShell());
    }
}
