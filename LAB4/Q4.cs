using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB4
{
    class StaticVar
    {
        public static int num;

        public StaticVar()
        {
            num++;
        }

        public void count()
        {
            num++;
        }

        public static int getNum()
        {
            return num;
        }
    }

    class Q4
    {
        static void Main(string[] args)
        {
            StaticVar s = new StaticVar();

            s.count();
            s.count();
            s.count();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            Console.ReadKey();
        }
    }
}
