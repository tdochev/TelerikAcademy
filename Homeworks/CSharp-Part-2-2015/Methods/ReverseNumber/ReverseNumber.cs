//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.
//Example:
//input 	output
//256 	    652
//123.45 	54.321

using System;

class ReverseNumber
{
    static decimal ReverseDecimal(decimal decimalToReverse)
    {
        string answer = "";
        for (int i = decimalToReverse.ToString().Length-1; i >= 0; i--)
        {
            answer +=  decimalToReverse.ToString()[i];
        }
        return decimal.Parse(answer);
    }
    //static string ReverseDecimal(decimal decimalToReverse)
    //{
    //    char[] result = decimalToReverse.ToString().ToCharArray();
    //    Array.Reverse(result);
    //    return new string(result);
    //}

    static void Main()
    {
        Console.WriteLine("Please enter a decimal to revesre it:");
        decimal input = decimal.Parse(Console.ReadLine());
        Console.Write("{0} => {1}", input, ReverseDecimal(input));
    }
    
}
