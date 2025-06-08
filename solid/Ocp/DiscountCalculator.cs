namespace Solid.Ocp;

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