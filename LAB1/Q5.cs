using System;  // Importing the System namespace for basic input/output operations

// Declaring a namespace to group related classes
namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    // Class definition
    class Q5
    {
        // Main method - entry point of the program
        static void Main(string[] args)
        {
            int n, fact = 1; // Declare variables: n for input number, fact to store factorial result

            // Prompt user to enter a number
            Console.WriteLine("Enter Number : ");

            // Read user input as string
            string str = Console.ReadLine();

            // Convert the input string to an integer
            n = Convert.ToInt32(str);

            // Calculate factorial using a for loop
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i; // Multiply current value of fact by i
            }

            // Display the calculated factorial
            Console.WriteLine("Factorial : {0}", fact);

            // Keep the console window open until a key is pressed
            Console.Read();
        }
    }
}
