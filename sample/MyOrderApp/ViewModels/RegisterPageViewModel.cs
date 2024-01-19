using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class RegisterPageViewModel : BaseViewModel
{
    private readonly IUserRepository _repository;

    [ObservableProperty]
    private User _user = new();

    public RegisterPageViewModel(IUserRepository repository)
    {
        _repository = repository;
    }


    public ICommand RegisterCommand => new Command(async () =>
    {
        var result = _repository.Add(User);

        if (result)
        {
            await Shell.Current.DisplayAlert("BİLGİ", "Kayıt Başarılı Olmuştur!", "OK");
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        else
            await Shell.Current.DisplayAlert("HATA", "Kayıt Başarısız Olmuştur!", "OK");
    });
}
