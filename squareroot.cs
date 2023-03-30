using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class squareroot
    {
        public static void Main()
        {
            Console.WriteLine(" enetr a number :");int number = Convert.ToInt16(Console.ReadLine());
            double sqrtnumber = Math.Sqrt(number);
            Console.WriteLine(" square root of {0} is :{1}", number, sqrtnumber);
            Console.ReadLine();

        }
    }
}
