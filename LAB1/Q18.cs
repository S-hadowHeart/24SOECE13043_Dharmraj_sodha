using System;
namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q18
    {
        public static void Main(string[] args)
        {
            int m = 1;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(m++ + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
