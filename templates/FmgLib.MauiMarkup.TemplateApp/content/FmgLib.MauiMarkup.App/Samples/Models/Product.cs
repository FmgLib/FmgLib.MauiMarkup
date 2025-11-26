using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FmgLib.MauiMarkup.App.Samples.Models;

public class Product : INotifyPropertyChanged
{
    private string _name = string.Empty;
    private string _description = string.Empty;
    private decimal _price;
    private string _imageUrl = string.Empty;
    private string _category = string.Empty;
    private double _rating;
    private bool _isFavorite;

    public string Name
    {
        get => _name;
        set { _name = value; OnPropertyChanged(); }
    }

    public string Description
    {
        get => _description;
        set { _description = value; OnPropertyChanged(); }
    }

    public decimal Price
    {
        get => _price;
        set { _price = value; OnPropertyChanged(); }
    }

    public string ImageUrl
    {
        get => _imageUrl;
        set { _imageUrl = value; OnPropertyChanged(); }
    }

    public string Category
    {
        get => _category;
        set { _category = value; OnPropertyChanged(); }
    }

    public double Rating
    {
        get => _rating;
        set { _rating = value; OnPropertyChanged(); }
    }

    public bool IsFavorite
    {
        get => _isFavorite;
        set { _isFavorite = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
