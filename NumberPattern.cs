using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class NumberPattern
    {
        static void Main()
        {
            Console.WriteLine(" enter no.of rows:");
            int rows = int.Parse(Console.ReadLine());
            int x = 1;
            for (int i = 1;i<= rows;i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.WriteLine($"{x++}");
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
