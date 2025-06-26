using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha
{
    internal class Q3
    {
        public static void Main(string[] a)
        {
            int b = 5;
            int k = 1;
            for (int i = 1; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    System.Console.Write(k);
                    System.Console.Write(" ");
                    k++;
                }
                System.Console.WriteLine();
            }
        }
    }
}
