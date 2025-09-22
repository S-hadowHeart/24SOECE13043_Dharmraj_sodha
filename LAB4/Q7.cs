using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB4
{
    sealed class A
    {
        public int x;
        public int y;
    }

    class SealedTest2
    {
        static void Main()
        {
            A sc = new A();
            sc.x = 110;
            sc.y = 150;

            Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        }
    }
}
