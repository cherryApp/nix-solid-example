## 🎤 **Interface Segregation Principle (ISP) – Short Lecture**

### Slide 1: What is ISP?

**Interface Segregation Principle (ISP)**
– The “I” in SOLID

> **Clients should not be forced to depend on interfaces they do not use.**

**In simple terms:**
It’s better to have many **small, specific interfaces** than a large, bloated one.

---

### Slide 2: 🔴 Bad Example — Violating ISP

```csharp
public interface IWorker
{
    void Work();
    void Eat();
}
```

Now imagine we have two classes:

```csharp
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
```

### What's wrong?

- `RobotWorker` is forced to implement a method (`Eat`) it **does not need**.
- Violates ISP: the interface is **too general**.
- Leads to **fragile and confusing** code.

---

### Slide 3: ✅ Good Example — ISP Respected

Split the interface into more specific ones:

```csharp
public interface IWorkable
{
    void Work();
}

public interface IEatable
{
    void Eat();
}
```

Now use only what's needed:

```csharp
public class HumanWorker : IWorkable, IEatable
{
    public void Work() => Console.WriteLine("Working...");
    public void Eat() => Console.WriteLine("Eating lunch...");
}

public class RobotWorker : IWorkable
{
    public void Work() => Console.WriteLine("Working...");
}
```

✅ Now:

- `RobotWorker` only depends on what it needs.
- Interfaces are **small and focused**.
- Easy to **extend**, test, and maintain.

---

### Slide 4: Summary

✅ **Interface Segregation Principle helps you:**

- Avoid bloated interfaces
- Prevent dummy or unimplemented methods
- Keep classes clean and focused
- Write code that’s easier to refactor

**Ask yourself:**
_"Is this interface forcing classes to implement things they don’t need?"_

If yes → split it!
