using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class postincreanddecre
    {
        private static void Main()
        {
            int input = 100;
            input = input++;
            Console.WriteLine(" number after post increment :" + input.ToString());
            input = input--;
            Console.WriteLine(" number after post dcrement :" + input.ToString());
            Console.ReadLine();
        }
    }
}
