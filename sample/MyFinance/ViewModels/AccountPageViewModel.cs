
namespace MyFinance.ViewModels;

public partial class AccountPageViewModel : BaseViewModel
{
    private readonly IUserRepo _userRepo;

    [ObservableProperty]
    private User userModel = new()
    {
        Email = string.Empty,
        FirstName = string.Empty,
        LastName = string.Empty,
        Password = string.Empty
    };

    [ObservableProperty]
    private UserCardVM user = new();

    [ObservableProperty]
    private bool isPopupShow = false;

    [ObservableProperty]
    private bool isInfoPopupShow = false;

    [ObservableProperty]
    private Color infoPopupColor = SkyBlue;

    [ObservableProperty]
    private string infoPopupTitle = "BİLGİ";

    [ObservableProperty]
    private string infoPopupDesc = "İşlem başarılı olmuştur.";

    public AccountPageViewModel(IUserRepo userRepo)
    {
        _userRepo = userRepo;
        var accessUser = AuthCheckHelper.ParseBasicAuthToken(SecureStorage.GetAsync("USERAUTH").Result);
        var currentUser = _userRepo.GetSingleAsync(e => e.Email == accessUser.Item1 && e.Password == accessUser.Item2).Result;

        if (currentUser == null)
            currentUser = default;

        UserModel = currentUser;

        User = new()
        {
            Name = $"{currentUser?.FirstName} {currentUser?.LastName}",
            Email = currentUser?.Email ?? string.Empty
        };
    }

    [RelayCommand]
    public void ShowDetails()
    {
        IsPopupShow = true;
    }

    [RelayCommand]
    public void ClosePopup()
    {
        if (InfoPopupTitle == "BİLGİ")
        {
            IsInfoPopupShow = false;
            IsPopupShow = false;
        }
        else
            IsInfoPopupShow = false;
    }

    [RelayCommand]
    public void CloseDetailsPopup()
    {
        IsPopupShow = false;
    }

    [RelayCommand]
    public async void Logout()
    {
        SecureStorage.Remove("USERAUTH");
        await AppShell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    [RelayCommand]
    public async Task Save()
    {
        var accessUser = AuthCheckHelper.ParseBasicAuthToken(SecureStorage.GetAsync("USERAUTH").Result);
        var result = await _userRepo.UpdateAsync(UserModel);
        if (result)
        {
            if (UserModel.Email != accessUser.Item1 || UserModel.Password != accessUser.Item2)
            {
                var auth = AuthCheckHelper.BasicAuth(UserModel.Email, UserModel.Password, accessUser.Item3.Value, UserModel.Id);
                await SecureStorage.SetAsync("USERAUTH", auth);
            }
            User = new()
            {
                Name = $"{UserModel?.FirstName} {UserModel?.LastName}",
                Email = UserModel?.Email ?? string.Empty
            };

            InfoPopupColor = SkyBlue;
            InfoPopupTitle = "BİLGİ";
            infoPopupDesc = "İşlem başarılı olmuştur.";
        }
        else
        {
            InfoPopupColor = DarkOrange;
            InfoPopupTitle = "HATA";
            infoPopupDesc = "İşlem sırasında beklenmeyen bir hata oluştu.";
        }
        IsInfoPopupShow = true;
    }
}
