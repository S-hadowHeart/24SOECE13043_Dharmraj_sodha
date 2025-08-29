using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB3
{
    class Student
    {
        private int enrolmentNo;
        private string name;
        private int age;

        public Student(int e, string n, int a)
        {
            enrolmentNo = e;
            name = n;
            age = a;
        }

        public void Display()
        {
            Console.WriteLine($"EnrolmentNo: {enrolmentNo}, Name: {name}, Age: {age}");
        }
    }

    class TestStudent
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student(101, "Aarav", 20);
            s1.Display();

            Console.ReadKey();
        }
    }
}
