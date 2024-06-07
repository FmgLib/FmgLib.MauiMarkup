using DevExpress.Maui.Core.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using SkiaSharp.Views.Maui.Controls.Hosting;
using DXImage = DevExpress.Maui.Core.DXImage;
using SwipeItem = DevExpress.Maui.CollectionView.SwipeItem;

namespace MyFinance;


[MauiMarkup(typeof(StatusBarBehavior), typeof(TextEdit), typeof(TextEditBase), typeof(EditBase), typeof(ComboBoxEdit))]
[MauiMarkup(typeof(PasswordEdit), typeof(CheckEdit), typeof(DXPopup), typeof(ComboBoxEditBase), typeof(ItemsEditBase))]
[MauiMarkup(typeof(DXImage), typeof(DXButton), typeof(DXViewBase), typeof(DXBorder), typeof(DXContentPresenterBase))]
[MauiMarkup(typeof(DXContentPresenter), typeof(DXCollectionView), typeof(CartesianChart), typeof(TabView), typeof(TabViewItem))]
[MauiMarkup(typeof(TabItem), typeof(DXButtonBase), typeof(ShimmerView), typeof(DXCollectionViewBase), typeof(SwipeContainer))]
[MauiMarkup(typeof(SwipeItem), typeof(DateEdit), typeof(CalendarHeaderAppearance), typeof(CalendarDayCellAppearance), typeof(CalendarSelectableCellAppearance))]
[MauiMarkup(typeof(DateEditActualAppearance), typeof(MultilineEdit), typeof(SimpleButton), typeof(DXStackLayout), typeof(DXLayoutBase))]
[MauiMarkup(typeof(SwipeItemBase))]
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseDevExpress()
            .UseMauiCommunityToolkit()
            .UseSkiaSharp(true)
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCompatibility();
        
        builder.Logging.AddDebug();

        builder.Services
            .AddSingleton<App>()
            .AddSingleton<AppShell>()
            .AddDbContext<MyFinanceContext>()
            .AddAutoMapper(typeof(App))
            .AddScopedWithShellRoute<MainPage, MainPageViewModel>($"//{nameof(MainPage)}")
            .AddScopedWithShellRoute<ChartPage, ChartPageViewModel>($"//{nameof(ChartPage)}")
            .AddScopedWithShellRoute<ItemsPage, ItemsPageViewModel>($"//{nameof(ItemsPage)}")
            .AddScopedWithShellRoute<AccountPage, AccountPageViewModel>($"//{nameof(AccountPage)}")
            .AddScopedWithShellRoute<LoginPage, LoginPageViewModel>($"//{nameof(LoginPage)}")
            .AddScopedWithShellRoute<RegisterPage, RegisterPageViewModel>($"//{nameof(RegisterPage)}")
            .AddScopedWithShellRoute<AddOrEditPage, AddOrEditPageViewModel>($"//{nameof(AddOrEditPage)}")
            .AddScoped<StartedPage>()
            .AddScoped<IUserRepo, UserRepo>()
            .AddScoped<IOperationItemsRepo, OperationItemsRepo>();

        #region Init DB
        var dbContext = new MyFinanceContext();
        dbContext.Database.EnsureCreated();
        if (dbContext.Users.Count() <= 0)
        {
            dbContext.Users.Add(new()
            {
                Age = 23,
                Email = "mg",
                Password = "00",
                FirstName = "Mustafa",
                LastName = "Gönültaş",
                Gender = Gender.Male,
                IsActive = true,
                PhoneNumber = "1234567890"
            });
            dbContext.SaveChanges();
        }

        if (dbContext.OperationItems.Count() <= 0)
        {
            List<OperationItem> items = new List<OperationItem>();
            Random random = new Random();
            for (int i = 1; i <= 500; i++)
            {
                var amount = random.Next(1, 10000);
                items.Add(
                    new OperationItem
                    {
                        IsIncome = amount % 2 != 0,
                        Date = DateTime.Now.AddDays(-(amount % 200)),
                        Title = amount % 2 == 0 ? "Borç ödendi" : "Ödeme Alındı",
                        Description = amount % 2 == 0 ? "Ödemeler yapıldı" : "Yaka parası alındı.",
                        Amount = amount,
                        CreateDate = DateTime.Now.AddDays(-(amount % 200)),
                        UpdateDate = DateTime.Now.AddDays(-(amount % 200)),
                        IsActive = true
                    }
                );
            }

            dbContext.AddRange(items);
            dbContext.SaveChanges();
        }
        dbContext.Dispose();
        #endregion

        return builder.Build();
    }
}
