using System;

namespace Caculates_square_of_an_integer_and_a_double
{
    class Program
    {
        private int intnum;
        private double dounum;

        public Program()
        {
            intnum = 3;
            dounum = 4.2;
        }

        public void show()
        {
            Console.WriteLine("Square of an integer and a double are: {0}, {1}", Square(intnum), Square(dounum));
        }

        public int Square(int x)
        {
            return x * x;
        }

        public double Square(double y)
        {
            return y * y;
        }


        static void Main(string[] args)
        {
            Program object1 = new Program();
            object1.show();
        }
    }
}
