﻿//Problem 10. Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Ivan";
        string lastName = "Ivanov";
        byte age = 32;
        char gender = 'm';
        long personalIDNumner = 8306112507;
        uint UniqueEmployeenumber = 27569999;
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(personalIDNumner);
        Console.WriteLine(UniqueEmployeenumber);

    }
}

