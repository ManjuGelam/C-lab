using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class DateFormate
    {
        static void Main()

        {
            DateTime date = new DateTime(2022, 12, 9);
            Console.WriteLine(" some date formates :");
            Console.WriteLine(date.ToString("yyyy-mm-dd"));
            Console.WriteLine(date.ToString("dd-mmm-yy"));
            Console.WriteLine(date.ToString("M/d/yyyy"));
            Console.WriteLine(date.ToString("M/d/yy"));
            Console.WriteLine(date.ToString("mm/dd/yyyy"));
            Console.WriteLine(date.ToString("mm/dd/yy"));
            Console.WriteLine(date.ToString("yy/mm/dd"));
        }
    }
}
