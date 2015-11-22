//Problem 6.* Matrix class
//Write a class Matrix, to hold a matrix of integers. Overload the operators for
//adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().

using System;

class MatrixClass
{
    public class Matrix
    {
        int rows = 0;
        int cols = 0;
        int[,] matrix;

        public Matrix(int Rows, int Cols)
        {
            rows = Rows;
            cols = Cols;
            matrix = new int[rows, cols];
        }

        public int this[int Row, int Col]
        {
            get { return matrix[Row, Col]; }
            set { matrix[Row, Col] = value; }
        }

        public void Fill()
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("Enter value for [{0},{1}]",row,col);
                    matrix[row,col]=int.Parse(Console.ReadLine());
                }
            }
        }
        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix result = new Matrix(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new Exception("Cannot sum matrices with different sizes!");
            }
            else
            {
                for (int row = 0; row < result.rows; row ++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        result[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                    }
                    
                }

            }
            return result;
        }
        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix result = new Matrix(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows != secondMatrix.cols)
            {
                throw new Exception("Cannot substract matrices with different sizes!");
            }
            else
            {
                for (int row = 0; row < result.rows; row ++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        result[row, col] = firstMatrix[row, col] - secondMatrix[row, col];
                    }
                    
                }

            }
            return result;
        }

        public static Matrix operator *(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix result = new Matrix(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows != secondMatrix.cols)
            {
                throw new Exception("The numbers of columns of the first matrix should match the number of rows of the second matrix in order to multiply them!");
            }
            else
            {
                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        result[row, col] = 0;
                        for (int firstMatrixCol = 0; firstMatrixCol < firstMatrix.cols; firstMatrixCol++)
                        {
                            result[row, col] += firstMatrix[row, firstMatrixCol] * secondMatrix[firstMatrixCol, col];
                        }
                    }

                }

            }
            return result;
        }

        public override string ToString()
        {
            string result = "";
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    result += String.Format("{0,3}", matrix[row, col]) + " ";
                }
                result += "\r\n";
            }
            return result;
        }
    }
    static void Main()
    {
        Matrix firstMatrix = new Matrix(3, 3);
        Matrix secondMatrix = new Matrix(3, 3);
        Console.WriteLine("Fill in first matrix:");
        firstMatrix.Fill();
        Console.WriteLine("Fill in second matrix:");
        secondMatrix.Fill();
        Console.WriteLine("First matrix:");
        Console.WriteLine(firstMatrix.ToString());
        Console.WriteLine("Second matrix: ");
        Console.WriteLine(secondMatrix.ToString());
        Console.WriteLine("The sum of the first and second matrices is: ");
        Console.WriteLine(firstMatrix+secondMatrix);
        Console.WriteLine("The substraction result of the first and second matrices is: ");
        Console.WriteLine(firstMatrix-secondMatrix);
        Console.WriteLine("The multilication result of the first and second matrices is: ");
        Console.WriteLine(firstMatrix * secondMatrix);

    }
}
