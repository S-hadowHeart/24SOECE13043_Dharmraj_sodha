using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir.Property
{
    internal class p2
    {
        class studentClass
        {
            private string _name;
            private string _enrollmentNumber;


            public string student 
            {
                get { return _enrollmentNumber+"||"+_name; }
                set {
                    string[] studentDetail = value.Split(new string[] { "||" }, StringSplitOptions.RemoveEmptyEntries); 
                    if (studentDetail.Length == 2)
                    {
                        _enrollmentNumber = studentDetail[0];
                        _name = studentDetail[1];
                    }
                    else
                    {
                        Console.WriteLine("Please give data in this formate only {enrollmentnumber}||{studentName}");
                    }
                }
            
            }
        
        }

        class Test
        {
            public static void Main()
            {
                studentClass p2 = new studentClass();
                p2.student = "24SOECE13043||Dharmaj sodha||";
                string[] studentDetail = p2.student.Split(new string[] { "||" }, StringSplitOptions.None); ;
                Console.WriteLine(studentDetail[0]);
                Console.WriteLine(studentDetail[1]);
            }
        }
    }
}
