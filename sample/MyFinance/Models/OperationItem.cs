namespace MyFinance.Models;

public class OperationItem : BaseModel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public double Amount { get; set; }
    public bool IsIncome { get; set; }
}
