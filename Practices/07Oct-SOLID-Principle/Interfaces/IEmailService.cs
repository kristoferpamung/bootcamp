namespace Oct_Solid_Principle.Interfaces;

public interface IEmailService
{
    bool ValidateEmail(string email);
    void SendWelcomeEmail(string email);
    void SendOrderConfirmation(string email, int orderId);
}