using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Testingcode
{
    internal class T2_codeBlock
    {
        public static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine(a);
             int b = 10; 
            {
                int c = 20;
                Console.WriteLine(c);
            }
            //C is kinda private to the block above, so it won't be accessible here.
            //Console.WriteLine(c);
            Console.WriteLine(b);

        }
    }
}
