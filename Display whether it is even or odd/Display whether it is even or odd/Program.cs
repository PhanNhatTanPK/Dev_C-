using System;

namespace Display_whether_it_is_even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Enter the number");
            num = Console.Read();
            if (num % 2 == 0)
            {
                Console.WriteLine("It is odd");
            }
            else
                Console.WriteLine("It is even");
            Console.ReadLine();
        }
    }
}
