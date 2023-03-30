using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class substring
    {
        static void Main()
        {
            string str = "abcd";
            for (int i = 1; i<str.Length; i++)
            {
                for(int start=0; start<= str.Length-i;start++)
                {
                    string substr = str.Substring(start, i);
                    Console.WriteLine(substr);
                }
                
            }
        }
    }
}
