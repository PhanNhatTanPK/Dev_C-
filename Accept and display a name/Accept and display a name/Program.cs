using System;

namespace Accept_and_display_a_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Your name is: {0}", name);
        }
    }
}
