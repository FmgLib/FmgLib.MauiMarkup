namespace MyOrderApp;

public partial class AppShell : Shell
{
    public AppShell(IServiceProvider services)
    {
        this
            .Items(
                new FlyoutItem()
                    .FlyoutItemIsVisible(false)
                    .Route(nameof(LoadingPage))
                    .Items(services.GetService<LoadingPage>()),

                new FlyoutItem()
                    .FlyoutItemIsVisible(false)
                    .Route(nameof(LoginPage))
                    .Items(services.GetService<LoginPage>()),

                new FlyoutItem()
                    .FlyoutItemIsVisible(false)
                    .Route(nameof(RegisterPage))
                    .Items(services.GetService<RegisterPage>()),

                new TabBar()
                    .FlyoutItemIsVisible(false)
                    .Route(nameof(LoadingPage))
                    .Items(
                        new Tab()
                            .FlyoutDisplayOptions(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisible(true)
                            .Route(nameof(HomePage))
                            .Title("Anasayfa")
                            .Icon("home.png")
                            .Items(services.GetService<HomePage>()),

                        new Tab()
                            .FlyoutDisplayOptions(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisible(true)
                            .Route(nameof(ProductsPage))
                            .Title("Ürünler")
                            .Icon("products.png")
                            .Items(services.GetService<ProductsPage>()),

                        new Tab()
                            .FlyoutDisplayOptions(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisible(true)
                            .Route(nameof(CategoriesPage))
                            .Title("Kategoriler")
                            .Icon("categories.png")
                            .Items(services.GetService<CategoriesPage>()),

                        new Tab()
                            .FlyoutDisplayOptions(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisible(true)
                            .Route(nameof(FavoritesPage))
                            .Title("Favoriler")
                            .Icon("favorites.png")
                            .Items(services.GetService<FavoritesPage>()),

                        new Tab()
                            .FlyoutDisplayOptions(FlyoutDisplayOptions.AsSingleItem)
                            .FlyoutItemIsVisible(true)
                            .Route(nameof(BasketPage))
                            .Title("Sepet")
                            .Icon("basket.png")
                            .Items(services.GetService<BasketPage>())
                    )
            );

    }
}
