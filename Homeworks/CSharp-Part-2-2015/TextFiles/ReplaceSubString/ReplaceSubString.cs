//// Problem 7. Replace sub-string
////Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
////Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;
using System.Threading;

class ReplaceSubString
{
    static void Main()
    {
        string path = @"..\..\..\TextFiles\07.ReplaceSubString.inputOutput.txt";
        ////Generate large file
        StreamWriter writer = new StreamWriter(path);
        string tempFile = Path.GetTempFileName();
        using (writer)
        {
            Console.WriteLine("Generating sample text file.");
            Console.Write("Generating lines: ");
            ////Uncomment the 5000000 below to generate large file
            for (int i = 0; i <= 50000 /*5000000*/; i++)
            {
                Console.Write(i);
                Console.SetCursorPosition(18, 1);
                writer.WriteLine("This word starts with a.");
                if (i % 2 == 0)
                {
                    writer.WriteLine("No string to replace here.");
                }
            }

            Console.WriteLine();
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = new FileInfo(path).Length;
            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            Console.WriteLine("Input file successfully created:\n{0}\nSize of the created file: {1}", Path.GetFullPath(path), string.Format("{0:0.##} {1}", len, sizes[order]));
        }

        var writerToTempFile = new StreamWriter(tempFile);
        var reader = new StreamReader(path);
        using (reader)
        {
            string currentLine = reader.ReadLine();
            using (writerToTempFile)
            {
                while (currentLine != null)
                {
                    currentLine = currentLine.Replace("start", "finish");
                    writerToTempFile.WriteLine(currentLine);
                    currentLine = reader.ReadLine();
                }
            }

            Console.WriteLine("Replaced all occurrences of the sub-string start with the sub-string finish.");
        }

        File.Delete(path);
        File.Move(tempFile, path);
    }
}