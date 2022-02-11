using System;

namespace Demonstrate_polymorphism_key_word_base
{
    class Program
    {
        static void Main(string[] args)
        {
            AppWindow obj1 = new ListBox(10, 4, "This is a list box");
            obj1.CreatWindow();
            AppWindow obj2 = new Button(2, 4);
            obj2.CreatWindow();
        }
    }
}
