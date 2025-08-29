using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB3
{
    class Clock
    {
        private int hour, min, sec;

        public Clock()
        {
            hour = 12; min = 0; sec = 0;
        }

        public Clock(int h, int m, int s)
        {
            hour = h; min = m; sec = s;
        }

        public void Tick()
        {
            sec++;
            if (sec == 60) { sec = 0; min++; }
            if (min == 60) { min = 0; hour++; }
            if (hour == 24) { hour = 0; }
        }

        public void Display()
        {
            Console.WriteLine($"{hour:D2}:{min:D2}:{sec:D2}");
        }

        public int getHour() => hour;
        public int getMinute() => min;
        public int getSeconds() => sec;
    }

    class TestClock
    {
        static void Main()
        {
            Clock c1 = new Clock();
            Clock c2 = new Clock(10, 59, 58);

            c1.Display();
            c2.Display();

            c2.Tick();
            c2.Display();

            Console.ReadKey();
        }
    }
}
