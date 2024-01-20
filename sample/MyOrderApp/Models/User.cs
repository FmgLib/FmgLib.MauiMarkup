namespace MyOrderApp.Models;

public class User : BaseModel
{
    public string FullName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}
