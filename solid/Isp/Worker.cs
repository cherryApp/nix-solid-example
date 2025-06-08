namespace Solid.Isp;

public interface IWorker
{
    void Work();
    void Eat();
}

public class HumanWorker : IWorker
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => Console.WriteLine("Eating lunch...");
}

public class RobotWorker : IWorker
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat()
    {
        // Not applicable for robots!
        throw new NotImplementedException();
    }
}
