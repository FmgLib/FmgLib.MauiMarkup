namespace MyOrderApp.Models;

public class Basket :BaseModel
{
    public List<Product> Products { get; set; }
    public decimal TotalPrice { get; set; }
}
