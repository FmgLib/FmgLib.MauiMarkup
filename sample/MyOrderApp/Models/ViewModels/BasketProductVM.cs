namespace MyOrderApp.Models;

public class BasketProductVM
{
    public int Count { get; set; }
    public ProductVM Product { get; set; }
    public string TotalPrice => Product == null ? "0₺" : $"{decimal.Parse(Product.Price.Trim().Trim('₺')) * Count}₺";
}
