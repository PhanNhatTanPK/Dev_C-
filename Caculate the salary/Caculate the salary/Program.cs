using System;

namespace Caculate_the_salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts ac = new Accounts();
            ac.Salary();
            Console.WriteLine();
            HR h = new HR();
            h.Salary();

        }
    }
}
