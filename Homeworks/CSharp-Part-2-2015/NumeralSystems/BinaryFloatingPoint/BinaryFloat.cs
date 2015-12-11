//Problem 9.* Binary floating-point
//Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format (the C# type float).
//Example:
//number 	sign 	exponent 	mantissa
//-27,25 	1 	    10000011 	10110100000000000000000

using System;

class BinaryFloat
{
    const string formatter = "{0,-10}{1,-10}{2,-10}{3,-20}";
    static void Main()
    {
        Console.WriteLine("Please enter a C# short to get its binary representation:");
        float input = float.Parse(Console.ReadLine());
        string result = string.Empty;
        byte[] byteArray = BitConverter.GetBytes(input);
        for (int i = 0; i < byteArray.Length; i++)
        {
            result = Convert.ToString(byteArray[i], 2).PadLeft(8, '0') + result;
        }
        string sign = new string(result[0],1);
        string exponent = result.Substring(1, 8);
        string mantissa = result.Substring(9, 22);
        Console.WriteLine(formatter, "number", "sign", "exponent", "mantissa");
        Console.WriteLine(formatter, input, sign, exponent, mantissa);
    }
}
