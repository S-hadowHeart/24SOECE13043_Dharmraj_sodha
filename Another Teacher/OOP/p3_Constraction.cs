using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    internal class p3_Constraction
    {

        class student

        {
            private int rollNumber = 0;
            private string name;

            public student()
            {
                Console.Write("Enter student rollNumber :  ");
                rollNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student Name: ");
                name = Console.ReadLine();
            }
            public student(student s)
            {
                rollNumber = s.rollNumber;
                name = s.name;



            }
            static student()
            {
                Console.WriteLine("I am static");
            }
            public void getStudentInfo()
            { 
                Console.WriteLine($"""
                    Name       : {name}
                    RollNumber : {rollNumber}
                    """);
            
            }
            public int getRollNumber()
                { return rollNumber; }
        }
        //class sim
        //{
        //    public void createob()
        //    {
        //        demo a = new demo();
        //    }
        //}
        //class demo
        //{
        //    int a=0; int b=0;
        //     static demo()
        //    {
        //        Console.WriteLine("Hello hahah");
        //    }
        //}
        // what is Constraction in oop ? 
        // Ans: Constraction is code of block that automatically call when object of class create , 
        // usally it's use to insizilze variables in class first time ,  
        // Constraction name and class name is same always , it's return object instant , 
        // by default there is no parameter  constraction , and we can overloading constraction , 
        // constraction can't inherate , using this keywoard you can call paraent class constraction
        // in C# there is more some type of constration : 
        // Copy ,Static , Private constructor 
        // copy const: want to create new object from exist object provide same set of values to all members of a class onject as an argument is passed
        // static const: static keyword with constructor not atake any arguments , scalled only once , initiallize the static members which belongs to class ,  never have access modifer in static , 
        // private const : private and parameter-less , not accessable from outside class !? , when all members of a class are static then only use , 
        // in static const , you allowed to make object , but in private const..  ,you are not able to make objects , 
        public static void Main(string[] args)
        {
            //demo a = new demo();
            int totolStudent = 0;
            //student s1 = new student();
            //student s2 = new student();
            //student s3 = new student();
            //s1.getStudentInfo();
            //s2.getStudentInfo();
            //s3.getStudentInfo();

            //student s = new student();
            //student y = new student(s);
            //y.getStudentInfo();
            //student z = new student();

            // Making Object of array : 
            Console.Write("Enter How many student you want  ? ");
            totolStudent = Convert.ToInt32(Console.ReadLine());
            student []students = new student[totolStudent];
            int i = 0;
            while (i < totolStudent)
            {
                Console.WriteLine("""
                     1. new student
                     2. copy studnet
                    """);
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                    students[i] = new student();
                else if (choice == 2)
                {
                    int rollnumber = 0;
                    Console.WriteLine("Enter Rollnumber of student that you want to copy details : ");
                    rollnumber = Convert.ToInt32(Console.ReadLine());
                    for (int j = 0; j < i; j++)
                    {
                        if (students[j].getRollNumber() == rollnumber)
                        {
                            students[i] = new student(students[j]);
                            break;
                        }
                        if (j == i - 1)
                        {
                            Console.WriteLine("Student not found.\nCreating new student ...");
                            students[i] = new student();
                        }
                    }
                    if (i == 0)
                    {
                        Console.WriteLine("Student not found.\nCreating new student ...");
                        students[i] = new student();

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }
                    i++;
               
            }
            foreach (student perStudent in students)
            {
                perStudent.getStudentInfo();
            }


        }
    }



}
