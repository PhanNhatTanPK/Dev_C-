using System;

namespace The_first_10_multiples_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            int num = 1;
            Console.WriteLine("Multiples of 5 are: ");
            while(num <=10)
            {
                result = num * 5;
                num += 1;
                Console.Write("{0}   ", result);
            }
        }
    }
}
