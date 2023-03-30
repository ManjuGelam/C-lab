using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class factorial
    {
        static void Main()
        {
            Console.WriteLine(" enter a number to find  factorial :");
            uint number = uint.Parse(Console.ReadLine());
            uint result = 1;
            for (uint i = 1; i<= number;i++)
            {
                result = result * i;

            }
            Console.WriteLine(" factorial of given number is :" + result);
            Console.ReadLine();
        }
    }
}
