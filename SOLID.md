Here's a detailed curriculum for your presentation on the SOLID principles in C#, including structure, timing, and multiple C# examples for each principle.

---

## 📚 **SOLID Principles in C# – Presentation Curriculum**

### 🎯 **Goal**

Educate attendees on the SOLID principles of object-oriented design using clear explanations and concrete C# examples.

---

### 🕒 **Total Time**: \~60 minutes

### 🧩 **Structure**

1. Introduction to SOLID (5 min)
2. Each SOLID Principle (10 min per principle x 5 = 50 min)
3. Q\&A and Wrap-up (5 min)

---

## 🧠 **1. Introduction to SOLID** (5 minutes)

### ✅ Content

- Origin: Introduced by Robert C. Martin (Uncle Bob)
- Purpose: Improve software design, maintainability, and flexibility
- Acronym:

  - S – Single Responsibility Principle
  - O – Open/Closed Principle
  - L – Liskov Substitution Principle
  - I – Interface Segregation Principle
  - D – Dependency Inversion Principle

---

## 🔍 **2. SOLID Principles Explained** (10 min each)

---

### 🔹 S – Single Responsibility Principle (SRP)

> **A class should have only one reason to change.**

### ❌ Bad Example

```csharp
public class Report
{
    public string Title { get; set; }

    public void SaveToFile(string filePath)
    {
        // Save logic
    }

    public void Print()
    {
        // Print logic
    }
}
```

### ✅ Good Example

```csharp
public class Report
{
    public string Title { get; set; }
}

public class ReportPrinter
{
    public void Print(Report report)
    {
        // Print logic
    }
}

public class ReportSaver
{
    public void SaveToFile(Report report, string filePath)
    {
        // Save logic
    }
}
```

---

### 🔹 O – Open/Closed Principle (OCP)

> **Software entities should be open for extension, but closed for modification.**

### ❌ Bad Example

```csharp
public class InvoicePrinter
{
    public void PrintInvoice(string type)
    {
        if (type == "PDF")
        {
            // PDF logic
        }
        else if (type == "Excel")
        {
            // Excel logic
        }
    }
}
```

### ✅ Good Example

```csharp
public interface IInvoicePrinter
{
    void Print();
}

public class PdfPrinter : IInvoicePrinter
{
    public void Print()
    {
        // PDF logic
    }
}

public class ExcelPrinter : IInvoicePrinter
{
    public void Print()
    {
        // Excel logic
    }
}

public class InvoicePrintService
{
    public void PrintInvoice(IInvoicePrinter printer)
    {
        printer.Print();
    }
}
```

---

### 🔹 L – Liskov Substitution Principle (LSP)

> **Subtypes must be substitutable for their base types.**

### ❌ Bad Example

```csharp
public class Bird
{
    public virtual void Fly() { }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("Ostriches can't fly!");
    }
}
```

### ✅ Good Example

```csharp
public abstract class Bird { }

public interface IFlyingBird
{
    void Fly();
}

public class Sparrow : Bird, IFlyingBird
{
    public void Fly()
    {
        // Flying logic
    }
}

public class Ostrich : Bird
{
    // No Fly() method – LSP respected
}
```

---

### 🔹 I – Interface Segregation Principle (ISP)

> **Clients should not be forced to depend on interfaces they do not use.**

### ❌ Bad Example

```csharp
public interface IMachine
{
    void Print();
    void Scan();
    void Fax();
}

public class OldPrinter : IMachine
{
    public void Print() { }
    public void Scan() { throw new NotImplementedException(); }
    public void Fax() { throw new NotImplementedException(); }
}
```

### ✅ Good Example

```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class SimplePrinter : IPrinter
{
    public void Print() { }
}

public class MultifunctionPrinter : IPrinter, IScanner
{
    public void Print() { }
    public void Scan() { }
}
```

---

### 🔹 D – Dependency Inversion Principle (DIP)

> **High-level modules should not depend on low-level modules. Both should depend on abstractions.**

### ❌ Bad Example

```csharp
public class FileLogger
{
    public void Log(string message)
    {
        // log to file
    }
}

public class AuthService
{
    private FileLogger logger = new FileLogger();

    public void Login(string user)
    {
        logger.Log("User logged in");
    }
}
```

### ✅ Good Example

```csharp
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // log to file
    }
}

public class AuthService
{
    private readonly ILogger _logger;

    public AuthService(ILogger logger)
    {
        _logger = logger;
    }

    public void Login(string user)
    {
        _logger.Log("User logged in");
    }
}
```

---

## 🎤 **3. Wrap-Up & Q\&A** (5 minutes)

### 🧾 Key Points to Emphasize

- SRP: One job, one class.
- OCP: Add features without touching core logic.
- LSP: Subclasses must behave like base classes.
- ISP: Prefer small, client-specific interfaces.
- DIP: Depend on abstractions, not implementations.

### 🛠 Suggested Tools

- Visual Studio / JetBrains Rider
- Live coding or REPL with LINQPad

---

## 📎 Optional: Demos / Practice Ideas

- Refactor a small "bad" code snippet live using each principle.
- Quiz: Show code, ask which principle is violated.
- Mini group workshop: “Fix this code with SOLID”

Would you like me to turn this into a PowerPoint or Keynote outline, or generate a PDF handout with this content?

---
