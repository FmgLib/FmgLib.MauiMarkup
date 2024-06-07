using System.Windows.Input;

namespace MyFinance.ViewModels;

public partial class RegisterPageViewModel(IUserRepo repo) : BaseViewModel
{
    [ObservableProperty]
    private User userModel = new()
    {
        Email = string.Empty,
        FirstName = string.Empty,
        LastName = string.Empty,
        Password = string.Empty
    };

    [ObservableProperty]
    private bool isInfoPopupShow = false;

    [ObservableProperty]
    private bool isErrorPopupShow = false;

    [ObservableProperty]
    private bool isUserAdded = false;

    public ICommand RegisterCommand => new Command(async () =>
    {
        if (UserModel == default!)
            return;

        UserModel.IsActive = true;
        var result = await repo.InsertAsync(UserModel);

        if (!result)
        {
            IsUserAdded = false;
            IsErrorPopupShow = true;
        }
        else
        {
            IsUserAdded = true;
            IsInfoPopupShow = true;
            await Task.Delay(3000);
            UserModel = new()
            {
                Email = string.Empty,
                FirstName = string.Empty,
                LastName = string.Empty,
                Password = string.Empty
            };
            IsInfoPopupShow = true;
            await AppShell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    });

    public ICommand GoToLoginCommand => new Command(async () =>
    {
        UserModel = new()
        {
            Email = string.Empty,
            FirstName = string.Empty,
            LastName = string.Empty,
            Password = string.Empty
        };
        await AppShell.Current.GoToAsync($"//{nameof(LoginPage)}");
    });
}
