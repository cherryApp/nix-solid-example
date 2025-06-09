using System.IO;

namespace Solid.Srp
{
    class Report
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
    }

    class ReportPrinter
    {
        public void Print(Report report)
        {
            Console.WriteLine(report.Title);
            Console.WriteLine(report.Content);
        }

    }
    class ReportSaver
    {
        public void SaveToFile(Report report, string path)
        {
            File.WriteAllText(path, report.Title + "\n" + report.Content);
        }
    }
}