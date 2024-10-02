namespace Game2048Maui;

public partial class App : Application
{
    public App(IServiceProvider service)
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(new NavigationPage(service.GetService<MainPage>()));
    }
}
