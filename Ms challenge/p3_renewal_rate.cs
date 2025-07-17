using System;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class p3_renewal_rate
    {
        public static void Main(string[] args)
        {
            Random ranom = new Random();
            int daysUntilExpiring = ranom.Next(12);
            int discountPercentage = 0;
            //Console.WriteLine(daysUntilExpiring);
            if (daysUntilExpiring < 1)
                Console.WriteLine("Your subscription has expired.");
            else if (daysUntilExpiring == 1)
                Console.WriteLine($"Your subscription expires within a day!\r\nRenew now and save {discountPercentage=20}%!");            
            else if (daysUntilExpiring <= 5)
                Console.WriteLine($"Your subscription expires in {daysUntilExpiring} days.\r\nRenew now and save {discountPercentage = 10}%!");
            else if (daysUntilExpiring <= 10) 
                Console.WriteLine($"Your subscription expires in {daysUntilExpiring} days.Renew now");
        }
    }
}
