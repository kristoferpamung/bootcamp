using Oct_Solid_Principle.Interfaces;
using Oct_Solid_Principle.Models;

namespace Oct_Solid_Principle.Services;
public class UserService
{
    private readonly IEmailService _emailService;
    private readonly IUserRepository _userRepository;
    private readonly ILogger _logger;
    public UserService(IEmailService emailService, IUserRepository userRepository, ILogger logger)
    {
        _emailService = emailService;
        _userRepository = userRepository;
        _logger = logger;
    }

    public void RegisterUser(string email, string password)
    {
        try
        {
            if (!_emailService.ValidateEmail(email))
            {
                throw new ArgumentException("Invalid email format");
            }

            if (string.IsNullOrEmpty(email) || password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters");
            }

            if (_userRepository.UserExist(email))
            {
                throw new InvalidOperationException("User already exists");
            }

            User user = new User(email, password);
            _userRepository.SaveUser(user);

            _emailService.SendWelcomeEmail(email);

            _logger.LogInfo($"User registered successfully: {email}");
        }
        catch (Exception e)
        {
            _logger.LogError($"Failed to register user {email}: {e.Message}");
            throw;
        }
    }
}