using System;
using System.Runtime.InteropServices;

class Q3
{
    static void Main()
    {
        //revers arrary order
        int size;
        Console.Write("Enter the size of the array: ");

        try
        {
            size = Convert.ToInt32(Console.ReadLine());
            if (size <= 0)
            {
                Console.WriteLine("Size must be a positive integer. Defaulting to 10.");
                size = 10;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Defaulting size to 10.");
            size = 10;
        }
        int[] arr = new int[size];
        Console.WriteLine("Enter elements in the array:");
        for (int i = 0; i < arr.Length; i++)
        {
            try
            {
                Console.Write($"Element {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                i--; // Decrement i to repeat this iteration
            }
        }
        Console.WriteLine("Reversed array:");
        int[] reversedArr = new int[size];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            reversedArr[arr.Length - 1 - i] = arr[i];
            Console.Write(arr[i] + " ");
        }
        
    }
}