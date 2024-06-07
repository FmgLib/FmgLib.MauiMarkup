namespace MyOrderApp.Models;

public class BasketVM
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; }
    public List<Product> Products { get; set; }
    public decimal TotalPrice { get; set; }
}
