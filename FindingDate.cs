using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class FindingDate
    { 
        static void Main()
        {
            DateTime todaytime = DateTime.Now;
            DateTime tomorrow;
            tomorrow = todaytime +  new TimeSpan(1, 0, 0, 0);
            Console.WriteLine("tomorrow :{0 }/{1}/{2}", tomorrow.Day, tomorrow.Month, tomorrow.Year);    

        }

    }
}
