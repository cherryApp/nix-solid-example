using System.IO;

namespace Solid.Srp
{
    class Report
    {
        public required string Title { get; set; }
        public required string Content { get; set; }

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
}