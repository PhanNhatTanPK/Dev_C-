using System;

namespace Display_character_is_Vowel_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            Console.WriteLine("Enter a character:");
            c = Console.ReadLine();
            if (c == "a" || c == "e" || c == "i" || c == "o" || c == "u"
                || c=="A" || c=="E" || c== "I" || c== "O" || c== "U" )
                Console.WriteLine("{0} it is Vowel", c);
            else
                Console.WriteLine("{0} it isn't Vowel", c);
            Console.ReadLine();
        }
    }
}
