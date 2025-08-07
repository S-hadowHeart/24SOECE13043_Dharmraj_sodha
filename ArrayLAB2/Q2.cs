using System;

class Q2
{
    static void Main()
    {
        //sorting element
        int size;
        Console.Write("Enter the size of the array: ");
        try { size = Convert.ToInt32(Console.ReadLine()); }
        catch
        {
            Console.WriteLine("Invalid input! Defaulting size to 10.");
            size = 10;
        }
        if (size <= 0)
        {
            Console.WriteLine("Size must be a positive integer. Defaulting to 10.");
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
        //soring arry without built-in sort method
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    // Swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        Console.WriteLine("Sorted array:");
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

    }

}
