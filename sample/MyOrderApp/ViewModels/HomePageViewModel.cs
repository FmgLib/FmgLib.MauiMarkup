using AutoMapper;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyOrderApp.ViewModels;

public partial class HomePageViewModel : BaseViewModel
{
    [ObservableProperty]
    private ObservableCollection<ProductVM> _products;

    [ObservableProperty]
    private ObservableCollection<SubCategoryVM> _categories;

    private readonly IProductRepository _productRepository;
    private readonly ISubCategoryRepository _subCategoryRepository;
    private readonly IMapper _mapper;

    public HomePageViewModel(IProductRepository productRepository,
        ISubCategoryRepository subCategoryRepository, 
        IMapper mapper)
    {
        _productRepository = productRepository;
        _subCategoryRepository = subCategoryRepository;
        _mapper = mapper;

        GetHomePageInfos();
    }

    public ICommand GotoAllProductsCommand => new Command(async () =>
    {
        await Shell.Current.GoToAsync($"//{nameof(ProductsPage)}");
    });

    public ICommand GotoAllCategoriesCommand => new Command(async () =>
    {
        await Shell.Current.GoToAsync($"//{nameof(CategoriesPage)}");
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


    public ICommand SearchCommand => new Command(async (object val) =>
    {
        ProductsPage.Filter = (string)val;
        await Shell.Current.GoToAsync($"//{nameof(ProductsPage)}");
    });


    private void GetHomePageInfos()
    {
        var p = _productRepository
                    .GetAll()
                    .OrderByDescending(x => x.CreatedDate)
                    .Take(5);

        var c = _subCategoryRepository.GetAll()
                    .OrderByDescending(x => x.CreatedDate)
                    .Take(8);

        Products = _mapper.Map<ObservableCollection<ProductVM>>(p);
        Categories = _mapper.Map<ObservableCollection<SubCategoryVM>>(c);
    }
}
