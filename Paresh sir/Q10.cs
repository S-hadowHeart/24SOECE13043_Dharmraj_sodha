using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q10
    {
        public static void Main(string[] args)
        {
            byte result;
            int a = 127;
            int b = 927;
            result = unchecked((byte)(a * b));
            Console.WriteLine(result);
            Console.WriteLine(a*b);

            //check and uncked 
        }
    }
}
