using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Bhomi_mam
{
    internal class array1
    {
        public static void Main()
        {
            int[] arr;
            int size;
            Console.Write("Enter the size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            arr = new int[size];
            for (int i = 0; i < size; i++)

            {
                Console.Write("Enter the element: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The elements of the array are:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
