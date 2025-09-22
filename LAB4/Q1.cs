using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB4
{
    class Employee
    {
        public int EmpCode { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double BasicPay { get; set; }

        public Employee(int empCode, string name, string designation, double basicPay)
        {
            EmpCode = empCode;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public void CalculatePay()
        {
            double hra = 0.10 * BasicPay;   
            double da = 0.45 * BasicPay;    
            double totalPay = BasicPay + hra + da;

            Console.WriteLine("Employee Code : " + EmpCode);
            Console.WriteLine("Name          : " + Name);
            Console.WriteLine("Designation   : " + Designation);
            Console.WriteLine("Basic Pay     : " + BasicPay);
            Console.WriteLine("HRA (10%)     : " + hra);
            Console.WriteLine("DA (45%)      : " + da);
            Console.WriteLine("Total Pay     : " + totalPay);
            Console.WriteLine("---------------------------------");
        }
    }

    class Q1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, "Rahul", "Manager", 50000);
            Employee e2 = new Employee(102, "Priya", "Engineer", 30000);
            Employee e3 = new Employee(103, "Amit Patel", "Clerk", 20000);

      
            e1.CalculatePay();
            e2.CalculatePay();
            e3.CalculatePay();
        }
    }
}
