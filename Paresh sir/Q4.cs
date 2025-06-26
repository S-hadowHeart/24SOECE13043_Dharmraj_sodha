using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha
{
    internal class Q4
    {
        public static void Main(string[] a)
        {
            int d = 0;
            bool increasing = false;

            for (int i = 1; i <= 5; i++)
            {
                increasing = !increasing;
                int k = increasing ? d + 1 : d + i;

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k += increasing ? 1 : -1;
                }

                d += i;
                Console.WriteLine();
            }
        }

    }
}

