namespace FmgLib.MauiMarkup.App;

public partial class App : Application
{
    public App()
    {
        this
        .Resources(new ResourceDictionary().MergedResources(AppStyles.Default))
        .MainPage(new AppShell());
    }
}
