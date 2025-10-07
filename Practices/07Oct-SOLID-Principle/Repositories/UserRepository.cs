using Oct_Solid_Principle.Interfaces;
using Oct_Solid_Principle.Models;

namespace Oct_Solid_Principle.Repositories;

public class UserRepository : IUserRepository
{
    private readonly List<User> _users = new();
    private readonly ILogger _logger;

    public UserRepository(ILogger logger)
    {
        _logger = logger;
    }

    public void SaveUser(User user)
    {
        _users.Add(user);
        _logger.LogInfo($"User saved: {user.Email}");
    }

    public User? GetUserByEmail(string email)
    {
        return _users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }

    public bool UserExist(string email)
    {
        return _users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
    }
}
