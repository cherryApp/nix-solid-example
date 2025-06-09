using Solid.Srp;
using Solid.Ocp;
using Solid.Lsp;
using Solid.Isp;
using Solid.Dip;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // SRP
            var report = new Report()
            {
                Title = "Report title",
                Content = "Report content",
            };
            new ReportPrinter().Print(report);
            new ReportSaver().SaveToFile(report, "report.txt");

            // OCP
            var discountCalculator = new DiscountCalculator(new RegularDiscount());
            var discount = discountCalculator.CalculateDiscount(100);
            Console.WriteLine("Discount: {0}", discount);

            // LSP
            var rectangle = new Rectangle() { Width = 10, Height = 20 };
            var square = new Square() { Side = 10 };
            PrintArea(rectangle);
            PrintArea(square);

            // ISP
            var humanWorker = new HumanWorker();
            humanWorker.Work();
            humanWorker.Eat();

            var robotWorker = new RobotWorker();
            robotWorker.Work();

            // DIP
            var logger = new ConsoleLogger();
            var UserService = new UserService(logger);
            UserService.RegisterUser("John");

        }

        public static void PrintArea(IShape r)
        {
            Console.WriteLine("Area: {0}", r.GetArea()); // Expected: 50
        }
    }
}
