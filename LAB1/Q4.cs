using System;
namespace ConsoleApplication1

{
    class Q4

    {

        static void Main(string[] args)

        {

            int x;

            Console.WriteLine("Enter Number : ");
            string str = Console.ReadLine();
            x = Convert.ToInt32(str);


            if (x % 2 == 0)
                Console.WriteLine("Number is Odd");
            else
                Console.WriteLine("Number is Even");
            Console.Read();

        }

    }

}

