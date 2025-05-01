namespace App1;

public partial class AppShell : MC.Shell
{
    public AppShell()
    {
        this
            .FlyoutBehavior(Microsoft.Maui.FlyoutBehavior.Disabled)
            .Items(
                new MC.ShellContent()
                    .Title("Home")
                    .ContentTemplate(() => new MainPage())
                    .Route(nameof(MainPage))
            );
    }
}