//Problem 19.** Spiral Matrix
//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
//and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
//Examples:
//n = 2   matrix      n = 3   matrix      n = 4   matrix
//        1 2                 1 2 3               1  2  3  4
//        4 3                 8 9 4               12 13 14 5
//                            7 6 5               11 16 15 6
//                                                10 9  8  7
//

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int cRow = 0;
        int cCol = 0;
        char direction = 'r';
        for (int i = 1; i <= n * n; i++)
        {
            if (direction == 'r')
            {
                matrix[cRow, cCol] = i;
                cCol++;
            }
            if (direction == 'd')
            {
                matrix[cRow, cCol] = i;
                cRow++;
            }
            if (direction == 'l')
            {
                matrix[cRow, cCol] = i;
                cCol--;
            }
            if (direction == 'u')
            {
                matrix[cRow, cCol] = i;
                cRow--;
            }
            if (direction == 'r' && (cCol > n - 1 || matrix[cRow, cCol] != 0))
            {
                direction = 'd';
                cCol--;
                cRow++;
            }
            if (direction == 'd' && (cRow > n - 1 || matrix[cRow, cCol] != 0))
            {
                direction = 'l';
                cRow--;
                cCol--;
            }
            if (direction == 'l' && (cCol < 0 || matrix[cRow, cCol] != 0))
            {
                direction = 'u';
                cCol++;
                cRow--;
            }
            if (direction == 'u' && (cRow < 0 || matrix[cRow, cCol] != 0))
            {
                direction = 'r';
                cRow++;
                cCol++;
            }
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
                Console.Write("");
            }
            Console.WriteLine();
        }
    }
}

