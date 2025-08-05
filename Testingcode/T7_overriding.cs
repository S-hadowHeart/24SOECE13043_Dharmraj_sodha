using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Testingcode
{
    internal class T7_overriding
    {
        class abc 
        {
            public abc()
            {
                Console.WriteLine("class conss");
            }
        
        }
        public static void Main(string[] args)
        {
            int a = 5, b = 10;
            int[] c = { a, b };
            int[] d = { 44, 32 };
            ab(a, b);
            Console.WriteLine("Calling ab with out parameter:");
            ab(a, out b);
            Console.WriteLine("After calling ab with out parameter:");
            Console.WriteLine("b = " + b);
            ab();
            ab(c,d);
            abc myabc = new abc();

        }

        public static void ab(int a, int b)
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("Sum = " + (a + b));
        }
        public static void ab(int a, out int b)
        {
            b = 12;
        }
        //public static void ab(int a, ref int b)
        //{

        //    // this will not work
        //    b = 12;

        //}

        public static void ab()
        {
            Console.WriteLine("no para..");
        }
        public static void ab(int[] a, int[] b)
        {
            Console.WriteLine("Arryy");
        }

    }
}
