## 🎤 **Liskov Substitution Principle (LSP) – Short Presentation**

### Slide 1: Title

**Understanding the Liskov Substitution Principle (LSP)**
_Part of the SOLID principles of object-oriented design_

---

### Slide 2: What is LSP?

**Definition:**

> _If S is a subtype of T, then objects of type T may be replaced with objects of type S without altering the correctness of the program._

— Barbara Liskov, 1987

**In simple terms:**
A subclass should behave in such a way that any code using the base class still works if we substitute it with the subclass.

---

### Slide 3: 🔴 Bad Example — Violating LSP

```csharp
public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea() => Width * Height;
}

public class Square : Rectangle
{
    public override int Width
    {
        set { base.Width = base.Height = value; }
    }

    public override int Height
    {
        set { base.Width = base.Height = value; }
    }
}
```

### Problem:

```csharp
public void PrintArea(Rectangle r)
{
    r.Width = 5;
    r.Height = 10;
    Console.WriteLine(r.GetArea()); // Expected: 50
}
```

But with `Square`, it prints `100` instead!
Why? Because setting width also changes height and vice versa.

**⚠️ This breaks the Liskov Substitution Principle.**

---

### Slide 4: ✅ Good Example — LSP Respected

Let’s separate the shapes with an interface:

```csharp
public interface IShape
{
    int GetArea();
}

public class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea() => Width * Height;
}

public class Square : IShape
{
    public int Side { get; set; }

    public int GetArea() => Side * Side;
}
```

### Now:

```csharp
public void PrintArea(IShape shape)
{
    Console.WriteLine(shape.GetArea());
}
```

**✅ Substitution is safe and behavior is consistent.**

---

### Slide 5: Key Takeaways

- Subclasses **must not** break the behavior expected from the base class.
- Respect **contracts**, **preconditions**, and **postconditions**.
- When in doubt, **rethink your inheritance hierarchy**.

**LSP ensures maintainable, reliable, and extendable code.**
