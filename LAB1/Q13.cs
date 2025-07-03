using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q13
    {
        public static void Main(string[] ar)
        {
            int a = 0,b = 1;
            Console.Write($"{a} {b} ");
            while(b != 55)
            {
                Console.Write($"{b = a + (a = b)} ");
            }
        }
    }
}
