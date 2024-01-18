using MyOrderApp.Helpers;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class LoginPageViewModel : BaseViewModel
{
    private readonly IUserRepository _repository;

    [ObservableProperty]
    private bool _isControl;

    [ObservableProperty]
    private User _user = new();

    public LoginPageViewModel(IUserRepository repository)
    {
        _repository = repository;
    }


    public ICommand LoginCommand => new Command(async () =>
    {
        var user = _repository.Get(u => u.IsActive && u.Username == User.Username && u.Password == User.Password);

        if (user == null)
            await Shell.Current.DisplayAlert("HATA", "Kullanıcı Adı veya Şifre yanlış!", "OK");
        else
        {
            if (IsControl)
                Preferences.Set(nameof(App.AuthKey), AuthHelper.BasicAuth(User.Username, User.Password));

            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
    });
}
