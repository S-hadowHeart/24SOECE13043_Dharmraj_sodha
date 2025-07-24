using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P15_getString
    {
        public static void Main(string[] args)
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            int startIndex = input.IndexOf("<span>") + "<span>".Length;
            int endIndex = input.IndexOf("</span>", startIndex);
            if (startIndex >= 0 && endIndex > startIndex)
            {
                quantity = "Quantity: " + input.Substring(startIndex, endIndex - startIndex);
            }
            output = "Output: " + input.Replace("<div>", "").Replace("</div>", "");

            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
    }
}
