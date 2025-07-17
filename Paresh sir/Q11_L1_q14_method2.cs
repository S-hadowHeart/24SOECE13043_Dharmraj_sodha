using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q11_L1_q14_method2
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your number : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int digit = 0;
            string numberString = "";
            while (Number != 0)
            { 
                digit = Number % 10;
                switch (digit)
                {
                    case 0:
                        numberString =  " Zero " +  numberString;
                        break;
                    case 1:
                        numberString = " One "+ numberString ;
                        break;
                    case 2:
                        numberString = " Two " + numberString;
                        break;
                    case 3:
                        numberString = " Three " + numberString;
                        break;
                    case 4:
                        numberString = " Four " + numberString;
                        break;
                    case 5:
                        numberString = " Five " + numberString;
                        break;
                    case 6:
                        numberString = " Six " + numberString;
                        break;
                    case 7:
                        numberString = " Seven " + numberString;
                        break;
                    case 8:
                        numberString = " Eight " + numberString;
                        break;  
                    case 9:
                        numberString = " Nine " + numberString;
                        break;
                }
                Number /= 10;

            }
            Console.WriteLine(numberString);
        }
        
    }
}
