//Problem 7. One system to any other
//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;

class OneSystemToAnyOther
{
    static int ParseBaseNumeralSystem()
    {
        int numeralSystemBase = int.Parse(Console.ReadLine());
        while (numeralSystemBase <= 1 || numeralSystemBase >= 17)
        {
            Console.WriteLine("invalid Input! Please enter a value in the range (2 ≤ value ≤ 16)");
            numeralSystemBase = int.Parse(Console.ReadLine());
        }
        return numeralSystemBase;
    }
    static void Main()
    {
        Console.WriteLine("Please enter from which numeral system you would like to convert:");
        int sourceBaseSystem = ParseBaseNumeralSystem();
        Console.WriteLine("Please enter to which numeral system you would like to convert:");
        int targetBaseSystem = ParseBaseNumeralSystem();
        Console.WriteLine("Please enter value to convert:");
        string input = Console.ReadLine().ToUpper();
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i]))
            {
                result += (input[i] - '0') * (int)Math.Pow(sourceBaseSystem, input.Length - i - 1);
            }
            else
            {
                result += (input[i] - 'A' + 10) * (int)Math.Pow(sourceBaseSystem, input.Length - i - 1);
            }
        }
        string finalResult = string.Empty;
        int remainder;
        while (result > 0)
        {
            remainder = result % targetBaseSystem;
            result /= targetBaseSystem;
            switch (remainder)
            {
                case 10:
                    finalResult = "A" + finalResult;
                    break;
                case 11:
                    finalResult = "B" + finalResult;
                    break;
                case 12:
                    finalResult = "C" + finalResult;
                    break;
                case 13:
                    finalResult = "D" + finalResult;
                    break;
                case 14:
                    finalResult = "E" + finalResult;
                    break;
                case 15:
                    finalResult = "F" + finalResult;
                    break;
                default:
                    finalResult = remainder.ToString() + finalResult;
                    break;
            }
        }
        Console.WriteLine(" {0}({1}) = {2}({3})", input, sourceBaseSystem, finalResult, targetBaseSystem);
    }
}
