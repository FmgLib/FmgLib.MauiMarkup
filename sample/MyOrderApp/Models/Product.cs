namespace MyOrderApp.Models;

public class Product : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsFavorite { get; set; }
    public string Unit { get; set; }
    public decimal Price { get; set; }
    public bool IsDiscount { get; set; }
    public int DiscountRate { get; set; }
    public string ImageId { get; set; }
    public Guid SubCategoryId { get; set; }
}
