using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P5_cointoss
    {
        public static void Main(string[] args)
        {
            
            Random random = new Random();
            Console.WriteLine($"Coin toss result is {((random.Next(0, 2)== 0)?"Heads":"Tails")} ");
            Console.WriteLine($"Coin toss result is {((random.Next(0, 2) == 0) ? "Heads" : "Tails")} ");
            Console.WriteLine($"Coin toss result is {((random.Next(0, 2) == 0) ? "Heads" : "Tails")} ");

        }
    }
}
