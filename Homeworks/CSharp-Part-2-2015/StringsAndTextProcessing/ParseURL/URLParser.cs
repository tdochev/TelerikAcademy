//Problem 12. Parse URL
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
//and extracts from it the [protocol], [server] and [resource] elements.
//Example:
//URL 	Information
//http://telerikacademy.com/Courses/Courses/Details/212 	
//[protocol] = http
//[server] = telerikacademy.com
//[resource] = /Courses/Courses/Details/212

using System;
using System.Text;
using System.Diagnostics;

class URLParser
{
    //Lenght of :// = 3
    static int MagicInt = 3;
    static void Main()
    {
        Stopwatch stopWatchForSubstring = new Stopwatch();
        Stopwatch stopWatchForString = new Stopwatch();
        Stopwatch stopWatchForStringBuilder = new Stopwatch();
        Console.WriteLine("Please enter a URL:");
        string Url = Console.ReadLine();
        stopWatchForSubstring.Start();
        string protocol = Url.Substring(0, Url.IndexOf("://"));
        string server = Url.Substring(Url.IndexOf("://") + MagicInt, Url.IndexOf('/', Url.IndexOf("://") + MagicInt) - protocol.Length - MagicInt);
        string resource = Url.Substring(protocol.Length + server.Length + MagicInt);
        stopWatchForSubstring.Stop();
        stopWatchForString.Start();
        string protocol1 = string.Empty;
        string server1 = string.Empty;
        string resource1 = string.Empty;
        int i = 0;
        while (Url[i] != ':')
        {
            protocol1+=Url[i];
            i++;
        }
        i += MagicInt;
        while (Url[i] != '/')
        {
            server1+=Url[i];
            i++;
        }
        while (i < Url.Length)
        {
            resource1+=Url[i];
            i++;
        }
        stopWatchForString.Stop();
        stopWatchForStringBuilder.Start();
        StringBuilder protocol2 = new StringBuilder();
        StringBuilder server2 = new StringBuilder();
        StringBuilder resource2 = new StringBuilder();
        int y = 0;
        while (Url[y] != ':')
        {
            protocol2.Append(Url[y]);
            y++;
        }
        y += MagicInt;
        while (Url[y] != '/')
        {
            server2.Append(Url[y]);
            y++;
        }
        while (y < Url.Length)
        {
            resource2.Append(Url[y]);
            y++;
        }
        stopWatchForStringBuilder.Stop();
        Console.WriteLine();
        Console.WriteLine("Parsing with substring");
        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}\n[time elapsed] = {3}", protocol, server, resource, stopWatchForSubstring.Elapsed);
        Console.WriteLine();
        Console.WriteLine("Parsing with while loop and string");
        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}\n[time elapsed] = {3}", protocol1, server1, resource1, stopWatchForString.Elapsed);
        Console.WriteLine();
        Console.WriteLine("Parsing with while loop and string builder");
        Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}\n[time elapsed] = {3}", protocol2, server2, resource2, stopWatchForStringBuilder.Elapsed);
    }
}
