using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB3
{
    class Car
    {
        private string brand;
        private string model;
        private int price;

        public Car(string b, string m, int p)
        {
            brand = b;
            model = m;
            price = p;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Price: " + price);
        }

        public void IncreasePrice(int amount)
        {
            price += amount;
            Console.WriteLine("Price increased by " + amount);
        }
    }

    class Demo
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("BMW", "X5", 7500000);
            Car car2 = new Car("Tesla", "Model S", 8500000);

            Console.WriteLine("\nCar 1 Info:");
            car1.DisplayInfo();
            car1.IncreasePrice(50000);
            car1.DisplayInfo();

            Console.WriteLine("\nCar 2 Info:");
            car2.DisplayInfo();
            car2.IncreasePrice(100000);
            car2.DisplayInfo();

            Console.ReadKey();
        }
    }
}
