//Problem 2. Maximal sum
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.WriteLine("Please enter number of rows for your matrix(the number of rows should be >= 3): ");
        int rows = int.Parse(Console.ReadLine());
        while (rows < 3)
        {
            Console.WriteLine("Invalid Number! The number of rows should be >= 3");
            Console.WriteLine("Please enter number of rows for your matrix (the number of rows should be >= 3):");
            rows = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Please enter number of columns for your matrix(the number of columns should be >= 3):");
        int cols = int.Parse(Console.ReadLine());
        while (cols < 3)
        {
            Console.WriteLine("Invalid Number! The number of columns should be >= 3");
            Console.WriteLine("Please enter number of columns for your matrix (the number of columns should be >= 3):");
            cols = int.Parse(Console.ReadLine());
        }
        int[,] numbers = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Enter matrix [{0}, {1}]", row, col);
                numbers[row, col] = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine();
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0,3} ", numbers[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < numbers.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < numbers.GetLength(1) - 2; col++)
            {
                int currentSum = numbers[row, col] + numbers[row, col + 1] + numbers[row, col + 2] +
                   numbers[row + 1, col] + numbers[row + 1, col + 1] + numbers[row + 1, col + 2] +
                   numbers[row + 2, col] + numbers[row + 2, col + 1] + numbers[row + 2, col + 2];
                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }
        Console.WriteLine("The Maximal sum is: {0}", bestSum);
        Console.WriteLine();
        Console.WriteLine("The 3x3 square with best sum in the matrix is:");
        Console.WriteLine("{0,3}{1,3}{2,3}", numbers[bestRow, bestCol], numbers[bestRow, bestCol + 1], numbers[bestRow, bestCol + 2]);
        Console.WriteLine("{0,3}{1,3}{2,3}", numbers[bestRow + 1, bestCol], numbers[bestRow + 1, bestCol + 1], numbers[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0,3}{1,3}{2,3}", numbers[bestRow + 2, bestCol], numbers[bestRow + 2, bestCol + 1], numbers[bestRow + 2, bestCol + 2]);
    }
}

