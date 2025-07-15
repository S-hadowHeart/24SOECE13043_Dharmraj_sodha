using System;
using System.ComponentModel;

class Q8
{
    static void Main()
    {
        //Write a C# Sharp program to sort array elements in descending order.
        int size;
        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements of the array:");
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        // Sort the array in descending order
        Console.WriteLine("Sorting array elements in descending order:");
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] < arr[j]) // Change to '>' for ascending order
                {
                    // Swap elements
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        // Display the sorted array
        Console.WriteLine("Sorted array in descending order:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }
}