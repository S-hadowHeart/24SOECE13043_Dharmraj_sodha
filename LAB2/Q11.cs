using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements (N): ");
            int N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"Sum of array elements = {sum}");
        }
    }
}
