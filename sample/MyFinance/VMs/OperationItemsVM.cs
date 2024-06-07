namespace MyFinance.VMs;

public class OperationItemsVM
{
    public Guid Id { get; set; }
    public string Icon { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Date { get; set; }
    public string Amount { get; set; }
    public Color Color { get; set; }
}
