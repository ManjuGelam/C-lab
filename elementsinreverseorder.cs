using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class elementsinreverseorder
    {
        public static void Main()
        {
            int i, n;
            int[] a = new int[100];
            Console.WriteLine("\n\n read n no.of values in an array and array display in revese oreder :\n");
            Console.Write("---------\n");
            Console.WriteLine("input the no.of elemnts store in an array ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(" input {0} no of elemnts in the array " + n);
            for(i=0;i<n;i++)
            {
                Console.Write("elements {0}:");
                a[i] = Convert.ToInt32(Console.ReadLine()); 
            }
        }
    }
}
