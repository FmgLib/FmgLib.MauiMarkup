namespace MyOrderApp.Models;

public class SubCategoryVM
{
    public Guid Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public bool IsActive { get; set; }
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string IconId { get; set; }
    public ImageSource Icon { get; set; }
}
