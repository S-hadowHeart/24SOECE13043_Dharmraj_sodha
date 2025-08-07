
using System;
using System.ComponentModel;

class Q7
{
    static void Main()
    {
        //Write a program in C# Sharp to separate odd and even integers into separate arrays
        int size;
        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[size];
        int evenCount = 0, oddCount = 0;
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write("Element {0}: ", i + 1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        // Create separate arrays for even and odd integers
        int[] evenArr = new int[evenCount];
        int[] oddArr = new int[oddCount];
        evenCount = 0; // Reset count for filling even array
        oddCount = 0; // Reset count for filling odd array
        Console.WriteLine("Separating odd and even integers into separate arrays:");
        for (int i = 0; i < size; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenArr[evenCount++] = arr[i]; // Fill even array
            }
            else
            {
                oddArr[oddCount++] = arr[i]; // Fill odd array
            }
        }
        // Display the even array
        Console.WriteLine("Even integers:");
        for (int i = 0; i < evenArr.Length; i++)
        {
            Console.Write(evenArr[i] + " ");
        }
        Console.WriteLine();
        // Display the odd array
        Console.WriteLine("Odd integers:");
        for (int i = 0; i < oddArr.Length; i++)
        {
            Console.Write(oddArr[i] + " ");
        }
        
    }
}