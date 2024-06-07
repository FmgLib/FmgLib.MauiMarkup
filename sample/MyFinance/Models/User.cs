namespace MyFinance.Models;

public class User : BaseModel
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string? PhoneNumber { get; set; }
    public int Age { get; set; }
    public Gender Gender { get; set; }
}
