namespace Solid.Dip;

public class FileLogger
{
    public void Log(string message)
    {
        File.AppendAllText("log.txt", message);
    }
}

public class UserService
{
    private FileLogger _logger = new FileLogger();
    public void RegisterUser(string username)
    {
        // logic to register user
        _logger.Log("User registered: " + username);
    }
}