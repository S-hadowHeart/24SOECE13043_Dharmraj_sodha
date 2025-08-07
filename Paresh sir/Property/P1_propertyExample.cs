using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Paresh_sir.Property
{
    internal class P1_propertyExample
    {
        class P1_property { 
        
            private string _firstName;
            public string carName;
            //string hero = "";

            public string FirstName { get { return _firstName; } set { _firstName = value; } }
            public string myCar {
                
                get {
                    Console.WriteLine("Sending car name ...");
                    return carName; } set {
                    Console.WriteLine("Typing Car name ...");
                    carName = value; } }


            public string smthCool
            {
                get {
                    if (myCar == "Nice car")
                    {
                        return "wow";
                    }

                    return "Bruhh";
                }
                set { }
                
            }

            public string getFirstName() { return _firstName; }

            public void setFirstName(string firstName) { _firstName = firstName; }



        }
        class Test
        {
            public static void Main()
            {
                Console.WriteLine("Access private variable using method");
                P1_property example = new P1_property();
                example.setFirstName("Bakage");
                Console.WriteLine(example.getFirstName());

                Console.WriteLine("Access private variable using property");
                example.FirstName = "Mico";
                Console.WriteLine(example.FirstName);


                Console.WriteLine("Access public variable using property");
                example.myCar = "Nice car";
                Console.WriteLine(example.myCar);

                string check = example.smthCool;

                Console.WriteLine(check);
            }
        }
    }
}
