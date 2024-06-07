namespace MyFinance.Models;

public class BaseModel
{
    public Guid Id { get; set; }
    public DateTime CreateDate { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime UpdateDate { get; set; }
    public Guid UpdatedBy { get; set; }
    public bool IsActive { get; set; }
}
