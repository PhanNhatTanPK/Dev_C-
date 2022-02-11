using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : vehicle  
    {
        public Car(string t, string c, double s, string b)
        {
            type = t;
            color = c;
            speed = s;
            brand = b;
        }
            public override  void run()
            {
            Console.WriteLine("The Car is running");
            }
            
        
    }
}
