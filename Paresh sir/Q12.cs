using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q12
    {
        public static void Main(string[] args)
        { 
            Console.Write("Enter a number for patten: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num} {num} {num}");
            for (int i = 1; i <= num; i++)
            { 
                Console.WriteLine($"{num} {i} {num}");
            }
            

        }
    }
}
