using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher
{
    internal class p1_commandline
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("My name: " + args[0]);
            //Console.WriteLine("My age: " + args[1]);
            //// Check if any command line arguments are provided
            if (args.Length == 0)
            {
                Console.WriteLine("No command line arguments provided.");
                return;
            }
            // Iterate through each command line argument
            foreach (string arg in args)
            {
                Console.WriteLine($"Command line argument: {arg}");
            }
        }
    }
}
