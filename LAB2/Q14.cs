using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q14
    {
        static void Main(string[] args)
        {
            Console.Write("Input the marks obtained in Maths : ");
            int maths = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Physics : ");
            int physics = int.Parse(Console.ReadLine());

            Console.Write("Input the marks obtained in Chemistry : ");
            int chemistry = int.Parse(Console.ReadLine());

            int totalAll = maths + physics + chemistry;
            int totalMathPhy = maths + physics;

            if (maths >= 65 && physics >= 55 && chemistry >= 50 &&
                (totalAll >= 180 || totalMathPhy >= 140))
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
        }
    }
}
