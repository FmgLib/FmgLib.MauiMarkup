namespace MyOrderApp.Models;

public class CategoryVM
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; }
    public string Name { get; set; }
    public List<SubCategoryVM> SubCategories { get; set; }
}
