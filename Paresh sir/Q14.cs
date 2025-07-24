using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q14
    {
        public static void Main(string[] args)
        {
            decimal num1, num2, result;
            string operation = "", error;
            do
            {
                Console.WriteLine("_______________________________________________________________________");
                if (!getInput(out num1, out num2, out error))
                {
                    Console.WriteLine($"Error: {error}");
                    continue;
                }
                Console.WriteLine("_______________________________________________________________________");
                Console.Write("Enter operation (sum, sub, mul, div, swap, exit): ");
                operation = Console.ReadLine();
                Console.WriteLine("_______________________________________________________________________");
                if (!calculate(num1, num2, operation, out result, out error))
                {
                    Console.WriteLine($"Error: {error}");
                }
                else
                {
                    Console.WriteLine($"Result of {operation} is: {result}");
                }
            } while (operation.ToLower() != "exit");

            Console.WriteLine("Cy Later!!");

        }

        static void swap(ref decimal a, ref decimal b)
        {
            // Swapping using a temporary variable
            //decimal temp = a;
            //a = b;
            //b = temp;
            // Swapping without using a temporary variable
            a = a + b;
            b = a - b;
            a = a - b;
            
        }




        public static bool getInput(out decimal num1, out decimal num2, out string error)
        {
            error = "";
            num1 = 0;
            num2 = 0;
            try
            {
                Console.Write("Enter first number: ");
                num1 = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = Convert.ToDecimal(Console.ReadLine());
                return true; // Return true if input is valid
            }
            catch (FormatException)
            {
                error = "Invalid input. Please enter valid integers.";
                return false; // Return false if input is invalid
            }
        }



        public static bool calculate(decimal num1, decimal num2, string operation, out decimal result, out string error)
        {
            error = "";
            result = 0;
            switch (operation.ToLower())
            {
                case "sum":
                    result = getSum(num1, num2);
                    return true;
                case "sub":
                    result = getSub(num1, num2);
                    return true;
                case "mul":
                    result = getMul(num1, num2);
                    return true;
                case "div":
                    result = getDiv(num1, num2, out error);
                    if (!string.IsNullOrEmpty(error))
                    {

                        return false; // Return false if there is an error
                    }
                    return true;
                case "swap":
                    swap(ref num1, ref num2);
                    Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
                    return true;
                case "exit":
                    return true;

                default:
                    error = "Invalid operation";
                    return false; // Return 0 for invalid operation
            }
        }
        public static decimal getSum(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static decimal getSub(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal getMul(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public static decimal getDiv(decimal num1, decimal num2, out string error)
        {
            if (num2 == 0)
            {
                error = "Division by zero is not allowed.";
                return 0; // Return 0 for division by zero
                // or throw an exception
            }
            error = ""; // No error
            return num1 / num2;
        }
    }
}

    
