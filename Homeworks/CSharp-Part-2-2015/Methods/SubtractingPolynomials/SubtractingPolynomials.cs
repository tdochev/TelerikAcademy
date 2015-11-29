//Problem 12. Subtracting polynomials
//Extend the previous program to support also subtraction and multiplication of polynomials.

namespace Polynominals
{

    using System;
    class SubtractingPolynomials
    {
        static decimal[] SubstractPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
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
                result[i] = firstPolynomial[i] - secondPolynomial[i];
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
        static decimal[] MultiplyPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
        {
            decimal[] result = new decimal[firstPolynomial.Length + secondPolynomial.Length];
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                for (int j = 0; j < secondPolynomial.Length; j++)
                {
                    int position = i + j;
                    result[position] += (firstPolynomial[i] * secondPolynomial[j]);
                }
            }
            return result;
        }
        static void Main()
        {
            decimal[] firstPolynomial = { 5, 0, 1 };
            decimal[] secondPolynomial = { 5, -6, 3 };
            Console.Write("First polynominal:                               ");
            AddingPolynomials.PrintPolynomial(firstPolynomial);
            Console.Write("Second polynominal:                              ");
            AddingPolynomials.PrintPolynomial(secondPolynomial);
            Console.Write("Substraction of polynominal:                     ");
            AddingPolynomials.PrintPolynomial(SubstractPolynomials(firstPolynomial, secondPolynomial));
            Console.Write("Multiplication of polynominal:                   ");
            AddingPolynomials.PrintPolynomial(MultiplyPolynomials(firstPolynomial, secondPolynomial));
        }

    }
}
