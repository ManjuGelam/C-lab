using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class TimeSpan1
    {
       
            public static void Main()
            {
                TimeSpan firsttimespan = new TimeSpan(2, 44, 0);
                TimeSpan secondtimespan = new TimeSpan(2, 20, 0);
                TimeSpan thirdtimespan = new TimeSpan(2, 30, 0);
                if (firsttimespan < secondtimespan)
                    Console.WriteLine("firsttimespan is less than secondtimespan");
                else
                    Console.WriteLine("firsttimespan is  not less than secondtimespan");
                if (secondtimespan < thirdtimespan)
                    Console.WriteLine("secondtimespan is   less than thirdtimespan");
                else Console.WriteLine("secondtimespan is  not less than thirdtimespan");
                Console.ReadLine();

            }
        }
    }



