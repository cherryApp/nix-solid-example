namespace Solid.Ocp;

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

public class VIPDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double total) => total * 0.7;
}

public class DiscountCalculator
{
    private readonly IDiscountStrategy _discountStrategy;

    public DiscountCalculator(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double CalculateDiscount(double total)
    {
        return _discountStrategy.ApplyDiscount(total);
    }
}