// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string fileName = "C:\\Users\\Diya\\source\\repos\\Pract5\\Pract5\\TextFile1.txt";

Console.WriteLine("\nReading the content of File TestFile1 : \n\n");

using (StreamReader sr = new StreamReader(fileName))
{
    string s = sr.ReadToEnd();
    Console.WriteLine("Content of file : \n" + s);
}

Console.WriteLine("\n Write the content to the file TestFile1 : \n\n");

Console.WriteLine("Enter text to write to file:");
string input = Console.ReadLine();

// Write to file
using (StreamWriter sw = new StreamWriter(fileName))
{ 
    sw.WriteLine(input);
}

Console.WriteLine("Write success");
