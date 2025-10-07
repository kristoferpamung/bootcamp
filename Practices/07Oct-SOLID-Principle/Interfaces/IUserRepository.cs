namespace Oct_Solid_Principle.Interfaces;

public interface IUserRepository
{
    void SaveUser(Models.User user);
    Models.User? GetUserByEmail(string email);
    bool UserExist(string email);
}