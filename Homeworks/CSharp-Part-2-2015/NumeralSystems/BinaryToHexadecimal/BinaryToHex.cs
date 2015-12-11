﻿//Problem 6. Binary to hexadecimal
//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinaryToHex
{
    static void Main()
    {
        {
            Console.WriteLine("Please enter a binary number to convert it to hexadecimal:");
            string input = Console.ReadLine();
            string result = string.Empty;
            for (int i = 0; i < input.Length; i+= 4)
            {
                string currentFour = input.Substring(i, 4);
                switch (currentFour)
                {
                    case "0000":
                        result += "0";
                        break;
                    case "0001":
                        result += "1";
                        break;
                    case "0010":
                        result += "2";
                        break;
                    case "0011":
                        result += "3";
                        break;
                    case "0100":
                        result += "4";
                        break;
                    case "0101":
                        result += "5";
                        break;
                    case "0110":
                        result += "6";
                        break;
                    case "0111":
                        result += "7";
                        break;
                    case "1000":
                        result += "8";
                        break;
                    case "1001":
                        result += "9";
                        break;
                    case "1010":
                        result += "A";
                        break;
                    case "1100":
                        result += "B";
                        break;
                    case "1011":
                        result += "C";
                        break;
                    case "1101":
                        result += "D";
                        break;
                    case "1110":
                        result += "E";
                        break;
                    case "1111":
                        result += "F";
                        break;
                }
            }
            Console.WriteLine("Your hexadecimal result is: " + result);
        }
    }
}

