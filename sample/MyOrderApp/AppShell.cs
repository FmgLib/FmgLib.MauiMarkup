namespace MyOrderApp;

public partial class AppShell : Shell
{
    public AppShell(IServiceProvider services)
    {
        this
            .ItemsFmg(
                new FlyoutItem()
                    .FlyoutItemIsVisibleFmg(false)
                    .RouteFmg(nameof(LoadingPage))
                    .ItemsFmg(services.GetService<LoadingPage>()),

                new FlyoutItem()
                    .FlyoutItemIsVisibleFmg(false)
                    .RouteFmg(nameof(LoginPage))
                    .ItemsFmg(services.GetService<LoginPage>()),

                new FlyoutItem()
                    .FlyoutItemIsVisibleFmg(false)
                    .RouteFmg(nameof(RegisterPage))
                    .ItemsFmg(services.GetService<RegisterPage>()),

                new TabBar()
                    .FlyoutItemIsVisibleFmg(false)
                    .RouteFmg(nameof(LoadingPage))
                    .ItemsFmg(
                        new Tab()
                            .FlyoutDisplayOptionsFmg(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisibleFmg(true)
                            .RouteFmg(nameof(HomePage))
                            .TitleFmg("Anasayfa")
                            .IconFmg("home.png")
                            .ItemsFmg(services.GetService<HomePage>()),

                        new Tab()
                            .FlyoutDisplayOptionsFmg(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisibleFmg(true)
                            .RouteFmg(nameof(ProductsPage))
                            .TitleFmg("Ürünler")
                            .IconFmg("products.png")
                            .ItemsFmg(services.GetService<ProductsPage>()),

                        new Tab()
                            .FlyoutDisplayOptionsFmg(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisibleFmg(true)
                            .RouteFmg(nameof(CategoriesPage))
                            .TitleFmg("Kategoriler")
                            .IconFmg("categories.png")
                            .ItemsFmg(services.GetService<CategoriesPage>()),

                        new Tab()
                            .FlyoutDisplayOptionsFmg(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisibleFmg(true)
                            .RouteFmg(nameof(FavoritesPage))
                            .TitleFmg("Favoriler")
                            .IconFmg("favorites.png")
                            .ItemsFmg(services.GetService<FavoritesPage>()),

                        new Tab()
                            .FlyoutDisplayOptionsFmg(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisibleFmg(true)
                            .RouteFmg(nameof(BasketPage))
                            .TitleFmg("Sepet")
                            .IconFmg("basket.png")
                            .ItemsFmg(services.GetService<BasketPage>())
                    )
            );

    }
}
