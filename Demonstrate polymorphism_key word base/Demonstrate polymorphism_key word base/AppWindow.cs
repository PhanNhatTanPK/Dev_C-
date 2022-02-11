using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate_polymorphism_key_word_base
{
    class AppWindow
    {
        protected int top;
        protected int left;

        public AppWindow(int t, int l)
        {
            top = t;
            left = l;
        }
        public virtual void CreatWindow()
        {
            Console.WriteLine("Window: drawing Window at Top and Left: {0}, {1}", top, left);
        }

       
    }
}
