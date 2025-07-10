using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q7
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            { 
                for (int j = 1; j <= (i <= 5 ? i : 10 - i); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
