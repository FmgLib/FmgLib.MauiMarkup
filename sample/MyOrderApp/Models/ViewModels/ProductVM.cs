namespace MyOrderApp.Models;

public class ProductVM
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsFavorite { get; set; }
    public string Unit { get; set; }
    public string Price { get; set; }
    public bool IsDiscount { get; set; }
    public string DiscountRate { get; set; }
    public string DiscountPrice { get; set; }
    public string ImageId { get; set; }
    public ImageSource Image { get; set; }
    public Guid SubCategoryId { get; set; }
}
