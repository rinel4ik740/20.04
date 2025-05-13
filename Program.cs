using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\pc15\\source\\repos\\ConsoleApp6\\App.config\\userInput.txt";
            SaveUserInputToFile(path);
        }

        static void SaveUserInputToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                string input;
                do
                {
                    Console.Write("Введите строку (exit - завершить): ");
                    input = Console.ReadLine();

                    if (input != "exit")
                    {
                        sw.WriteLine(input);
                    }
                } while (input != "exit");
            }

            Console.WriteLine($"Данные сохранены в файл: {path}");
        }
    }
}