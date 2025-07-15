using System;
using System.ComponentModel;

class Q6
{
    static void Main()
    {
        //Write a C# Sharp program to find the maximum and minimum elements in an array.
        int size;
        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        // Initialize max and min with the first element
        int max = arr[0];
        int min = arr[0];
        // Find max and min

        Console.WriteLine("Finding maximum and minimum elements in the array:");
        for (int i = 1; i < size; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        // Display the results
        Console.WriteLine("Maximum element in the array: " + max);
        Console.WriteLine("Minimum element in the array: " + min);

    }
}