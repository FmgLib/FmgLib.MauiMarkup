using CommunityToolkit.Maui.Behaviors;

namespace F1TV;

public partial class App : Application
{
    public App()
    {
        this
        .Resources(AppStyles.Default)
        .MainPage(new AppShell());
    }
}
