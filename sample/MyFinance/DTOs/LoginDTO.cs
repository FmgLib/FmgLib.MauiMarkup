namespace MyFinance.DTOs;

public class LoginDTO
{
    public string Username { get; set; }
    public string Password { get; set; }
    public bool IsRememberMe { get; set; }
}
