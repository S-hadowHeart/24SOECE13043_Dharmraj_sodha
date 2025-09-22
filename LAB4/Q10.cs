using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB4
{
    // User-defined exception
    class MyException : Exception
    {
        public MyException(string str) : base(str)
        {
            Console.WriteLine("User defined exception");
        }
    }

    class MyClient
    {
        public static void Main()
        {
            try
            {
                throw new MyException("my exception generated.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught here: " + e.Message);
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
