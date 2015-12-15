//Problem 3. Read file contents
//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        Console.WriteLine("Please enter a valid path file to read its contents:");
        string filePath = Console.ReadLine();
        string fileContent = string.Empty;
        try
        {
            fileContent = File.ReadAllText(filePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine(fileContent);
    }
}

