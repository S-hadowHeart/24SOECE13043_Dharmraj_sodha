using System;

class Q1
{
    static void Main()
    {
        //stoeres elements in an array  and prints them
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
        for (int i = 0; i < size; i++) {
            Console.Write($"Element {i + 1}: ");
            try
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid integer.");
                i--; // Decrement i to repeat this iteration
            }
        }
        Console.WriteLine("All elements stored successfully.");
        foreach (int element in arr)
        {
            Console.WriteLine($"Stored element: {element}");
        }
    }
    }