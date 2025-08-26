using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    internal class p7
    {
        class employee
        {
            int code;
            public String name { get; set; }
            string _designation{get; set;}
            static string institudeName;
            decimal basicPay, houseRentAllowance,dearnessAllowance,totalPay;
            public employee(int code)
            {
                this.code = code;
            }
            private void calculateHRA()
            {
                houseRentAllowance = basicPay / 10;

            }
            private void calulateDA()
            {
                dearnessAllowance = basicPay *45 / 100;
            }

            private void calulateTotalPay()
            {
                totalPay =  houseRentAllowance + dearnessAllowance;
            }

            public void showDetails()
            {
                System.Console.WriteLine($"""
                    Our Employee Details code {code} from {institudeName}
                    Name : {name}
                    Designation : {_designation}
                    Total pay : {totalPay}
                    """);
            }

        }

        static void Main()
        {
            employee ep = new employee(101);
            employee.institudeName = "xyz Company" 
            ep.name = "Rahul";
            
        }
    }
}
