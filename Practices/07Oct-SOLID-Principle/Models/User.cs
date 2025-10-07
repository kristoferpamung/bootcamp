namespace Oct_Solid_Principle.Models;

public class User
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool IsActive { get; set; }

    public User(string email, string password)
    {
        Email = email;
        Password = password;
        CreatedAt = DateTime.Now;
        IsActive = true;
    }
}