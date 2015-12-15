//Problem 4. Download file
//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        string remoteUri = "http://telerikacademy.com/Content/Images/";
        string fileName = "news-img01.png";
        string myStringWebResource = string.Empty;

        using (WebClient myWebClient = new WebClient())
        {
            myStringWebResource = remoteUri + fileName;
            try
            {
                myWebClient.DownloadFile(myStringWebResource, fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
        }
        // Download the Web resource and save it into the current filesystem folder.
        Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
    }
}

