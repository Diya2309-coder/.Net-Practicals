using System;
using System.IO;

namespace prac5
{
    class RW
    {
        static void Main(string[] args)
        {
            string fileName = "day-3.txt";

            Console.WriteLine("Enter some text: ");
            string userInput = Console.ReadLine();

            using (StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(userInput);
            }

            using (StreamReader sr = new StreamReader(fileName))
            {
               string fileContents = sr.ReadToEnd();
                Console.WriteLine($"Content of file {fileName}:");
                Console.WriteLine(fileContents);

            }
            Console.ReadLine();
        }
    }
}