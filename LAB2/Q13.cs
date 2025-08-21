using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q13
    {
        static void Main(string[] args)
        {
            // Denominations available in Indian currency
            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            Console.Write("Enter the amount: ");
            int amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Minimum number of notes required:");

            foreach (int note in notes)
            {
                int count = amount / note;
                if (count > 0)
                {
                    Console.WriteLine($"Notes of Rs.{note} = {count}");
                    amount %= note;
                }
            }
        }
    }
}
