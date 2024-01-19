namespace MyOrderApp.Models;

public class SubCategory : BaseModel
{
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public string IconId { get; set; }
}
