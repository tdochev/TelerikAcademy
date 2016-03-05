////Problem 8. Replace whole word
////Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        string path = @"..\..\..\TextFiles\08.ReplaceWholeWord.inputOutput.txt";
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
                    writerToTempFile.WriteLine(Regex.Replace(currentLine, @"\bstart\b", "finish"));
                    currentLine = reader.ReadLine();
                }
            }
        }

        File.Delete(path);
        File.Move(tempFile, path);
    }
}
