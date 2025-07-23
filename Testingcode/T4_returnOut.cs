using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Testingcode
{
    internal class T4_returnOut
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Return and Out Parameters Example");
            int result;
            string message;
            int a = 5, b = 10;
            // Using return
            result = Add(a, b);
            int tp;
            Console.WriteLine($"Sum using return: {result}");
            // Using out parameter
            tp = Multiply(a, b, out result, out message);
            Console.WriteLine(message);
            Console.WriteLine(tp);
            Console.WriteLine($"Product using out: {result}");
        }

        static int Multiply(int x, int y, out int product,out string msg)
        {
            product = x * y;
            msg = $"The product of {x} and {y} is {product}.";
            return 4848;

        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
