// This is Q10.cs
using System;
using System.ComponentModel;

class Q10
{
    static void Main()
    {
        //Write a C# Sharp program for adding two matrices of the same size.
        int rows, cols;
        Console.Write("Enter the number of rows: ");
        rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        cols = Convert.ToInt32(Console.ReadLine());
        int[,] matrix1 = new int[rows, cols];
        int[,] matrix2 = new int[rows, cols];
        int[,] sumMatrix = new int[rows, cols];
        Console.WriteLine("Enter elements of first matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Enter elements of second matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        // Adding the two matrices
        Console.WriteLine("Sum of the two matrices:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                Console.Write(sumMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}