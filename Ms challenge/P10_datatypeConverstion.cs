using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P10_datatypeConverstion
    {
        public static void Main(String[] args)
        {
            string[] values = { "12.3", "45", "ABC", "11", "DEF" };
            decimal num, sum = 0;
            string message = "";
            foreach (string value in values)
            {
                if (decimal.TryParse(value, out num))
                {
                    sum += num;
                }
                else
                {
                    message += value;
                }

            }
            Console.WriteLine($"Sum : {sum}");
            Console.WriteLine($"Message: {message}");
        }
    }
}
