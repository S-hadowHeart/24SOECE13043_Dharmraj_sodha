using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    internal class P1
    {
        public static void Main(string[] args)
        {
            //why oop language ? 
            // oop is more suitable for larger project , where there are many interntiy ,
            // and deal with many methods and data.
            // using opp you can group each intentiy 's attributes and method ,
            // also oop data and methods can be more security and
            // u can give limited access to protect
            //Encapsulation : wrap data and method in single intity like class or intenface
            //Bind your data together,hiding
            //Abstraction : show only importance things
            //hide unimportant things, like in car you only see steering wheel, brake, accelerator
            //Inheritance : inheritance parent class propery
            //child class can use parent class property and method
            //Polymorphism : one name diffrent bahavior

            laptop l1 = new laptop(8, 512, "Intel i5", true, false, "Windows 11", "USB-C", "1080p", 599.99m);
            l1.showDetails();
            laptop l2 = new laptop(16, 1024, "AMD Ryzen 7", true, true, "Linux", "USB-C", "720p", 899.99m);
            l1.showDetails();
            //high ram laptop is 
            if (l1.getram() > l2.getram())
            { 
                Console.WriteLine("Laptop 1 has more RAM than Laptop 2.");
            }
            else if (l1.getram() < l2.getram())
            {
                Console.WriteLine("Laptop 2 has more RAM than Laptop 1.");
            }
            else
            {
                Console.WriteLine("Both laptops have the same amount of RAM.");
            }
        }


        class laptop
        {
            int ram, storange;
            string cpu;
            bool support180Rotation, support360Rotation;
            string os,chargingPort,camera;
            decimal price;
            
            public laptop(int ram, int storange, string cpu, bool support180Rotation, bool support360Rotation, string os, string chargingPort, string camera, decimal price)
            {   this.ram = ram;
                this.storange = storange;
                this.cpu = cpu;
                this.support180Rotation = support180Rotation;
                this.support360Rotation = support360Rotation;
                this.os = os;
                this.chargingPort = chargingPort;
                this.camera = camera;
                this.price = price;



            }
                public int getram()
                                    {
                    return ram;
                }
            public void showDetails()
            {   
                Console.WriteLine($"Laptop Details:\n" +
                                  $"RAM: {ram}GB\n" +
                                  $"Storage: {storange}GB\n" +
                                  $"CPU: {cpu}\n" +
                                  $"Supports 180° Rotation: {support180Rotation}\n" +
                                  $"Supports 360° Rotation: {support360Rotation}\n" +
                                  $"Operating System: {os}\n" +
                                  $"Charging Port: {chargingPort}\n" +
                                  $"Camera: {camera}\n" +
                                  $"Price: ${price}");
                Console.WriteLine("--------------------------------------------------");

            }
        }
    }
}
