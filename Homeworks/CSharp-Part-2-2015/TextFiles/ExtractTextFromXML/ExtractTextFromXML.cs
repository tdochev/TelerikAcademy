////Problem 10. Extract text from XML
////Write a program that extracts from given XML file all the text without the tags.
////Example:
////<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
////<interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.IO;
using System.Text;

class ExtractTextFromXML
{
    static void Main()
    {
        string path = @"..\..\..\TextFiles\10.ExtractTextFromXML.xml";
        ////Generate xml file
        StreamWriter fileCreator = new StreamWriter(path);
        using (fileCreator)
        {
            fileCreator.WriteLine(@"<?xml version=""1.0""><student><name>Pesho</name><age>21</age><interests count=""3""><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>");
        }

        Console.WriteLine("Input XML file successfully created:\n{0}", Path.GetFullPath(path));
        var reader = new StreamReader(path);
        string fileContent = string.Empty;
        using (reader)
        {
            fileContent = reader.ReadToEnd();
        }

        StringBuilder result = new StringBuilder();
        bool isInTag = false;
        for (int i = 0; i < fileContent.Length; i++)
        {
            if (i != 0 && fileContent[i - 1] != '>' && fileContent[i] == '<')
            {
            result.Append(' ');
            }

            if (fileContent[i] == '<' && isInTag == false)
            {
                isInTag = true;
            }

            if (!isInTag)
            {
                result.Append(fileContent[i]);
            }

            if (fileContent[i] == '>' && isInTag == true)
            {
                isInTag = false;
            }
        }

        Console.WriteLine("The content of the given xml is:\n{0}", result.ToString());
    }
}