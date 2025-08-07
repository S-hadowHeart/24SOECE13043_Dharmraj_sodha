using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.LAB3
{
    internal class Q6
    {

        class Line

        {

            private double length;   // Length of a line

            public Line()

            {

                length = 10;
                Console.WriteLine("Object is being created, length = " + this.length);
                //………………………………Missing statement-1……………………………….// 

                //………………………………Missing statement-2……………………………….// 

            }



            public void setLength(double len)

            {

                length = len;  



            }

            public double getLength()

            {

                return length;  

            }

        }



        class TestLine

        {

            static void Main(string[] args)

            {

                Line line = new Line();

                line.setLength(10);

                Console.WriteLine("Length of line : {0}", line.getLength());

                line.setLength(6);

                Console.WriteLine("Length of line : {0}", line.getLength());

                Console.ReadKey();

            }

        }

    }

}
