using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Array
{
    internal class Q1
    {
        public static void Main(string[] args)
        {
            //FindType largest element in array
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
            Console.WriteLine("Enter 10 elements in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.Write($"Element {i + 1}: ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                    if (i == 0)
                    {
                        size = arr[i]; 
                    }
                    if (arr[i] > size)
                    {
                        size = arr[i];
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                    i--; 
                }
            }
            
            Console.WriteLine($"The largest element in the array is: {size}");
        }

    }
}
