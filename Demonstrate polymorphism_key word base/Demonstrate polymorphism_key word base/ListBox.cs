using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrate_polymorphism_key_word_base
{
    class ListBox : AppWindow
    {
        private string ListBoxContents;
        public ListBox(int t, int l, string list ) : base(t, l)
        {
            ListBoxContents = list;
        }

        public override void CreatWindow()
        {
            base.CreatWindow();
            Console.WriteLine("Writing stirng to the listbox: {0}", ListBoxContents);
        }
    }
}
