## 🎤 **Dependency Inversion Principle (DIP) – Short Lecture**

### Slide 1: What is DIP?

**Dependency Inversion Principle (DIP)**
– The “D” in SOLID

> **High-level modules should not depend on low-level modules. Both should depend on abstractions.** > **Abstractions should not depend on details. Details should depend on abstractions.**

### In simpler terms:

- Code should depend on **interfaces**, not **concrete implementations**.
- This makes your code more flexible, testable, and maintainable.

---

### Slide 2: 🔴 Bad Example — Violating DIP

```csharp
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
```

### What's wrong?

- `UserService` (a high-level class) **directly depends** on `FileLogger` (a low-level class).
- Tight coupling: hard to replace logger, or test `UserService`.
- Violates DIP.

---

### Slide 3: ✅ Good Example — DIP Respected

### Step 1: Introduce an abstraction

```csharp
public interface ILogger
{
    void Log(string message);
}
```

### Step 2: Implement concrete loggers

```csharp
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
```

### Step 3: Use abstraction in the high-level class

```csharp
public class UserService
{
    private readonly ILogger _logger;

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
```

### Now:

- `UserService` depends on the **interface**, not the concrete logger.
- You can **swap in any logger** at runtime or in tests.
- ✅ DIP is respected.

---

### Slide 4: Summary

✅ **Dependency Inversion Principle brings:**

- **Loose coupling** between modules
- Easier **testing and mocking**
- Better **scalability and flexibility**

**Ask yourself:**
_"Am I depending on abstractions, or on concrete classes?"_

If it’s the latter → introduce interfaces!
