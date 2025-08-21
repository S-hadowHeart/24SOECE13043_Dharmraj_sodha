using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("You entered the following {0} command line arguments:",

               args.Length);

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }

        }
    }
}