using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q13
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number for patten: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Method 1:

            //string sym = "#";
            //int toggle = 0;
            //for (int i = 0; i < num; i++)
            //{
            //    if (toggle == 1)
            //    {
            //        sym = "*";
            //        toggle = 0;
            //    }
            //    else
            //    {
            //        sym = "#";
            //        toggle = 1;
            //    }
            //    for (int j = 0; j <= i; j++)
            //    { 
            //            Console.Write(sym = sym=="#"?"*":"#");

            //    }
            //    Console.WriteLine();
            //}


            //Method 2:
            //for (int i = 0; i < num; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            if (j % 2 == 0)
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write("#");
            //            }
            //        }
            //        else
            //        {
            //            if (j % 2 == 0)
            //            {
            //                Console.Write("#");
            //            }
            //            else
            //            {
            //                Console.Write("*");
            //            }
            //        }

            //    }
            //    Console.WriteLine();
            //}


            // Method 2 updated version :

            //for (int i = 1; i <= num; i++)
            //{ 
            //    for(int j = 1; j <= i; j++)
            //    {
            //        if ((i + j) % 2 == 0)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write("#");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            // Accoding for me optimal Method : 
    
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(((i + j) % 2 == 0)?"*" :"#");
                }
                Console.WriteLine();
            }
        }
    }
}


