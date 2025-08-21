using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB2
{
    class Q3
    {
        static void Main(string[] args)

        {
            string firstName = "John";
            string lastName = "Doe";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("New name: "  +firstName + " "+  lastName);
            Console.ReadLine();

        }
    }
}