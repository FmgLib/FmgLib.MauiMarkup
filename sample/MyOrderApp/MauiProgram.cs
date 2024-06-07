using Microsoft.Extensions.Logging;
using SkiaSharp.Extended.UI.Controls;
using SkiaSharp.Views.Maui.Controls.Hosting;

namespace MyOrderApp;

[MauiMarkup(typeof(Expander), typeof(SKLottieView))]
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
        builder.Services.AddSingleton<App>();
        builder.Services.AddSingleton<AppShell>();

        builder.Services.AddAutoMapper(typeof(App));

        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();


        builder.Services.AddScopedWithShellRoute<LoadingPage, LoadingPageViewModel>($"//{nameof(LoadingPage)}");
        builder.Services.AddScopedWithShellRoute<LoginPage, LoginPageViewModel>($"//{nameof(LoginPage)}");
        builder.Services.AddScopedWithShellRoute<HomePage, HomePageViewModel>($"//{nameof(HomePage)}");
        builder.Services.AddScopedWithShellRoute<RegisterPage, RegisterPageViewModel>($"//{nameof(RegisterPage)}");
        builder.Services.AddScopedWithShellRoute<CategoriesPage, CategoriesPageViewModel>($"//{nameof(CategoriesPage)}");
        builder.Services.AddScopedWithShellRoute<FavoritesPage, FavoritesPageViewModel>($"//{nameof(FavoritesPage)}");
        builder.Services.AddScopedWithShellRoute<BasketPage, BasketPageViewModel>($"//{nameof(BasketPage)}");
        builder.Services.AddScopedWithShellRoute<ProductsPage, ProductsPageViewModel>($"//{nameof(ProductsPage)}");

        return builder.Build();
    }
}
