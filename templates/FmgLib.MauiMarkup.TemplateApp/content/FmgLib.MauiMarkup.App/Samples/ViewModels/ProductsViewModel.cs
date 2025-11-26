using System.Collections.ObjectModel;
using System.Windows.Input;
using FmgLib.MauiMarkup.App.Samples.Models;

namespace FmgLib.MauiMarkup.App.Samples.ViewModels;

public class ProductsViewModel : BaseViewModel
{
    private ObservableCollection<Product> _products = new();
    private ObservableCollection<Product> _filteredProducts = new();
    private string _searchText = string.Empty;
    private string _selectedCategory = "All";

    public ProductsViewModel()
    {
        Title = "Products";
        LoadProducts();
        
        SearchCommand = new RelayCommand(PerformSearch);
        FilterByCategoryCommand = new RelayCommand<string>(FilterByCategory);
        ToggleFavoriteCommand = new RelayCommand<Product>(ToggleFavorite);
        RefreshCommand = new RelayCommand(async () => await RefreshProducts());
    }

    public ObservableCollection<Product> FilteredProducts
    {
        get => _filteredProducts;
        set => SetProperty(ref _filteredProducts, value);
    }

    public string SearchText
    {
        get => _searchText;
        set
        {
            if (SetProperty(ref _searchText, value))
                PerformSearch();
        }
    }

    public string SelectedCategory
    {
        get => _selectedCategory;
        set => SetProperty(ref _selectedCategory, value);
    }

    public List<string> Categories { get; } = new() { "All", "Electronics", "Fashion", "Home", "Books" };

    public ICommand SearchCommand { get; }
    public ICommand FilterByCategoryCommand { get; }
    public ICommand ToggleFavoriteCommand { get; }
    public ICommand RefreshCommand { get; }

    private void LoadProducts()
    {
        _products = new ObservableCollection<Product>
        {
            new Product 
            { 
                Name = "Wireless Headphones", 
                Description = "Premium noise-cancelling headphones",
                Price = 199.99m, 
                Category = "Electronics",
                Rating = 4.5,
                ImageUrl = "🎧"
            },
            new Product 
            { 
                Name = "Smart Watch", 
                Description = "Fitness tracker with heart rate monitor",
                Price = 299.99m, 
                Category = "Electronics",
                Rating = 4.8,
                ImageUrl = "⌚"
            },
            new Product 
            { 
                Name = "Designer Jacket", 
                Description = "Premium leather jacket",
                Price = 399.99m, 
                Category = "Fashion",
                Rating = 4.3,
                ImageUrl = "🧥"
            },
            new Product 
            { 
                Name = "Running Shoes", 
                Description = "Comfortable athletic footwear",
                Price = 129.99m, 
                Category = "Fashion",
                Rating = 4.6,
                ImageUrl = "👟"
            },
            new Product 
            { 
                Name = "Coffee Maker", 
                Description = "Automatic espresso machine",
                Price = 249.99m, 
                Category = "Home",
                Rating = 4.4,
                ImageUrl = "☕"
            },
            new Product 
            { 
                Name = "Table Lamp", 
                Description = "Modern LED desk lamp",
                Price = 59.99m, 
                Category = "Home",
                Rating = 4.2,
                ImageUrl = "💡"
            },
            new Product 
            { 
                Name = "Programming Book", 
                Description = "Learn C# and .NET MAUI",
                Price = 49.99m, 
                Category = "Books",
                Rating = 4.7,
                ImageUrl = "📚"
            },
            new Product 
            { 
                Name = "E-Reader", 
                Description = "Digital book reader with backlight",
                Price = 159.99m, 
                Category = "Electronics",
                Rating = 4.5,
                ImageUrl = "📖"
            }
        };

        FilteredProducts = new ObservableCollection<Product>(_products);
    }

    private void PerformSearch()
    {
        if (string.IsNullOrWhiteSpace(SearchText))
        {
            FilterByCategory(SelectedCategory);
            return;
        }

        var filtered = _products.Where(p => 
            p.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase) ||
            p.Description.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
        );

        if (SelectedCategory != "All")
            filtered = filtered.Where(p => p.Category == SelectedCategory);

        FilteredProducts = new ObservableCollection<Product>(filtered);
    }

    private void FilterByCategory(string? category)
    {
        if (category == null) return;
        
        SelectedCategory = category;
        
        if (category == "All")
            FilteredProducts = new ObservableCollection<Product>(_products);
        else
            FilteredProducts = new ObservableCollection<Product>(_products.Where(p => p.Category == category));
    }

    private void ToggleFavorite(Product? product)
    {
        if (product != null)
            product.IsFavorite = !product.IsFavorite;
    }

    private async Task RefreshProducts()
    {
        IsBusy = true;
        await Task.Delay(1500); // Simulate network delay
        LoadProducts();
        IsBusy = false;
    }
}
