////Problem 5. Maximal area sum
////Write a program that reads a text file containing a square matrix of numbers.
////Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
////The first line in the input file contains the size of matrix N.
////Each of the next N lines contain N numbers separated by space.
////The output should be a single number in a separate text file.
////
////Example:
////input       output
////4
////2 3 3 4
////0 2 3 4
////3 7 1 2
////4 3 3 2     17

using System;
using System.IO;

class MaximalAreaSum
{
    static void Main()
    {
        string inputPath = @"..\..\..\TextFiles\05.MaximalAreaSum.input.txt";
        string outputPath = @"..\..\..\TextFiles\05.MaximalAreaSum.output.txt";
        StreamReader inputReader = new StreamReader(inputPath);
        StreamWriter outputWriter = new StreamWriter(outputPath);
        int matrixSize = 0;
        int bestSum = 0;
        using (inputReader)
        {
            Console.WriteLine("The file:\n{0}\nconatining the matrix was successfully opened.", Path.GetFullPath(inputPath));
            Console.WriteLine();
            matrixSize = int.Parse(inputReader.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            int currentSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    char currentChar = (char)inputReader.Read();
                    if (char.IsDigit(currentChar))
                    {
                        matrix[row, col] = currentChar - '0';
                    }
                    else
                    {
                        col--;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                    }
                }
            }
        }

        using (outputWriter)
        {
            Console.WriteLine("The result of the calculations was saved to:\n{0}.", Path.GetFullPath(outputPath));
            outputWriter.Write(bestSum);
        }
    }
}
