using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate_polymorphism_key_word_base
{
    class Button : AppWindow
    {
        public Button(int t, int l) : base(t, l)
        {

        }

        public override void CreatWindow()
        {
            Console.WriteLine("Drawing a button at {0} and {1}", top, left);

        }
    }
}
