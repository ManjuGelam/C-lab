using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class greatestoftwonums
    {
        static void Main()
        {
            Console.WriteLine(" enter 1st number");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" enter 2nd number");
            double d2 = double.Parse(Console.ReadLine());
            if (d1 > d2)
                Console.WriteLine(" 1st number is greater than 2nd number");
            else if (d1 < d2)
                Console.WriteLine(" 2nd number is greater than 1st number");
            else
                Console.WriteLine(" both numbers are equal");

        }
    }
}
