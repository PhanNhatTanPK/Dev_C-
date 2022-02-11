using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_with_color
{
    class Blue : Color
    {
        public override  void Fill(string c)
        {
            Console.WriteLine("Fill me up with" + c);
        }
    }
}
