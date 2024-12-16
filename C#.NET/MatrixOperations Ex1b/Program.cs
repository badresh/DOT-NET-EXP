using System;

class MatrixOperations
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

        if (rowsMatrix1 != rowsMatrix2 || colsMatrix1 != colsMatrix2)
        {
            Console.WriteLine("Matrices must have the same dimensions for addition and subtraction.");
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

        Console.WriteLine("Choose an operation: 1. Addition 2. Subtraction 3. Multiplication");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                resultMatrix = AddMatrices(matrix1, matrix2);
                Console.WriteLine("Result of matrix addition is:");
                break;
            case 2:
                resultMatrix = SubtractMatrices(matrix1, matrix2);
                Console.WriteLine("Result of matrix subtraction is:");
                break;
            case 3:
                if (colsMatrix1 != rowsMatrix2)
                {
                    Console.WriteLine("Matrices cannot be multiplied.");
                    return;
                }
                resultMatrix = MultiplyMatrices(matrix1, matrix2);
                Console.WriteLine("Result of matrix multiplication is:");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                return;
        }

        PrintMatrix(resultMatrix);
    }

    static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rowsMatrix1 = matrix1.GetLength(0);
        int colsMatrix1 = matrix1.GetLength(1);
        int colsMatrix2 = matrix2.GetLength(1);
        int[,] result = new int[rowsMatrix1, colsMatrix2];

        for (int i = 0; i < rowsMatrix1; i++)
        {
            for (int j = 0; j < colsMatrix2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < colsMatrix1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
