using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q12
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

            Console.Write("Enter element to search: ");
            int X = int.Parse(Console.ReadLine());

            int found = 0; // flag

            for (int i = 0; i < N; i++)
            {
                if (arr[i] == X)
                {
                    found = 1;
                    break;
                }
            }

            Console.WriteLine(found);
        }
    }
}
