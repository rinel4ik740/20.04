using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp5
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "C:\\Users\\pc15\\source\\repos\\ConsoleApp5\\App.config\\userInput.txt";
        AnalyzeFile(path);
    }

    static void AnalyzeFile(string path)
    {

        int lineCount = 0;
        int wordCount = 0;
        int charCount = 0;

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lineCount++;
                charCount += line.Length;
                wordCount += line.Split(new[] { ' ' }).Length;
            }
        }

        Console.WriteLine($"Строк: {lineCount}");
        Console.WriteLine($"Слов: {wordCount}");
        Console.WriteLine($"Символов: {charCount}");
    }
}
