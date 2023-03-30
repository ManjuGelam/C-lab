using System;
using System.Collections;
using System.Text;
using System.Linq;

namespace labprograms
{
    class prnitstringonly
    {
        static void Main()
        {
            ArrayList al = new ArrayList { "hello", 10, false, 100, "good afternoon" };
            var onlystr = al.OfType<string>();
            Console.WriteLine("printing only strings");
            foreach (var str in onlystr)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
