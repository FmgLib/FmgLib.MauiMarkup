using Microsoft.Extensions.Logging;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MyOrderApp;

public static partial class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>()
               .UseMauiCommunityToolkit()
               .UseSkiaSharp()
               .ConfigureFonts(fonts =>
               {
                   fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                   fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
               });

#if DEBUG
        builder.Logging.AddDebug();
#endif
        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>()
            .AddAutoMapper(typeof(App))
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ICategoryRepository, CategoryRepository>()
            .AddScoped<ISubCategoryRepository, SubCategoryRepository>()
            .AddScopedWithShellRoute<LoadingPage, LoadingPageViewModel>($"//{nameof(LoadingPage)}")
            .AddScopedWithShellRoute<LoginPage, LoginPageViewModel>($"//{nameof(LoginPage)}")
            .AddScopedWithShellRoute<HomePage, HomePageViewModel>($"//{nameof(HomePage)}")
            .AddScopedWithShellRoute<RegisterPage, RegisterPageViewModel>($"//{nameof(RegisterPage)}")
            .AddScopedWithShellRoute<CategoriesPage, CategoriesPageViewModel>($"//{nameof(CategoriesPage)}")
            .AddScopedWithShellRoute<FavoritesPage, FavoritesPageViewModel>($"//{nameof(FavoritesPage)}")
            .AddScopedWithShellRoute<BasketPage, BasketPageViewModel>($"//{nameof(BasketPage)}")
            .AddScopedWithShellRoute<ProductsPage, ProductsPageViewModel>($"//{nameof(ProductsPage)}");

        return builder.Build();
    }
}
