
using System;
namespace _24SOECE13043_Dharmraj_sodha.LAB1
{

    class Q5
{
    static void Main(string[] args)
    {
        int n, fact = 1;
        Console.WriteLine("Enter Number : ");
        string str = Console.ReadLine();
        n = Convert.ToInt32(str);
        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine("Factorial : {0}", fact);

        Console.Read();
    }
}
}

