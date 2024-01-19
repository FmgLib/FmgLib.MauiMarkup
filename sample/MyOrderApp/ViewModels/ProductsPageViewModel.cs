using AutoMapper;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class ProductsPageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<ProductVM> _products;


    private readonly IProductRepository _productRepository;
    private readonly ISubCategoryRepository _subCategoryRepository;
    private readonly IMapper _mapper;

    public ProductsPageViewModel(IProductRepository productRepository, 
        ISubCategoryRepository subCategoryRepository, 
        IMapper mapper)
    {
        _productRepository = productRepository;
        _subCategoryRepository = subCategoryRepository;
        _mapper = mapper;

        GetInfo();
    }



    public ICommand SearchCommand => new Command<string>((val) =>
    {
        var p = _productRepository
                    .GetAll(x => x.Name.Contains(val))
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
        Products[index] = product;

        var p = _productRepository.Get(product.Id);
        p.IsFavorite = product.IsFavorite;
        _productRepository.Update(p);
    });


    private void GetInfo()
    {
        var p = _productRepository
                    .GetAll()
                    .OrderByDescending(x => x.CreatedDate);

        Products = _mapper.Map<ObservableCollection<ProductVM>>(p);
    }
}
