// This is Q4.cs
using System;
using System.Reflection;

class Q4
{
    static void Main()
    {
       // copy one arry to another
       int size;
         Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] arr1 = new int[size];
        int[] arr2 = new int[size];
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        // Copying arr1 to arr2
        for (int i = 0; i < size; i++)
        {
            arr2[i] = arr1[i];
        }
        // Displaying the copied array
        Console.WriteLine("Copied array elements:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("Element {0}: {1}", i + 1, arr2[i]);
        }
    }
}