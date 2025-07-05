using System;
namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q22
    {
        public static void Main()
        {
            int n = 5;
            for (int i = 1; i <= 2 * n - 1; i++)
            {
                int spaces = Math.Abs(n - i);
                int stars = 2 * (n - spaces) - 1;

                Console.Write(new string(' ', spaces));
                Console.WriteLine(new string('*', stars));
            }
        }
    }

}

