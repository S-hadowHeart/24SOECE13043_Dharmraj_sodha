using System;


namespace _24SOECE13043_Dharmraj_sodha.LAB1
{
    internal class Q21
    {
        public static void Main(string[] args)
        {
            
            int sum=0,n=0;
            string og, t;
            try
            {
                Console.Write("Enter N term : ");
                n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input number: ");
                t = og = Console.ReadLine();
                while (n>0)
                {
                    sum += Convert.ToInt32(t);
                    t += og;
                    n--;
                }
                Console.WriteLine(sum); 
            } catch {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return;
            }   
        }
    }
}
