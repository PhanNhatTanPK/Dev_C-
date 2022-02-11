using System;
using System.IO;

namespace Creat_and_delete_a_directory_Testdir
{
    class Program
    {
        static void Main(string[] args)
        {
            string strans;
            Console.WriteLine(@"creating a directory c:\Testdir\Desktop");
            Directory.CreateDirectory(@"c:\Testdir");
            Console.WriteLine("Directory craeting");
            Console.WriteLine(@"Delete directory c:\Testdir (y\n):?");
            strans = Console.ReadLine();
            if(strans == "y")
            {
                Directory.Delete(@"c:\Testdir");
                Console.Write(@"Directory c:\Testdir deleted");
            }
        }
    }
}
