namespace Solid.Lsp;

public interface IShape
{
    int GetArea();
}

public class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetArea() => Width * Height;
}

public class Square : IShape
{
    public int Side { get; set; }

    public int GetArea() => Side * Side;
}
