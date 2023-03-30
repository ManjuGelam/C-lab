using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class overloading
    {
        void display(int a)
        {
            Console.WriteLine(" arguements :" + a) ;

        }
        void display(int a , int b)
        {
            Console.WriteLine(" arguements:" + a + " " + b);
        }
        static void Main()
        {
            overloading o1 = new overloading();
            o1.display(100);
            o1.display(100, 200);
            Console.ReadLine();
        }
     }
}
