namespace FmgLib.MauiMarkup.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        this
        .FlyoutBehavior(FlyoutBehavior.Disabled)
        .Items(
            new ShellContent()
            .Title("Home")
            .ContentTemplate(() => new MainPage())
            .Route(nameof(MainPage))
{{#if includeContent}}
            ,
            new ShellContent()
            .Title("Getting Started")
            .ContentTemplate(() => new Samples.GettingStartedPage())
            .Route("GettingStarted")
{{/if}}
        );
    }
}
