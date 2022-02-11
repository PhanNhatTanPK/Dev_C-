using System;

namespace Accept_a_number_and_return_day
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]  a = new int[3] ;
            for(int i=0; i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("a[{1}] = {0}", a[i], i);
            }
           /* string number;
            Console.WriteLine("Accepts a number: ");
            number = Console.ReadLine();
            switch(number)
            {
                case "1":
                    Console.WriteLine("First day of week is Sunday");
                    break;
                case "2":
                    Console.WriteLine("Sencond day of week is Monday");
                    break;
                case "3":
                    Console.WriteLine("Third day of week is Tuesday");
                    break;
                case "4":
                    Console.WriteLine("Fourth day of week is Wednesday");
                    break;
                case "5":
                    Console.WriteLine("Fifth day of week is Thursday");
                    break;
                case "6":
                    Console.WriteLine("Sixth day of week is Friday");
                    break;
                case "7":
                    Console.WriteLine("Seventh day of week is Saturday");
                    break;
                default:
                    Console.WriteLine("Enter number between 1 and 7");
                    break;*/
            
        }
    }
}
