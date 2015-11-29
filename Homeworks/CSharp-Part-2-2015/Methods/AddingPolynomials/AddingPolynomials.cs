//Problem 11. Adding polynomials
//Write a method that adds two polynomials.
//Represent them as arrays of their coefficients.
//Example:
//x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

using System;

namespace Polynominals
{
    public class AddingPolynomials
    {
        public static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0 && i != 0)
                {
                    if (polynomial[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} +", i, polynomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polynomial[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynomial[i]);
                }
            }

            Console.WriteLine();
        }
        static decimal[] SumOfPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
        {
            int minLenght = 0;
            int maxLenght = 0;
            bool firstIsSmaller = true;

            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                minLenght = secondPolynomial.Length;
                maxLenght = firstPolynomial.Length;
                firstIsSmaller = false;
            }
            else
            {
                minLenght = firstPolynomial.Length;
                maxLenght = secondPolynomial.Length;
            }
            decimal[] result = new decimal[maxLenght];
            for (int i = 0; i < minLenght; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }

            for (int i = minLenght; i < result.Length; i++)
            {
                if (firstIsSmaller)
                {
                    result[i] = secondPolynomial[i];
                }
                else
                {
                    result[i] = firstPolynomial[i];
                }
            }
            return result;
        }
 
        static void Main()
        {
            decimal[] firstPolynomial = { 5, 0, 1 };
            decimal[] secondPolynomial = { 5, -6, 3 };
            Console.Write("First polynominal:           ");
            PrintPolynomial(firstPolynomial);
            Console.Write("Second polynominal:          ");
            PrintPolynomial(secondPolynomial);
            Console.Write("Sum of polynominal:          ");
            PrintPolynomial(SumOfPolynomials(firstPolynomial, secondPolynomial));
        }
    }

}
