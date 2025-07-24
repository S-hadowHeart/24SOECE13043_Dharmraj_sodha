using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P14_printLetters
    {
        public static void Main(string[] args)
        {
            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            // Your logic here

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            // Your logic here

            Console.WriteLine(comparisonMessage);



            Console.WriteLine($"""
                Dear {customerName},
                As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

                Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.

                Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.

                Here's a quick comparison:

                {currentProduct.PadRight(20)}{currentReturn:P2}   {currentProfit:C}      
                {newProduct.PadRight(20)}{newReturn:P2}   {newProfit:C}
                """);
        }
    }
}
