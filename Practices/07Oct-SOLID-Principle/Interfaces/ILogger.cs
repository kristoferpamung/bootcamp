namespace Oct_Solid_Principle.Interfaces;

public interface ILogger
{
    void LogInfo(string message);
    void LogError(string message);
    void LogError(Exception exception);
}