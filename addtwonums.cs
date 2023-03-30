using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class addtwonums
    {
        static void Main()
        {
            Console.Write(" enter first number: ");
            string s1 = Console.ReadLine();
            int i = Convert.ToInt32(s1);
            Console.Write("enter second number: ");
            string s2 = Console.ReadLine();
            int j = int.Parse(s2);
            int k = i + j;
            Console.WriteLine(k);
        }
    }
}
