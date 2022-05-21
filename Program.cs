using System;
using System.Text;


class Program 
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No argument.");
            return;
        }

        var filePath = Path.GetFullPath(Path.Combine(".", args[0]));
        if (!File.Exists( filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        var fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);
    }
}