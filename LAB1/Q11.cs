using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q11
    {
        public static void Main(string[] a)
        {
            Console.Write("Enter your Good Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Name: {name}");
            name = name.ToLower();

            if (!(name.StartsWith("mr") || name.StartsWith("ms")))
                Console.WriteLine("Gender: not mention");
            if (name.StartsWith("mr"))
                Console.WriteLine("Gender: Male");
            else
                Console.WriteLine("Gender: Famale");


        }
    }
}
