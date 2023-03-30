using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
    class destructor
    {
        public destructor()
        {
            Console.WriteLine(" constructor is invoked ");

        }
       ~ destructor()
        {
            Console.WriteLine(" destructor is invoked");

        }
        class testdestructor
        {
            public static  void Main()
            {
                destructor d1 = new destructor();
                destructor d2 = new destructor();
            }
        }
    }
}
