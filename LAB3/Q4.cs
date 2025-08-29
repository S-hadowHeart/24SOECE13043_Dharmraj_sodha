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
            Student s2 = new Student(102, "Meera", 21);
            Student s3 = new Student(103, "Ravi", 22);
            Student s4 = new Student(104, "Isha", 20);
            Student s5 = new Student(105, "Dev", 23);

            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

            Console.ReadKey();
        }
    }
}
