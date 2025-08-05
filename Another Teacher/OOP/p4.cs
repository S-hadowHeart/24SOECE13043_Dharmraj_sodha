using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    class Employee
    {
        private int id;
        private string name;
        private int age;

        
        public void giveValue(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
                }
        public void getEmpData()
        {
            Console.WriteLine($"""
                ID   : {id}
                Name : {name}
                Age  : {age}
                """);
        }

    }
    internal class p4
    {
        public static void Main(string[] args)
        {
            int i = 0;
            do
            {
                
                try
                {
                    Employee emp = new Employee();
                    emp.giveValue(Convert.ToInt32(args[0]), args[1], Convert.ToInt32(args[2]));
                    emp.getEmpData();
                    i = 1;
                }
                catch
                {
                    Console.WriteLine("Give Command line args in this formate id name age");
                    break;
                }
            }while (i == 0);
        }
            
    }
}
