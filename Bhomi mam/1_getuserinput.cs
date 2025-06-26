using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Bhomi_mam
{
    internal class Class1
    {
        public static void Main(string[] args)
        {
            Double a = 0, b = 0;
            int i=0;
            string choice;
            while (true)
            {
                Console.Write(@"
1.ADD
2.Sub
3.Mul
4.Div
Enter anything to exit!
Choice:");
                choice = Console.ReadLine();
                if(choice == "1" | choice == "2" | choice =="3" | choice =="4") {
                    while (i == 0)
                    {
                        try
                        {
                            Console.Write("Enter One Number: ");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter Second Number: ");
                            b = Convert.ToDouble(Console.ReadLine());
                            i = 1;
                        }
                        catch
                        {
                            Console.WriteLine("Enter valid input!!");
                        }
                        
                    }
                    i = 0;
                }
                switch (choice)
                {
                    case "1":
                        Console.Write($"Sum of Number {a} and {b} is {a + b}");
                        break;
                    case "2":
                        Console.Write($"Subtraction of Number {a} and {b} is {a - b}");
                        break;
                    case "3":
                        Console.Write($"Multi of Number {a} and {b} is {a * b}");
                        break;
                    case "4":
                        Console.Write($"Div of Number {a} and {b} is {a / b}");
                        break;
                    default:
                        Console.Write("Thank you for Using :) ");
                        return;
                }
            }
            
            //Console.WriteLine("Hello world");
        }
    }
}
