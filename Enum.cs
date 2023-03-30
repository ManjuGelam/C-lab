using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    enum month
    {
        jan,
            feb,
            mar,
            apr
    }
    class Enum
    {
        static void Main()
        {
            Console.WriteLine(" value of jan month :" + " enum is " + (int)month.jan);
            Console.WriteLine(" value of jan month :" + " enum is " + (int)month.feb);
            Console.WriteLine(" value of jan month :" + " enum is " + (int)month.mar);
            Console.WriteLine(" value of jan month :" + " enum is " + (int)month.apr);
        }
    }
}
