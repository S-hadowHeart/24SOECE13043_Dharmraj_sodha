using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB3
{
    class Student
    {
        private int enrolmentNo;
        private string name;

        public int EnrolmentNo
        {
            get { return enrolmentNo; }
            set { enrolmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student(int e, string n)
        {
            enrolmentNo = e;
            name = n;
        }

        public void Display()
        {
            Console.WriteLine($"EnrolmentNo: {EnrolmentNo}, Name: {Name}");
        }
    }

    class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student(201, "Karan");
            Student s2 = new Student(202, "Pooja");

            Console.WriteLine("Before update:");
            s1.Display();

            s1.Name = "Karan Patel";

            Console.WriteLine("After update:");
            s1.Display();

            s2.Display();

            Console.ReadKey();
        }
    }
}
