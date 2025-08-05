using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13043_Dharmraj_sodha.Another_Teacher.OOP
{
    internal class p2_time
    {
        public static void Main(string[] args)
        {
            //Time class

            //create object of TimeManage class
            int h, m, s;
            Console.Write("Enter hours: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds: ");
            s = Convert.ToInt32(Console.ReadLine());
            TimeManage time = new TimeManage(h, m, s);
            //show time
            time.ShowTime();
            time.AddTime();

        }

        class TimeManage
        {
            int h, m, s;
            public TimeManage(int h, int m, int s)
            {
                this.h = h;
                this.m = m;
                this.s = s;
            }
            public void ShowTime()
            {
                Console.WriteLine($"Time is {h:D2}:{m:D2}:{s:D2}");
            }
            public void AddTime()
            {
                //Increment 1 second
                if (s < 59)
                {
                    s++;
                }
                else
                {
                    s = 0;
                    if (m < 59)
                    {
                        m++;
                    }
                    else
                    {
                        m = 0;
                        if (h < 23)
                        {
                            h++;
                        }
                        else
                        {
                            h = 0; // Reset to 0 if it exceeds 23
                        }
                    }
                    ShowTime();
                }
            }
        }
    }
}
