## 🎤 **Open/Closed Principle (OCP) – Short Lecture**

### Slide 1: What is OCP?

**Open/Closed Principle (OCP)**
– The "O" in SOLID

> **Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.**

**Meaning:**
You should be able to add new behavior **without modifying** existing code.

---

### Slide 2: 🔴 Bad Example — Violating OCP

```csharp
public class DiscountCalculator
{
    public double CalculateDiscount(string customerType, double total)
    {
        if (customerType == "Regular")
            return total * 0.9;
        else if (customerType == "Premium")
            return total * 0.8;
        else if (customerType == "VIP")
            return total * 0.7;
        else
            return total;
    }
}
```

### What's wrong?

- Adding a **new customer type** (e.g., "Gold") means editing the method.
- Every change violates **OCP**.
- High **risk of bugs** and code duplication over time.

---

### Slide 3: ✅ Good Example — OCP Respected

We can apply **polymorphism** to extend behavior.

```csharp
public interface IDiscountStrategy
{
    double ApplyDiscount(double total);
}

public class RegularDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double total) => total * 0.9;
}

public class PremiumDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double total) => total * 0.8;
}

public class VipDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double total) => total * 0.7;
}
```

Now the calculator uses dependency injection:

```csharp
public class DiscountCalculator
{
    private readonly IDiscountStrategy _strategy;

    public DiscountCalculator(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public double CalculateDiscount(double total)
    {
        return _strategy.ApplyDiscount(total);
    }
}
```

➡️ To add a new strategy (e.g., `GoldDiscount`), you just implement the interface.
**No changes** required in existing classes.

---

### Slide 4: Summary

✅ **Open/Closed Principle** promotes:

- **Extensibility**: Add features without touching stable code
- **Maintainability**: Fewer bugs when requirements change
- **Testability**: Smaller, focused classes

**Ask yourself:**
_"Am I modifying existing code every time I need to support a new case?"_
If yes → consider using OCP and abstraction.
