namespace FmgLib.MauiMarkup.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
< !--#if (includeContent)-->
        Routing.RegisterRoute(nameof(Samples.Pages.DashboardPage), typeof(Samples.Pages.DashboardPage));
        Routing.RegisterRoute(nameof(Samples.Pages.ProductsPage), typeof(Samples.Pages.ProductsPage));
        Routing.RegisterRoute(nameof(Samples.Pages.AnimationsPage), typeof(Samples.Pages.AnimationsPage));
< !--#endif-->

        this
        .FlyoutBehavior(FlyoutBehavior.Disabled)
        .Items(
< !--#if (!includeContent)-->
            new ShellContent()
            .Title("Home")
            .ContentTemplate(() => new MainPage())
            .Route(nameof(MainPage))
< !--#endif-->
< !--#if (includeContent)-->
            new ShellContent()
            .Title("Getting Started")
            .ContentTemplate(() => new Samples.GettingStartedPage())
            .Route("GettingStarted")
< !--#endif-->
        );
    }
}
