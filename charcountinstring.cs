using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class charcountinstring
    {
        static void Main()
        {
            Console.WriteLine(" enter a string :");
            string input = Console.ReadLine();
            int Length = 0; 
            foreach( char ch in input )
            {
                if (ch != 32)
                    Length ++;

            }
            Console.WriteLine(" no.of chars in string :" + Length);
        }
    }
}
