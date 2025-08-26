using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    internal class p5
    {
        class demo1
        {
            //int x ; int y;
            public int X
            {
                //get { return x; }
                //set { x = value; }
                set; get;
            }

            public int z;

            public int Y
            {
                //get { return y; } // initilize member
                //set { y = value; } // read-write properties
                get; set;
            }
            //public int getx()
            //{
            //    return x;
            //}
            //public int gety()
            //{
            //    return y;
            //}
        }

        public static void Main()
        {
            demo1 ob = new demo1();
            //ob.x not able to access here
            ob.X = 100;
            System.Console.WriteLine(ob.X);
            //System.Console.WriteLine(ob.getx());
            ob.Y = 200;
            System.Console.WriteLine(ob.Y);
            //System.Console.WriteLine(ob.gety());
            ob.X = ob.X + ob.Y;
            //ob.X = ob.getx() + ob.gety();
            System.Console.WriteLine("Sum of x and y and store in x : "+ ob.X);
            //System.Console.WriteLine("Sum of x and y and store in x : "+ ob.getx());

        }
    }
}
