using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class autoincrement//using++
    {
        static void Main()
        {
            int i = 0;
            Console.WriteLine(i);
            i++;
            Console.WriteLine(i);
            i += 3;
            Console.WriteLine(i);
            ++i;
            Console.WriteLine(i);
            i += i; 
            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
