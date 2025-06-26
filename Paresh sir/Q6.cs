using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha
{
    internal class Q6
    {
        public static void Main(String[] a)
        {
            Console.WriteLine("Welcome to computer");
            int j = 1;
            int l = 1;
            for (int i = 5; i > 0; i--)
            {

                while (j < i)
                {
                    Console.Write(" ");
                    j++;


                }
                while (j <= 5)
                {
                    Console.Write(l+" ");
                    j++;
                    l++;
                }
                j = 1;
                
                Console.WriteLine();

            }
        }
    }
}
