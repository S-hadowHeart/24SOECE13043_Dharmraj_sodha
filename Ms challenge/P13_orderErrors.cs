using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P13_orderErrors
    {
        public static void Main(string[] args)
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] eachOrder = orderStream.Split(','); 

            foreach (string eachOrderItem in eachOrder)
            {
                Console.WriteLine($"{eachOrderItem} \t- {((eachOrderItem.Length == 4) ? "" : " Error")}");
            }

        }
    }
}
