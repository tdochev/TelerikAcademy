using System;

class BinaryShort
{
    static void Main()
    {
        Console.WriteLine("Please enter a C# short to get its binary representation:");
        short input = short.Parse(Console.ReadLine());
        string result = string.Empty;
        byte[] byteArray = BitConverter.GetBytes(input);
        for (int i = 0; i < byteArray.Length; i++)
        {
            result = Convert.ToString(byteArray[i], 2).PadLeft(8, '0') + result;
        }
        Console.WriteLine("The binary value of {0} is {1}.", input, result);
    }
}