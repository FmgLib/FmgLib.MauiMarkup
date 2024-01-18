using AutoMapper;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class FavoritesPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<ProductVM> _products;

    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public FavoritesPageViewModel(IProductRepository productRepository,
        IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;

        GetInfo();
    }


    public ICommand SearchCommand => new Command<string>((val) =>
    {
        var p = _productRepository
                    .GetAll(x => x.IsFavorite && x.Name.Contains(val))
                    .OrderByDescending(x => x.CreatedDate);

        Products = _mapper.Map<ObservableCollection<ProductVM>>(p);
    });


    public ICommand AddProductBasketCommand => new Command<ProductVM>((parameter) =>
    {
        if (BasketPageViewModel.BasketProduct.Any(x => x.Product.Id == parameter.Id))
            BasketPageViewModel.BasketProduct.First(x => x.Product.Id == parameter.Id).Count++;
        else
            BasketPageViewModel.BasketProduct.Add(new BasketProductVM { Count = 1, Product = parameter });
    });


    public ICommand ChangeFavoriteCommand => new Command((object parameter) =>
    {
        var product = (ProductVM)parameter;
        var index = Products.IndexOf(product);
        product.IsFavorite = !product.IsFavorite;
        Products.RemoveAt(index);

        var p = _productRepository.Get(product.Id);
        p.IsFavorite = product.IsFavorite;
        _productRepository.Update(p);
    });


    public void GetInfo()
    {
        var p = _productRepository
                    .GetAll(x => x.IsFavorite)
                    .OrderByDescending(x => x.CreatedDate);

        Products = _mapper.Map<ObservableCollection<ProductVM>>(p);
    }
}
