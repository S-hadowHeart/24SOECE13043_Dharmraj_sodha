using System;

namespace _24SOECE13043_Dharmraj_sodha.LAB3
{
    class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("Object is being created, length = 10");
            length = 10;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }
    }

    class TestLine
    {
        static void Main(string[] args)
        {
            Line line = new Line();
            Console.WriteLine("Length of line : {0}", line.getLength());

            line.setLength(6);
            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();
        }
    }
}
