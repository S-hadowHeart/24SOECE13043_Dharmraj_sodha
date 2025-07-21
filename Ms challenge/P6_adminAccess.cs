using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class P6_adminAccess
    {
        public static void Main(String[] args) 
        {
            Random random = new Random();
            int i = random.Next(0, 3);
            string permission = ((i == 0) ? "Admin" :((i == 1)? "Manager": "User"));
            int level = random.Next(0,61);
            Console.WriteLine($"Current user : {permission} on Level {level}");
            Console.WriteLine($"{((permission == "Admin") ? ((level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.") : ((permission == "Manager") ? ((level > 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.") : "You do not have sufficient privileges."))}");

        }
    }
}
