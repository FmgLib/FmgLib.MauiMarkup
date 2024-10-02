namespace DalluiApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            this
            .FlyoutBehavior(FlyoutBehavior.Disabled)
            .ShellNavBarIsVisible(false)
            .Items(
                new ShellContent()
                .Title("DashboardView")
                .ContentTemplate(() => new DashboardView())
                .Route(nameof(DashboardView)),

                new ShellContent()
                .Title("GenerationOptionsView")
                .ContentTemplate(() => new GenerationOptionsView())
                .Route(nameof(GenerationOptionsView)),

                new ShellContent()
                .Title("ImageGeneratorView")
                .ContentTemplate(() => new ImageGeneratorView())
                .Route(nameof(ImageGeneratorView))
            );
        }
    }
}
