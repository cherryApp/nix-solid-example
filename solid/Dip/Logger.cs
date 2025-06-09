namespace Solid.Dip;

public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        File.AppendAllText("log.txt", message);
    }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class UserService
{
    private ILogger _logger;

    public UserService(ILogger logger)
    {
        _logger = logger;
    }

    public void RegisterUser(string username)
    {
        // logic to register user
        _logger.Log("User registered: " + username);
    }
}