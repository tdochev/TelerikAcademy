//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:
//numbers 	result
//2 1 1 6 3 	yes
//product = 6 	
//	
//3 10 4 6 5 1 	yes
//product = 60 	
//	
//4 3 2 5 2 	no
//odd_product = 16 	
//even_product = 15 	

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Please enter number separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
            if ((i+1) % 2 ==0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = {0}", oddProduct);
            Console.WriteLine("even_product = {0}",evenProduct);
        }

    }
}

