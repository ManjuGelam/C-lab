using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class exceptionhandling
    {
        public static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
            Console.WriteLine(" print the program");
        }
    }
}
