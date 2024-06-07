namespace MyFinance.ViewModels;

public partial class MainPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private List<OperationItemsVM> items = new();

    [ObservableProperty]
    private string totalBalance;

    [ObservableProperty]
    private string totalIncome;

    [ObservableProperty]
    private string totalExpense;

    [ObservableProperty]
    private UserCardVM user = new();

    public MainPageViewModel(IUserRepo userRepo, IOperationItemsRepo operationItemsRepo, IMapper mapper)
    {
        var accessUser = AuthCheckHelper.ParseBasicAuthToken(SecureStorage.GetAsync("USERAUTH").Result);
        var currentUser = userRepo.GetSingleAsync(e => e.Email == accessUser.Item1 && e.Password == accessUser.Item2).Result;
        if (currentUser == null)
            currentUser = default;

        User = new()
        {
            Name = $"{currentUser?.FirstName} {currentUser?.LastName}",
            Email = currentUser?.Email ?? string.Empty
        };

        Items = mapper.Map<List<OperationItemsVM>>(operationItemsRepo.GetAllAsync(ordered:e => e.Date, limit:10, descOrder: true).Result);

        var inA = operationItemsRepo.GetSumAsync(sumProp: e => e.Amount, expression: e => e.Date >= DateTime.Now.AddMonths(-1) && e.IsIncome).Result;
        var outA = operationItemsRepo.GetSumAsync(sumProp: e => e.Amount, expression: e => e.Date >= DateTime.Now.AddMonths(-1) && !e.IsIncome).Result;
        
        TotalExpense = $"{outA} ₺";
        TotalIncome = $"{inA} ₺";
        TotalBalance = $"{inA - outA} ₺";
    }
}
