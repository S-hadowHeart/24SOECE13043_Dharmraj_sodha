using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Testingcode
{
    internal class T6_formatString
    {
        public static void Main(string[] args)
        {
            string name = "Dharmraj Sodha";
            int marks = 10;
            int age = 21;
            Console.WriteLine($"|".PadRight(50, '-') + "|");
            Console.WriteLine($"| marks: {marks}".PadRight(50,' ')+"|");
            Console.WriteLine($"| name : {name}".PadRight(50,' ')+"|");
            Console.WriteLine($"| age  : {age}".PadRight(50,' ')+"|");
            Console.WriteLine($"|".PadRight(50,'_')+"|");
        }
    }
}
