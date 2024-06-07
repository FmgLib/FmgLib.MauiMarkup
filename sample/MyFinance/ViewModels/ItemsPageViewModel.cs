namespace MyFinance.ViewModels;

public partial class ItemsPageViewModel : BaseViewModel
{
    private readonly IOperationItemsRepo _operationItemsRepo;
    private readonly IMapper _mapper;

    [ObservableProperty]
    private List<OperationItemsVM> items = new();

    [ObservableProperty]
    private List<int> loadingItems = new() { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    [ObservableProperty]
    private bool isLoadingItems = false;

    [ObservableProperty]
    private bool isRefreshing = false;

    [ObservableProperty]
    private bool isLoadMoreEnabled = true;

    [ObservableProperty]
    private int operationType = 0;

    [ObservableProperty]
    private int dateType = 3;

    [ObservableProperty]
    private bool isShowPopup = false;

    [ObservableProperty]
    private bool isDeletePopupShow = false;

    [ObservableProperty]
    private Guid deleteId;

    private int index = 0;

    public ItemsPageViewModel(IOperationItemsRepo operationItemsRepo, IMapper mapper)
    {
        _operationItemsRepo = operationItemsRepo;
        _mapper = mapper;

        Items = GetItems(GetDate()).Result;
    }


    private async Task<List<OperationItemsVM>> GetItems(DateTime date)
    {
        var tempList = await _operationItemsRepo.GetAllAsync(
            expression: e => e.Date >= date && (OperationType == 0 ? true : OperationType == 1 ? e.IsIncome : !e.IsIncome),
            ordered: e => e.Date,
            skip: index,
            limit: 15,
            descOrder: true);
        index += 15;

        if (tempList.Count == 0)
            IsLoadMoreEnabled = false;
        else
            IsLoadMoreEnabled = true;

        return _mapper.Map<List<OperationItemsVM>>(tempList) ?? new();
    }

    private DateTime GetDate() => DateType switch
    {
        0 => DateTime.Now.AddDays(-7),
        1 => DateTime.Now.AddMonths(-1),
        2 => DateTime.Now.AddMonths(-6),
        3 => DateTime.Now.AddYears(-1)
    };
    

    [RelayCommand]
    public async Task ApplyFilter()
    {
        IsLoadingItems = true;
        index = 0;

        Items = await GetItems(GetDate());

        IsShowPopup = false;
        await Task.Delay(1500);

        IsLoadingItems = false;
    }

    [RelayCommand]
    public async Task LoadMore()
    {
        if (index != 0)
            IsRefreshing = true;

        Items.AddRange(await GetItems(GetDate()));

        //await Task.Delay(1500);
        index += 15;
        IsRefreshing = false;
    }

    [RelayCommand]
    public void ShowFilterPopup()
    {
        IsShowPopup = true;
    }

    [RelayCommand]
    public async void GotoAddPage(object parameter)
    {
        await AppShell.Current.GoToAsync($"//{nameof(AddOrEditPage)}");
    }

    [RelayCommand]
    public void Cancel()
    {
        DeleteId = Guid.Empty;
        IsDeletePopupShow = false;
    }

    [RelayCommand]
    public async Task Yes()
    {
        var result = await _operationItemsRepo.RemoveAsync(DeleteId);
        IsLoadingItems = true;
        Items = await GetItems(GetDate());
        IsDeletePopupShow = false;
        await Task.Delay(1500);

        IsLoadingItems = false;
    }
}
