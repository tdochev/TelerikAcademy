////Problem 6. Divisible by 7 and 3
////Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
////Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LINQDivisibleBy7And3
    {
        private const int FirstDivisor = 3;
        private const int SecondDivisor = 7;

        public static void Main()
        {
            int[] numbersArray = { 1, 3, 7, 21, 42, 84, 85, 100, 168 };
            DivisibleByLinq(numbersArray);
            DivisibleByLambda(numbersArray);
        }

        private static void DivisibleByLinq(int[] numbersArray)
        {
            var result = (from number in numbersArray
                          where (number % FirstDivisor == 0 || number % SecondDivisor == 0)
                          select number).ToArray();
            Console.WriteLine(string.Join(", ", result));
        }

        private static void DivisibleByLambda(int[] numbersArray)
        {
            var result = numbersArray.Where(n => n % FirstDivisor == 0 || n % SecondDivisor == 0);
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
