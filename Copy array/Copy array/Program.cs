using System;

namespace Copy_array
{
    class Program
    {
        public static void Show(int[] a)
        {
            int i;
            for( i=0;i<a.Length;i++)
            {
                Console.WriteLine("Element {0}: {1}", i, a[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = new int[5];
            

            Show(array1);
            Console.WriteLine();
            Show(array2);
            Array.Copy(array1, array2, 5);
            Array.Reverse(array2);
            Console.WriteLine("Array2 after copying and reversing Array1");
            Show(array2);

        }
    }
}
