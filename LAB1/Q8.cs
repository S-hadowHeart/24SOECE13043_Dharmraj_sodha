using System;
namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q8
    {
        public static void Main(string[] a)
        {
            Console.Write("Enter your String: ");
            string str = Console.ReadLine();
            //A -65to90 and a-97to122
            foreach (char c in str)
            {
                int unicode = c;
                if (unicode >= 97 && unicode <= 122)
                {
                    unicode -= 32;
                    Console.Write(((char)unicode));
                }
                else
                {
                    Console.Write(((char)unicode));
                }
            }
            
        }
    }
}
