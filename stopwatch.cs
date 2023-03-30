using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace labprograms
{
    class stopwatch
    {
        static void Main()
        {
            Stopwatch SW = new Stopwatch();
            SW.Start();
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine(" manju");

            }
            SW.Stop();
            Console.WriteLine(" time elapses : {0}", SW.Elapsed);
            Console.WriteLine();
        }
        
    }
}
