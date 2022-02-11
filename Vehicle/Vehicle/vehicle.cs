using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class vehicle
    {
        protected string type;
        protected string color;
        protected double speed;
        protected string brand;

        public virtual  void run()
        {
            Console.WriteLine("I'm running ");
        }

        public void display()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Brand: " + brand);
        }
    }
}
