﻿using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class exception
    {
        static void excep(int value )
        {
            Console.WriteLine (value);
            excep(++value);
        }
        static void Main()
        {
            try
            {
                excep(0);
            }
            catch (StackOverflowException e )
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
