using System;
namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q19
    {
        public static void Main(string[] args)
        {
            int m = 3;
            for (int i = 1; i < 5 ; i++)
            {
                for (int j = m; j >= 1; j--)
                { 
                    System.Console.Write(" ");
                }
                m--;
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
