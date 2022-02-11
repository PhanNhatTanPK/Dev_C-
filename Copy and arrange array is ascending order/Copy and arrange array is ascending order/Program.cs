using System;

namespace Copy_and_arrange_array_is_ascending_order
{
    class Program
    {
        public static void Show(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Value {0}: {1}", i, a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 6, 3, 7, 1, 5 };
            int[] array2 = new int[5];
            Console.WriteLine("The contents of array1 as follows: ");
            Show(array1);
            Array.Copy(array1, array2, 5);
            Array.Sort(array2);
            Console.WriteLine("The contents of array after copying and ascending as follows:");
            Show(array2);
            Console.WriteLine();
            Show(array1);
        }
    }
}
