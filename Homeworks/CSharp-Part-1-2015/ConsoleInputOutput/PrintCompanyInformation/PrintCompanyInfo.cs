//Problem 2. Print Company Information
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Example input:
//program 	user
//Company name: 	Telerik Academy
//Company address: 	31 Al. Malinov, Sofia
//Phone number: 	+359 888 55 55 555
//Fax number: 	
//Web site: 	http://telerikacademy.com/
//Manager first name: 	Nikolay
//Manager last name: 	Kostov
//Manager age: 	25
//Manager phone: 	+359 2 981 981
//Example output:
//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Please enter Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Please enter Company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Please enter Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Please enter Fax number: ");
        string faxNumber = Console.ReadLine();
        if (faxNumber == string.Empty)
        {
            faxNumber = "(no fax)"; 
        }
        Console.Write("Please enter Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Please enter Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Please enter Manager last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Please enter Manager age: ");
        uint managerAge = UInt32.Parse(Console.ReadLine());
        Console.Write("Please enter Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine();
        //first approach to print company info
        Console.WriteLine(@"
{0}
Address: {1}
Tel. {2}
Fax: {3}
Web site: {4}
Manager: {5} {6} (age: {7}, tel. {8})"
        ,companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        //second approach to print company info
        Console.WriteLine();
        Console.WriteLine("\n{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})", companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhone);
        //third approach to print company info
        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phoneNumber);
        Console.WriteLine("Fax: " + faxNumber);
        Console.WriteLine("Web site: " + webSite);
        Console.WriteLine("Manager: " + managerFirstName + " " + managerLastName + " (age: " + managerAge + ", tel. " + managerPhone + ")");
    }
}
