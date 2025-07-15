using System;
using System.ComponentModel;

class Q9
{
    static void Main()
    {
        //Write a C# Sharp program to delete an element at the desired position from an array.
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
        // Display the original array
        Console.WriteLine("Original array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        // Ask for the position to delete
        Console.Write("Enter the position of the element to delete (1 to {0}): ", size);
        int position = Convert.ToInt32(Console.ReadLine());
        // Validate position
        if (position < 1 || position > size)
        {
            Console.WriteLine("Invalid position! Please enter a position between 1 and {0}.", size);
            return;
        }
        // Adjust position for zero-based index
        position--; // Convert to zero-based index
        // Create a new array with one less size
        int[] newArr = new int[size - 1];
        // Copy elements to the new array, skipping the element at the specified position
        for (int i = 0, j = 0; i < size; i++)
        {
            if (i != position) // Skip the element at the specified position
            {
                newArr[j++] = arr[i];
            }
        }
        // Display the new array
        Console.WriteLine("Array after deleting element at position {0}:", position + 1);
        for (int i = 0; i < newArr.Length; i++)
        {
            Console.Write(newArr[i] + " ");
        }
        
    }
}