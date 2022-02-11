using System;

namespace Find_the_square_of_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            sqr(num);
            Console.ReadLine();
        }
        static void sqr(int num)
        {
            int square = num * num;
            Console.Write("Square of the number 10 is: {0}", square);
        }
    }
}
