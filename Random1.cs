using System;
using System.Collections;

namespace labprograms
{
    class Random1
    {
        static void Main( String[] args )
        {
            Random rand = new Random();
            
            Console.WriteLine ($"random num : " + rand.Next(10));
                     Console.WriteLine($"random num:" + rand.Next(10, 1000));
        }
    }
}
