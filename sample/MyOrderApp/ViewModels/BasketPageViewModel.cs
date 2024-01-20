using CommunityToolkit.Maui.Core.Extensions;
using MyOrderApp.Controls;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class BasketPageViewModel : BaseViewModel
{
    public static List<BasketProductVM> BasketProduct { get; set; } = new List<BasketProductVM>();

    [ObservableProperty]
    private ObservableCollection<BasketProductVM> _basketProducts;

    [ObservableProperty]
    private string _totalProductPrice;

    [ObservableProperty]
    private string _totalKdv;

    [ObservableProperty]
    private string _totalPrice;

    public BasketPageViewModel()
    {
        GetInfo();
    }

    public ICommand AddCountCommand => new Command<BasketProductVM>((val) =>
    {
        var index = BasketProducts.IndexOf(val);
        val.Count++;
        BasketProducts[index] = val;
        Calculate();
    });

    public ICommand RemoveCountCommand => new Command<BasketProductVM>((val) =>
    {
        var index = BasketProducts.IndexOf(val);
        val.Count--;
        BasketProducts[index] = val;
        Calculate();
    });

    public ICommand RemoveProductCommand => new Command<BasketProductVM>((val) =>
    {
        var index = BasketProducts.IndexOf(val);
        BasketProducts.RemoveAt(index);
        BasketProduct.RemoveAt(index);
        Calculate();
    });

    public ICommand CompletedCommand => new Command(async () =>
    {
        BasketProducts.Clear();
        BasketProduct.Clear();
        Calculate();
        await Shell.Current.ShowPopupAsync(new MyPopup());
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    });

    private void Calculate()
    {
        var totalProductPrice = BasketProducts.Sum(x => decimal.Parse(x.TotalPrice.Trim().Trim('₺')));
        var totalKdv = BasketProducts.Sum(x => x.Count) * 0.18M;
        TotalProductPrice = $"{totalProductPrice}₺";
        TotalKdv = $"{totalKdv}₺";
        TotalPrice = $"{totalProductPrice + totalKdv}₺";
    }

    public void GetInfo()
    {
        BasketProducts = BasketProduct.ToObservableCollection();
        Calculate();
    }
}
