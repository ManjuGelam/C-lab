using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class anagrams
    {
        static void Main()

        {
            string str1 = "heater";
            string str2 = "reheat";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if(val1 == val2)

            {
                Console.WriteLine("both are anagrams ");
            }
            else
            {
                Console.WriteLine("both are  not anagrams ");

            }
        }

    }
}
