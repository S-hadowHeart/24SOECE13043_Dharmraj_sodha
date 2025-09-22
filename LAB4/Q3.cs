using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB4
{
    class Person
    {
        private int age;
        protected string address;
        public string name;

        public void SetDetails(string n, int a, string addr)
        {
            name = n;
            age = a;
            address = addr;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
    }

    class Employee : Person
    {
        private double salary;
        protected string department;
        public int empId;

        public void SetEmployee(int id, double sal, string dept)
        {
            empId = id;
            salary = sal;
            department = dept;
        }

        public void ShowEmployee()
        {
            Console.WriteLine("Employee ID: " + empId);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class Q3
    {
        static void Main()
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            e1.SetDetails("Rahul Mehta", 30, "Ahmedabad");
            e1.SetEmployee(101, 50000, "IT");

            e2.SetDetails("Priya Shah", 28, "Surat");
            e2.SetEmployee(102, 45000, "HR");

            Console.WriteLine("Employee 1 Information:");
            e1.ShowDetails();
            e1.ShowEmployee();

            Console.WriteLine();

            Console.WriteLine("Employee 2 Information:");
            e2.ShowDetails();
            e2.ShowEmployee();
        }
    }
}
