using Oct_Solid_Principle.Interfaces;

namespace Oct_Solid_Principle.Services;

public class EmailService : IEmailService
{
    private readonly ILogger _logger;
    public EmailService(ILogger logger)
    {
        _logger = logger;
    }

    public bool ValidateEmail(string email)
    {
        return !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".") && email.IndexOf("@") < email.IndexOf(".");
    }

    public void SendWelcomeEmail(string email)
    {
        Console.WriteLine($"📧 Sending welcome email to: {email}");
        _logger.LogInfo($"Welcome email send to {email}");
    }

    public void SendOrderConfirmation(string email, int orderId)
    {
        Console.WriteLine($"📧 Sending order confirmation to: {email} for order: {orderId}");
        _logger.LogInfo($"Order confirmation sent to {email}");
    }
}