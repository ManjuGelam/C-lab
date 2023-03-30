using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class studentmarksheet
    {
        static void Main()
        {
            int r, m1, m2, m3, t;
            float p;
            string n;
            Console.WriteLine(" enter roll number ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter student  number ");
            n = (Console.ReadLine());
            Console.WriteLine(" marks of first subject  ");

            m1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" marks of second  subject  ");

            m2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" marks of third  subject  ");

            m3 = int.Parse(Console.ReadLine());
            t = m1 + m2 + m3;
            p = t / 3.0f;
            Console.WriteLine(" total " + t);
            Console.WriteLine(" percentage" + p);
            if (p >= 35 && p < 50)
            {
                Console.WriteLine(" grade c");

            }
            if (p >= 50 && p < 60)
            {
                Console.WriteLine(" grade b ");
            }
            if (p >= 60 && p < 80)
            {
                Console.WriteLine(" grade a ");

            }
            if (p >= 80 && p < 100)
            {
                Console.WriteLine(" grade  a +");
            }
            Console.ReadLine();
        }
    }
}
