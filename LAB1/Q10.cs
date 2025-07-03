using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q10
    {
        public static void Main(string[] a)
        {
            Console.Write("Enter your Phone number: ");
            string str = Console.ReadLine();

            string[] myArray = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                myArray[i] = str[i].ToString();
                if (i >= 5) {
                    myArray[i] = "X";
                }
            }
            Console.WriteLine(string.Join("",myArray));
        }
    }
}
