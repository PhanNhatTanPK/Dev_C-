using System;

namespace Display_the_name_and_age
{
    
    class Program
    {
        private string name;
        private int age;

        public Program()
        {
            name = "Tan";
            age = 20;
        }

        public Program(string n , int a)
        {
            name = n;
            age = a;
        }

        public void show ()
        {
            Console.WriteLine("Name: {0} ", name);
            Console.WriteLine("Age: {0}", age);
        }
        static void Main(string[] args)
        {
            Program person1 = new Program();
            Program person2 = new Program("Hoang", 20);
            person1.show();
            person2.show();

        }
    }
}
