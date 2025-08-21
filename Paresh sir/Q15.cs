using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir
{
    internal class Q15
    {
        static class student
        {
            public static void hello()
            {
                Console.WriteLine("Hello, Students!");
            }
            
        }
    
        // creating static class without static ;-;

        class student2
        {
            private student2() { } // private constructor to prevent instantiation
            public void hello()
            {
                Console.WriteLine("Hello, Students from student2!");
            }
        }

        // normal class
        class student3
        {
            public void hello()
            {
                Console.WriteLine("Hello, Students from student3!");
            }
        }
        static void Main(string[] args)
        {
            // try to make object of static class
            //student student = new student();
            // This will not work because 'student' is a static class and cannot be instantiated

            // Calling the static method from the nested class
            student.hello();

            // Creating an instance of the non-static class
            //student2 nonStaticStudent = new student2();
            // This will work because 'student2' is a non-static class and can be instantiated

            student3 student3 = new student3();

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
