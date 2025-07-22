using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P8_fizzBuzz
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write(i + " - ");
                if (i % 3 == 0) Console.Write("Fizz");
                if (i % 5 == 0) Console.Write("Buzz");
                Console.WriteLine();
            }
        }
    }
}
