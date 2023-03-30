using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class AddDates
    {
        static void Main()
        {
            DateTime sdate = new DateTime(2022, 12, 8);
            Console.WriteLine(" starting date :{0}", sdate);
            DateTime edate = sdate.AddDays(100);
            Console.WriteLine(" ending  date :{0}", edate);
            Console.ReadLine();
        }
    }
}
