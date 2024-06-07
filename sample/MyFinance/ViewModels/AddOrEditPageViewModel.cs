namespace MyFinance.ViewModels;

public partial class AddOrEditPageViewModel : BaseViewModel
{
    public static Guid Id;
    private readonly IOperationItemsRepo _operationItemsRepo;

    [ObservableProperty]
    private OperationItem operationItem = new();

    [ObservableProperty]
    private bool isInfoPopupShow = false;

    [ObservableProperty]
    private bool isErrorPopupShow = false;

    public AddOrEditPageViewModel(IOperationItemsRepo operationItemsRepo)
    {
        _operationItemsRepo = operationItemsRepo;
        OperationItem.Date = (OperationItem.Id == Guid.Empty ? DateTime.Now : OperationItem.Date);
    }

    [RelayCommand]
    public async Task Save()
    {
        var currentUser = Preferences.Get(nameof(App.CurrentUserId), string.Empty);
        OperationItem.IsActive = true;

        if (OperationItem.Id == Guid.Empty)
        {
            OperationItem.CreatedBy = !string.IsNullOrEmpty(currentUser) ? Guid.Parse(currentUser) : Guid.Empty;
            OperationItem.UpdatedBy = !string.IsNullOrEmpty(currentUser) ? Guid.Parse(currentUser) : Guid.Empty;
            OperationItem.UpdateDate = DateTime.Now;
        }
        else
        {
            OperationItem.UpdatedBy = !string.IsNullOrEmpty(currentUser) ? Guid.Parse(currentUser) : Guid.Empty;
        }

        var result = OperationItem.Id == Guid.Empty ? 
            await _operationItemsRepo.InsertAsync(OperationItem) :
            await _operationItemsRepo.UpdateAsync(OperationItem);

        if (result)
        {
            IsInfoPopupShow = true;
        }
        else
        {
            IsErrorPopupShow = true;
        }
    }

    [RelayCommand]
    public async Task Cancel()
    {
        await AppShell.Current.GoToAsync($"//{nameof(ItemsPage)}");

        OperationItem = new();
    }

    [RelayCommand]
    public async Task Loading()
    {
        if (Id != Guid.Empty)
        {
            OperationItem = await _operationItemsRepo.GetSingleAsync(e => e.Id == Id);
        }
        else
            OperationItem.Date = (OperationItem.Id == Guid.Empty ? DateTime.Now : OperationItem.Date);
    }
}
