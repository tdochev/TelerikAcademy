//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//a) 	b) 	c) 	d)*
//1	5	9	13
//2	6	10	14
//3	7	11	15
//4	8	12	16
//	
//1	8	9	16
//2	7	10	15
//3	6	11	14
//4	5	12	13
//	
//7	11	14	16
//4	8	12	15
//2	5	9	13
//1	3	6	10
//	
//1	12	11	10
//2	13	16	9
//3	14	15	8
//4	5	6	7


using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.WriteLine("Please enter n for the size of matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] numbersMatrix = new int[n, n];
        Console.WriteLine("Please select which type of matrix woul you like to fill and print: \na: \nb: \nc: \nd: ");
        ConsoleKeyInfo key = Console.ReadKey(true);
        int number = n / n;
        //fill in the matrix as per case a:
        if (key.Key.ToString() == "A")
        {
            for (int row = 0; row < numbersMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < numbersMatrix.GetLength(1); col++)
                {
                    numbersMatrix[col, row] = number;
                    number++;
                }
            }
        }
        //fill in the matrix as per case b:
        if (key.Key.ToString() == "B")
        {
            bool isReversed = false;
            for (int row = 0; row < numbersMatrix.GetLength(0); row++)
            {
                isReversed = !isReversed;
                for (int col = 0; col < numbersMatrix.GetLength(1); col++)
                {
                    if (isReversed)
                    {
                        numbersMatrix[col, row] = number;
                        number++;
                    }
                    else
                    {
                        numbersMatrix[numbersMatrix.GetLength(1) - 1 - col, row] = number;
                        number++;
                    }
                }
            }
        }
        //fill in the matrix as per case c:
        if (key.Key.ToString() == "C")
        {
            int startCol = 0;
            int startRow = n - 1;
            numbersMatrix[startRow, startCol] = number;
            while (number <= n * n)
            {
                int currentCol = startCol;
                int currentRow = startRow;
                if (startRow >= startCol)
                {
                    for (int y = n - currentRow; y > 0; y--)
                    {
                        numbersMatrix[currentRow, currentCol] = number;
                        number++;
                        currentCol++;
                        currentRow++;
                    }
                    startRow--;
                }
                if (startRow < startCol)
                {
                    currentRow = n - n;
                    for (int y = currentCol; y < n; y++)
                    {
                        numbersMatrix[currentRow, currentCol] = number;
                        number++;
                        currentCol++;
                        currentRow++;
                    }
                    startCol++;
                }
            }
        }
        //fill in the matrix as per case d:
        if (key.Key.ToString() == "D")
        {
            int currentCol = 0;
            int currentRow = 0;
            char direction = 'd';
            while (number <= n* n)
            {
                numbersMatrix[currentRow, currentCol] = number++;
                if (direction == 'd')
                {
                    currentRow++;
                    //number++;
                }
                if (direction == 'r')
                {
                    currentCol++;
                    //number++;
                }
                if (direction == 'u')
                {
                    currentRow--;
                    //number++;
                }
                if (direction == 'l')
                {
                    currentCol--;
                    //number++;
                }
                if (direction == 'r' && (currentCol > n - 1 || numbersMatrix[currentRow, currentCol]!=0))
                {
                    direction = 'u';
                    currentCol--;
                    currentRow--;
                }
                if (direction == 'd' && (currentRow > n - 1 || numbersMatrix[currentRow, currentCol] != 0))
                {
                    direction = 'r';
                    currentCol++;
                    currentRow--;
                }
                if (direction == 'u' && (currentRow < 0 || numbersMatrix[currentRow, currentCol] != 0))
                {
                    direction = 'l';
                    currentCol--;
                    currentRow++;
                }
                if (direction == 'l' && (currentCol < 0 || numbersMatrix[currentRow, currentCol] != 0))
                {
                    direction = 'd';
                    currentCol++;
                    currentRow++;
                }

            }
            //print the result
            for (int row = 0; row < numbersMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < numbersMatrix.GetLength(1); col++)
                {
                    if (col == numbersMatrix.GetLength(1) - 1)
                    {
                        Console.Write("{0,2}", numbersMatrix[row, col]);
                    }
                    else
                    {
                        Console.Write("{0,2}, ", numbersMatrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

