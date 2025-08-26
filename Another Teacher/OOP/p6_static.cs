using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    internal class p6_static

    {
        class Demo2
        {
            int x;
            static int y=20;
            public Demo2() {}

            public Demo2(int x) { this.x = x; }

            
            public static int addNum()
            {
                Demo2 ob = new Demo2();
                return (ob.x + y);
                // x is not accessble directly cuz x is non staic , if you want to access then you need object class then access
            }

            public void show()
            {
                Console.WriteLine("x is: " + x);
                Console.WriteLine("y is: " + y);
            }
        }
        static void Main()
        {
            Demo2 ob = new Demo2(30);
            
            Console.WriteLine("Addition is: " + Demo2.addNum());
        }
    }
}
