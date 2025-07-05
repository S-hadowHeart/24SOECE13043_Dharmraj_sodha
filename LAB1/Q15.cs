using System;
using System.Numerics;


namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q15
    {
        public static void Main(string[] args)
        {
            int number=0, len=0,sum=0,clone;
            Console.Write("Enter a decimal number: ");
            clone = number = Convert.ToInt32( Console.ReadLine());
            len = number.ToString().Length;

            while (number > 0)
            {
                sum += Convert.ToInt32(Math.Pow((number % 10), len));
                number /= 10;
            }
            Console.WriteLine($"{clone} is{(clone==sum ? "":" not")} armstrong ");
        }
    }
}
