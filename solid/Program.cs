using Solid.Srp;
using Solid.Ocp;
using Solid.Lsp;
using Solid.Isp;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // SRP
            var riport = new Report()
            {
                Title = "Report title",
                Content = "Report content",
            };
            riport.Print();
            riport.SaveToFile("report.txt");

            // OCP
            var discountCalculator = new DiscountCalculator();
            var discount = discountCalculator.CalculateDiscount("", 100);
            Console.WriteLine("Discount: {0}", discount);

            // LSP
            var rectangle = new Rectangle();
            var square = new Square();
            PrintArea(rectangle);
            PrintArea(square);

            // ISP


        }

        public static void PrintArea(Rectangle r)
        {
            r.Width = 5;
            r.Height = 10;
            Console.WriteLine("Area: {0}", r.GetArea()); // Expected: 50
        }
    }
}
