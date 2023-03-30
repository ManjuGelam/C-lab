using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class  sample //operator overloading not operator
    {
        private bool x;
        public sample ()
        {
            x = false;
        }
        public void set (bool v)
        {
            x = v;
        }
        public static bool operator!(sample s )
        {
            return !(s.x);
        }
        class program
        {
            static void Main()
            {
                sample s1 = new sample();
                sample s2 = new sample();
                s1.set(true);
                s2.set(false);
                Console.WriteLine(" "! + s1);
                Console.WriteLine(" "! + s2);
            }
        }
    }
}
