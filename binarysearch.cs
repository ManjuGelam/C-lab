using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class binarysearch
    {
        public static void Main()
        {
            Console.WriteLine(" enter no.of elements you want to hold in an array :");
            string s = Console.ReadLine();
            int x = Int32.Parse(s);
            int[] a = new int[x];
            Console.WriteLine(" enter array elemets ");
            for (int i = 0; i < x; i++)
            {
                string s1 = Console.ReadLine();

                a[i] = Int32.Parse(s1);

            }
            Array.Sort(a);
            Console.WriteLine("Sorted array :");
            for (int i = 0; i <x; i++)
            {
                Console.WriteLine("{0}", a[i]);

            }
            Console.WriteLine(" enter the elements to be searched :");
            string s3 = Console.ReadLine();
            int x2 = Int32.Parse(s3);
            int x3 = Array.BinarySearch(a, (object)x2);
            Console.WriteLine("binary search :" + x3);
            Console.WriteLine("elements {0} is {1}", x3, a[x3]);
            Console.ReadLine();

        }
    }
}