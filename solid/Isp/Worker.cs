namespace Solid.Isp;

public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public class HumanWorker : IWorkable, IEatable
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => Console.WriteLine("Eating lunch...");
}

public class RobotWorker : IWorkable
{
    public void Work() => Console.WriteLine("Working...");
}
