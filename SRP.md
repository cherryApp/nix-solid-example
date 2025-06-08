## 🎤 **Single Responsibility Principle (SRP) – Short Lecture**

### Slide 1: What is SRP?

**Single Responsibility Principle (SRP)**
– The “S” in SOLID

> **A class should have only one reason to change.**

In other words:
A class should **only do one thing** and **do it well**.

---

### Slide 2: 🔴 Bad Example — Violating SRP

```csharp
public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }

    public void SaveToFile(string path)
    {
        File.WriteAllText(path, Title + "\n" + Content);
    }

    public void Print()
    {
        Console.WriteLine(Title);
        Console.WriteLine(Content);
    }
}
```

### What's wrong here?

This class has **multiple responsibilities**:

1. **Holds report data**
2. **Handles file saving**
3. **Handles printing**

➡️ If printing logic changes, this class must change.
➡️ If file I/O changes, this class must also change.

**⚠️ Violates SRP**

---

### Slide 3: ✅ Good Example — SRP Respected

Let's break this into separate classes:

```csharp
public class Report
{
    public string Title { get; set; }
    public string Content { get; set; }
}

public class ReportPrinter
{
    public void Print(Report report)
    {
        Console.WriteLine(report.Title);
        Console.WriteLine(report.Content);
    }
}

public class ReportSaver
{
    public void SaveToFile(Report report, string path)
    {
        File.WriteAllText(path, report.Title + "\n" + report.Content);
    }
}
```

### Now:

- `Report` → stores data
- `ReportPrinter` → prints the report
- `ReportSaver` → saves to a file

Each class has **only one reason to change**.

---

### Slide 4: Summary

✅ **SRP helps you**:

- Keep code clean and modular
- Improve readability and maintainability
- Reduce risk of bugs when requirements change

**Always ask:**
_“Does this class do more than one thing?”_
If yes → time to refactor!
