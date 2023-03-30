using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class specifydate
    {
        public static void Main()
        {
            DateTime dt = new DateTime(2001, 5, 2);
            Console.WriteLine(" the day of the week for {0:d}is {1} :",dt, dt.DayOfWeek);
        }
    }
}
