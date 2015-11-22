//Problem 3. Sequence n matrix
//We are given a matrix of strings of size N x M. Sequences in the matrix
//we define as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Example:
//matrix 	result 		    matrix 	result
//ha	fifi	ho	hi      ha, ha, ha 		
//fo	ha	    hi	xx
//xxx	ho	    ha	xx
//	
//s	    qq	s               s, s, s
//pp	pp	s
//pp	qq	s
	

using System;

class SequenceNMatrix
{
    static void Main(string[] args)
    {
        string[,] stringMatrix = 
            {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx",},
            {"xxx", "ho", "ha", "xx"},
            };
        int bestSequence = 1;
        int curentSequence = 1;
        string result = "";
        for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1); col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row + 1, col])
                {
                    curentSequence++;
                }
                if (curentSequence > bestSequence)
                {
                    bestSequence = curentSequence;
                    result = stringMatrix[row, col];
                }

            }
        }
        curentSequence = 1;
        for (int row = 0; row < stringMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row, col + 1])
                {
                    curentSequence++;
                }
                if (curentSequence > bestSequence)
                {
                    bestSequence = curentSequence;
                    result = stringMatrix[row, col];
                }

            }
        }
        curentSequence = 1;
        for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row + 1, col + 1])
                {
                    curentSequence++;
                }
                if (curentSequence > bestSequence)
                {
                    bestSequence = curentSequence;
                    result = stringMatrix[row, col];
                }
            }
        }
        curentSequence = 0;
        for (int row = 1; row < stringMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row - 1, col + 1])
                {
                    curentSequence++;
                }
                if (curentSequence > bestSequence)
                {
                    bestSequence = curentSequence;
                    result = stringMatrix[row, col];
                }
            }
        }
        for (int i = 0; i < bestSequence; i++)
        {
            if (i == bestSequence - 1)
            {
                Console.Write(result);
            }
            else
            {
                Console.Write(result + ", ");
            }
        }
        Console.WriteLine();
    }
}

