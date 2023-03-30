using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class SquareNumber
    {
        static void Main()
        {
            Console.WriteLine(" enter a number");
            int number = Convert.ToInt16(Console.ReadLine());
            double sqr = Math.Pow(number, 2);
            Console.WriteLine("square of {0} is :{1}", number, sqr);
            Console.ReadLine();
        }
    }
}
