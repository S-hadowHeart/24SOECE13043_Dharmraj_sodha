using System;
using System.ComponentModel;

class Q5
{
    static void Main()
    {
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
        int[] count = new int[size];
        for (int i = 0; i < size; i++)
        {
            count[i] = 1; 
            for (int j = i + 1; j < size; j++)
            {
                if (arr[i] == arr[j])
                {
                    count[i]++;
                    arr[j] = -1;
                }
            }
        }
        Console.WriteLine("Duplicate elements and their counts:");
        
        for (int i = 0; i < size; i++)
        {
            if (arr[i] != -1 && count[i] > 1) 
            {
                Console.WriteLine("Element {0} occurs {1} times", arr[i], count[i]);
            }
        }


    }
}