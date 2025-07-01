namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q3
    {
        public static void Main(string[] a)
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even");
            }
            else
            {
                Console.WriteLine($"{number} is odd");
            }

        }
    }
}
