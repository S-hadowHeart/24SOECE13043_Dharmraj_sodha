using System;

namespace _24SOECE13043_Dharmraj_sodha.Ms_challenge
{
    internal class p4_fradulent_order
    {
        public static void Main(string[] args)
        {
            String[] orders = { "B123","C234","A345","C15","B177","G3003","C235","B179" };
            foreach (String order in orders)
            {
                if (order.StartsWith("B"))
                    Console.WriteLine(order);
            }
        }
    }
}
