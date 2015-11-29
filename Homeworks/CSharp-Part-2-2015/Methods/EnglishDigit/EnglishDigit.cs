﻿//Problem 3. English digit
//Write a method that returns the last digit of given integer as an English word.
//Examples:
//input 	output
//512 	two
//1024 	four
//12309 	nine

using System;

class EnglishDigit
{
    static string LastDigitToWord(int number)
    {
        string lastDigit = "";
        switch (number % 10)
        {
            case 0: 
                lastDigit = "zero";
                break;
            case 1: 
                lastDigit = "one";
                break;
            case 2: 
                lastDigit = "two";
                break;
            case 3: 
                lastDigit = "three";
                break;
            case 4: 
                lastDigit = "four";
                break;
            case 5: 
                lastDigit = "five";
                break;
            case 6: 
                lastDigit = "six";
                break;
            case 7: 
                lastDigit = "seven";
                break;
            case 8: 
                lastDigit = "eight";
                break;
            case 9: 
                lastDigit = "nine";
                break;
        }
        return lastDigit;
    }

    static void Main()
    {
        Console.WriteLine("Please eneter a number to get it's last digit as word: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitToWord(number));
    }
}

