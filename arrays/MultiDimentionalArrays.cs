using System;

class Program
{
    static void Main123()
    {
        // Define two 2x2 matrices
        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
        int[,] matrixB = { { 5, 6 }, { 7, 8 } };

        // Display matrices
        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("\nMatrix B:");
        DisplayMatrix(matrixB);

        // Add matrices
        int[,] sumMatrix = AddMatrices(matrixA, matrixB);

        // Display the sum
        Console.WriteLine("\nSum of Matrices:");
        DisplayMatrix(sumMatrix);

        // Multiply matrices
        int[,] productMatrix = MultiplyMatrices(matrixA, matrixB);

        // Display the product
        Console.WriteLine("\nProduct of Matrices:");
        DisplayMatrix(productMatrix);
    }

    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int cols = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        return resultMatrix;
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int colsB = matrixB.GetLength(1);

        int[,] resultMatrix = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                for (int k = 0; k < colsA; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return resultMatrix;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
