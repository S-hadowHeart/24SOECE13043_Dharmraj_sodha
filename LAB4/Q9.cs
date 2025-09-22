using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB4
{
    class MyClient
    {
        public static void Main()
        {
            int x = 0;
            try
            {
                int div = 100 / x;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }
        }
    }
}
