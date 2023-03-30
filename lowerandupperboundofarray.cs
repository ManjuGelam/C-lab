using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class lowerandupperboundofarray
    {
        static void Main()
        {
            Array stringArray = Array.CreateInstance(typeof(string), 6);
            stringArray.SetValue("MANGO", 0);
            stringArray.SetValue("BANANA", 1);
            stringArray.SetValue("ORANGE", 2);
            stringArray.SetValue("APPLE", 3);
            stringArray.SetValue("GOA", 4);
            stringArray.SetValue("GRAPES", 5);
            Console.WriteLine(" the lower bound of an array :{0}", stringArray.GetLowerBound(0).ToString());
            Console.WriteLine(" the upper bound of an array :{0}", stringArray.GetUpperBound(0). ToString());
        }
    }
}
