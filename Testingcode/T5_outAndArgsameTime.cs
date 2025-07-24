using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Testingcode
{
    internal class T5_outAndArgsameTime
    {
        public static void Main(string[] args)
        {
            int a, b;
            a = 10;
            b = 20;
            sum(out a, out b);
            Console.WriteLine($"{a} and {b}");



        }

        //NOP not working
        static void sum(out int a, out int b)
        {
            a = b;
            b = a;
        }
    }
}
