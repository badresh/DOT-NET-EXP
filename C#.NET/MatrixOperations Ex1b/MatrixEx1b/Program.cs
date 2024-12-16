using System;

class MatrixMultiplication
{
    static void Main()
    {

        Console.Write("Enter the number of rows in the first matrix: ");
        int rowsMatrix1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns in the first matrix: ");
        int colsMatrix1 = int.Parse(Console.ReadLine());




        int[,] matrix1 = new int[rowsMatrix1, colsMatrix1];
        Console.WriteLine("Enter the elements of the first matrix:");
        for (int i = 0; i < rowsMatrix1; i++)
        {
            for (int j = 0; j < colsMatrix1; j++)
            {
                Console.Write($"Element [{i + 1}, {j + 1}]: ");
                
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }


        Console.Write("Enter the number of rows in the second matrix: ");
        int rowsMatrix2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns in the second matrix: ");
        int colsMatrix2 = int.Parse(Console.ReadLine());

        if (colsMatrix1 != rowsMatrix2)
        {
            Console.WriteLine("Matrices cannot be multiplied.");
            return;
        }


        int[,] matrix2 = new int[rowsMatrix2, colsMatrix2];
        Console.WriteLine("Enter the elements of the second matrix:");
        for (int i = 0; i < rowsMatrix2; i++)
        {
            for (int j = 0; j < colsMatrix2; j++)
            {
                Console.Write($"Element [{i + 1}, {j + 1}]: ");
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[,] resultMatrix = new int[rowsMatrix1, colsMatrix2];


        for (int i = 0; i < rowsMatrix1; i++)
        {
            for (int j = 0; j < colsMatrix2; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < colsMatrix1; k++)
                {
                    resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }


        Console.WriteLine("Result matrix multiplication is:");
        for (int i = 0; i < rowsMatrix1; i++)
        {
            for (int j = 0; j < colsMatrix2; j++)
            {
                Console.Write(resultMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
