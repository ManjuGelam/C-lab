using System;
using System.Collections.Generic;
using System.Text;

namespace labprograms
{
   sealed  class sealedclass
    {
        public int x;
        public int y;


    }
    class sealedtest
    {
       static void Main()
        {
            sealedclass sc = new sealedclass();
            sc.x = 100;
            sc.y = 150;
            Console.WriteLine("x = {0},y = {1}", sc.x, sc.y);
            Console.ReadLine();
        }
    }
}
